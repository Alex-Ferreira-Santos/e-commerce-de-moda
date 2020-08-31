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
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewModel viewModel = new ViewModel();
            viewModel.ProdutoRepository = new ProdutoRepository();
            viewModel.listaProduto = viewModel.ProdutoRepository.promocao();
            viewModel.listaProd = viewModel.ProdutoRepository.novo();
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Index(string login,ViewModel u) {  
            switch(login) {
                case "entrar":
                    
                    return(Entrar(u));
                case "Confirmar":
                    
                    return(Cadastrar(u));
                default:
                    
                    return(View());
            }
        }   
    

        private IActionResult Cadastrar(ViewModel u) {
            ViewModel viewModel = new ViewModel();
            viewModel.UsuarioRepository = new usuarioRepository();
            viewModel.UsuarioRepository.insert(u.usuario);

            viewModel.ProdutoRepository = new ProdutoRepository();
            viewModel.listaProduto = viewModel.ProdutoRepository.promocao();
            viewModel.listaProd = viewModel.ProdutoRepository.novo();

            ViewBag.mensagem=$"Usuario {u.usuario.nome} criado com sucesso";
            return(View("Index",viewModel));
        }

        private IActionResult Entrar(ViewModel u) {
            ViewModel viewModel = new ViewModel();
            viewModel.UsuarioRepository = new usuarioRepository();
            viewModel.usuario = viewModel.UsuarioRepository.login(u.usuario);

            viewModel.ProdutoRepository = new ProdutoRepository();
            viewModel.listaProduto = viewModel.ProdutoRepository.promocao();
            viewModel.listaProd = viewModel.ProdutoRepository.novo();

            if(viewModel.usuario!=null)
            {
                HttpContext.Session.SetInt32("idUsuariousuario",viewModel.usuario.id);
                HttpContext.Session.SetString("nomeUsuariousuario",viewModel.usuario.nome);
                HttpContext.Session.SetInt32("tipoUsuariousuario",viewModel.usuario.tipo);
                return(View("Index",viewModel));
            }
            else{
                ViewBag.mensagem=$" falha no login";
                return(View("Index",viewModel));
            }             
        } 
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index","Home");
        }
        public IActionResult Curtidos(){
            if(HttpContext.Session.GetInt32("tipoUsuariousuario")==null){
                return RedirectToAction("Index","Home");
            }
            ViewModel viewModel = new ViewModel();
            viewModel.CurtidosRepository = new CurtidosRepository();
            viewModel.listaCurtidos= viewModel.CurtidosRepository.curtidos(int.Parse(HttpContext.Session.GetInt32("idUsuariousuario").ToString()));
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Curtidos(Curtidos c){
            ViewModel viewModel = new ViewModel();
            viewModel.CurtidosRepository = new CurtidosRepository();
            viewModel.CurtidosRepository.insert(c,HttpContext.Session.GetInt32("idUsuariousuario"));
            viewModel.listaCurtidos= viewModel.CurtidosRepository.curtidos(int.Parse(HttpContext.Session.GetInt32("idUsuariousuario").ToString()));
            return PartialView("_ProdutoCurtido",viewModel);
        }
        [HttpPost]
        public IActionResult RemoveCurtidos(Curtidos c){
            ViewModel viewModel = new ViewModel();
            viewModel.CurtidosRepository = new CurtidosRepository();
            viewModel.CurtidosRepository.delete(c,HttpContext.Session.GetInt32("idUsuariousuario"));
            viewModel.listaCurtidos= viewModel.CurtidosRepository.curtidos(int.Parse(HttpContext.Session.GetInt32("idUsuariousuario").ToString()));
            return PartialView("_ProdutoCurtido",viewModel);
        }

        public IActionResult Carrinho(){
            if(HttpContext.Session.GetInt32("tipoUsuariousuario")==null){
                return RedirectToAction("Index","Home");
            }
            ViewModel viewModel = new ViewModel();
            viewModel.CarrinhoRepository = new CarrinhoRepository();
            viewModel.listaCarrinho= viewModel.CarrinhoRepository.carrinho(HttpContext.Session.GetInt32("idUsuariousuario"));
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Carrinho(Carrinho c){
            ViewModel viewModel = new ViewModel();
            viewModel.CarrinhoRepository = new CarrinhoRepository();
            viewModel.CarrinhoRepository.insert(c,HttpContext.Session.GetInt32("idUsuariousuario"));
            viewModel.listaCarrinho= viewModel.CarrinhoRepository.carrinho(HttpContext.Session.GetInt32("idUsuariousuario"));
            return PartialView("_ProdutoCart",viewModel);
        }

        [HttpPost]
        public IActionResult CarrinhoRemove(Carrinho c){
            ViewModel viewModel = new ViewModel();
            viewModel.CarrinhoRepository = new CarrinhoRepository();
            viewModel.CarrinhoRepository.remove(c,HttpContext.Session.GetInt32("idUsuariousuario"));
            viewModel.listaCarrinho= viewModel.CarrinhoRepository.carrinho(HttpContext.Session.GetInt32("idUsuariousuario"));
            return PartialView("_ProdutoCart",viewModel);
        }

        public IActionResult ProdutoCart(){
            if(HttpContext.Session.GetInt32("tipoUsuario")!=1){
                return RedirectToAction("Index","Home");
            }
            return PartialView("_ProdutoCart");
        }

    }
}
