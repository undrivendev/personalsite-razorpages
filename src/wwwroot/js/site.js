$(function () {
    $("#ldv-arrow-container a").click(function (event) {
        event.preventDefault();
        var viewportHeight = $(window).height();

        $('html, body').animate({
            scrollTop: viewportHeight
        }, 2000);
    });

    $(window).scroll(function () {
        if ($(window).scrollTop() === 0) {
            $('#ldv-arrow-container').show();
        } else {
            $('#ldv-arrow-container').fadeOut();
        }
    });
});