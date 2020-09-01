$(".remover").on("click",function(){
    id = document.querySelector("#remover").value
    $.post("/Home/CarrinhoRemove",{idCarrinho:id})
        .done(function(data){
            $(".adicionados").html(data)
        })
        .fail(function(){
            alert(Error, id, data)
        })
    $(".produto").css({display:"none"})
})