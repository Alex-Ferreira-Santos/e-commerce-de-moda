using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using exercicio_3_Alex_Ferreira_Santos.Models;

namespace exercicio_3_Alex_Ferreira_Santos.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Produto(){
            return PartialView("_Produto");
        }
        public IActionResult ProdutoPromo(){
            return PartialView("_ProdutoPromo");
        }
        public IActionResult Produtos(){
            return View();
        }
    }
}
