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

        var doc = new jsPDF();

        html2canvas(document.getElementById("pdfBackground"), { logging: false }).then(function (canvas) {
            var image = canvas.toDataURL("image/jpeg").replace("image/png", "image/octet-stream");

            var width = doc.internal.pageSize.width;
            var height = doc.internal.pageSize.height;
            doc.addImage(image, 'JPEG', 0, 0, width, height);
        });

        html2canvas(document.getElementById("schedulePrint"), { logging: false }).then(function (canvas) {

            var image = canvas.toDataURL("image/jpeg").replace("image/png", "image/octet-stream");

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

    //Session popup
    function singleSession(thisObj) {
        var sessionId = thisObj.data('id');
        $.getJSON("/Umbraco/Api/Session/GetSession?sID=" + sessionId, function (result) {
            sessionHtml = "<div class='topbar'></div><div class='session-content'><div class='left'></div><div class='right'></dib></div>";
            modalAndBg(thisObj);
            $(".modal").append("<div class='single-session'></div>");
            $(".single-session").append(sessionHtml);

            var d = new Date(result.Date);
            var month = ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'];
            var days = ['Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'];
            var date = days[d.getDay()] + " " + d.getDate() + ". " + month[d.getMonth()] + " " + d.getFullYear();

            var dateTime = date + " at " + result.StartTime;

            $(".topbar").append("<h3>" + result.Title + "</h3><span>" + dateTime + "</span>");
            $(".left").append("<h3>" + result.DescriptionHeadline + "</h3>" + result.Description);

            result.Speakers.forEach(function (speaker) {
                $(".right").append("<a class='getSpeaker' href='' data-id='" + speaker.Id + "'><img src='"+ speaker.Picture +"' alt='" + speaker.Name + "'>" + speaker.Name + "</a>");
            });
        });
    }

    //speaker popup
    function singleSpeaker(thisObj) {
        var speakerId = thisObj.data('id');
        $.getJSON("/Umbraco/Api/Speaker/GetSpeaker?sID=" + speakerId, function (result) {
            modalAndBg(thisObj);
            $(".modal").append("<div class='speaker-profile'></div>");

            $(".speaker-profile").append("<img class='profile-picture' src='"+ result.Picture +"'><h2>"+ result.Name +"</h2><p class='title'>"+ result.Title +"</p>");
            $(".speaker-profile").append("<span class='social-links'><a href='" + result.Facebook + "'><img src='/Media/SocialMediaIcons/yellow-facebook.svg' /></a><a href='" + result.LinkedIn + "'><img src='/Media/SocialMediaIcons/yellow-linkedin.svg' /></a><a href='"+ result.Twitter +"'><img src='/Media/SocialMediaIcons/yellow-twitter.svg' /></a></span>");
            $(".speaker-profile").append("<div class='info'><span>"+ result.DescriptionHeadline +"</span>" + result.Description + "</div>");
        });
    }

    $(".session").click(function (e) {
        e.preventDefault();
        singleSession($(this));
    });

    //Add Modal & background
    function modalAndBg() {
        html = "<div class='modal'><a class='modal-close' href='' title='Close'><div></div><div></div></a></div><div class='modal-bg'></div>";
        $(document.body).append(html);
        showModal();
    }

    function showModal() {
        if ($(document.body).find('.modal').hasClass("show")) {
            $('.modal').toggleClass("show");
            $('.modal-bg').toggleClass("show");
            setTimeout(function () {
                $('.modal').remove();
                $('.modal-bg').remove();
            }, 500);
        } else {
            $('.modal').toggleClass("show");
            $('.modal-bg').toggleClass("show");
        }
    }

    $(document.body).on("click", ".modal-bg", function (e) {
        e.preventDefault();
        showModal();
    });

    $(document.body).on("click", ".modal-close", function (e) {
        e.preventDefault();
        showModal();
    });

    $(document.body).on("click", ".getSpeaker", function (e) {
        e.preventDefault();
        singleSpeaker($(this));
    });

    //Select2 js
    function formatState(state) {
        if (!state.id) {
            return state.text;
        }
        var $state = $(
            '<span>' + state.text + '</span>'
        );
        return $state;
    };

    $(".select").select2({
        templateSelection: formatState,
        minimumResultsForSearch: -1
    });

});