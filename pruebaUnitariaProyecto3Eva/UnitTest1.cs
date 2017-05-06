using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace pruebaUnitariaProyecto3Eva
{
    [TestClass]
    public class UnitTestProyecto
    {
        [TestClass]
        public class pruebasUnitarias3Evaluacion
        {
            /// <summary>
            /// Caso de prueba para números fibonacci,los rangos estan
            /// controladas con las pruebas
            /// de caja negra y negativos y caracteres tambien.
            /// <remarks>Unica prueba necesaria para números fibonacci</remarks>
            /// </summary>
            [TestMethod]
            public void testFibo()
            {
                //escenario
                int numInicial = 111;
                string textoEsperado = "Estos son los números fibonacci hasta el número introducido: 0,1,1,2,3,5,8,13,21,34,55,89,";
                string textoObtenido = "";

                //acción
                textoObtenido = Numeros.Fibonacci.numerosFibonacciLogica.textFibo(numInicial);

                //afirmación
                Assert.AreEqual(textoEsperado, textoObtenido);
            }

            /// <summary>
            /// Prueba para la clase de la primitiva logica
            /// <remarks>Comprueba que el número esta repetido
            /// y lo devuelve en un string</remarks>
            /// </summary>
            [TestMethod]
            public void numPrimiRepetido()
            {
                //creamos el objeto para poder usar las clases
                Numeros.Primitiva.LaPrimitivaLogica oPrimitiva = new Numeros.Primitiva.LaPrimitivaLogica();

                //escenario
                ArrayList listaContiene = new ArrayList();
                listaContiene = oPrimitiva.listaDondeJuegas;
                int numInicial = 1;
                listaContiene.Add(1);
                string textoEsperado = "El número esta repetido ingrese otro";
                string textoObtenido = "";

                //acción  
                textoObtenido = oPrimitiva.rellenarPrimitiva(numInicial);

                //afirmación

                Assert.AreEqual(textoEsperado, textoObtenido);

            }
            /// <summary>
            /// Prueba para clase logica de la primitiva
            /// <remarks>Comprueba que el número no esta repetido 
            /// y lo devuelve en un string</remarks>
            /// </summary>
            [TestMethod]
            public void numPrimiNoRepetido()
            {
                //creamos el objeto para poder usar las clases
                Numeros.Primitiva.LaPrimitivaLogica oPrimitiva = new Numeros.Primitiva.LaPrimitivaLogica();

                //escenario
                ArrayList listaContiene = new ArrayList();
                listaContiene = oPrimitiva.listaDondeJuegas;
                int numInicial = 1;
                listaContiene.Add(2);
                string textoEsperado = "El número ha sido añadido";
                string textoObtenido = "";

                //acción  
                textoObtenido = oPrimitiva.rellenarPrimitiva(numInicial);

                //afirmación

                Assert.AreEqual(textoEsperado, textoObtenido);

            }
            /// <summary>
            /// Prueba unitaria para primitiva cuando no hay aciertos
            /// </summary>
            [TestMethod]
            public void sinAciertosPrimitiva()
            {
                //creamos el objeto para poder usar las clases
                Numeros.Primitiva.LaPrimitivaLogica oPrimitiva = new Numeros.Primitiva.LaPrimitivaLogica();

                //escenario
                ArrayList listaDondeJuegas = new ArrayList();
                ArrayList listaPremiada = new ArrayList();

                listaDondeJuegas = oPrimitiva.listaDondeJuegas;
                listaPremiada = oPrimitiva.listaPremiada;

                //añadimos un 2 para comprobar
                listaDondeJuegas.Add(2);

                //añadimos un 1 para comprobar numeros
                listaPremiada.Add(1);

                string textoEsperado = "No has acertado ninguno";
                string textoObtenido = "";

                //acción  
                textoObtenido = oPrimitiva.textoLoteria();

                //afirmación

                Assert.AreEqual(textoEsperado, textoObtenido);

            }
            /// <summary>
            /// Prueba unitaria para primitiva cuando aciertas los 6 numeros
            /// </summary>
            [TestMethod]
            public void seisAciertosPrimitiva()
            {
                //creamos el objeto para poder usar las clases
                Numeros.Primitiva.LaPrimitivaLogica oPrimitiva = new Numeros.Primitiva.LaPrimitivaLogica();

                //escenario
                ArrayList listaDondeJuegas = new ArrayList();
                ArrayList listaPremiada = new ArrayList();

                listaDondeJuegas = oPrimitiva.listaDondeJuegas;
                listaPremiada = oPrimitiva.listaPremiada;

                //añadimos los 6 números
                listaDondeJuegas.Add(1);
                listaDondeJuegas.Add(13);
                listaDondeJuegas.Add(21);
                listaDondeJuegas.Add(42);
                listaDondeJuegas.Add(33);
                listaDondeJuegas.Add(49);

                //añadimos un 1 para comprobar numeros
                listaPremiada.Add(1);
                listaPremiada.Add(13);
                listaPremiada.Add(21);
                listaPremiada.Add(42);
                listaPremiada.Add(33);
                listaPremiada.Add(49);

                string textoEsperado = "Has acertado todas YOU WIN!!!";
                string textoObtenido = "";

                //acción  
                textoObtenido = oPrimitiva.textoLoteria();

                //afirmación

                Assert.AreEqual(textoEsperado, textoObtenido);

            }
            /// <summary>
            /// Pruebas unitarias para primitiva cuando aciertas mas de 0
            /// y menos de 6
            /// </summary>
            [TestMethod]
            public void aciertoMasDeCeroMenosDeSeis()
            {
                //creamos el objeto para poder usar las clases
                Numeros.Primitiva.LaPrimitivaLogica oPrimitiva = new Numeros.Primitiva.LaPrimitivaLogica();

                //escenario
                ArrayList listaDondeJuegas = new ArrayList();
                ArrayList listaPremiada = new ArrayList();

                listaDondeJuegas = oPrimitiva.listaDondeJuegas;
                listaPremiada = oPrimitiva.listaPremiada;

                //añadimos un 1 para comprobar que acierta un número
                listaDondeJuegas.Add(1);

                //añadimos un 1 para que concida con la lista donde juegas
                listaPremiada.Add(1);

                string textoEsperado = "has acertado: \n 1,";
                string textoObtenido = "";

                //acción  
                textoObtenido = oPrimitiva.textoLoteria();

                //afirmación

                Assert.AreEqual(textoEsperado, textoObtenido);

            }
            /// <summary>
            /// Prueba unitaria para numeros primos con resultado 
            /// de numero primo true
            /// </summary>
            [TestMethod]
            public void testPrimosEsPrimo()
            {
                //escenario
                int numInicial = 11;

                bool resultadoEsperado = true;
                bool resultadoObtenido = true;

                //acción
                resultadoObtenido = Numeros.Primos.numerosPrimosLogica.esPrimo(numInicial);

                //afirmación
                Assert.AreEqual(resultadoEsperado, resultadoObtenido);
            }
            /// <summary>
            /// Prueba unitaria para numeros primos con resultado 
            /// de número primo false
            /// </summary>
            [TestMethod]
            public void testPrimosNoEsPrimo()
            {
                //escenario
                int numInicial = 8;

                bool resultadoEsperado = false;
                bool resultadoObtenido = false;

                //acción
                resultadoObtenido = Numeros.Primos.numerosPrimosLogica.esPrimo(numInicial);

                //afirmación
                Assert.AreEqual(resultadoEsperado, resultadoObtenido);
            }

            /// <summary>
            /// prueba unitaria cuando en la matriz hay 2 números
            /// primos muestra cuales son
            /// </summary>
            [TestMethod]
            public void testMatrizPrimos()
            {
                //escenario

                //matriz creada de 2x2
                int[,] matrizPrimos = new int[2, 2];

                //agrego los 4 numeros
                matrizPrimos[0, 0] = 2;
                matrizPrimos[0, 1] = 8;
                matrizPrimos[1, 0] = 11;
                matrizPrimos[1, 1] = 22;

                string resultadoEsperado = "Los números primos dentro de la matriz son: \nde la posicion 0,0el valor: 2\n de la posicion 1,0el valor: 11\n ";
                string resultadoObtenido = "";

                //acción
                resultadoObtenido = Numeros.Primos.numerosPrimosLogica.comprobarMatriz(matrizPrimos);

                //afirmación
                Assert.AreEqual(resultadoEsperado, resultadoObtenido);
            }

            [TestMethod]
            public void testTorresHanoi()
            {
                //escenario
                int numeroIntroducido = 3;

                string resultadoObtenido = "";

                Numeros.Hanoi.torresDeHanoiLogica oHanoi = new Numeros.Hanoi.torresDeHanoiLogica();
                //aqui se obtiene el resultado obtenido
                oHanoi.torresDeHanoi(numeroIntroducido, "Origen", "Destino", "Auxiliar", ref resultadoObtenido);

                string resultadoEsperado = "Muevo el disco 1 de Origen a Destino\n Muevo el disco 2 de Origen a Auxiliar\n Muevo el disco 1 de Destino a Auxiliar\n Muevo el disco 3 de Origen a Destino\n Muevo el disco 1 de Auxiliar a Origen\n Muevo el disco 2 de Auxiliar a Destino\n Muevo el disco 1 de Origen a Destino\n ";
               
                //acción
                

                //afirmación
                Assert.AreEqual(resultadoEsperado, resultadoObtenido);
            }
        }

    }
}
