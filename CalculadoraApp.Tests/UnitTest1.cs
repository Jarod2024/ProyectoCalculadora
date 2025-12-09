using Xunit;    
namespace CalculadoraApp.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void Sumar_DosNumeros_VerificaSumaCorrecta()
        {
            // Arrange
            var calc = new CalculadoraApp.calculadora();
            var resultado = calc.Sumar(2, 3);
            Assert.Equal(5, resultado); 


        }
    }
}
