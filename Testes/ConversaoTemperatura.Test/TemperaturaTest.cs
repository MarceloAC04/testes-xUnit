using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoTemperatura.Test
{
    public class TemperaturaTest
    {
        [Fact]
        public void ConversaoTeste()
        {
            double celsius = 100;

            double tempConvertida = Temperatura.CelsiusToFahrenheit(celsius);
            double tempEsperada = 212;

            Assert.Equal(tempConvertida, tempEsperada);
        }
    }
}
