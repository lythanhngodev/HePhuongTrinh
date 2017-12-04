using Microsoft.VisualStudio.TestTools.UnitTesting;
using HePhuongTrinh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HePhuongTrinh.Tests
{
    [TestClass()]
    public class PhuongTrinhTests
    {
        [TestMethod()]
        public void BatLoiTest()
        {
            PhuongTrinh pt = new PhuongTrinh();
            bool err = pt.BatLoi("3");
            Assert.AreEqual(true,err);
        }
    }
}