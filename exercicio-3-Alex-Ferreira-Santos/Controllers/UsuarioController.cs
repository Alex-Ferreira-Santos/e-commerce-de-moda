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
    public class UsuarioController : Controller
    {
        public IActionResult Alterar(){
            if(HttpContext.Session.GetInt32("tipoUsuariousuario")!=1){
                return RedirectToAction("Index","Home");
            }
            return View();
        }
        public IActionResult Excluir(){
            if(HttpContext.Session.GetInt32("tipoUsuariousuario")!=1){
                return RedirectToAction("Index","Home");
            }
            return View();
        }
    }
}