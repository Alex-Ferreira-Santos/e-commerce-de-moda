// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var a = 0
function LikedImage(element){
    $(`${element}`).on("click",function(){
        if(a%2===0){
            $(this).css({backgroundImage:"url(' ../images/favorite-heart-button.png')"})
            a++
        }
        else{
            $(this).css({backgroundImage:"url('../images/heart.png')"})
            a++
        }
    })
    
}
var b  =0
function CartImage(element){
    $(`${element}`).on("click",function(){
        if(b%2===0){
            $(this).css({backgroundImage:"url('../images/shopping-cart-black.png')"})
            b++
        }
        else{
            $(this).css({backgroundImage:"url('../images/shopping-cart.png')"})
            b++
        }
    })
    
}
LikedImage(".curtir")
CartImage(".loja")


$("#usuario").on("click",function(){
    $("body").css({backgroundColor:"rgba(0,0,0,0.7)",overflow:"hidden",transition:"0.5s"})
    $("#cadastro").css({display:"initial"})
    $("main,header,footer").css({opacity:"0.5"})
})
$("#fechar").on("click",function(){
    $("body").css({overflow:"auto",backgroundColor:"#fff",opacity:"1"})
    $("#cadastro").css({display:"none"})
    $("main,header,footer").css({opacity:"1"})
})
$("#cadastroBtn").on("click",function(){
    $("#cadastro").css({display:"none"})
    $("#newUser").css({display:"initial"})
})
$("#voltar").on("click", function(){
    $("#newUser").css({display:"none"})
    $("#cadastro").css({display:"initial"})
})
$("#cur").on("click",function(){
    alert("Faça login para acessar os produtos curtidos")
})
$("#car").on("click",function(){
    alert("Faça login para acessar o carrinho")
})

$(".curtir").on("click",function(){
    var id = document.querySelector("#curtir").value;
    console.log(id)
    $.post("/Home/Curtidos",{idProduto:id})
        .done(function(data){
            $(".curtidos").html(data);
        })
        .fail(function(){
            alert(id,data)
        })
})

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


