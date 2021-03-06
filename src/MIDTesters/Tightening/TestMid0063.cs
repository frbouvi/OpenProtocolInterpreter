﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenProtocolInterpreter.Tightening;

namespace MIDTesters.Tightening
{
    [TestClass]
    public class TestMid0063 : MidTester
    {
        [TestMethod]
        public void Mid0063AllRevisions()
        {
            string package = "00200063002         ";
            var mid = _midInterpreter.Parse(package);

            Assert.AreEqual(typeof(Mid0063), mid.GetType());
            Assert.AreEqual(package, mid.Pack());
        }
    }
}
