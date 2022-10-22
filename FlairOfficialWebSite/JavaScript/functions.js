$(document).ready(function(){
    
    var slider_index = 1; 
    setTimeout(() => {
        $("#loader").fadeOut(500);
        $("body, html").css("overflow", "auto");
        setTimeout(() => {
            AnimateElementBox1();
        }, 1000);
    }, 1500);
function AnimateElementBox1(){
    $("#element_box_1").animate({
        height: "20%"
    }, {duration: 1200,
    step: function() {
        flair_new.recalculate();
    }, complete:
     function() {
        $("#element_box_1").animate({
            height: "100%"
        }, {duration: 1200,
        step: function() {
            flair_new.recalculate();
        }, complete:
         function() {
            $("#element_box_1").animate({
                width: "30%"
            }, {duration: 1200,
            step: function() {
                flair_new.recalculate();
            }, complete:
             function() {
                $("#element_box_1").animate({
                    height: "30%"
                }, {duration: 1200,
                step: function() {
                    flair_new.recalculate();
                }, complete:
                 function() {
                    $("#element_box_1").animate({
                        height: "100%"
                    }, {duration: 1200,
                    step: function() {
                        flair_new.recalculate();
                    }, complete:
                     function() {
                        $("#element_box_1").animate({
                            width: "100%"
                        }, {duration: 1200,
                        step: function() {
                            flair_new.recalculate();
                        }, complete:
                         function() {
                            document.getElementById("slider_container_0"+slider_index).style.display = "none";
                            document.getElementById("slider_button_0"+slider_index).classList.remove("slider_buttons_active");
                            slider_index++;
                            if(slider_index>6)
                                slider_index = 1;
                            document.getElementById("slider_container_0"+slider_index).style.display = "block";
                            document.getElementById("slider_button_0"+slider_index).classList.add("slider_buttons_active");
                            AnimateElementBox1();
                        }});
                    }});
                }});
            }});
        }});
    }});
}

$(".slider_buttons").click(function(){
    $("#element_box_1").stop(true);
    document.getElementById("slider_container_0"+slider_index).style.display = "none";
    document.getElementById("slider_button_0"+slider_index).classList.remove("slider_buttons_active");
    slider_index = parseInt($(this).attr("alt"));
    document.getElementById("slider_container_0"+slider_index).style.display = "block";
    document.getElementById("slider_button_0"+slider_index).classList.add("slider_buttons_active");
    $("#element_box_1").css("width", "100%");
    $("#element_box_1").css("height", "100%");
    AnimateElementBox1();
});
$(".button_text_").click(function(){
    $("#element_box_1").stop(true);
    document.getElementById("slider_container_0"+slider_index).style.display = "none";
    document.getElementById("slider_button_0"+slider_index).classList.remove("slider_buttons_active");
    slider_index = parseInt($(this).attr("alt"));
    document.getElementById("slider_container_0"+slider_index).style.display = "block";
    document.getElementById("slider_button_0"+slider_index).classList.add("slider_buttons_active");
    $("#element_box_1").css("width", "100%");
    $("#element_box_1").css("height", "100%");
    AnimateElementBox1();
});

var animatingCheck = true;
$(window).scroll(function(){
    animateMenu();
});
function animateMenuDown(){
    if(animatingCheck){
        animatingCheck = false;
        $("#fixed_menu_container").animate({
            top: "2.2vh"
        }, 200, function(){
            animatingCheck = true;
            if(parseFloat($("#standard_menu").offset().top) - $(document).scrollTop() >= -$("#standard_menu").height())
            {
                animateMenuUp();
            }
        });
    }
}
function animateMenuUp(){
    if(animatingCheck){
        animatingCheck = false;
        $("#fixed_menu_container").animate({
            top: (-1.5*$("#fixed_menu_container").height() + "px")
        }, 200, function(){
            animatingCheck = true;
            if(parseFloat($("#standard_menu").offset().top) - $(document).scrollTop() < -$("#standard_menu").height())
            {
                animateMenuDown();
            }
        });
    }
}
function animateMenu(){
    if(parseFloat($("#standard_menu").offset().top) - $(document).scrollTop() < -$("#standard_menu").height())
    {
        animateMenuDown();
    }
    else
    {
        animateMenuUp();
    }
}

$("#go_top_icon").click(function(){
    $("html, body").animate({ scrollTop: 0 }, 300);
});
});