"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/alarmHub").build();

connection.on("AlarmReceived", function (alarm) {

    var alarmDetailTpl = document.getElementById("alarmDetail").innerHTML;
    var alarmDetail = fillTemplate(alarmDetailTpl, alarm);

    //if we want just the cracker...
    //var alarmObjectTpl = document.getElementById("alarmCracker").innerHTML;
    //var alarmObject = fillTemplate(alarmObjectTpl, alarm);

    $(alarmDetail).prependTo("#alarmDetailList");

    //$(alarmObject).prependTo("#alarmObjects");

});

connection.start().then(function () {
   //
}).catch(function (err) {
    return console.error(err.toString());
});

function fillTemplate(template, data) {

    Object.keys(data).forEach(function (key) {
        var placeholder = "{{" + key + "}}";
        var value = data[key];

        while (template.indexOf(placeholder) !== -1) {
            template = template.replace(placeholder, value);
        }
    });

    return template;
}
