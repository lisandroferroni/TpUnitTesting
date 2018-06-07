using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.Tests
{
    [TestClass()]
    public class RectanguloTests
    {
        [TestMethod()]
        public void RectanguloTest()
        {
            Rectangulo seba = new Rectangulo(10,20);
            Assert.IsNotNull(seba);
        }

        [TestMethod()]
        public void PerimetroTest()
        {
            Rectangulo seba = new Rectangulo(10, 20);
            var actual = seba.Perimetro();
            const int esperado = 60;
            Assert.AreEqual(esperado,actual);
            
        }

        [TestMethod()]
        public void AreaTest()
        {
            Rectangulo seba = new Rectangulo(10, 20);
            var actual = seba.Area();
            const int esperado = 200;
            Assert.AreEqual(esperado,actual);
        }
    }
}