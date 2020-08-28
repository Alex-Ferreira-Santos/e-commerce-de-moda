using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using exercicio_3_Alex_Ferreira_Santos.Models;
using Microsoft.AspNetCore.Http;
namespace exercicio_3_Alex_Ferreira_Santos.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Menu(){
            if(HttpContext.Session.GetInt32("tipoUsuariousuario")==null){
                return RedirectToAction("Index","Home");
            }
            return View();
        }
        public IActionResult Inserir(){
            if(HttpContext.Session.GetInt32("tipoUsuariousuario")!=1){
                return RedirectToAction("Index","Home");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Inserir(Produto p){
            if(HttpContext.Session.GetInt32("tipoUsuariousuario")!=1){
                return RedirectToAction("Index","Home");
            }
            ProdutoRepository pr = new ProdutoRepository();
            pr.insert(p);
            ViewBag.mensagem=$"Produto {p.nome} inserido com sucesso";
            return View();
        }
        public IActionResult Modificar(){
            if(HttpContext.Session.GetInt32("tipoUsuariousuario")!=1){
                return RedirectToAction("Index","Home");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Modificar(Produto p){
            if(HttpContext.Session.GetInt32("tipoUsuariousuario")!=1){
                return RedirectToAction("Index","Home");
            }
            ProdutoRepository pr =new ProdutoRepository();
            pr.update(p);
            ViewBag.mensagem=$"produto {p.nome} alterado com sucesso";
            return View();
        }
        public IActionResult Deletar(){
            return View();
        }
        [HttpPost]
        public IActionResult Deletar(Produto p){
            if(HttpContext.Session.GetInt32("tipoUsuariousuario")!=1){
                return RedirectToAction("Index","Home");
            }
            ProdutoRepository pr = new ProdutoRepository();
            ViewBag.mensagem=$"produto {p.nome} deletado com sucesso";
            pr.delete(p);
            return View();
        }
        public IActionResult Produtos(string categoria){
            ViewModel viewModel = new ViewModel();
            viewModel.ProdutoRepository = new ProdutoRepository();
            string ordenacao= Categoria(categoria);
            viewModel.listaProduto = viewModel.ProdutoRepository.select(ordenacao);
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Produtos(string login,ViewModel u,string categoria) {  
            switch(login) {
                case "entrar":
                    
                    return(Entrar(u,categoria));
                case "Confirmar":
                    
                    return(Cadastrar(u,categoria));
                default:
                    
                    return(View());
            }
        }   
        private string Categoria(string categoria){
            string ordenacao;
            switch (categoria)
            {
                case "masculino":
                    ordenacao="masculino";
                    break;
                
                case "feminino":
                    ordenacao="feminino";
                    break;

                case "infantil":
                    ordenacao="infantil";
                    break;

                case "calcados":
                    ordenacao="calcados";
                    break;

                case "Novidades" :
                    ordenacao="novidade";
                    break;

                default:
                    ordenacao=null;
                    break;
                
            }
            return ordenacao;
        }
        private IActionResult Cadastrar(ViewModel u, string categoria) {
            ViewModel viewModel = new ViewModel();
            viewModel.UsuarioRepository = new usuarioRepository();
            viewModel.UsuarioRepository.insert(u.usuario);

            viewModel.ProdutoRepository = new ProdutoRepository();
            string ordenacao= Categoria(categoria);
            viewModel.listaProduto = viewModel.ProdutoRepository.select(ordenacao);

            ViewBag.mensagem=$"Usuario {u.usuario.nome} criado com sucesso";
            return(View("Produtos",viewModel));
        }

        private IActionResult Entrar(ViewModel u, string categoria) {
            ViewModel viewModel = new ViewModel();
            viewModel.UsuarioRepository = new usuarioRepository();
            viewModel.usuario = viewModel.UsuarioRepository.login(u.usuario);

            viewModel.ProdutoRepository = new ProdutoRepository();
            string ordenacao= Categoria(categoria);
            viewModel.listaProduto = viewModel.ProdutoRepository.select(ordenacao);

            if(viewModel.usuario!=null)
            {
                HttpContext.Session.SetInt32("idUsuariousuario",viewModel.usuario.id);
                HttpContext.Session.SetString("nomeUsuariousuario",viewModel.usuario.nome);
                HttpContext.Session.SetInt32("tipoUsuariousuario",viewModel.usuario.tipo);
                return(View("Produtos",viewModel));
            }
            else{
                ViewBag.mensagem=$" falha no login";
                return(View("Produtos",viewModel));
            }             
        } 
        public IActionResult _Produto(string categoria){
            ViewModel viewModel = new ViewModel();
            viewModel.ProdutoRepository = new ProdutoRepository();
            string ordenacao;
            switch (categoria)
            {
                case "masculino":
                    ordenacao="masculino";
                    break;
                
                case "feminino":
                    ordenacao="feminino";
                    break;

                case "infantil":
                    ordenacao="infantil";
                    break;

                case "calcados":
                    ordenacao="calcados";
                    break;

                case "Novidades":
                    ordenacao="novidade";
                    break;

                default:
                    ordenacao=null;
                    break;
            }
            viewModel.listaProduto =viewModel.ProdutoRepository.select(ordenacao);
            return PartialView(viewModel);
        }

        public IActionResult ProdutoPromo(){
            ViewModel viewModel = new ViewModel();
            viewModel.ProdutoRepository = new ProdutoRepository();
            viewModel.listaProduto =viewModel.ProdutoRepository.promocao();
            return PartialView("_ProdutoPromo",viewModel);
        }
        public IActionResult ProdutoNovo(){
            ViewModel viewModel = new ViewModel();
            viewModel.ProdutoRepository = new ProdutoRepository();
            viewModel.listaProd =viewModel.ProdutoRepository.novo();
            return PartialView("_ProdutoPromo",viewModel);
        }

    }
}