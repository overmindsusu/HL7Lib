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
    public class primitiveTypeTests
    {

        [TestMethod()]
        public void primitiveTypeTest()
        {

            primitiveType obj = new primitiveType("ID");
            Assert.AreEqual("ID", obj.Name);
            obj.Value = "ABC123456";
            Assert.AreEqual("ABC123456", obj.Value);

          


        }

        [TestMethod()]
        public void ToStringTest()
        {
            primitiveType obj = new primitiveType("TS");
            obj.Value = DateTime.Now.ToString("yyyyMMddhhmmss.fff");
            DateTime dt = DateTime.Now;
            obj.ToString();
            Assert.AreEqual(dt.ToString("yyyyMMddhhmmss.fff"), obj.Value);

        }

        [TestMethod()]
        public void ParseTest()
        {
            primitiveType obj = new primitiveType("TS");
            string ts = DateTime.Now.ToString("yyyyMMddhhmmss.fff");
            obj.Parse(ts);
            Assert.AreEqual(ts, obj.Value);

            DateTime dt = DateTime.Now;
            obj.Parse(dt.ToString("yyyyMMddhhmm"));
            Assert.AreEqual(dt.ToString("yyyyMMddhhmm"), obj.Value);

        }
    }
}