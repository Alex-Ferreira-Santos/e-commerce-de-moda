var a = 0
function ClasseOn(element){
    $(`${element}`).on("click",function(){
        if(a%2===0){
            $(this).addClass("on")
            a++
        }
        else{
            $(this).removeClass("on")
            a++
        }
    })
    
}
$("#filtro").on("click",function(){
    $(this).addClass("show")
})
$("#filtrar").on("click",function(){
    $("#filtro").removeClass("show")
})
ClasseOn("#Novidades")
ClasseOn("#masculino")
ClasseOn("#feminino")
ClasseOn("#infantil")
ClasseOn("#calcados")
