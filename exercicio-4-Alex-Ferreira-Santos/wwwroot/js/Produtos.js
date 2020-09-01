$("#filtrar").on("change",function () {
    var ordem = document.getElementById("filtrar").value;
    $.get("/Produto/_Produto?categoria=" + ordem)
        .done(function (data) { 
            $(".Produtos").html(data);
        })
        .fail(function () { 
            alert("Falha ao concluir requisição. ");
        });
}) ;