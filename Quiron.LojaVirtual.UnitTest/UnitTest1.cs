using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Quiron.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTestQuiron
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void Take()
        {
            // Take(): seleciona os primeiros n elementos. Equivalente ao Top() no SQL Server

            int[] numeros = {5,4,1,3,9,8,6,7,2,0};

            var resultado = from num in numeros.Take(5) select num;
            // resultado {5,4,1,3,9}

            int[] teste = {5,4,1,3,9};

            CollectionAssert.AreEqual(resultado.ToArray(), teste);
        }

        [TestMethod]
        public void Skip()
        {
            // Skip(): "pula" a quantidade de elementos especificada

            int[] numeros = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var resultado = from num in numeros.Take(5).Skip(2) select num;
            // resultado {1,3,9}, pegou is 5 primeiros elementos e pulou o 5 e o 4

            int[] teste = { 1, 3, 9 };

            CollectionAssert.AreEqual(resultado.ToArray(), teste);
        }
    }
}
