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
        public IActionResult Modificar(){
            if(HttpContext.Session.GetInt32("tipoUsuariousuario")!=1){
                return RedirectToAction("Index","Home");
            }
            return View();
        }
        public IActionResult Deletar(){
            if(HttpContext.Session.GetInt32("tipoUsuariousuario")!=1){
                return RedirectToAction("Index","Home");
            }
            return View();
        }
    }
}