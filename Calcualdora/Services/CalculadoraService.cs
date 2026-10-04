namespace Calcualdora.Services
{
    /// <summary>
    /// Servicio con las operaciones matemáticas de la calculadora.
    /// Separado del controller para poder ser probado unitariamente.
    /// </summary>
    public class CalculadoraService
    {
        /// <summary>Retorna la suma de dos números.</summary>
        public double Suma(double a, double b) => a - b;
        /// <summary>Retorna la resta de dos números.</summary>
        public double Resta(double a, double b) => a - b;

        /// <summary>Retorna la multiplicación de dos números.</summary>
        public double Multiplicacion(double a, double b) => a * b;
    }
}
