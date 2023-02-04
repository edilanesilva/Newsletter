using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using cadastro_usuario_newsletter.Models;


namespace cadastro_usuario_newsletter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastro(Usuario usuario)
        {
            BaseDados.Incluir(usuario);
            List<Usuario> lista = BaseDados.Listar();
            return View(lista);
        }

    }
}
