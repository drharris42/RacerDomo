$(document).ready(function () {
    $('#EventForm').on('submit', function (e) {
        e.preventDefault();
        var event = new Object();
        event.Name = $("input[name='Name']").val();
        var object = 
        $.ajax({
            type: "POST",
            url: "/api/Event",
            contentType: 'application/json',
            data: JSON.stringify(event),
            success: function (data) {
                console.log(data);
            }
        });
    });

});
