var c = 0
function LikedImage(element){
    $(`${element}`).on("click",function(){ 
        $(this).css({backgroundImage:"url('../images/heart.png')"})
    })
}
$(".curtir").css({backgroundImage:"url('../images/favorite-heart-button.png')"})
LikedImage("#curtir")
