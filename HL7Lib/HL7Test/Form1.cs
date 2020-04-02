using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HL7Lib;

namespace HL7Test
{
    public partial class Form1 : Form
    {

        public enum enumMessages { ACK, A01, A02 };
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_toString_Click(object sender, EventArgs e)
        {
            messageFactory factory = new messageFactory();
            ACK msg = factory.Create(null, enumMessages.ACK, "ACK") as ACK;
            msg.msh.FieldSeparator.Value = "|";
            msg.msh.EncodingCharacters.Value = "^~\\&";
            msg.msh.DateTimeOfMessage.Value = DateTime.Now.ToString("yyyyMMddhhmmss.fff");
            msg.msh.MessageType.MessageType.Value = "ACK";
            msg.msh.MessageType.TriggerEvent.Value = "A01";
            msg.msh.MessageType.MessageStructure.Value = "ACK_A01";
            msg.msh.MessageControlID.Value = "A00002";
            msg.msh.ProcessingID.ProcessingID.Value = "P";
            msg.msh.VersionID.VersionID.Value = "2.4";
            msg.msa.AcknowledgmentCode.Value = "AA";
            msg.msa.MessageControlID.Value = "MSG00001";
            msg.msa.TextMessage.Value = "Success";

            txtMessage.Text = msg.ToString();
        }

        private void button_Parse_Click(object sender, EventArgs e)
        {
            messageFactory factory = new messageFactory();

           ACK msg = factory.Create(null, enumMessages.ACK, "ACK") as ACK;

            msg.Parse("MSH|^~\\&|HIS|00001|LIS|1234|2004112754000||ACK^A01^ACK_A01|0200002|P|2.4\rMSA|AE|0200001|type error|||102\r");
            txtMessage.Text = msg.ToString(); 
            txtMsgControllID.Text = msg.msa.MessageControlID.Value;
            txtTextMsg.Text = msg.msa.TextMessage.Value;

        }
    }
}
