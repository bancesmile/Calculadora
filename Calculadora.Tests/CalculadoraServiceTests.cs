using Calcualdora.Services;
using Xunit;

namespace Calculadora.Tests
{
    public class CalculadoraServiceTests
    {
        [Fact]
        public void Suma_DosNumeros_RetornaResultadoCorrecto()
        {
            // Arrange
            var calculadora = new CalculadoraService();

            // Act
            var resultado = calculadora.Suma(10, 5);

            // Assert
            Assert.Equal(15, resultado);
        }

        [Fact]
        public void Resta_DosNumeros_RetornaResultadoCorrecto()
        {
            // Arrange
            var calculadora = new CalculadoraService();

            // Act
            var resultado = calculadora.Resta(10, 5);

            // Assert
            Assert.Equal(5, resultado);
        }

        [Fact]
        public void Multiplicacion_DosNumeros_RetornaResultadoCorrecto()
        {
            // Arrange
            var calculadora = new CalculadoraService();

            // Act
            var resultado = calculadora.Multiplicacion(10, 5);

            // Assert
            Assert.Equal(50, resultado);
        }
    }
}