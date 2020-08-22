var c = 0
function LikedImage(element){
    $(`${element}`).on("click",function(){ 
        if(c%2===0){
            $(this).css({backgroundImage:"url('../images/heart.png')"})
            c++
        }
        else{
            $(this).css({backgroundImage:"url('../images/favorite-heart-button.png')"})
            c++
        }
    })
}
$(".curtir").css({backgroundImage:"url('../images/favorite-heart-button.png')"})
LikedImage(".curtir")