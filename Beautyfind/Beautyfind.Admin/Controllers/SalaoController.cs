using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Beautyfind.Admin.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Beautyfind.Admin.Controllers
{
    public class SalaoController : Controller
    {
        // GET: /<controller>/

        public IActionResult Create(string nome )
        {
            Salao salao = new Models.Salao();
            salao.Nome = nome;
            
            return View(salao);
        }
    }
}
