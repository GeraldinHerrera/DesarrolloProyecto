using DesarrolloProyecto.Context;
using DesarrolloProyecto.Models;
using DesarrolloProyecto.Models.peticiones;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DesarrolloProyecto.Controllers
{
    public class HomeController : Controller
    {
        private readonly TODOYAContext _TODOYAContext;

        public HomeController(TODOYAContext context)
        {
            _TODOYAContext = context;
        }

        public IActionResult Index()
        {
            List<Categorium> lista = _TODOYAContext.Categoria.ToList();
            return View();
        }

        public IActionResult Login()
        {
            return View(Login);
        }
    }
}