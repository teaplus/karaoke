namespace QLKaraoke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox_Login_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox_Login_PassW = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button_Login_Exit = new System.Windows.Forms.Button();
            this.button_Login_DN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Login_ChangeConnString = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox_Login_Name);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(208, 132);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(511, 69);
            this.panel4.TabIndex = 6;
            // 
            // textBox_Login_Name
            // 
            this.textBox_Login_Name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Login_Name.Location = new System.Drawing.Point(149, 21);
            this.textBox_Login_Name.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Login_Name.Name = "textBox_Login_Name";
            this.textBox_Login_Name.Size = new System.Drawing.Size(356, 35);
            this.textBox_Login_Name.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(15, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "UserName";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBox_Login_PassW);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(208, 242);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(511, 65);
            this.panel5.TabIndex = 7;
            // 
            // textBox_Login_PassW
            // 
            this.textBox_Login_PassW.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Login_PassW.ForeColor = System.Drawing.Color.Black;
            this.textBox_Login_PassW.Location = new System.Drawing.Point(149, 21);
            this.textBox_Login_PassW.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Login_PassW.Name = "textBox_Login_PassW";
            this.textBox_Login_PassW.PasswordChar = '*';
            this.textBox_Login_PassW.Size = new System.Drawing.Size(356, 35);
            this.textBox_Login_PassW.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Fuchsia;
            this.label3.Location = new System.Drawing.Point(16, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "PassWord";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button_Login_Exit);
            this.panel6.Controls.Add(this.button_Login_DN);
            this.panel6.Location = new System.Drawing.Point(208, 354);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(511, 74);
            this.panel6.TabIndex = 8;
            // 
            // button_Login_Exit
            // 
            this.button_Login_Exit.BackColor = System.Drawing.SystemColors.Control;
            this.button_Login_Exit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login_Exit.Location = new System.Drawing.Point(328, 15);
            this.button_Login_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.button_Login_Exit.Name = "button_Login_Exit";
            this.button_Login_Exit.Size = new System.Drawing.Size(125, 43);
            this.button_Login_Exit.TabIndex = 3;
            this.button_Login_Exit.Text = "Exit";
            this.button_Login_Exit.UseVisualStyleBackColor = false;
            this.button_Login_Exit.Click += new System.EventHandler(this.Button_Login_Exit_Click);
            // 
            // button_Login_DN
            // 
            this.button_Login_DN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Login_DN.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login_DN.Location = new System.Drawing.Point(48, 15);
            this.button_Login_DN.Margin = new System.Windows.Forms.Padding(4);
            this.button_Login_DN.Name = "button_Login_DN";
            this.button_Login_DN.Size = new System.Drawing.Size(128, 43);
            this.button_Login_DN.TabIndex = 2;
            this.button_Login_DN.Text = "Đăng Nhập";
            this.button_Login_DN.UseVisualStyleBackColor = false;
            this.button_Login_DN.Click += new System.EventHandler(this.Button_Login_DN_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button_Login_ChangeConnString);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(57, 54);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 460);
            this.panel1.TabIndex = 4;
            // 
            // button_Login_ChangeConnString
            // 
            this.button_Login_ChangeConnString.Location = new System.Drawing.Point(763, 425);
            this.button_Login_ChangeConnString.Margin = new System.Windows.Forms.Padding(4);
            this.button_Login_ChangeConnString.Name = "button_Login_ChangeConnString";
            this.button_Login_ChangeConnString.Size = new System.Drawing.Size(185, 28);
            this.button_Login_ChangeConnString.TabIndex = 9;
            this.button_Login_ChangeConnString.Text = "ChangeConnString";
            this.button_Login_ChangeConnString.UseVisualStyleBackColor = true;
            this.button_Login_ChangeConnString.Click += new System.EventHandler(this.Button_Login_ChangeConnString_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(208, 13);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(511, 96);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(341, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Nhập";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::QLKaraoke.Properties.Resources.logoLogin2;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox_Login_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox_Login_PassW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button_Login_Exit;
        private System.Windows.Forms.Button button_Login_DN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Login_ChangeConnString;
    }
}

