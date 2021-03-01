namespace SQL_Project
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TName = new System.Windows.Forms.TextBox();
            this.TLast = new System.Windows.Forms.TextBox();
            this.TPhone = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(49, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(49, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(49, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone Number :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(144, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Add a Teacher";
            // 
            // TName
            // 
            this.TName.Location = new System.Drawing.Point(167, 207);
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(100, 20);
            this.TName.TabIndex = 7;
            this.TName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TName_KeyPress);
            // 
            // TLast
            // 
            this.TLast.Location = new System.Drawing.Point(167, 297);
            this.TLast.Name = "TLast";
            this.TLast.Size = new System.Drawing.Size(100, 20);
            this.TLast.TabIndex = 9;
            this.TLast.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.TLast.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TLast_KeyPress);
            // 
            // TPhone
            // 
            this.TPhone.Location = new System.Drawing.Point(244, 377);
            this.TPhone.Name = "TPhone";
            this.TPhone.Size = new System.Drawing.Size(100, 20);
            this.TPhone.TabIndex = 13;
            this.TPhone.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            this.TPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TPhone_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 41);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add Teacher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 540);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 36);
            this.button2.TabIndex = 18;
            this.button2.Text = "<- Class";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 498);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 36);
            this.button3.TabIndex = 19;
            this.button3.Text = "<- Student";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "02",
            "03",
            "04",
            "050",
            "051",
            "052",
            "053",
            "054",
            "055",
            "058",
            "071",
            "072",
            "073",
            "074",
            "076",
            "078",
            "079",
            "08",
            "09"});
            this.comboBox1.Location = new System.Drawing.Point(178, 376);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(43, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.TextUpdate += new System.EventHandler(this.comboBox1_TextUpdate);
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(227, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(402, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TPhone);
            this.Controls.Add(this.TLast);
            this.Controls.Add(this.TName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TName;
        private System.Windows.Forms.TextBox TLast;
        private System.Windows.Forms.TextBox TPhone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}

