using Calcualdora.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Calcualdora.Controllers
{
    public class HomeController : Controller
    {
        // ─── Página principal ────────────────────────────────────────────────
        public IActionResult Index()
        {
            return View();
        }

        // ─── Calculadora: muestra formulario vacío ───────────────────────────
        public IActionResult Calculadora()
        {
            return View(new CalculadoraViewModel());
        }

        // ─── Función de Suma ─────────────────────────────────────────────────
        [HttpPost]
        public IActionResult Sumar(CalculadoraViewModel model)
        {
            model.Resultado = Suma(model.Numero1, model.Numero2);
            model.Operacion = "Suma";
            return View("Calculadora", model);
        }

        // ─── Función de Resta ────────────────────────────────────────────────
        [HttpPost]
        public IActionResult Restar(CalculadoraViewModel model)
        {
            model.Resultado = Resta(model.Numero1, model.Numero2);
            model.Operacion = "Resta";
            return View("Calculadora", model);
        }

        // ─── Función de Multiplicación ───────────────────────────────────────
        [HttpPost]
        public IActionResult Multiplicar(CalculadoraViewModel model)
        {
            model.Resultado = Multiplicacion(model.Numero1, model.Numero2);
            model.Operacion = "Multiplicación";
            return View("Calculadora", model);
        }

        // ════════════════════════════════════════════════════════════════════
        //  Funciones matemáticas privadas
        // ════════════════════════════════════════════════════════════════════

        /// <summary>Retorna la suma de dos números.</summary>
        private static double Suma(double a, double b) => a + b;

        /// <summary>Retorna la resta de dos números.</summary>
        private static double Resta(double a, double b) => a - b;

        /// <summary>Retorna la multiplicación de dos números.</summary>
        private static double Multiplicacion(double a, double b) => a * b;

        // ─── Páginas estándar ────────────────────────────────────────────────
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
