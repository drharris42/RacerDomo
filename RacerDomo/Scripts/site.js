$(document).ready(function () {
    $('.custom-button').on('click', function () {
        console.log("clicked it");
        $.ajax({
            url: "/api/Event",
            success: function (data) {
                console.log(data);
            }
        });
    });

});
