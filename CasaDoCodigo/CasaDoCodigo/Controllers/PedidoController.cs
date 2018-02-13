using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CasaDoCodigo.Controllers
{
    public class PedidoController : Controller
    {
        // GET: /<controller>/
        public IActionResult Carrossel()
        {
            ViewData["Title"] = "Carrossel";
            return View();
        }

        public IActionResult Carrinho()
        {
            ViewData["Title"] = "Carrinho";
            return View();
        }

        public IActionResult Resumo()
        {
            ViewData["Title"] = "Resumo";
            string [] title = new string[2];
            return View(title);
        }
    }
}
