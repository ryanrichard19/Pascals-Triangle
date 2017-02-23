using Microsoft.VisualStudio.TestTools.UnitTesting;
using PascalsTriangle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalsTriangle.Tests
{
    [TestClass]
    public class PascalTriTest
    {
        [TestMethod]
        public void Valueszerotwoequalsone()
        {
            PascalTri target = new PascalTri();
            int result = PascalTri.Pascal(0, 2);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Valuesonetwoequaltwo()
        {
            PascalTri target = new PascalTri();
            int result = PascalTri.Pascal(1, 2);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Valuesonetreeequalsthree()
        {
            PascalTri target = new PascalTri();
            int result = PascalTri.Pascal(1, 3);
            Assert.AreEqual(3, result);
        }
    }
}