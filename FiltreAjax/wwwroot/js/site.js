$(document).ready(function () {
    $('#filterForm').submit(function (event) {
        event.preventDefault();// Empêche l'action par défaut du bouton si c'est un submit
        $.ajax({
            url: $(this).attr('action'),
            type: 'get',
            data: $(this).serialize(),
            success: function (result) {
                $('#results').html(result);
            },
            error: function (xhr, status, error) {
                console.error("Error: " + status + " - " + error);
                console.error("Response Text: " + xhr.responseText);
            }
        });
    });
});
