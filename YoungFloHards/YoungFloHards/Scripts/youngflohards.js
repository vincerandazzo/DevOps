$(document).ready(function () {
    var stickTheNavigation = $('#navigation').offset().top;

    var stickyNav = function () {
        var scrollTop = $(window).scrollTop();

        if (scrollTop > stickTheNavigation) {
            $('#navigation').addClass('stickyNavigation');
            $('.mainImg').show();
        } else {
            $('#navigation').removeClass('stickyNavigation');
            $('.mainImg').hide();
        }
    };

    stickyNav();

    $(window).scroll(function () {
        stickyNav();
    });

    if ($("#banner").length){
        $("#banner").fadeIn(3000);
        $("#banner").fadeOut(4000);
    }
    
});

