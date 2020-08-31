var c = 0
function LikedImage(element){
    $(`${element}`).on("click",function(){ 
        id = document.querySelector("#curtir").value
        $.post("/Home/RemoveCurtidos",{idCurtidos:id})
            .done(function(data){
                $(".curtidos").html(data);
            })
            .fail(function(){
                alert(id,data)
            })
        $(".produto").css({display:"none"})
    })
}
$(".curtir").css({backgroundImage:"url('../images/favorite-heart-button.png')"})
LikedImage("#curtir")


$(".loja").on("click",function(){
    var id = document.querySelector("#carrinho").value;
    console.log(id)
    $.post("/Home/Carrinho",{idProdutos:id})
        .done(function(data){
            $(".adicionados").html(data);
        })
        .fail(function(){
            alert(id,data)
        })
})
