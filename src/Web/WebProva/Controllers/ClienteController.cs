using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProva.Models;

namespace WebProva.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Novo(ProdutoViewModel cliente)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dados = cliente;
            return View();
        }
    }
}
