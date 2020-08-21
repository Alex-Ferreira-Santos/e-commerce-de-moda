// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
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


