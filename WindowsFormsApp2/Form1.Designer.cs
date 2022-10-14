namespace WindowsFormsApp2
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
            this.label1 = new System.Windows.Forms.Label();
            this.slicesInput = new System.Windows.Forms.TextBox();
            this.popInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chepsInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totaloutput = new System.Windows.Forms.Label();
            this.tatalTaxAmoutoutput = new System.Windows.Forms.Label();
            this.subtotalAlloutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "pezza slices";
            // 
            // slicesInput
            // 
            this.slicesInput.Location = new System.Drawing.Point(106, 7);
            this.slicesInput.Name = "slicesInput";
            this.slicesInput.Size = new System.Drawing.Size(179, 20);
            this.slicesInput.TabIndex = 1;
            this.slicesInput.Text = "0";
            this.slicesInput.TextChanged += new System.EventHandler(this.slicesInput_TextChanged);
            // 
            // popInput
            // 
            this.popInput.Location = new System.Drawing.Point(106, 33);
            this.popInput.Name = "popInput";
            this.popInput.Size = new System.Drawing.Size(179, 20);
            this.popInput.TabIndex = 3;
            this.popInput.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "cane of pop";
            // 
            // chepsInput
            // 
            this.chepsInput.Location = new System.Drawing.Point(106, 59);
            this.chepsInput.Name = "chepsInput";
            this.chepsInput.Size = new System.Drawing.Size(179, 20);
            this.chepsInput.TabIndex = 5;
            this.chepsInput.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "bag of cheps";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "total";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "tax";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "sudtotal";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // totaloutput
            // 
            this.totaloutput.AutoSize = true;
            this.totaloutput.Location = new System.Drawing.Point(92, 232);
            this.totaloutput.Name = "totaloutput";
            this.totaloutput.Size = new System.Drawing.Size(13, 13);
            this.totaloutput.TabIndex = 12;
            this.totaloutput.Text = "0";
            // 
            // tatalTaxAmoutoutput
            // 
            this.tatalTaxAmoutoutput.AutoSize = true;
            this.tatalTaxAmoutoutput.Location = new System.Drawing.Point(92, 206);
            this.tatalTaxAmoutoutput.Name = "tatalTaxAmoutoutput";
            this.tatalTaxAmoutoutput.Size = new System.Drawing.Size(13, 13);
            this.tatalTaxAmoutoutput.TabIndex = 11;
            this.tatalTaxAmoutoutput.Text = "0";
            // 
            // subtotalAlloutput
            // 
            this.subtotalAlloutput.AutoSize = true;
            this.subtotalAlloutput.Location = new System.Drawing.Point(92, 180);
            this.subtotalAlloutput.Name = "subtotalAlloutput";
            this.subtotalAlloutput.Size = new System.Drawing.Size(13, 13);
            this.subtotalAlloutput.TabIndex = 10;
            this.subtotalAlloutput.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 293);
            this.Controls.Add(this.totaloutput);
            this.Controls.Add(this.tatalTaxAmoutoutput);
            this.Controls.Add(this.subtotalAlloutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chepsInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.popInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.slicesInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox slicesInput;
        private System.Windows.Forms.TextBox popInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox chepsInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totaloutput;
        private System.Windows.Forms.Label tatalTaxAmoutoutput;
        private System.Windows.Forms.Label subtotalAlloutput;
    }
}

