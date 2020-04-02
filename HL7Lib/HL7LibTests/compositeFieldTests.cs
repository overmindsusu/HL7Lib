using Microsoft.VisualStudio.TestTools.UnitTesting;
using HL7Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7Lib.Tests
{
    [TestClass()]
    public class compositeFieldTests
    {
        [TestMethod()]
        public void compositeFieldTest()
        {
            compositeMessage ack = new compositeMessage(null, "ACK");
            EVN evn = new EVN(ack, "EVN");
            evn.Value = "EVN|A01|199806051529";
            Assert.AreEqual("199806051529", evn.Value);
        }

        [TestMethod()]
        public void ParseTest()
        {
            compositeMessage ack = new compositeMessage(null, "ACK");
            EVN evn = new EVN(ack, "EVN");
            evn.Parse("EVN|A01|199806051529");
            Assert.AreEqual("EVN|A01|199806051529", evn.Value);
        }
    }
}