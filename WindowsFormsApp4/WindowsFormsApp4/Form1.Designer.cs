namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DO_ON = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtResult = new System.Windows.Forms.TextBox();
            this.ReadDO = new System.Windows.Forms.Button();
            this.ReadReg = new System.Windows.Forms.Button();
            this.ReadDI = new System.Windows.Forms.Button();
            this.ReadJPOS = new System.Windows.Forms.Button();
            this.ReadCPOS = new System.Windows.Forms.Button();
            this.ReadActualPos = new System.Windows.Forms.Button();
            this.WriteCartPos = new System.Windows.Forms.Button();
            this.RobotIP = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.DOval = new System.Windows.Forms.TextBox();
            this.DO_OFF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DO_ON
            // 
            this.DO_ON.Location = new System.Drawing.Point(274, 190);
            this.DO_ON.Name = "DO_ON";
            this.DO_ON.Size = new System.Drawing.Size(65, 23);
            this.DO_ON.TabIndex = 0;
            this.DO_ON.Text = "DO ON";
            this.DO_ON.UseVisualStyleBackColor = true;
            this.DO_ON.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connection Status";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Connect To Robot";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(127, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Disconnect";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "RegWrite Status";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 141);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Register NO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Value:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(89, 193);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Comment:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 219);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Write Reg";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "RegComment Status";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(195, 344);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(194, 370);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(194, 396);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(358, 344);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 16;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(358, 370);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 17;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(358, 396);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "X / J1:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Y / J2:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(149, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Z / J3:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(309, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "W / J4:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(309, 377);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "P / J5:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(309, 399);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "R / J6:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 373);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 23);
            this.button5.TabIndex = 25;
            this.button5.Text = "Write Joint POS";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(195, 318);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 26;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(145, 321);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "PR NO:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(298, 291);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Utool NO:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(125, 292);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Uframe NO:";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(358, 288);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 29;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(195, 289);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(254, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "WriteJPOS Status";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(331, 318);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "E1:";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(358, 318);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 33;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtResult
            // 
            this.txtResult.AcceptsReturn = true;
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.BackColor = System.Drawing.SystemColors.Window;
            this.txtResult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResult.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtResult.Location = new System.Drawing.Point(503, 48);
            this.txtResult.MaxLength = 0;
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(270, 368);
            this.txtResult.TabIndex = 37;
            this.txtResult.TabStop = false;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // ReadDO
            // 
            this.ReadDO.Location = new System.Drawing.Point(503, 19);
            this.ReadDO.Name = "ReadDO";
            this.ReadDO.Size = new System.Drawing.Size(75, 23);
            this.ReadDO.TabIndex = 38;
            this.ReadDO.Text = "READ DO";
            this.ReadDO.UseVisualStyleBackColor = true;
            this.ReadDO.Click += new System.EventHandler(this.ReadDO_Click);
            // 
            // ReadReg
            // 
            this.ReadReg.Location = new System.Drawing.Point(598, 17);
            this.ReadReg.Name = "ReadReg";
            this.ReadReg.Size = new System.Drawing.Size(75, 23);
            this.ReadReg.TabIndex = 40;
            this.ReadReg.Text = "READ REG";
            this.ReadReg.UseVisualStyleBackColor = true;
            this.ReadReg.Click += new System.EventHandler(this.ReadReg_Click);
            // 
            // ReadDI
            // 
            this.ReadDI.Location = new System.Drawing.Point(698, 19);
            this.ReadDI.Name = "ReadDI";
            this.ReadDI.Size = new System.Drawing.Size(75, 23);
            this.ReadDI.TabIndex = 41;
            this.ReadDI.Text = "READ DI";
            this.ReadDI.UseVisualStyleBackColor = true;
            this.ReadDI.Click += new System.EventHandler(this.ReadDI_Click);
            // 
            // ReadJPOS
            // 
            this.ReadJPOS.Location = new System.Drawing.Point(13, 315);
            this.ReadJPOS.Name = "ReadJPOS";
            this.ReadJPOS.Size = new System.Drawing.Size(108, 23);
            this.ReadJPOS.TabIndex = 42;
            this.ReadJPOS.Text = "Read Joint POS";
            this.ReadJPOS.UseVisualStyleBackColor = true;
            this.ReadJPOS.Click += new System.EventHandler(this.ReadJPOS_Click);
            // 
            // ReadCPOS
            // 
            this.ReadCPOS.Location = new System.Drawing.Point(13, 344);
            this.ReadCPOS.Name = "ReadCPOS";
            this.ReadCPOS.Size = new System.Drawing.Size(108, 23);
            this.ReadCPOS.TabIndex = 43;
            this.ReadCPOS.Text = "Read Cart POS";
            this.ReadCPOS.UseVisualStyleBackColor = true;
            this.ReadCPOS.Click += new System.EventHandler(this.ReadCPOS_Click);
            // 
            // ReadActualPos
            // 
            this.ReadActualPos.Location = new System.Drawing.Point(13, 286);
            this.ReadActualPos.Name = "ReadActualPos";
            this.ReadActualPos.Size = new System.Drawing.Size(108, 23);
            this.ReadActualPos.TabIndex = 44;
            this.ReadActualPos.Text = "Read Actual POS";
            this.ReadActualPos.UseVisualStyleBackColor = true;
            this.ReadActualPos.Click += new System.EventHandler(this.ReadActualPos_Click);
            // 
            // WriteCartPos
            // 
            this.WriteCartPos.Location = new System.Drawing.Point(13, 402);
            this.WriteCartPos.Name = "WriteCartPos";
            this.WriteCartPos.Size = new System.Drawing.Size(108, 23);
            this.WriteCartPos.TabIndex = 45;
            this.WriteCartPos.Text = "Write Cart POS";
            this.WriteCartPos.UseVisualStyleBackColor = true;
            this.WriteCartPos.Click += new System.EventHandler(this.WriteCartPos_Click);
            // 
            // RobotIP
            // 
            this.RobotIP.Location = new System.Drawing.Point(68, 11);
            this.RobotIP.Name = "RobotIP";
            this.RobotIP.Size = new System.Drawing.Size(105, 20);
            this.RobotIP.TabIndex = 46;
            this.RobotIP.TextChanged += new System.EventHandler(this.RobotIP_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 13);
            this.label18.TabIndex = 47;
            this.label18.Text = "Robot IP:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(271, 167);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 13);
            this.label19.TabIndex = 49;
            this.label19.Text = "DO NO:";
            // 
            // DOval
            // 
            this.DOval.Location = new System.Drawing.Point(322, 164);
            this.DOval.Name = "DOval";
            this.DOval.Size = new System.Drawing.Size(100, 20);
            this.DOval.TabIndex = 48;
            // 
            // DO_OFF
            // 
            this.DO_OFF.Location = new System.Drawing.Point(357, 190);
            this.DO_OFF.Name = "DO_OFF";
            this.DO_OFF.Size = new System.Drawing.Size(65, 23);
            this.DO_OFF.TabIndex = 50;
            this.DO_OFF.Text = "DO OFF";
            this.DO_OFF.UseVisualStyleBackColor = true;
            this.DO_OFF.Click += new System.EventHandler(this.DO_OFF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DO_OFF);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.DOval);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.RobotIP);
            this.Controls.Add(this.WriteCartPos);
            this.Controls.Add(this.ReadActualPos);
            this.Controls.Add(this.ReadCPOS);
            this.Controls.Add(this.ReadJPOS);
            this.Controls.Add(this.ReadDI);
            this.Controls.Add(this.ReadReg);
            this.Controls.Add(this.ReadDO);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DO_ON);
            this.Name = "Form1";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DO_ON;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button ReadDO;
        private System.Windows.Forms.Button ReadReg;
        private System.Windows.Forms.Button ReadDI;
        private System.Windows.Forms.Button ReadJPOS;
        private System.Windows.Forms.Button ReadCPOS;
        private System.Windows.Forms.Button ReadActualPos;
        private System.Windows.Forms.Button WriteCartPos;
        private System.Windows.Forms.TextBox RobotIP;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox DOval;
        private System.Windows.Forms.Button DO_OFF;
    }
}

