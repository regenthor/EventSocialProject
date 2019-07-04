$('.event').hover(
    function () {
        $(this).children(".fdw-background").animate({opacity:'1'});
    },
    function () {
        $(this).children(".fdw-background").animate({opacity:'0'});
    }
);
