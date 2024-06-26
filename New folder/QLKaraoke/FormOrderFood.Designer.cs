namespace QLKaraoke
{
    partial class FormOrderFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrderFood));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_OrdFood_Room = new System.Windows.Forms.ComboBox();
            this.comboBox_OrdFood_FoodName = new System.Windows.Forms.ComboBox();
            this.comboBox_OrdFood_Category = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView_OrdFood = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_OrdFood_AddFood = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(125, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(846, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin món ăn của các phòng";
            // 
            // comboBox_OrdFood_Room
            // 
            this.comboBox_OrdFood_Room.FormattingEnabled = true;
            this.comboBox_OrdFood_Room.Items.AddRange(new object[] {
            "25",
            "30",
            "32"});
            this.comboBox_OrdFood_Room.Location = new System.Drawing.Point(191, 22);
            this.comboBox_OrdFood_Room.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_OrdFood_Room.Name = "comboBox_OrdFood_Room";
            this.comboBox_OrdFood_Room.Size = new System.Drawing.Size(273, 24);
            this.comboBox_OrdFood_Room.TabIndex = 1;
            this.comboBox_OrdFood_Room.SelectedIndexChanged += new System.EventHandler(this.ComboBox_OrdFood_Room_SelectedIndexChanged);
            // 
            // comboBox_OrdFood_FoodName
            // 
            this.comboBox_OrdFood_FoodName.FormattingEnabled = true;
            this.comboBox_OrdFood_FoodName.Location = new System.Drawing.Point(191, 167);
            this.comboBox_OrdFood_FoodName.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_OrdFood_FoodName.Name = "comboBox_OrdFood_FoodName";
            this.comboBox_OrdFood_FoodName.Size = new System.Drawing.Size(273, 24);
            this.comboBox_OrdFood_FoodName.TabIndex = 1;
            // 
            // comboBox_OrdFood_Category
            // 
            this.comboBox_OrdFood_Category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.comboBox_OrdFood_Category.FormattingEnabled = true;
            this.comboBox_OrdFood_Category.Location = new System.Drawing.Point(235, 89);
            this.comboBox_OrdFood_Category.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_OrdFood_Category.Name = "comboBox_OrdFood_Category";
            this.comboBox_OrdFood_Category.Size = new System.Drawing.Size(273, 24);
            this.comboBox_OrdFood_Category.TabIndex = 1;
            this.comboBox_OrdFood_Category.SelectedIndexChanged += new System.EventHandler(this.ComboBox_OrdFood_Category_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.numericUpDown1.Location = new System.Drawing.Point(233, 249);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(275, 22);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(16, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phòng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.comboBox_OrdFood_Room);
            this.panel1.Controls.Add(this.comboBox_OrdFood_FoodName);
            this.panel1.Controls.Add(this.comboBox_OrdFood_Category);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(16, 96);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 345);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 249);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(28, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "FoodName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(15, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Food Category";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.listView_OrdFood);
            this.panel2.Location = new System.Drawing.Point(584, 96);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 443);
            this.panel2.TabIndex = 4;
            // 
            // listView_OrdFood
            // 
            this.listView_OrdFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listView_OrdFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_OrdFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_OrdFood.ForeColor = System.Drawing.Color.Red;
            this.listView_OrdFood.GridLines = true;
            this.listView_OrdFood.HideSelection = false;
            this.listView_OrdFood.Location = new System.Drawing.Point(20, 4);
            this.listView_OrdFood.Margin = new System.Windows.Forms.Padding(4);
            this.listView_OrdFood.Name = "listView_OrdFood";
            this.listView_OrdFood.Size = new System.Drawing.Size(434, 420);
            this.listView_OrdFood.TabIndex = 1;
            this.listView_OrdFood.UseCompatibleStateImageBehavior = false;
            this.listView_OrdFood.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 102;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 92;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tổng tiền";
            this.columnHeader4.Width = 141;
            // 
            // button_OrdFood_AddFood
            // 
            this.button_OrdFood_AddFood.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_OrdFood_AddFood.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold);
            this.button_OrdFood_AddFood.ForeColor = System.Drawing.Color.Crimson;
            this.button_OrdFood_AddFood.Location = new System.Drawing.Point(136, 459);
            this.button_OrdFood_AddFood.Margin = new System.Windows.Forms.Padding(4);
            this.button_OrdFood_AddFood.Name = "button_OrdFood_AddFood";
            this.button_OrdFood_AddFood.Size = new System.Drawing.Size(229, 59);
            this.button_OrdFood_AddFood.TabIndex = 0;
            this.button_OrdFood_AddFood.Text = "Thêm món";
            this.button_OrdFood_AddFood.UseVisualStyleBackColor = false;
            this.button_OrdFood_AddFood.Click += new System.EventHandler(this.Button_OrdFood_AddFood_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(412, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 59);
            this.button2.TabIndex = 11;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormOrderFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLKaraoke.Properties.Resources.Foood;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_OrdFood_AddFood);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormOrderFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOrderFood";
            this.Load += new System.EventHandler(this.FormOrderFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_OrdFood_Room;
        private System.Windows.Forms.ComboBox comboBox_OrdFood_FoodName;
        private System.Windows.Forms.ComboBox comboBox_OrdFood_Category;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_OrdFood_AddFood;
        private System.Windows.Forms.ListView listView_OrdFood;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button2;
    }
}