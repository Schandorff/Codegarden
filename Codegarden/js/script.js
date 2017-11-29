$(document).ready(function(){
    function openNav(thisObj) {
        thisObj.toggleClass("open");
        $("nav").toggleClass("open");
    }
    $('.hamburger-nav').click(function(){
        openNav($(this));
    });

    function expandCollapse(thisObj) {
        var item = thisObj.parent();

        item.siblings().each(function() {
            if ($(this).hasClass("active")) {
                $(this).removeClass("active");
                $(this).find(".collapsed").animate({
                  "max-height": 0
                }, 250, function() {
                  // Animation complete.
                });
            }
        });
        item.toggleClass("active");

        if (item.hasClass("active")) {
          item.find(".collapsed").animate({
            "max-height": 200
          }, 300, function() {
            // Animation complete.
          });
        }else{
          item.find(".collapsed").animate({
            "max-height": 0
          }, 250, function() {
            // Animation complete.
          });
        }

    }
    $('.collapse').click(function( e ){
        e.preventDefault();
        expandCollapse($(this));
    });

    function showSpeaker(thisObj) {
        $('.modal').toggleClass("show");
        $('.modal-bg').toggleClass("show");
    }
    $('.getSpeaker').click(function( e ) {
        e.preventDefault();
        showSpeaker($(this));
    });
    $('.modal .close').click(function( e ) {
        e.preventDefault();
        showSpeaker($(this));
    });
    $('.modal-bg').click(function( e ) {
        e.preventDefault();
        showSpeaker($(this));
    });

    function createPersonal() {
        if(!$(".actions span").hasClass("check")){
            $(".schedule-card").each(function() {
                if(!$(this).hasClass("inactive")) {
                    var actionsDiv = $(this).find(".actions");

                    actionsDiv.append("<div class='spacer'></div><span class='check'><a href=''><img src='../media/check.svg'><img src='../media/checked.svg'></a><span class='tooltiptext'>Click the checkmark to mark what you'd like on your personal schedule</span></span>");

                }
            });
        }
    }
    $('#personalSchedule').click(function( e ) {
        e.preventDefault();
        createPersonal();
    });

    function check(thisObj) {
        thisObj.find(".tooltiptext").remove();

        thisObj.toggleClass("checked");

    }

    $(".actions").on("click", ".check", function( e ) {
      e.preventDefault();
      check($(this));
    });

    $('.showFilter').click(function( e ){
        e.preventDefault();
        $(this).toggleClass("clicked");
        $('.filter-container').toggleClass("active");
    });

    function activateFilter(thisObj) {
        thisObj.toggleClass("active");
    }
    $(".filter-card label").click(function( e ) {
        activateFilter($(this));
    });

    $(window).scroll(function() {
        if ($(window).scrollTop() > 100 ){
            $('header').addClass('scroll');
        } else {
            $('header').removeClass('scroll');
        };
    });

});
