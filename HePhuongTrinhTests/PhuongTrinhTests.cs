﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            Assert.AreEqual(new PhuongTrinh().BatLoi("2"), true);
            Assert.AreEqual(new PhuongTrinh().BatLoi("@"), false);
            Assert.AreEqual(new PhuongTrinh().BatLoi(""), false);
            Assert.AreEqual(new PhuongTrinh().BatLoi("2f"), false);
        }

        [TestMethod()]
        public void DoiChuoiSangSoTest()
        {
            Assert.AreEqual(new PhuongTrinh().DoiChuSangSo("3.6"), 3.6f);
        }

        [TestMethod()]
        public void gptTest()
        {
           Assert.AreEqual(new PhuongTrinh().gpt(0, 0, 0, 0, 0, 0),"VO NGHIEM");
           Assert.AreEqual(new PhuongTrinh().gpt(1, -2, 1, 3, -6, 3), "VO SO NGHIEM");
           Assert.AreEqual(new PhuongTrinh().gpt(1, 2, 3, 4, 5, 6), "Nghiem 1: -1 | Nghiem 2: 2");
        }
    }
}