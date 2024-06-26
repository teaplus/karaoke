namespace QLKaraoke
{
    partial class ChangeConnString
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeConnString));
            this.textBox_ChangeConnS_SVName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ChangeConnS_DBName = new System.Windows.Forms.TextBox();
            this.button_ChangeConnString = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_ChangeConnS_SVName
            // 
            this.textBox_ChangeConnS_SVName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ChangeConnS_SVName.Location = new System.Drawing.Point(341, 156);
            this.textBox_ChangeConnS_SVName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_ChangeConnS_SVName.Name = "textBox_ChangeConnS_SVName";
            this.textBox_ChangeConnS_SVName.Size = new System.Drawing.Size(337, 38);
            this.textBox_ChangeConnS_SVName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhap ServerName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 238);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhap DB Name";
            // 
            // textBox_ChangeConnS_DBName
            // 
            this.textBox_ChangeConnS_DBName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ChangeConnS_DBName.Location = new System.Drawing.Point(341, 238);
            this.textBox_ChangeConnS_DBName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_ChangeConnS_DBName.Name = "textBox_ChangeConnS_DBName";
            this.textBox_ChangeConnS_DBName.Size = new System.Drawing.Size(337, 38);
            this.textBox_ChangeConnS_DBName.TabIndex = 0;
            // 
            // button_ChangeConnString
            // 
            this.button_ChangeConnString.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button_ChangeConnString.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ChangeConnString.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_ChangeConnString.Location = new System.Drawing.Point(287, 327);
            this.button_ChangeConnString.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_ChangeConnString.Name = "button_ChangeConnString";
            this.button_ChangeConnString.Size = new System.Drawing.Size(199, 53);
            this.button_ChangeConnString.TabIndex = 2;
            this.button_ChangeConnString.Text = "ok";
            this.button_ChangeConnString.UseVisualStyleBackColor = false;
            this.button_ChangeConnString.Click += new System.EventHandler(this.Button_ChangeConnString_Click);
            // 
            // ChangeConnString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(759, 473);
            this.Controls.Add(this.button_ChangeConnString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ChangeConnS_DBName);
            this.Controls.Add(this.textBox_ChangeConnS_SVName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChangeConnString";
            this.Text = "ChangeConnString";
            this.Load += new System.EventHandler(this.ChangeConnString_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ChangeConnS_SVName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ChangeConnS_DBName;
        private System.Windows.Forms.Button button_ChangeConnString;
    }
}