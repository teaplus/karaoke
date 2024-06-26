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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(212, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 31);
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
            this.comboBox_OrdFood_Room.Location = new System.Drawing.Point(143, 18);
            this.comboBox_OrdFood_Room.Name = "comboBox_OrdFood_Room";
            this.comboBox_OrdFood_Room.Size = new System.Drawing.Size(206, 21);
            this.comboBox_OrdFood_Room.TabIndex = 1;
            this.comboBox_OrdFood_Room.SelectedIndexChanged += new System.EventHandler(this.ComboBox_OrdFood_Room_SelectedIndexChanged);
            // 
            // comboBox_OrdFood_FoodName
            // 
            this.comboBox_OrdFood_FoodName.FormattingEnabled = true;
            this.comboBox_OrdFood_FoodName.Location = new System.Drawing.Point(143, 136);
            this.comboBox_OrdFood_FoodName.Name = "comboBox_OrdFood_FoodName";
            this.comboBox_OrdFood_FoodName.Size = new System.Drawing.Size(206, 21);
            this.comboBox_OrdFood_FoodName.TabIndex = 1;
            // 
            // comboBox_OrdFood_Category
            // 
            this.comboBox_OrdFood_Category.FormattingEnabled = true;
            this.comboBox_OrdFood_Category.Location = new System.Drawing.Point(143, 74);
            this.comboBox_OrdFood_Category.Name = "comboBox_OrdFood_Category";
            this.comboBox_OrdFood_Category.Size = new System.Drawing.Size(206, 21);
            this.comboBox_OrdFood_Category.TabIndex = 1;
            this.comboBox_OrdFood_Category.SelectedIndexChanged += new System.EventHandler(this.ComboBox_OrdFood_Category_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(143, 202);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(206, 20);
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
            this.label2.Location = new System.Drawing.Point(21, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phòng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.comboBox_OrdFood_Room);
            this.panel1.Controls.Add(this.comboBox_OrdFood_FoodName);
            this.panel1.Controls.Add(this.comboBox_OrdFood_Category);
            this.panel1.Location = new System.Drawing.Point(12, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 280);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "FoodName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Food Category";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView_OrdFood);
            this.panel2.Location = new System.Drawing.Point(438, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 360);
            this.panel2.TabIndex = 4;
            // 
            // listView_OrdFood
            // 
            this.listView_OrdFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_OrdFood.GridLines = true;
            this.listView_OrdFood.HideSelection = false;
            this.listView_OrdFood.Location = new System.Drawing.Point(3, 3);
            this.listView_OrdFood.Name = "listView_OrdFood";
            this.listView_OrdFood.Size = new System.Drawing.Size(344, 357);
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
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tổng tiền";
            // 
            // button_OrdFood_AddFood
            // 
            this.button_OrdFood_AddFood.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_OrdFood_AddFood.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OrdFood_AddFood.Location = new System.Drawing.Point(102, 373);
            this.button_OrdFood_AddFood.Name = "button_OrdFood_AddFood";
            this.button_OrdFood_AddFood.Size = new System.Drawing.Size(172, 48);
            this.button_OrdFood_AddFood.TabIndex = 0;
            this.button_OrdFood_AddFood.Text = "Thêm món";
            this.button_OrdFood_AddFood.UseVisualStyleBackColor = false;
            this.button_OrdFood_AddFood.Click += new System.EventHandler(this.Button_OrdFood_AddFood_Click);
            // 
            // FormOrderFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_OrdFood_AddFood);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOrderFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOrderFood";
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
    }
}