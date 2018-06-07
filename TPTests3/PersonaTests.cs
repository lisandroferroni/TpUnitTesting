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
    public class PersonaTests
    {
        [TestMethod()]
        public void PersonaTest()
        {
            ///Assert.Fail();
        }

        [TestMethod()]
        public void GetEdadTest()
        {
            DateTime fecha = new DateTime(2000, 6, 8);
            Persona seba = new Persona("seba","jaja",fecha);
            var actual = seba.GetEdad();
            const int esperado = 18;
            Assert.AreEqual(actual,esperado);
        }
    }
}