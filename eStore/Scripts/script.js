﻿$(document).ready(function () {
    $(window).scroll(function (event) {
        var y = $(this).scrollTop();

        if (y >= 300) {

            $('#zafuTallBlue').addClass('animate');
            $('#zafuBlue').addClass('animate');

        }

        if (y >= 650) {

            $('#zafu').addClass('animate grow-img');
            $('#zab').addClass('animate grow-img');
            $('#neck').addClass('animate grow-img');

            $('.center-icons span').addClass('animate');
        }
    });
});