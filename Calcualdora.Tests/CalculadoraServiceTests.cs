using Calcualdora.Services;

namespace Calcualdora.Tests
{
    /// <summary>
    /// Pruebas unitarias para CalculadoraService.
    /// Estas pruebas son ejecutadas automáticamente en la rama QA-Pruebas.
    /// Si alguna falla, el merge a main queda BLOQUEADO.
    /// </summary>
    public class CalculadoraServiceTests
    {
        private readonly CalculadoraService _svc = new();

        // ════════════════════════════════════════════════════════════════════
        //  SUMA
        // ════════════════════════════════════════════════════════════════════

        [Fact]
        public void Suma_NumerosPositivos_RetornaResultadoCorrecto()
        {
            var resultado = _svc.Suma(5, 3);
            Assert.Equal(8, resultado);
        }

        [Fact]
        public void Suma_NumeroNegativo_RetornaResultadoCorrecto()
        {
            var resultado = _svc.Suma(-4, 10);
            Assert.Equal(6, resultado);
        }

        [Fact]
        public void Suma_AmbosNegativos_RetornaResultadoCorrecto()
        {
            var resultado = _svc.Suma(-3, -7);
            Assert.Equal(-10, resultado);
        }

        [Fact]
        public void Suma_ConCero_RetornaMismoNumero()
        {
            var resultado = _svc.Suma(99, 0);
            Assert.Equal(99, resultado);
        }

        // ════════════════════════════════════════════════════════════════════
        //  RESTA
        // ════════════════════════════════════════════════════════════════════

        [Fact]
        public void Resta_NumerosPositivos_RetornaResultadoCorrecto()
        {
            var resultado = _svc.Resta(10, 4);
            Assert.Equal(6, resultado);
        }

        [Fact]
        public void Resta_ResultadoNegativo_RetornaResultadoCorrecto()
        {
            var resultado = _svc.Resta(3, 8);
            Assert.Equal(-5, resultado);
        }

        [Fact]
        public void Resta_MismoNumero_RetornaCero()
        {
            var resultado = _svc.Resta(7, 7);
            Assert.Equal(0, resultado);
        }

        // ════════════════════════════════════════════════════════════════════
        //  MULTIPLICACIÓN
        // ════════════════════════════════════════════════════════════════════

        [Fact]
        public void Multiplicacion_NumerosPositivos_RetornaResultadoCorrecto()
        {
            var resultado = _svc.Multiplicacion(6, 7);
            Assert.Equal(42, resultado);
        }

        [Fact]
        public void Multiplicacion_PorCero_RetornaCero()
        {
            var resultado = _svc.Multiplicacion(999, 0);
            Assert.Equal(0, resultado);
        }

        [Fact]
        public void Multiplicacion_NegativoPorPositivo_RetornaNegativo()
        {
            var resultado = _svc.Multiplicacion(-3, 5);
            Assert.Equal(-15, resultado);
        }

        [Fact]
        public void Multiplicacion_NegativoPorNegativo_RetornaPositivo()
        {
            var resultado = _svc.Multiplicacion(-4, -4);
            Assert.Equal(16, resultado);
        }
    }
}
