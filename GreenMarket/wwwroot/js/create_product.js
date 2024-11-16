const categoriesContainer = document.querySelector("#category_container");
const categorySelector = document.querySelector("#category_select");
const selectors = [];
const createForm = document.querySelector("#createProductForm");
selectors.push(categorySelector);

categorySelector.addEventListener("change", handleCategorySelector);
createForm.addEventListener("submit", async (e) => {
    e.preventDefault();

    console.log(selectors[0].value);
    const formData = {
        Name: document.querySelector("#name").value.trim(),
        ImgUrl: document.querySelector("#img").value.trim(),
        Description: document.querySelector("#description").value.trim(),
        CategoryId: selectors[selectors.length - 1]?.value || null
    }

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

    await addCategorySpecifier(e.target.value);
}

async function addCategorySpecifier(value) {
    const res = await fetch(`/Farmer/Category/${value}`);
    const newCategories = await res.json();

    if (newCategories.length !== 0) {
        const newSelector = createCategorySelectorElement(newCategories);

        newSelector.addEventListener("change", handleCategorySelector);
        categoriesContainer.appendChild(newSelector);
        selectors.push(newSelector);
        console.log(selectors.length);
    }
}

function createCategorySelectorElement(newCategories) {
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