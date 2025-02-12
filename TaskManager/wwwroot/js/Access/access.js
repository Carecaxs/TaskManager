
$(document).ready(function () {

    //set focus the first input of the form
    let inputs = $(".form input");
    inputs.eq(0).focus();


    $(".form input:not([type=submit]):visible").on("keydown", function (event) {
        if (event.key === "Enter") {
            event.preventDefault();

            let inputs = $(".form input:not([type=submit]):visible"); // Select only visible input fields
            let index = inputs.index(this); // Get the index of the current input
            let nextInput = inputs.eq(index + 1);  // Get the next input in the list

            if (nextInput.length) {
                nextInput.focus(); // Move focus to the next input field
            } else {
       
                if (validateForm()) {
                    //if all is right submit the form

                    //$(".form").submit(); // Submits the form
                }
            }
        }
    });






    //function validateForm
    function validateForm() {
        let isValid = true;

        // get inputs of the form
        $(".form input").each(function () {
            // validate fiels are not empty
            if ($(this).val().trim() === "") {
                isValid = false;
                $(this).addClass("is-invalid"); // add error class (Bootstrap)
            } else {
                $(this).removeClass("is-invalid"); // remove error class if the field is not empty
            }
        });

        // validate email format
        let email = $("#email").val();
        if (email==="" || !validateEmail(email)) {
            isValid = false;
            $("#email").addClass("is-invalid"); // add error class (Bootstrap)
            $(".email-feedback").show();
        } else {
            $("#email").removeClass("is-invalid"); // remove error class if the field is not empty
            $(".email-feedback").hide();
        }

        return isValid;
    }



    // Función para validar el formato del correo electrónico
    function validateEmail(email) {
        const regex = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$/;
        return regex.test(email);
    }



});