$("#CitySelected").change(function () {
    var value = $("#CitySelected").val();
    document.getElementById("City").value = value;
   
});

$("#CountrySelected").change(function () {
    var value = $("#CountrySelected").val();
    document.getElementById("Country").value = value;
 
});

//$(document).ready(function () {
//    $("#btnSearch").click(function () {
//        var city = 'London,uk';
//        var key = 'a86bcaa9eaa1e45dbd7db3679c52e59d';


//        $.ajax({
//            url: 'http://api.openweathermap.org/data/2.5/weather',
//            dataType: 'json',
//            type: 'GET',
//            data: {
//                q: city,
//                appid: key,
//                units: 'imperial'
//            },
//            success: function (data) {
//                var wf = '';
//                $.each(data.weather, function (index, val) {
//                    wf += '<p><b>' + data.name + "</b><img src=" + val.icon + ".png></p>" + data.main.temp + '&deg;C' + ' | ' + val.main + ", " + val.description
//                });
//                $("#ShowWeatherForecast").html(wf);
//            }
//        });
//    });
//});





