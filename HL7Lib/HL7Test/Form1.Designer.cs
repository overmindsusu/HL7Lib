namespace HL7Test
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.button_toString = new System.Windows.Forms.Button();
            this.button_Parse = new System.Windows.Forms.Button();
            this.txtMsgControllID = new System.Windows.Forms.TextBox();
            this.txtTextMsg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 51);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(729, 99);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.Text = "MSH|^~\\\\&|HIS|00001|LIS|1234|2004112754000||ACK^A01^ACK_A01|0200002|P|2.4\\rMSA|AE" +
    "|0200001|type error|||102";
            this.txtMessage.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button_toString
            // 
            this.button_toString.Location = new System.Drawing.Point(12, 12);
            this.button_toString.Name = "button_toString";
            this.button_toString.Size = new System.Drawing.Size(75, 23);
            this.button_toString.TabIndex = 1;
            this.button_toString.Text = "tostring";
            this.button_toString.UseVisualStyleBackColor = true;
            this.button_toString.Click += new System.EventHandler(this.button_toString_Click);
            // 
            // button_Parse
            // 
            this.button_Parse.Location = new System.Drawing.Point(12, 174);
            this.button_Parse.Name = "button_Parse";
            this.button_Parse.Size = new System.Drawing.Size(75, 23);
            this.button_Parse.TabIndex = 2;
            this.button_Parse.Text = "parse";
            this.button_Parse.UseVisualStyleBackColor = true;
            this.button_Parse.Click += new System.EventHandler(this.button_Parse_Click);
            // 
            // txtMsgControllID
            // 
            this.txtMsgControllID.Location = new System.Drawing.Point(142, 231);
            this.txtMsgControllID.Name = "txtMsgControllID";
            this.txtMsgControllID.Size = new System.Drawing.Size(280, 21);
            this.txtMsgControllID.TabIndex = 3;
            // 
            // txtTextMsg
            // 
            this.txtTextMsg.Location = new System.Drawing.Point(142, 276);
            this.txtTextMsg.Name = "txtTextMsg";
            this.txtTextMsg.Size = new System.Drawing.Size(280, 21);
            this.txtTextMsg.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "txtMsgControllID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "txtTextMsg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTextMsg);
            this.Controls.Add(this.txtMsgControllID);
            this.Controls.Add(this.button_Parse);
            this.Controls.Add(this.button_toString);
            this.Controls.Add(this.txtMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.Button button_toString;
        private System.Windows.Forms.Button button_Parse;
        private System.Windows.Forms.TextBox txtMsgControllID;
        private System.Windows.Forms.TextBox txtTextMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

