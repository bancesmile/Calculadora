namespace Calcualdora.Models
{
    /// <summary>
    /// ViewModel para la calculadora con operaciones de suma, resta y multiplicación.
    /// </summary>
    public class CalculadoraViewModel
    {
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }
        public double? Resultado { get; set; }
        public string? Operacion { get; set; }
        public string? MensajeError { get; set; }
    }
}
