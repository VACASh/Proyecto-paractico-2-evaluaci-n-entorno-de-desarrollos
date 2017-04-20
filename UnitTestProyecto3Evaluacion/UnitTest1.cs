using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numeros.fibonacci;

namespace UnitTestProyecto3Evaluacion
{
    [TestClass]
    public class pruebasUnitarias3Evaluacion
    {
        /// <summary>
        /// Caso de prueba para números fibonacci,los rangos estan controladas con las pruebas
        /// de caja negra y negativos y caracteres tambien.
        /// <remarks>Unica prueba necesaria para números fibonacci</remarks>
        /// </summary>
        [TestMethod]
        public void testFibo()
        {
            //escenario
            int numInicial = 111;
            string textoEsperado = "Estos son los números fibonacci hasta el número introducido: 0,1,1,2,3,5,8,13,21,34,55,89,";
            string textoObtenido ="";
            
            //acción
            textoObtenido= Numeros.Fibonacci.numerosFibonacciLogica.textFibo(numInicial);

            //afirmación
            Assert.AreEqual(textoEsperado, textoObtenido);
        }

        [TestMethod]
        public void testPrimitiva()
        {

        }
    }
}
