namespace Hotel_Management_System
{
    partial class ManageReservationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageReservationsForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonRemoveReserve = new System.Windows.Forms.Button();
            this.buttonEditReserve = new System.Windows.Forms.Button();
            this.buttonAddReserve = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxRoomNumber = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePickerIN = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerOUT = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonB = new System.Windows.Forms.Button();
            this.textBoxReserveID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(394, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(394, 327);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buttonClear.Location = new System.Drawing.Point(54, 472);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(263, 23);
            this.buttonClear.TabIndex = 40;
            this.buttonClear.Text = "Clear fields";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonRemoveReserve
            // 
            this.buttonRemoveReserve.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveReserve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buttonRemoveReserve.Location = new System.Drawing.Point(244, 434);
            this.buttonRemoveReserve.Name = "buttonRemoveReserve";
            this.buttonRemoveReserve.Size = new System.Drawing.Size(73, 23);
            this.buttonRemoveReserve.TabIndex = 39;
            this.buttonRemoveReserve.Text = "Remove";
            this.buttonRemoveReserve.UseVisualStyleBackColor = true;
            this.buttonRemoveReserve.Click += new System.EventHandler(this.buttonRemoveReserve_Click);
            // 
            // buttonEditReserve
            // 
            this.buttonEditReserve.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditReserve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buttonEditReserve.Location = new System.Drawing.Point(183, 434);
            this.buttonEditReserve.Name = "buttonEditReserve";
            this.buttonEditReserve.Size = new System.Drawing.Size(55, 23);
            this.buttonEditReserve.TabIndex = 38;
            this.buttonEditReserve.Text = "Edit";
            this.buttonEditReserve.UseVisualStyleBackColor = true;
            this.buttonEditReserve.Click += new System.EventHandler(this.buttonEditReserve_Click);
            // 
            // buttonAddReserve
            // 
            this.buttonAddReserve.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddReserve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buttonAddReserve.Location = new System.Drawing.Point(54, 434);
            this.buttonAddReserve.Name = "buttonAddReserve";
            this.buttonAddReserve.Size = new System.Drawing.Size(123, 23);
            this.buttonAddReserve.TabIndex = 37;
            this.buttonAddReserve.Text = "Add Reservation";
            this.buttonAddReserve.UseVisualStyleBackColor = true;
            this.buttonAddReserve.Click += new System.EventHandler(this.buttonAddReserve_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(51, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 61;
            this.label8.Text = "Client ID :";
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClientID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.textBoxClientID.Location = new System.Drawing.Point(147, 184);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(181, 21);
            this.textBoxClientID.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(31, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 16);
            this.label9.TabIndex = 63;
            this.label9.Text = "Rooom Type :";
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomType.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Location = new System.Drawing.Point(147, 220);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(181, 24);
            this.comboBoxRoomType.TabIndex = 64;
            this.comboBoxRoomType.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoomType_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(10, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 16);
            this.label10.TabIndex = 65;
            this.label10.Text = "Rooom Number :";
            // 
            // comboBoxRoomNumber
            // 
            this.comboBoxRoomNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomNumber.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoomNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.comboBoxRoomNumber.FormattingEnabled = true;
            this.comboBoxRoomNumber.Location = new System.Drawing.Point(147, 260);
            this.comboBoxRoomNumber.Name = "comboBoxRoomNumber";
            this.comboBoxRoomNumber.Size = new System.Drawing.Size(181, 24);
            this.comboBoxRoomNumber.TabIndex = 66;
            this.comboBoxRoomNumber.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoomNumber_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(58, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 16);
            this.label11.TabIndex = 67;
            this.label11.Text = "Date IN :";
            // 
            // dateTimePickerIN
            // 
            this.dateTimePickerIN.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dateTimePickerIN.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dateTimePickerIN.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerIN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerIN.Location = new System.Drawing.Point(147, 304);
            this.dateTimePickerIN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerIN.Name = "dateTimePickerIN";
            this.dateTimePickerIN.Size = new System.Drawing.Size(181, 20);
            this.dateTimePickerIN.TabIndex = 68;
            this.dateTimePickerIN.ValueChanged += new System.EventHandler(this.dateTimePickerIN_ValueChanged);
            // 
            // dateTimePickerOUT
            // 
            this.dateTimePickerOUT.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dateTimePickerOUT.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dateTimePickerOUT.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerOUT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerOUT.Location = new System.Drawing.Point(147, 347);
            this.dateTimePickerOUT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerOUT.Name = "dateTimePickerOUT";
            this.dateTimePickerOUT.Size = new System.Drawing.Size(181, 20);
            this.dateTimePickerOUT.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 69;
            this.label2.Text = "Date OUT :";
            // 
            // buttonB
            // 
            this.buttonB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonB.Location = new System.Drawing.Point(149, 552);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(73, 23);
            this.buttonB.TabIndex = 71;
            this.buttonB.Text = "Back";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // textBoxReserveID
            // 
            this.textBoxReserveID.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReserveID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.textBoxReserveID.Location = new System.Drawing.Point(147, 149);
            this.textBoxReserveID.Name = "textBoxReserveID";
            this.textBoxReserveID.Size = new System.Drawing.Size(181, 21);
            this.textBoxReserveID.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 72;
            this.label3.Text = "Reserve ID :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.button1.Location = new System.Drawing.Point(150, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 74;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(277, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 26);
            this.label1.TabIndex = 77;
            this.label1.Text = "Manage Reservations";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 104);
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // closebtn
            // 
            this.closebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.ForeColor = System.Drawing.Color.White;
            this.closebtn.Location = new System.Drawing.Point(751, 9);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(40, 40);
            this.closebtn.TabIndex = 75;
            this.closebtn.Text = "X";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // ManageReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxReserveID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.dateTimePickerOUT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerIN);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxRoomNumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxRoomType);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxClientID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRemoveReserve);
            this.Controls.Add(this.buttonEditReserve);
            this.Controls.Add(this.buttonAddReserve);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageReservationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageReservationsForm";
            this.Load += new System.EventHandler(this.ManageReservationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonRemoveReserve;
        private System.Windows.Forms.Button buttonEditReserve;
        private System.Windows.Forms.Button buttonAddReserve;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxRoomNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePickerIN;
        private System.Windows.Forms.DateTimePicker dateTimePickerOUT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.TextBox textBoxReserveID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button closebtn;
    }
}