//Programmation en Module Pattern

//var zombieIndex = zombieIndex || (function () {
//    var _args = {};

//    return {

//        init: function (Args) { _args = Args; },

//        eventHandler: function () {
//            $(".FavoriteBtn").on("click", zombieIndex.favoris);
//            $(".detailBtn").on("click", zombieIndex.detail)
//        },

//        favoris: function (evt) {
//            let lien = $(this);
//            let zombieid = lien.attr("data-zombieid")
//            let url = "Zombie/Favorite/" + zombieid
//            $.ajax({
//                type: 'GET',
//                url: url,
//                success: function (response) {
//                    let isFavorite = JSON.parse(response)
//                    if (isFavorite) {
//                        lien.addClass("text-primary")
//                        lien.removeClass("text-dark")
//                    }
//                    else {
//                        lien.removeClass("text-primary")
//                        lien.addClass("text-dark")
//                    }
//                },
//                error: function (response) {
//                    console.log("ERROR!!!!");
//                }
//            })
//        },

//        detail: function (evt) {
//            let $buttonClicked = $(this);
//            let id = $buttonClicked.attr('data-id');

//            $.get('/Zombie/Details', { "id": id },
//                function (data) {
//                    $("#showmodal #content").html(data)
//                    $("#showmodal").modal("show")
//                }
//            ).fail(function () {
//                alert("Impossible d'obtenir l'information à propos de ce zombie.");
//            });
//        }

//    };
//}());



//var zombieCreate = zombieCreate || (function () {
//    var _args = {};

//    return {

//        init: function (Args) { _args = Args; },

//        eventHandler: function () {

//        },

//        favoris: function () {
//            alert("zombieCreate");
//        },

//        detail: function () {

//        }

//    };
//}());


// jQuery Event Handling

$(document).ready(function () {
    $(".FavoriteBtn").on("click", function (evt) {
        let formData = new FormData();
        let lien = $(this);
        let zombieid = $(this).attr("data-zombieid")
        let url = "Zombie/Favorite/" + zombieid
        $.ajax({
            type: 'GET',
            url: url,
            contentType: false,
            processData: false,
            cache: false,
            data: formData,
            success: function (response) {
                let isFavorite = JSON.parse(response)
                if (isFavorite) {
                    lien.addClass("text-primary")
                    lien.removeClass("text-dark")
                }
                else {
                    lien.removeClass("text-primary")
                    lien.addClass("text-dark")
                }
            },
            error: function (response) {
                console.log("ERROR!!!!");
            }
        })
    });


    $(".detailBtn").click(function () {
        debugger
        let $buttonClicked = $(this);
        let id = $buttonClicked.attr('data-id');

        $.get('/Zombie/Details', { "id": id },
            function (data) {
                $("#showmodal #content").html(data)
                $("#showmodal").modal("show")
            }
        ).fail(function () {
            alert("Impossible d'obtenir l'information à propos de ce zombie.");
        });
    });
});




//Module Pattern est préférable pour les projets plus grands ou lorsque vous
//avez besoin d'une meilleure organisation du code, d'une encapsulation et 
//d'une modularité claires.

//jQuery Event Handling peut être plus simple et rapide à mettre en place pour 
//des projets plus petits ou pour des fonctionnalités simples où la structure 
//et la modularité ne sont pas aussi critiques.




