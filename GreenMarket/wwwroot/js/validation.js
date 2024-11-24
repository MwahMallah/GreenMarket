const submitBtn = document.querySelector(".submit-btn");
submitBtn.disabled = true;
const requiredInputs = document.querySelectorAll(".validation_required");
const requiredInputsStatus = new Map();

for (const input of requiredInputs) {
    requiredInputsStatus.set(input, input.value.trim() !== "");
    input.addEventListener("input", handleRequiredInput);
}

const equalInputs = document.querySelectorAll(".validation_equal");
for (const input of equalInputs) {
    input.addEventListener("input", handleEqualInput);
}

function handleRequiredInput(e) {
    const input = e.target;
    
    if (input.value.trim() === "") {
        requiredInputsStatus.set(input, false);
        input.classList.add('border');
        input.classList.add('border-3');
        input.classList.add('border-danger');
    } else {
        requiredInputsStatus.set(input, true);
        input.classList.remove('border');
        input.classList.remove('border-3');
        input.classList.remove('border-danger');
    }

    changeSubmitBtnStatus();
    function changeSubmitBtnStatus() {
        submitBtn.disabled = !Array.from(requiredInputsStatus.values()).every(s => s);
    }
}

function handleEqualInput(e) {
    const newContent = e.target.value;

    for (const otherInput of equalInputs) {
        if (otherInput.value !== newContent) {
            showEqualError();
            return;
        }
    }

    showNoEqualError();
    
    function showEqualError() {
        for (const input of equalInputs) {
            input.classList.add('border');
            input.classList.add('border-3');
            input.classList.add('border-danger');
        }
    }
    
    function showNoEqualError() {
        for (const input of equalInputs) {
            input.classList.remove('border');
            input.classList.remove('border-3');
            input.classList.remove('border-danger');
        }
    }
}
