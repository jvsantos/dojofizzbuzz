using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/*
 * Codificado por: Jorge Santos(santos.reis.vinicius.jorge@gmail.com)
 * Dojo: Fizzbuzz
 * 
 * Critérios de aceitação:
 * Neste problema, você deverá exibir uma lista de 1 a 100, um em cada linha, com as seguintes exceções:
 * Números divisíveis por 3 deve aparecer como 'Fizz' ao invés do número;
 * Números divisíveis por 5 devem aparecer como 'Buzz' ao invés do número;
 * Números divisíveis por 3 e 5 devem aparecer como 'FizzBuzz' ao invés do número'.
 */

namespace Testes
{
    [TestClass]
    public class FizzbuzzTest
    {
        int[] _listaNumeros;

        [TestInitialize]
        public void Setup() {
            _listaNumeros = new int[100];

            for (int i = 1; i < 100; i++) _listaNumeros[i] = i;            
        }

        [TestMethod]
        public void Deve_Conter_Numeros_De_1_a_100()
        {
            Assert.IsTrue(_listaNumeros.Any(f => f >= 1 && f <= 100), "Lista deve conter números de 1 a 100");
        }

        [TestMethod]
        public void Deve_Conter_100_Numeros()
        {
            Assert.IsTrue(_listaNumeros.Length == 100, "Lista deve conter 100 números");
        }

        [TestMethod]
        public void Deve_Exibir_Fizz_Se_Numero_Divisivel_Por_3()
        {
            var resultado = ProcessarNumero(9);

            Assert.AreEqual(resultado, "Fizz", string.Format("Deve exibir Fizz se número divisivel por 3 porem valor exibido foi {0}", resultado));
        }

        [TestMethod]
        public void Deve_Exibir_Fizz_Se_Numero_Divisivel_Por_5()
        {
            var resultado = ProcessarNumero(25);

            Assert.AreEqual(resultado, "Buzz", string.Format("Deve exibir Buzz se número divisivel por 5 porem valor exibido foi {0}", resultado));
        }

        [TestMethod]
        public void Deve_Exibir_FizzBuzz_Se_Numero_Divisivel_Por_3_e_5()
        {
            var resultado = ProcessarNumero(15);

            Assert.AreEqual(resultado, "FizzBuzz", string.Format("Deve exibir FizzBuzz se número divisivel por 3 e 5 porem valor exibido foi {0}", resultado));
        }

        [TestMethod]
        public void Deve_Exibir_Proprio_Numero_Se_Nao_Divisivel_Por_3_e_5()
        {
            var resultado = ProcessarNumero(15);

            Assert.AreEqual(resultado, "FizzBuzz", string.Format("Deve exibir FizzBuzz se número divisivel por 3 e 5 porem valor exibido foi {0}", resultado));
        }

        [TestMethod]
        public void Deve_Exibir_O_Numero_Se_Nao_Divisivel_Por_3_e_5()
        {
            var resultado = ProcessarNumero(7);

            Assert.AreEqual(resultado, "7", string.Format("Deve exibir o próprio número se o mesmo não for divisivel por 3 e 5 porem valor exibido foi {0}", resultado));
        }

        #region Métodos Auxiliares

        private string ProcessarNumero(int p)
        {
            return (p % 3 == 0) && (p % 5 == 0) ? "FizzBuzz" :
                        (p % 3 == 0) ? "Fizz" :
                            (p % 5 == 0) ? "Buzz" : p.ToString();
        }

        #endregion

    }
}
