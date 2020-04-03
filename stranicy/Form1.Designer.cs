namespace stranicy
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.StatusConnTB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.DisconnectBt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ConnectBt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SlotTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CpuTypeCB = new System.Windows.Forms.ComboBox();
            this.RackTB = new System.Windows.Forms.TextBox();
            this.DbAddressTB = new System.Windows.Forms.TextBox();
            this.IPaddressTB = new System.Windows.Forms.TextBox();
            this.WriteDataTB = new System.Windows.Forms.TextBox();
            this.ReadDataTB = new System.Windows.Forms.TextBox();
            this.WriteBt = new System.Windows.Forms.Button();
            this.ReadDataBt = new System.Windows.Forms.Button();
            this.PreviousPage = new System.Windows.Forms.Button();
            this.NextPage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.StatusConnTB);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.DisconnectBt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.ConnectBt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.SlotTB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.CpuTypeCB);
            this.panel1.Controls.Add(this.RackTB);
            this.panel1.Controls.Add(this.DbAddressTB);
            this.panel1.Controls.Add(this.IPaddressTB);
            this.panel1.Controls.Add(this.WriteDataTB);
            this.panel1.Controls.Add(this.ReadDataTB);
            this.panel1.Controls.Add(this.WriteBt);
            this.panel1.Controls.Add(this.ReadDataBt);
            this.panel1.Location = new System.Drawing.Point(15, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 384);
            this.panel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "IP address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(47, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "Slot";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Rack";
            // 
            // StatusConnTB
            // 
            this.StatusConnTB.Location = new System.Drawing.Point(114, 236);
            this.StatusConnTB.Name = "StatusConnTB";
            this.StatusConnTB.Size = new System.Drawing.Size(100, 20);
            this.StatusConnTB.TabIndex = 45;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(47, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "CPU";
            // 
            // DisconnectBt
            // 
            this.DisconnectBt.Location = new System.Drawing.Point(220, 234);
            this.DisconnectBt.Name = "DisconnectBt";
            this.DisconnectBt.Size = new System.Drawing.Size(75, 23);
            this.DisconnectBt.TabIndex = 39;
            this.DisconnectBt.Text = "Disconnect";
            this.DisconnectBt.UseVisualStyleBackColor = true;
            this.DisconnectBt.Click += new System.EventHandler(this.DisconnectBt_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Write data";
            // 
            // ConnectBt
            // 
            this.ConnectBt.Location = new System.Drawing.Point(26, 233);
            this.ConnectBt.Name = "ConnectBt";
            this.ConnectBt.Size = new System.Drawing.Size(75, 23);
            this.ConnectBt.TabIndex = 38;
            this.ConnectBt.Text = "Connect";
            this.ConnectBt.UseVisualStyleBackColor = true;
            this.ConnectBt.Click += new System.EventHandler(this.ConnectBt_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Read data";
            // 
            // SlotTB
            // 
            this.SlotTB.Location = new System.Drawing.Point(84, 159);
            this.SlotTB.Name = "SlotTB";
            this.SlotTB.Size = new System.Drawing.Size(100, 20);
            this.SlotTB.TabIndex = 44;
            this.SlotTB.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "DB";
            // 
            // CpuTypeCB
            // 
            this.CpuTypeCB.FormattingEnabled = true;
            this.CpuTypeCB.Location = new System.Drawing.Point(82, 51);
            this.CpuTypeCB.Name = "CpuTypeCB";
            this.CpuTypeCB.Size = new System.Drawing.Size(121, 21);
            this.CpuTypeCB.TabIndex = 40;
            // 
            // RackTB
            // 
            this.RackTB.Location = new System.Drawing.Point(84, 130);
            this.RackTB.Name = "RackTB";
            this.RackTB.Size = new System.Drawing.Size(100, 20);
            this.RackTB.TabIndex = 43;
            this.RackTB.Text = "0";
            // 
            // DbAddressTB
            // 
            this.DbAddressTB.Location = new System.Drawing.Point(356, 59);
            this.DbAddressTB.Name = "DbAddressTB";
            this.DbAddressTB.Size = new System.Drawing.Size(100, 20);
            this.DbAddressTB.TabIndex = 31;
            // 
            // IPaddressTB
            // 
            this.IPaddressTB.Location = new System.Drawing.Point(84, 104);
            this.IPaddressTB.Name = "IPaddressTB";
            this.IPaddressTB.Size = new System.Drawing.Size(100, 20);
            this.IPaddressTB.TabIndex = 42;
            this.IPaddressTB.Text = "192.168.0.228";
            // 
            // WriteDataTB
            // 
            this.WriteDataTB.Location = new System.Drawing.Point(356, 148);
            this.WriteDataTB.Name = "WriteDataTB";
            this.WriteDataTB.Size = new System.Drawing.Size(100, 20);
            this.WriteDataTB.TabIndex = 29;
            // 
            // ReadDataTB
            // 
            this.ReadDataTB.Location = new System.Drawing.Point(356, 98);
            this.ReadDataTB.Name = "ReadDataTB";
            this.ReadDataTB.Size = new System.Drawing.Size(100, 20);
            this.ReadDataTB.TabIndex = 28;
            // 
            // WriteBt
            // 
            this.WriteBt.Location = new System.Drawing.Point(482, 146);
            this.WriteBt.Name = "WriteBt";
            this.WriteBt.Size = new System.Drawing.Size(75, 23);
            this.WriteBt.TabIndex = 22;
            this.WriteBt.Text = "Write";
            this.WriteBt.UseVisualStyleBackColor = true;
            this.WriteBt.Click += new System.EventHandler(this.WriteBt_Click);
            // 
            // ReadDataBt
            // 
            this.ReadDataBt.Location = new System.Drawing.Point(482, 99);
            this.ReadDataBt.Name = "ReadDataBt";
            this.ReadDataBt.Size = new System.Drawing.Size(75, 23);
            this.ReadDataBt.TabIndex = 21;
            this.ReadDataBt.Text = "Read";
            this.ReadDataBt.UseVisualStyleBackColor = true;
            this.ReadDataBt.Click += new System.EventHandler(this.ReadDataBt_Click);
            // 
            // PreviousPage
            // 
            this.PreviousPage.Location = new System.Drawing.Point(697, 10);
            this.PreviousPage.Name = "PreviousPage";
            this.PreviousPage.Size = new System.Drawing.Size(82, 23);
            this.PreviousPage.TabIndex = 1;
            this.PreviousPage.Text = "PreviousPage";
            this.PreviousPage.UseVisualStyleBackColor = true;
            this.PreviousPage.Click += new System.EventHandler(this.PreviousPage_Click);
            // 
            // NextPage
            // 
            this.NextPage.Location = new System.Drawing.Point(704, 46);
            this.NextPage.Name = "NextPage";
            this.NextPage.Size = new System.Drawing.Size(75, 23);
            this.NextPage.TabIndex = 1;
            this.NextPage.Text = "NextPage";
            this.NextPage.UseVisualStyleBackColor = true;
            this.NextPage.Click += new System.EventHandler(this.NextPage_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(15, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 384);
            this.panel2.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "IP address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Slot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Rack";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(138, 263);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 43;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(126, 166);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 42;
            this.textBox3.Text = "2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(126, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 41;
            this.textBox2.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 40;
            this.textBox1.Text = "192.168.0.162";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "CPU";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(105, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "TCP/IP ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 37;
            this.button2.Text = "Disconnect";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 474);
            this.Controls.Add(this.NextPage);
            this.Controls.Add(this.PreviousPage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PreviousPage;
        private System.Windows.Forms.Button NextPage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DbAddressTB;
        private System.Windows.Forms.TextBox WriteDataTB;
        private System.Windows.Forms.TextBox ReadDataTB;
        private System.Windows.Forms.Button WriteBt;
        private System.Windows.Forms.Button ReadDataBt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox StatusConnTB;
        private System.Windows.Forms.TextBox SlotTB;
        private System.Windows.Forms.TextBox RackTB;
        private System.Windows.Forms.TextBox IPaddressTB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox CpuTypeCB;
        private System.Windows.Forms.Button DisconnectBt;
        private System.Windows.Forms.Button ConnectBt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

