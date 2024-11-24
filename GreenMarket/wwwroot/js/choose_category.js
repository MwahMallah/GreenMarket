const categoriesContainer = document.querySelector("#category_container");
const categorySelector = document.querySelector("#category_select");
const typeSelector = document.querySelector("#type_select")
const selectors = [];
const createForm = document.querySelector("#createProductForm");
selectors.push(categorySelector);

const attributesContainer = document.querySelector("#attribute_container");
const attributeElements = [];

const productSalesTypeMap = {
    "PerUnit": 0, // Value ProductSalesType.PerUnit
    "Harvest": 1  // Value ProductSalesType.Harvest
};

categorySelector.addEventListener("change", handleCategorySelector);
createForm.addEventListener("submit", async (e) => {
    e.preventDefault();
    console.log(typeSelector.value);
    console.log(productSalesTypeMap[typeSelector.value])
    
    const formData = {
        Name: document.querySelector("#name").value.trim(),
        ImgUrl: document.querySelector("#img").value.trim(),
        Description: document.querySelector("#description").value.trim(),
        Type: productSalesTypeMap[typeSelector.value],
        CategoryId: selectors[selectors.length - 1]?.value || null,
        Attributes: attributeElements.map(a => {
            const input = a.querySelector("input");
            return {Id: input.name, Value: input.value}
        })
    }
    
    console.log(attributeElements);
    console.log(formData);

    await sendForm(formData);

    async function sendForm(formData) {
        const res = await fetch("/Farmer/Create", {
            method: "post",
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(formData)
        });

        console.log(res);
        if (!res.ok) {
            const errorData = await res.json();
            if (errorData.errors && errorData.errors["CategoryId"]) {
                Toastify({
                    text: "Category id is not set",
                    duration: 3000,
                    gravity: "top",
                    position: "center",
                    backgroundColor: "red",
                    stopOnFocus: true
                }).showToast();
            }
            
            if (errorData.errors && errorData.errors["Attributes"]) {
                Toastify({
                    text: errorData.errors["Attributes"],
                    duration: 3000,
                    gravity: "top",
                    position: "center",
                    backgroundColor: "red",
                    stopOnFocus: true
                }).showToast();
            }
            //set location from response
        } else {
            const location = res.headers.get("Location");

            if (location) {
                window.location.href = location;
            } else {
                window.location.href = "/Farmer/Index";
            }
        }
    }
});


async function handleCategorySelector(e) {
    const thisSelectorNum = Number(this.getAttribute("selector_num"));
    let selectorsToRemove = selectors.length - thisSelectorNum;
    for (let i = 0; i < selectorsToRemove; i++) {
        let selectorToRemove = selectors.pop();
        categoriesContainer.removeChild(selectorToRemove);
    }
    
    for (let attr of attributeElements) {
        attributesContainer.removeChild(attr);
    }
    attributeElements.length = 0;

    await addCategorySpecifier(e.target.value);
}

async function addCategorySpecifier(value) {
    const res = await fetch(`/Farmer/Category/${value}`);
    const resBody = await res.json();
    console.log(resBody);

    if (resBody.type === "categories") {
        const newSelector = createCategorySelectorElement(resBody.payload);

        newSelector.addEventListener("change", handleCategorySelector);
        categoriesContainer.appendChild(newSelector);
        selectors.push(newSelector);
    } else if (resBody.type === "attributes") {
        const attributes = resBody.payload;
        for (let attr of attributes) {
            const attrElement = createAttributeDiv(attr);
            attributesContainer.appendChild(attrElement);
            attributeElements.push(attrElement);
        }
    }
}

function createCategorySelectorElement(newCategories) {
    console.log(newCategories);
    const selector = document.createElement("select");
    selector.setAttribute("selector_num", `${selectors.length + 1}`);

    selector.appendChild(createDefaultOption());

    for (let category of newCategories) {
        let newOption = createOption(category);
        selector.appendChild(newOption);
    }

    function createOption(category) {
        let newCategoryOption = document.createElement("option");
        const optionText = document.createTextNode(category.name);
        newCategoryOption.appendChild(optionText);
        newCategoryOption.value = category.id;

        return newCategoryOption;
    }

    function createDefaultOption() {
        let defaultCategoryOption = document.createElement("option");
        const optionText = document.createTextNode("--Choose Category--");
        defaultCategoryOption.appendChild(optionText);
        defaultCategoryOption.value = "";

        return defaultCategoryOption;
    }

    return selector;
}

function createAttributeDiv(attr) {
    const containerDiv = createContainerDiv();
    const name = createAttributeName(attr)
    const input = createAttributeInput(attr);
    
    containerDiv.appendChild(name);
    containerDiv.appendChild(input);
    return containerDiv;
    
    function createContainerDiv() {
        const div = document.createElement("div");
        div.classList.add("col-md-6", "mb-3");
        return div;
    }
    
    function createAttributeName(attr) {
        const strong = document.createElement("strong");
        const txt = document.createTextNode(attr.name + (attr.isRequired ? "*" : ""));
        strong.appendChild(txt);
        return strong;
    }
    
    function createAttributeInput(attr) {
        const input = document.createElement("input");
        input.type = "text";
        input.id = attr.name;
        input.name = attr.id;
        input.classList.add("form-control", "mt-1");
        input.placeholder = attr.name;
        return input;
    }
}