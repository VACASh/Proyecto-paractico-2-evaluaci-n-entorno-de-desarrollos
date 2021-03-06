using System.Reflection;
// <copyright file="revisarPrimosMatrizTest.cs">Copyright ©  2017</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numeros.Primos;

namespace Numeros.Primos.Tests
{
    [TestClass]
    [PexClass(typeof(revisarPrimosMatriz))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class revisarPrimosMatrizTest
    {

        [PexMethod(MaxBranches = 20000)]
        [PexMethodUnderTest("bPrimos(Object, EventArgs)")]
        internal void bPrimos(
            [PexAssumeUnderTest]revisarPrimosMatriz target,
            object sender,
            EventArgs e
        )
        {
            object[] args = new object[2];
            args[0] = sender;
            args[1] = (object)e;
            Type[] parameterTypes = new Type[2];
            parameterTypes[0] = typeof(object);
            parameterTypes[1] = typeof(EventArgs);
            object result = ((MethodBase)(typeof(revisarPrimosMatriz).GetMethod("bPrimos",
                                                                                BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic, (Binder)null,
                                                                                CallingConventions.HasThis, parameterTypes, (ParameterModifier[])null)))
                                .Invoke((object)target, args);
            // TODO: agregar aserciones a método revisarPrimosMatrizTest.bPrimos(revisarPrimosMatriz, Object, EventArgs)
        }
    }
}
