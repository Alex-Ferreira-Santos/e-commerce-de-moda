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
        public IActionResult Modificar(){
            if(HttpContext.Session.GetInt32("tipoUsuariousuario")==null){
                return RedirectToAction("Index","Home");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Modificar(string tipo,usuario u){
            if(HttpContext.Session.GetInt32("tipoUsuariousuario")==null){
                return RedirectToAction("Index","Home");
            }
            usuarioRepository ur = new usuarioRepository();
            if(HttpContext.Session.GetInt32("tipoUsuariousuario")==1){
                switch (tipo)
                {
                    case "1":
                        u.tipo=1;
                        break;
                    default:
                        u.tipo=0;
                        break;
                }
                ur.updateAdm(u);
            }
            if(HttpContext.Session.GetInt32("tipoUsuariousuario")==0){
                ur.update(u);
            }
            ViewBag.mensagem=$"Usuário {u.nome} modificado com sucesso";
            return View();
        }
        public IActionResult Excluir(){
            if(HttpContext.Session.GetInt32("tipoUsuariousuario")==null){
                return RedirectToAction("Index","Home");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Excluir(usuario u){
            if(HttpContext.Session.GetInt32("tipoUsuariousuario")!=0){
                return RedirectToAction("Index","Home");
            }
            usuarioRepository ur = new usuarioRepository();
            u.nome=HttpContext.Session.GetString("nomeUsuariousuario");
            ViewBag.mensagem=$"Usuário {u.nome} Deletado com sucesso";
            ur.delete(u);
            HttpContext.Session.Clear();
            return View();
        }

    }
}