using System.Collections.Generic;

namespace exercicio_3_Alex_Ferreira_Santos.Models
{
    public class ViewModel
    {
        public usuario usuario{get;set;}
        public Produto produto{get;set;}
        public List<Produto> listaProduto{get;set;}
        public List<Produto> listaProd{get;set;}
        public List<Curtidos> listaCurtidos{get;set;}
        public usuarioRepository UsuarioRepository{get;set;}
        public ProdutoRepository ProdutoRepository{get;set;}
        public CurtidosRepository CurtidosRepository{get;set;}
        public Curtidos curtidos{get;set;}
    }
}