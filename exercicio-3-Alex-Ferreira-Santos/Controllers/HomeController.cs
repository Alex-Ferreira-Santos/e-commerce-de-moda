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
            return View();
        }
        [HttpPost]
        public IActionResult Index(string login,usuario u) {
            switch(login) {
                case "entrar":
                    // delegate sending to another controller action
                    return(Entrar(u));
                case "Confirmar":
                    // call another action to perform the cancellation
                    return(Cadastrar(u));
                default:
                    // If they've submitted the form without a submitButton, 
                    // just return the view again.
                    return(View());
            }
        }   
    

        private IActionResult Cadastrar(usuario u) {
            usuarioRepository ur = new usuarioRepository();
            u.tipo=0;
            ur.insert(u);
            ViewBag.mensagem=$"Usuario {u.nome} criado com sucesso";
            return(View("Index"));
        }

        private IActionResult Entrar(usuario u) {
            usuarioRepository ur = new usuarioRepository();
            usuario Usuario = ur.login(u);
            if(Usuario!=null)
            {
                HttpContext.Session.SetInt32("idUsuariousuario",Usuario.id);
                HttpContext.Session.SetString("nomeUsuariousuario",Usuario.nome);
                HttpContext.Session.SetInt32("tipoUsuariousuario",Usuario.tipo);
                return(View("Index"));
            }
            else{
                ViewBag.mensagem=$" falha no login";
                return(View("Index"));
            }             
        } 
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index","Home");
        }

        public IActionResult Produto(){
            if(HttpContext.Session.GetInt32("tipoUsuario")!=1){
                return RedirectToAction("Index","Home");
            }
            return PartialView("_Produto");
        }

        public IActionResult ProdutoPromo(){
            if(HttpContext.Session.GetInt32("tipoUsuario")!=1){
                return RedirectToAction("Index","Home");
            }
            return PartialView("_ProdutoPromo");
        }

        public IActionResult Produtos(){
            return View();
        }

        public IActionResult Curtidos(){
            if(HttpContext.Session.GetInt32("tipoUsuario")==null){
                return RedirectToAction("Index","Home");
            }
            return View();
            
        }

        public IActionResult Carrinho(){
            if(HttpContext.Session.GetInt32("tipoUsuario")==null){
                return RedirectToAction("Index","Home");
            }
            return View();
        }

        public IActionResult ProdutoCart(){
            if(HttpContext.Session.GetInt32("tipoUsuario")!=1){
                return RedirectToAction("Index","Home");
            }
            return PartialView("_ProdutoCart");
        }
    }
}
