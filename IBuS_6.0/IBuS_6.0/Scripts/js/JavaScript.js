$(function () {
    $('.BackToTop').hide();

    $(window).scroll(function () {
        if ($(this).scrollTop() > 100) {
            $('.BackToTop').fadeIn();
        }
        else {
            $('.BackToTop').fadeOut();
        }
    });
    $('.BackToTop').click(function () {
        $('html , body').animate({
            scrollTop: 0
        }, 1000);
    });

});


var $doc = $('html, body');
$('a').click(function () {
    $doc.animate({
        scrollTop: $($.attr(this, 'href')).offset().top
    }, 1000);
    return false;
});




