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
    public class A04Tests
    {
        [TestMethod()]
        public void A04Test()
        {
            A04 a04 = new A04(null,"A04");
            string x = "MSH|^~\\&|REGADT|MCM|IFENG||201901101501||ADT^A04|00001|P|2.4\r" +
                "EVN|A04|201901101500|201901101400|01||201901101410\r"+
                "PID|||191919^^^GENHOS^MR~371-66-9256^^^USSSA^SS|253763|" +
                "MASSIE^ JAMES^A||19560129|M|||171 ZOBERLEIN^^ISHPEMING^MI^49849^“”^||" +
                "(900)485-5344|(900)485-5344||S|C| 10199925^^^GENHOS^AN|371-669256\r"+
                "PV1||O|O/R||||0148^ADDISON,JAMES|0148^ADDISON,JAMES|0148^ADDISON,JAMES|AMB||||||" +
                "|0148^ADDISON,JAMES|S|1400|A|||||||||||||||||||GENHOS||||| 201901101410";
            a04.Parse(x);
            Assert.AreEqual(x,a04.Value);
            
        }
    }
}