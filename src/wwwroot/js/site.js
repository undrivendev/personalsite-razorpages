let isArrowVisible = true;

function setupArrowEventHandlers() {
    const $window = $(window),
        $ldvarrow = $("#ldv-arrow-container a");

    $ldvarrow.click(function (event) {
        event.preventDefault();
        var viewportHeight = $window.height();

        $('html, body').animate({
            scrollTop: viewportHeight
        }, 2000);
    });
    $window.scroll(function () {
        if ($window.scrollTop() === 0 && !isArrowVisible) {
            isArrowVisible = true;
            $ldvarrow.show();
        } else if (isArrowVisible) {
            isArrowVisible = false;
            $ldvarrow.fadeOut();
        }
    });
}


function setupFadeOnScrollEventHandlers() {
    const $window = $(window);
    let $allElementsToFade;
    let $sectionsToFade;
    let $timelineContainersToFade;

    let getViewPortFadeLimit = function () {
        return window.innerHeight - (window.innerHeight * 0.225);
    };
    
    $sectionsToFade = $(".ldv-section .container")
        .filter(function (a, b) {
            if (b.parentElement.id !== "ldv-section-timeline") {
                return b.getBoundingClientRect().top > getViewPortFadeLimit();
            }
        });
    $timelineContainersToFade = $(".timeline-container")
        .filter(function (a, b) {
            return b.getBoundingClientRect().top > getViewPortFadeLimit();
        });
    
    $allElementsToFade = $sectionsToFade.add($timelineContainersToFade);
    $allElementsToFade.css("opacity", 0);
    $window.scroll(function () {
        $allElementsToFade.filter(function (a, b) {
            return b.getBoundingClientRect().top < getViewPortFadeLimit();
        })
            .animate({opacity: 1}, 200);
    });
}



// on document ready
$(function () {
    setupArrowEventHandlers();
    setupFadeOnScrollEventHandlers();
});

