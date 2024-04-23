using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidaStringTests
    {
        private ValidaString _valida;
        public ValidaStringTests()
        {
            _valida = new ValidaString();
        }

        [Fact]
        public void DeveContar3CaracteresEmOlaERetornar3()
        {
            // Arrange
            string texto = "Ola";

            // Act
            int resultado = _valida.ContarCarecteres(texto);

            // Assert
            Assert.Equal(3, resultado);
        }
    }
}