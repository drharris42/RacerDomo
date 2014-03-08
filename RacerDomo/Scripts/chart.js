var RDLineGraphOptions = {};
RDLineGraphOptions.fillColor = "rgba(220,220,220,0.5)";
RDLineGraphOptions.strokeColor = "rgba(220,220,220,1)";
RDLineGraphOptions.pointColor = "rgba(220,220,220,1)";
RDLineGraphOptions.pointStrokeColor = "#fff";

var RDRadarGraphOptions = {};
RDRadarGraphOptions.fillColor = "rgba(220,220,220,0.5)";
RDRadarGraphOptions.strokeColor = "#376299";
RDRadarGraphOptions.pointColor = "rgba(220,220,220,1)";
RDRadarGraphOptions.pointStrokeColor = "#000";

var graphIt = function (elementName) {
    var data = {
        labels: ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "Dec"],
        datasets: [
        {
            fillColor: RDLineGraphOptions.fillColor,
            strokeColor: RDLineGraphOptions.strokeColor,
            pointColor: RDLineGraphOptions.pointColor,
            pointStrokeColor: RDLineGraphOptions.pointStrokeColor,
            data: [0, 1, 0, 3, 4, 2, 3, 4]
        }
        ]
    }
    //Get the context of the canvas element we want to select
    var ctx = document.getElementById(elementName).getContext("2d");
    var myNewChart = new Chart(ctx).Line(data);
}

var radarIt = function (elementName) {
    var data = {
        labels: ["Spartan", "Tough Mudder", "Mud Run", "Challenge - Heavy", "Challenge", "Challenge  - Light", "IronMan"],
        datasets: [
        {
            fillColor: RDRadarGraphOptions.fillColor,
            strokeColor: RDRadarGraphOptions.strokeColor,
            pointColor: RDRadarGraphOptions.pointColor,
            pointStrokeColor: RDRadarGraphOptions.pointStrokeColor,
            data: [2, 1, 5, 2, 3, 4, 0]
        }
        ]
    }
    //Get the context of the canvas element we want to select
    var ctx = document.getElementById(elementName).getContext("2d");
    var myNewRadar = new Chart(ctx).Radar(data);
}