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