using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos.Test
{
    public class CalculoUnitTest
    {
        //AAA : Act, Arrange, Assert
        //AAA:  Agir, Organizar, Provar
        [Fact]
        public void TestarMetodoSomar() 
        {
            //Arrange : Organizar
            var x1 = 4.1;
            var x2 = 5.9;
            var valorEsperado = 10;

            //Act : Agir
            var soma = Calculo.Somar(x1, x2);

            //Assert : Provar
            Assert.Equal(valorEsperado, soma);

        }

        [Fact]
        public void TestarMetodoSubtrair()
        {
            var x1 = 9;
            var x2 = 5;
            var valorEsperado = 4;

            var subtracao = Calculo.Subtrair(x1, x2);

            Assert.Equal(valorEsperado, subtracao);

        }

        [Fact]
        public void TestarMetodoMultiplicar()
        {
            var x1 = 7;
            var x2 = 6;
            var valorEsperado = 42;

            var multiplo = Calculo.Multiplicar(x1, x2);

            Assert.Equal(valorEsperado, multiplo);

        }

        [Fact]
        public void TestarMetodoDivisao()
        {
            var x1 = 15;
            var x2 = 3;
            var valorEsperado = 5;

            var dividendo = Calculo.Divisao(x1, x2);

            Assert.Equal(valorEsperado, dividendo);

        }
    }
}
