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
    public class MSHTests
    {
        [TestMethod()]
        public void MSHTest()
        {
            compositeMessage message = new compositeMessage(null,"ACK");
            MSH msh = new MSH(message,"MSH");
            msh.Value = "MSH|^~\\&|HIS|00001|LIS|1234|2004112754000||ACK^A01^ACK_A01|0200002|P|2.4\rMSA|AE|0200001|type error|||102\r";
            Assert.AreEqual("2004112754000", msh.DateTimeOfMessage.Time.Value);
        }

        [TestMethod()]
        public void ParseTest()
        {
            compositeMessage message = new compositeMessage(null, "ACK");
            MSH msh = new MSH(message, "MSH");
            msh.Parse("MSH|^~\\&|HIS|00001|LIS|1234|2004112754000||" +
                "ACK^A01^ACK_A01|0200002|P|2.4\rMSA|AE|" +
                "0200001|type error|||102");
            /*
            Assert.AreEqual("|", msh.FieldSeparator.Value);
            Assert.AreEqual("LIS", msh.ReceivingApplication.NamespaceID.Value);
            Assert.AreEqual("HIS", msh.SendingApplication.NamespaceID.Value);
            Assert.AreEqual(null, msh.Security.Value);
            Assert.AreEqual("ACK", msh.MessageType.MessageType.Value);
            Assert.AreEqual("A01", msh.MessageType.TriggerEvent.Value);
            Assert.AreEqual("P", msh.ProcessingID.ProcessingID.Value);
            Assert.AreEqual("0200001", msh.ContinuationPointer.Value);
            */
            // Assert.AreEqual("102", msh.CharacterSet.Value);
            Assert.AreEqual("MSH|^~\\&|HIS|00001|LIS|1234|2004112754000||" +
                "ACK^A01^ACK_A01|0200002|P|2.4\rMSA|AE|" +
                "0200001|type error|||102", msh.Value);
        }    

        [TestMethod()]
        public void ToStringTest()
        {
            compositeMessage message = new compositeMessage(null, "ACK");
            MSH msh = new MSH(message, "MSH");
            msh.FieldSeparator.Value = "|";
            msh.ReceivingApplication.NamespaceID.Value = "LIS";
           Assert.AreEqual("MSH||||LIS", msh.ToString());
        }
    }
}