using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestDev.Data;
using TestDev.Models;
using TestDev.Models.Clientes;

namespace TestDev.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            var clientes = FakeDB.Clientes;
            return View(clientes);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Criar(Cliente cliente)
        {
            if (!ModelState.IsValid) return View();

            FakeDB.Clientes.Add(cliente);

            return RedirectToAction(nameof(Index));
        }
    }
}
