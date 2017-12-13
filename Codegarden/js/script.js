$(document).ready(function () {
    function openNav(thisObj) {
        thisObj.toggleClass("open");
        $("nav").toggleClass("open");
    }
    $('.hamburger-nav').click(function () {
        openNav($(this));
    });

    function expandCollapse(thisObj) {
        var item = thisObj.parent();

        item.siblings().each(function () {
            if ($(this).hasClass("active")) {
                $(this).removeClass("active");
                $(this).find(".collapsed").animate({
                    "max-height": 0
                }, 250, function () {
                    // Animation complete.
                });
            }
        });
        item.toggleClass("active");

        if (item.hasClass("active")) {
            item.find(".collapsed").animate({
                "max-height": 200
            }, 300, function () {
                // Animation complete.
            });
        } else {
            item.find(".collapsed").animate({
                "max-height": 0
            }, 250, function () {
                // Animation complete.
            });
        }

    }
    $('.collapse').click(function (e) {
        e.preventDefault();
        expandCollapse($(this));
    });

    function showSpeaker(thisObj) {
        $('.modal').toggleClass("show");
        $('.modal-bg').toggleClass("show");
    }

    $('.getSpeaker').click(function (e) {
        e.preventDefault();
        var speakerID = $(this).data('id');
        $.getJSON("/Umbraco/Api/Speaker/GetSpeaker?sID=" + speakerID, function (result) {
            $("#speakerName").html(result.Name);
            $("#speakerTitle").html(result.Title);
            $("#speakerFacebook").attr("href", result.Facebook);
            $("#speakerLinkedin").attr("href", result.LinkedIn);
            $("#speakerTwitter").attr("href", result.Twitter);
            $("#speakerDescriptionHeadline").html(result.DescriptionHeadline);
            $("#speakerDescription").html(result.Description);
            $("#speakerPicture").attr("src", result.Picture);
        });
        showSpeaker($(this));
    });

    $('.modal .close').click(function (e) {
        e.preventDefault();
        showSpeaker($(this));
        $("#speakerPicture").attr("src", "");
        $("#speakerName").html("");
        $("#speakerTitle").html("");
        $("#speakerFacebook").attr("href", "");
        $("#speakerLinkedin").attr("href", "");
        $("#speakerTwitter").attr("href", "");
        $("#speakerDescriptionHeadline").html("");
        $("#speakerDescription").html("");
    });

    $('.modal-bg').click(function (e) {
        e.preventDefault();
        showSpeaker($(this));
    });

    function createPersonal() {
        if (!$(".actions span").hasClass("check")) {

            $(".btn-secondary").addClass("active");

            $(".schedule-card").each(function () {
                if (!$(this).hasClass("inactive")) {
                    var actionsDiv = $(this).find(".actions");

                    actionsDiv.append("<div class='spacer'></div><span class='check'><a href=''><img src='/Media/ScheduleIcons/check.svg'><img src='/Media/ScheduleIcons/checked.svg'></a><span class='tooltiptext'>Click the checkmark to mark what you'd like on your personal schedule</span></span>");

                }
            });
        }
    }
    $('#personalSchedule').click(function (e) {
        e.preventDefault();
        createPersonal();
    });

    function downloadPersonalSchedule() {
        var element;

        var doc = new jsPDF();

        html2canvas(document.getElementById("pdfBackground"), { logging: false }).then(function (canvas) {
            var image = canvas.toDataURL("image/jpeg").replace("image/png", "image/octet-stream");  // here is the most important part because if you dont replace you will get a DOM 18 exception.

            var width = doc.internal.pageSize.width;
            var height = doc.internal.pageSize.height;
            doc.addImage(image, 'JPEG', 0, 0, width, height);
        });

        var scrollWidth = $('#schedulePrint').prop('scrollWidth'); //document.getElementById("primary").style.width;
        var scrollHeight = $('#schedulePrint').prop('scrollHeight'); //document.getElementById("primary").style.height;
        var width = $('#schedulePrint').width();
        var height = $('#schedulePrint').height();

        html2canvas(document.getElementById("schedulePrint"), { logging: false }).then(function (canvas) {
<<<<<<< HEAD
=======


>>>>>>> eccdeab0fd0f30c4044731c1e0a69a89e149ee78

            var image = canvas.toDataURL("image/jpeg").replace("image/png", "image/octet-stream");  // here is the most important part because if you dont replace you will get a DOM 18 exception.

            var width = $("#schedulePrint").width() / 6;
            var height = $("#schedulePrint").height() / 5;
            doc.addImage(image, 'JPEG', 43, 55, width, height);
            doc.save('sample-file.pdf');
        });
    }

    $('.download').click(function (e) {
        e.preventDefault();
        downloadPersonalSchedule();
    });

    function check(thisObj) {
        thisObj.find(".tooltiptext").remove();
        $(".personal-container").addClass("active");

        thisObj.toggleClass("checked");

    }

    function addSession(thisObj) {
        var session = thisObj.parents(".schedule-card");
        var time = session.parent().find(".schedule-time").html();
        var sessionTitle = session.find(".session").html();

        //Check if checked already
        if (thisObj.hasClass("checked")) {
            removeSession(sessionTitle);
        } else {
            checkSiblings();
            addSession();
        }

        //Check if any siblings are checked
        function checkSiblings() {
            session.parents(".schedule-row").find(".checked").toggleClass("checked");
        }

        //Remove session
        function removeSession(title) {
            var getRemoveTitle = title;

            $(".personal-row").each(function () {
                p = $(this).find("p");

                if (getRemoveTitle == p.html()) {
                    $(this).remove();
                }
            });
        }

        //Add session
        function addSession() {

            var sessions = [];

            thisObj.toggleClass("checked");

            $(".schedule-card").each(function (e) {
                if ($(this).find(".check").hasClass("checked")) {

                    sessionTime = $(this).parent().find(".schedule-time").html();
                    sessionTitle = $(this).find(".session").html();
                    sessionDay = $(this).parents(".day").find("h3").html();
                    sessionObj = {};

                    sessionObj.Time = sessionTime;
                    sessionObj.Title = sessionTitle;
                    sessionObj.Day = sessionDay;

                    sessions.push(sessionObj);
                }
            });

            thisObj.toggleClass("checked");

            $(".sessionCenter").html("");

            sessions.forEach(function (sessionItem) {
                var sessionHtml = "<div class='personal-row'><div class='personal-card'><div class='personal-time'>" + sessionItem.Time + "</div><div class='personal-session'><p>" + sessionItem.Title + "</p></div></div></div>";

                if ($(".sessionCenter").find("h3").last().html() != sessionItem.Day) {
                    $(".sessionCenter").append("<h3 class='day'>" + sessionItem.Day + "</h3>");
                }

                $(".sessionCenter").append(sessionHtml);

            });
        }
    }

    $(".actions").on("click", ".check", function (e) {
        e.preventDefault();
        addSession($(this));
        check($(this));
    });

    function openPersonal() {
        $(".personal-container").toggleClass("clicked");
        $("#close").toggleClass("active");
    }

    function closePersonal(thisObj) {
        $(".personal-container").toggleClass("clicked");
        thisObj.toggleClass("active");
    }

    $('#open').click(function (e) {
        e.preventDefault();
        openPersonal();
    });

    $('#close').click(function (e) {
        e.preventDefault();
        closePersonal($(this));
    });

    $('.showFilter').click(function (e) {
        e.preventDefault();
        $(this).toggleClass("clicked");
        $('.filter-container').toggleClass("active");
    });

    function activateFilter(thisObj) {
        thisObj.toggleClass("active");
    }
    $(".filter-card label").click(function (e) {
        activateFilter($(this));
    });

    $(window).scroll(function () {
        if ($(window).scrollTop() > 100) {
            $('header').addClass('scroll');
        } else {
            $('header').removeClass('scroll');
        };
    });

});