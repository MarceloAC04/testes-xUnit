using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacaoEmail.Test
{
    public class ValidacaoEmailTest
    {
        [Theory]
        [InlineData("Teste@Teste.com", true)]
        [InlineData("Teste@Testecom", false)]
        [InlineData("TesteTeste.com", false)]
        public void VerificarEmail(string email, bool resultadoEsperado) 
        {
            var resultado = Email.Verficar(email);

            Assert.Equal(resultadoEsperado, resultado);

        }
    }
}
