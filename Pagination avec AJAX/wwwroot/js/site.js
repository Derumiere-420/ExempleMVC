$(document).ready(function () {
    // Charger la première page au démarrage
    loadPage(1);

    // Gérer les clics sur les liens de pagination
    $(document).on('click', '.page-link', function (e) {
        e.preventDefault();
        var page = $(this).data('page');
        loadPage(page);
    });

    function loadPage(pageNumber) {
        $.ajax({
            url: '/Products/GetProducts',
            data: { pageNumber: pageNumber },
            success: function (data) {
                $('#product-list').html(data);
            },
            error: function () {
                alert("An error occurred while loading the page.");
            }
        });
    }
});
