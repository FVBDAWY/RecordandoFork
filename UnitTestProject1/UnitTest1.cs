using Ejercicio_8;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Meterdosnumeros()
        {
            Form1 form = new Form1();
            List<int> numerosSorteo = new List<int>() { 2,3,4,5,6,8};
            List<int> numerosUsuario = new List<int>() { 2, 3, 4, 5, 6, 8 };
            int cont = 0;
            cont=form.numerosAcertadosSorteo(numerosSorteo, numerosUsuario);
            Assert.AreEqual(cont, 6);

        }
    }
}
