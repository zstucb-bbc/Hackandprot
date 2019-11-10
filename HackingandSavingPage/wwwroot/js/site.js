function Compare() {
    console.log("Hello")
    if (document.getElementById("Email").value == document.getElementById("RepeatEmail").value) {
        document.getElementById("submitButton").removeAttribute("disabled");

    } else {
        document.getElementById("submitButton").setAttribute("disabled", "disabled");
    }
}