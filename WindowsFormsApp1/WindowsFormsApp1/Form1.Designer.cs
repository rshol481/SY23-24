namespace WindowsFormsApp1
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
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.TypetextBox = new System.Windows.Forms.TextBox();
            this.LeveltextBox = new System.Windows.Forms.TextBox();
            this.AttckTypetextBox = new System.Windows.Forms.TextBox();
            this.HptextBox = new System.Windows.Forms.TextBox();
            this.ExPtextBox = new System.Windows.Forms.TextBox();
            this.GenerationtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LegcheckBox = new System.Windows.Forms.CheckBox();
            this.ShinycheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.DebugtextBox = new System.Windows.Forms.TextBox();
            this.openbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(58, 8);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(100, 22);
            this.NametextBox.TabIndex = 0;
            // 
            // TypetextBox
            // 
            this.TypetextBox.Location = new System.Drawing.Point(58, 36);
            this.TypetextBox.Name = "TypetextBox";
            this.TypetextBox.Size = new System.Drawing.Size(100, 22);
            this.TypetextBox.TabIndex = 1;
            // 
            // LeveltextBox
            // 
            this.LeveltextBox.Location = new System.Drawing.Point(58, 64);
            this.LeveltextBox.Name = "LeveltextBox";
            this.LeveltextBox.Size = new System.Drawing.Size(100, 22);
            this.LeveltextBox.TabIndex = 2;
            // 
            // AttckTypetextBox
            // 
            this.AttckTypetextBox.Location = new System.Drawing.Point(58, 92);
            this.AttckTypetextBox.Name = "AttckTypetextBox";
            this.AttckTypetextBox.Size = new System.Drawing.Size(100, 22);
            this.AttckTypetextBox.TabIndex = 3;
            // 
            // HptextBox
            // 
            this.HptextBox.Location = new System.Drawing.Point(58, 120);
            this.HptextBox.Name = "HptextBox";
            this.HptextBox.Size = new System.Drawing.Size(100, 22);
            this.HptextBox.TabIndex = 4;
            this.HptextBox.TextChanged += new System.EventHandler(this.HptextBox_TextChanged);
            // 
            // ExPtextBox
            // 
            this.ExPtextBox.Location = new System.Drawing.Point(58, 148);
            this.ExPtextBox.Name = "ExPtextBox";
            this.ExPtextBox.Size = new System.Drawing.Size(100, 22);
            this.ExPtextBox.TabIndex = 5;
            // 
            // GenerationtextBox
            // 
            this.GenerationtextBox.Location = new System.Drawing.Point(58, 232);
            this.GenerationtextBox.Name = "GenerationtextBox";
            this.GenerationtextBox.Size = new System.Drawing.Size(100, 22);
            this.GenerationtextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Attack";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "HP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Exp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Leg";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Shiny";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Gen";
            // 
            // LegcheckBox
            // 
            this.LegcheckBox.AutoSize = true;
            this.LegcheckBox.Location = new System.Drawing.Point(58, 178);
            this.LegcheckBox.Name = "LegcheckBox";
            this.LegcheckBox.Size = new System.Drawing.Size(94, 20);
            this.LegcheckBox.TabIndex = 18;
            this.LegcheckBox.Text = "Legendary";
            this.LegcheckBox.UseVisualStyleBackColor = true;
            // 
            // ShinycheckBox
            // 
            this.ShinycheckBox.AutoSize = true;
            this.ShinycheckBox.Location = new System.Drawing.Point(58, 204);
            this.ShinycheckBox.Name = "ShinycheckBox";
            this.ShinycheckBox.Size = new System.Drawing.Size(62, 20);
            this.ShinycheckBox.TabIndex = 19;
            this.ShinycheckBox.Text = "Shiny";
            this.ShinycheckBox.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(189, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 246);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(93, 280);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 21;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // DebugtextBox
            // 
            this.DebugtextBox.Location = new System.Drawing.Point(189, 264);
            this.DebugtextBox.Multiline = true;
            this.DebugtextBox.Name = "DebugtextBox";
            this.DebugtextBox.Size = new System.Drawing.Size(317, 56);
            this.DebugtextBox.TabIndex = 22;
            // 
            // openbutton
            // 
            this.openbutton.Location = new System.Drawing.Point(12, 280);
            this.openbutton.Name = "openbutton";
            this.openbutton.Size = new System.Drawing.Size(75, 23);
            this.openbutton.TabIndex = 23;
            this.openbutton.Text = "open";
            this.openbutton.UseVisualStyleBackColor = true;
            this.openbutton.Click += new System.EventHandler(this.openbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 332);
            this.Controls.Add(this.openbutton);
            this.Controls.Add(this.DebugtextBox);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ShinycheckBox);
            this.Controls.Add(this.LegcheckBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenerationtextBox);
            this.Controls.Add(this.ExPtextBox);
            this.Controls.Add(this.HptextBox);
            this.Controls.Add(this.AttckTypetextBox);
            this.Controls.Add(this.LeveltextBox);
            this.Controls.Add(this.TypetextBox);
            this.Controls.Add(this.NametextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox TypetextBox;
        private System.Windows.Forms.TextBox LeveltextBox;
        private System.Windows.Forms.TextBox AttckTypetextBox;
        private System.Windows.Forms.TextBox HptextBox;
        private System.Windows.Forms.TextBox ExPtextBox;
        private System.Windows.Forms.TextBox GenerationtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox LegcheckBox;
        private System.Windows.Forms.CheckBox ShinycheckBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.TextBox DebugtextBox;
        private System.Windows.Forms.Button openbutton;
    }
}

