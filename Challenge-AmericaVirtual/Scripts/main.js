$("#CitySelected").change(function () {
    var value = $("#CitySelected").val();
    //document.getElementById("City").value = value;
    var button = document.getElementById("btnSearch");
    button.disabled = false;
});

$("#CountrySelected").change(function () {
    var value = $("#CountrySelected").val();
    document.getElementById("Country").value = value;
    var form = document.getElementById("formCountrySelect");
    form.method = "post";
    form.action = "CitySelect";
    form.submit();
});

function ConfirmLogin() {
    var form = document.getElementById("formLogin");
    form.method = "post";
    form.action = "Login";
    form.submit();
};









