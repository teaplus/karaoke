namespace QLKaraoke
{
    partial class OrderRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderRoom));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_Order_listRoomFull = new System.Windows.Forms.ComboBox();
            this.comboBox_OrderRoom_listRoom = new System.Windows.Forms.ComboBox();
            this.dateTimePicker__OrderRoom_TimeOrderR = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_OrderRoom_DateOrderR = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_OrderRoom_RemoveRoom = new System.Windows.Forms.Button();
            this.button_OrderRoom_AddRoom = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.comboBox_Order_listRoomFull);
            this.groupBox2.Controls.Add(this.comboBox_OrderRoom_listRoom);
            this.groupBox2.Controls.Add(this.dateTimePicker__OrderRoom_TimeOrderR);
            this.groupBox2.Controls.Add(this.dateTimePicker_OrderRoom_DateOrderR);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(381, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(493, 402);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin đặt phòng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 38);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 19);
            this.label10.TabIndex = 4;
            this.label10.Text = "DS phòng trống";
            // 
            // comboBox_Order_listRoomFull
            // 
            this.comboBox_Order_listRoomFull.FormattingEnabled = true;
            this.comboBox_Order_listRoomFull.Location = new System.Drawing.Point(163, 101);
            this.comboBox_Order_listRoomFull.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Order_listRoomFull.Name = "comboBox_Order_listRoomFull";
            this.comboBox_Order_listRoomFull.Size = new System.Drawing.Size(307, 27);
            this.comboBox_Order_listRoomFull.TabIndex = 4;
            // 
            // comboBox_OrderRoom_listRoom
            // 
            this.comboBox_OrderRoom_listRoom.FormattingEnabled = true;
            this.comboBox_OrderRoom_listRoom.Location = new System.Drawing.Point(163, 34);
            this.comboBox_OrderRoom_listRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_OrderRoom_listRoom.Name = "comboBox_OrderRoom_listRoom";
            this.comboBox_OrderRoom_listRoom.Size = new System.Drawing.Size(307, 27);
            this.comboBox_OrderRoom_listRoom.TabIndex = 0;
            // 
            // dateTimePicker__OrderRoom_TimeOrderR
            // 
            this.dateTimePicker__OrderRoom_TimeOrderR.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker__OrderRoom_TimeOrderR.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker__OrderRoom_TimeOrderR.Location = new System.Drawing.Point(163, 247);
            this.dateTimePicker__OrderRoom_TimeOrderR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker__OrderRoom_TimeOrderR.Name = "dateTimePicker__OrderRoom_TimeOrderR";
            this.dateTimePicker__OrderRoom_TimeOrderR.Size = new System.Drawing.Size(307, 26);
            this.dateTimePicker__OrderRoom_TimeOrderR.TabIndex = 2;
            // 
            // dateTimePicker_OrderRoom_DateOrderR
            // 
            this.dateTimePicker_OrderRoom_DateOrderR.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_OrderRoom_DateOrderR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_OrderRoom_DateOrderR.Location = new System.Drawing.Point(163, 167);
            this.dateTimePicker_OrderRoom_DateOrderR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_OrderRoom_DateOrderR.Name = "dateTimePicker_OrderRoom_DateOrderR";
            this.dateTimePicker_OrderRoom_DateOrderR.Size = new System.Drawing.Size(307, 26);
            this.dateTimePicker_OrderRoom_DateOrderR.TabIndex = 2;
            this.dateTimePicker_OrderRoom_DateOrderR.Value = new System.DateTime(2020, 12, 3, 17, 5, 0, 0);
            this.dateTimePicker_OrderRoom_DateOrderR.ValueChanged += new System.EventHandler(this.dateTimePicker_OrderRoom_DateOrderR_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 256);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "Thời gian đặt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 175);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ngày đặt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 105);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "DS phòng Full";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button_OrderRoom_RemoveRoom);
            this.panel1.Controls.Add(this.button_OrderRoom_AddRoom);
            this.panel1.Location = new System.Drawing.Point(16, 425);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 94);
            this.panel1.TabIndex = 0;
            // 
            // button_OrderRoom_RemoveRoom
            // 
            this.button_OrderRoom_RemoveRoom.BackColor = System.Drawing.Color.Red;
            this.button_OrderRoom_RemoveRoom.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OrderRoom_RemoveRoom.ForeColor = System.Drawing.Color.Yellow;
            this.button_OrderRoom_RemoveRoom.Location = new System.Drawing.Point(559, 5);
            this.button_OrderRoom_RemoveRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_OrderRoom_RemoveRoom.Name = "button_OrderRoom_RemoveRoom";
            this.button_OrderRoom_RemoveRoom.Size = new System.Drawing.Size(256, 65);
            this.button_OrderRoom_RemoveRoom.TabIndex = 1;
            this.button_OrderRoom_RemoveRoom.Text = "Hủy phòng";
            this.button_OrderRoom_RemoveRoom.UseVisualStyleBackColor = false;
            this.button_OrderRoom_RemoveRoom.Click += new System.EventHandler(this.Button_OrderRoom_RemoveRoom_Click);
            // 
            // button_OrderRoom_AddRoom
            // 
            this.button_OrderRoom_AddRoom.BackColor = System.Drawing.Color.Red;
            this.button_OrderRoom_AddRoom.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OrderRoom_AddRoom.ForeColor = System.Drawing.Color.Yellow;
            this.button_OrderRoom_AddRoom.Location = new System.Drawing.Point(92, 9);
            this.button_OrderRoom_AddRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_OrderRoom_AddRoom.Name = "button_OrderRoom_AddRoom";
            this.button_OrderRoom_AddRoom.Size = new System.Drawing.Size(256, 65);
            this.button_OrderRoom_AddRoom.TabIndex = 0;
            this.button_OrderRoom_AddRoom.Text = "Đặt phòng";
            this.button_OrderRoom_AddRoom.UseVisualStyleBackColor = false;
            this.button_OrderRoom_AddRoom.Click += new System.EventHandler(this.Button_OrderRoom_AddRoom_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 389);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // OrderRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1047, 533);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OrderRoom";
            this.Text = "OrderRoom";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_OrderRoom_listRoom;
        private System.Windows.Forms.DateTimePicker dateTimePicker__OrderRoom_TimeOrderR;
        private System.Windows.Forms.DateTimePicker dateTimePicker_OrderRoom_DateOrderR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_OrderRoom_RemoveRoom;
        private System.Windows.Forms.Button button_OrderRoom_AddRoom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_Order_listRoomFull;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}