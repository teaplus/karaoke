﻿namespace QLKaraoke
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_Main_Pay = new System.Windows.Forms.TextBox();
            this.listView_Main = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox_Main_ChangeR = new System.Windows.Forms.ComboBox();
            this.numericUpDown_Main_Discount = new System.Windows.Forms.NumericUpDown();
            this.button_Main_ChangeR = new System.Windows.Forms.Button();
            this.button_Main_Discount = new System.Windows.Forms.Button();
            this.button_Main_Pay = new System.Windows.Forms.Button();
            this.flowLayoutPanel_M_ListRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.xinChàoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderFoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Main_Discount)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox_Main_Pay);
            this.panel3.Controls.Add(this.listView_Main);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(509, 135);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(383, 277);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // textBox_Main_Pay
            // 
            this.textBox_Main_Pay.Location = new System.Drawing.Point(232, 251);
            this.textBox_Main_Pay.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Main_Pay.Name = "textBox_Main_Pay";
            this.textBox_Main_Pay.ReadOnly = true;
            this.textBox_Main_Pay.Size = new System.Drawing.Size(145, 22);
            this.textBox_Main_Pay.TabIndex = 1;
            this.textBox_Main_Pay.Text = "0";
            this.textBox_Main_Pay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listView_Main
            // 
            this.listView_Main.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_Main.GridLines = true;
            this.listView_Main.HideSelection = false;
            this.listView_Main.Location = new System.Drawing.Point(2, 0);
            this.listView_Main.Margin = new System.Windows.Forms.Padding(4);
            this.listView_Main.Name = "listView_Main";
            this.listView_Main.Size = new System.Drawing.Size(377, 234);
            this.listView_Main.TabIndex = 0;
            this.listView_Main.UseCompatibleStateImageBehavior = false;
            this.listView_Main.View = System.Windows.Forms.View.Details;
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
            this.columnHeader4.Width = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 249);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng Tiền";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboBox_Main_ChangeR);
            this.panel4.Controls.Add(this.numericUpDown_Main_Discount);
            this.panel4.Controls.Add(this.button_Main_ChangeR);
            this.panel4.Controls.Add(this.button_Main_Discount);
            this.panel4.Controls.Add(this.button_Main_Pay);
            this.panel4.Location = new System.Drawing.Point(511, 420);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(383, 71);
            this.panel4.TabIndex = 0;
            // 
            // comboBox_Main_ChangeR
            // 
            this.comboBox_Main_ChangeR.FormattingEnabled = true;
            this.comboBox_Main_ChangeR.Location = new System.Drawing.Point(4, 42);
            this.comboBox_Main_ChangeR.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Main_ChangeR.Name = "comboBox_Main_ChangeR";
            this.comboBox_Main_ChangeR.Size = new System.Drawing.Size(116, 24);
            this.comboBox_Main_ChangeR.TabIndex = 0;
            // 
            // numericUpDown_Main_Discount
            // 
            this.numericUpDown_Main_Discount.Location = new System.Drawing.Point(153, 39);
            this.numericUpDown_Main_Discount.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_Main_Discount.Name = "numericUpDown_Main_Discount";
            this.numericUpDown_Main_Discount.Size = new System.Drawing.Size(109, 22);
            this.numericUpDown_Main_Discount.TabIndex = 0;
            // 
            // button_Main_ChangeR
            // 
            this.button_Main_ChangeR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold);
            this.button_Main_ChangeR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_Main_ChangeR.Location = new System.Drawing.Point(13, 6);
            this.button_Main_ChangeR.Margin = new System.Windows.Forms.Padding(4);
            this.button_Main_ChangeR.Name = "button_Main_ChangeR";
            this.button_Main_ChangeR.Size = new System.Drawing.Size(117, 28);
            this.button_Main_ChangeR.TabIndex = 1;
            this.button_Main_ChangeR.Text = "Chuyển phòng";
            this.button_Main_ChangeR.UseVisualStyleBackColor = true;
            this.button_Main_ChangeR.Click += new System.EventHandler(this.Button_Main_ChangeR_Click);
            // 
            // button_Main_Discount
            // 
            this.button_Main_Discount.Location = new System.Drawing.Point(153, 4);
            this.button_Main_Discount.Margin = new System.Windows.Forms.Padding(4);
            this.button_Main_Discount.Name = "button_Main_Discount";
            this.button_Main_Discount.Size = new System.Drawing.Size(109, 28);
            this.button_Main_Discount.TabIndex = 0;
            this.button_Main_Discount.Text = "Giảm giá";
            this.button_Main_Discount.UseVisualStyleBackColor = true;
            // 
            // button_Main_Pay
            // 
            this.button_Main_Pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_Main_Pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Main_Pay.ForeColor = System.Drawing.Color.Red;
            this.button_Main_Pay.Location = new System.Drawing.Point(292, 4);
            this.button_Main_Pay.Margin = new System.Windows.Forms.Padding(4);
            this.button_Main_Pay.Name = "button_Main_Pay";
            this.button_Main_Pay.Size = new System.Drawing.Size(87, 64);
            this.button_Main_Pay.TabIndex = 0;
            this.button_Main_Pay.Text = "Thanh Toán";
            this.button_Main_Pay.UseVisualStyleBackColor = false;
            this.button_Main_Pay.Click += new System.EventHandler(this.Button_Main_Pay_Click);
            // 
            // flowLayoutPanel_M_ListRoom
            // 
            this.flowLayoutPanel_M_ListRoom.AutoScroll = true;
            this.flowLayoutPanel_M_ListRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel_M_ListRoom.Location = new System.Drawing.Point(16, 135);
            this.flowLayoutPanel_M_ListRoom.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel_M_ListRoom.Name = "flowLayoutPanel_M_ListRoom";
            this.flowLayoutPanel_M_ListRoom.Size = new System.Drawing.Size(485, 356);
            this.flowLayoutPanel_M_ListRoom.TabIndex = 1;
            this.flowLayoutPanel_M_ListRoom.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel_M_ListRoom_Paint);
            // 
            // xinChàoToolStripMenuItem
            // 
            this.xinChàoToolStripMenuItem.Name = "xinChàoToolStripMenuItem";
            this.xinChàoToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.xinChàoToolStripMenuItem.Text = "Xin chào: ";
            // 
            // OrderRoomToolStripMenuItem
            // 
            this.OrderRoomToolStripMenuItem.Name = "OrderRoomToolStripMenuItem";
            this.OrderRoomToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.OrderRoomToolStripMenuItem.Text = "Order Room";
            this.OrderRoomToolStripMenuItem.Click += new System.EventHandler(this.OrderRoomToolStripMenuItem_Click);
            // 
            // orderFoodToolStripMenuItem
            // 
            this.orderFoodToolStripMenuItem.Name = "orderFoodToolStripMenuItem";
            this.orderFoodToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.orderFoodToolStripMenuItem.Text = "Order Food";
            this.orderFoodToolStripMenuItem.Click += new System.EventHandler(this.OrderFoodToolStripMenuItem_Click);
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.managementToolStripMenuItem.Text = "Management";
            this.managementToolStripMenuItem.Click += new System.EventHandler(this.ManagementToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xinChàoToolStripMenuItem,
            this.OrderRoomToolStripMenuItem,
            this.orderFoodToolStripMenuItem,
            this.managementToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(928, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.BackgroundImage = global::QLKaraoke.Properties.Resources.karaoke1;
            this.panel1.Location = new System.Drawing.Point(16, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 97);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(928, 506);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel_M_ListRoom);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lí quán Karaoke";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Main_Discount)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_Main_ChangeR;
        private System.Windows.Forms.Button button_Main_Pay;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_M_ListRoom;
        public System.Windows.Forms.Button button_Main_Discount;
        private System.Windows.Forms.ComboBox comboBox_Main_ChangeR;
        private System.Windows.Forms.NumericUpDown numericUpDown_Main_Discount;
        private System.Windows.Forms.ListView listView_Main;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Main_Pay;
        private System.Windows.Forms.ToolStripMenuItem xinChàoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrderRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderFoodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
    }
}