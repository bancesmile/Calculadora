using Calcualdora.Models;
using Calcualdora.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Calcualdora.Controllers
{
    public class HomeController : Controller
    {
        // ─── Inyección del servicio ───────────────────────────────────────────
        private readonly CalculadoraService _calculadora;

        public HomeController()
        {
            _calculadora = new CalculadoraService();
        }

        // ─── Página principal ─────────────────────────────────────────────────
        public IActionResult Index()
        {
            return View();
        }

        // ─── Calculadora: muestra formulario vacío ────────────────────────────
        public IActionResult Calculadora()
        {
            return View(new CalculadoraViewModel());
        }

        // ─── Función de Suma ──────────────────────────────────────────────────
        [HttpPost]
        public IActionResult Sumar(CalculadoraViewModel model)
        {
            model.Resultado = _calculadora.Suma(model.Numero1, model.Numero2);
            model.Operacion = "Suma";
            return View("Calculadora", model);
        }

        // ─── Función de Resta ─────────────────────────────────────────────────
        [HttpPost]
        public IActionResult Restar(CalculadoraViewModel model)
        {
            model.Resultado = _calculadora.Resta(model.Numero1, model.Numero2);
            model.Operacion = "Resta";
            return View("Calculadora", model);
        }

        // ─── Función de Multiplicación ────────────────────────────────────────
        [HttpPost]
        public IActionResult Multiplicar(CalculadoraViewModel model)
        {
            model.Resultado = _calculadora.Multiplicacion(model.Numero1, model.Numero2);
            model.Operacion = "Multiplicación";
            return View("Calculadora", model);
        }

        // ─── Páginas estándar ─────────────────────────────────────────────────
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
