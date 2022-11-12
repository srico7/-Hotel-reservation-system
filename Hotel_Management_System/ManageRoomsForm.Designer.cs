namespace Hotel_Management_System
{
    partial class ManageRoomsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonRemoveRoom = new System.Windows.Forms.Button();
            this.buttonEditRoom = new System.Windows.Forms.Button();
            this.buttonAddRoom = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButtonNO = new System.Windows.Forms.RadioButton();
            this.radioButton1YES = new System.Windows.Forms.RadioButton();
            this.radioButtonYES = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxphone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(353, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(492, 327);
            this.dataGridView1.TabIndex = 28;
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Location = new System.Drawing.Point(141, 161);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(151, 21);
            this.comboBoxRoomType.TabIndex = 27;
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(25, 387);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(263, 23);
            this.buttonClear.TabIndex = 26;
            this.buttonClear.Text = "Clear fields";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonRemoveRoom
            // 
            this.buttonRemoveRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveRoom.Location = new System.Drawing.Point(215, 343);
            this.buttonRemoveRoom.Name = "buttonRemoveRoom";
            this.buttonRemoveRoom.Size = new System.Drawing.Size(73, 23);
            this.buttonRemoveRoom.TabIndex = 25;
            this.buttonRemoveRoom.Text = "Remove";
            this.buttonRemoveRoom.UseVisualStyleBackColor = true;
            this.buttonRemoveRoom.Click += new System.EventHandler(this.buttonRemoveRoom_Click);
            // 
            // buttonEditRoom
            // 
            this.buttonEditRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditRoom.Location = new System.Drawing.Point(154, 343);
            this.buttonEditRoom.Name = "buttonEditRoom";
            this.buttonEditRoom.Size = new System.Drawing.Size(55, 23);
            this.buttonEditRoom.TabIndex = 24;
            this.buttonEditRoom.Text = "Edit";
            this.buttonEditRoom.UseVisualStyleBackColor = true;
            this.buttonEditRoom.Click += new System.EventHandler(this.buttonEditRoom_Click);
            // 
            // buttonAddRoom
            // 
            this.buttonAddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddRoom.Location = new System.Drawing.Point(25, 343);
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.Size = new System.Drawing.Size(123, 23);
            this.buttonAddRoom.TabIndex = 23;
            this.buttonAddRoom.Text = "Add New Room";
            this.buttonAddRoom.UseVisualStyleBackColor = true;
            this.buttonAddRoom.Click += new System.EventHandler(this.buttonAddRoom_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.radioButtonYES);
            this.panel2.Location = new System.Drawing.Point(141, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 37);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.radioButtonNO);
            this.panel3.Controls.Add(this.radioButton1YES);
            this.panel3.Location = new System.Drawing.Point(-1, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(152, 37);
            this.panel3.TabIndex = 9;
            // 
            // radioButtonNO
            // 
            this.radioButtonNO.AutoSize = true;
            this.radioButtonNO.BackColor = System.Drawing.SystemColors.Window;
            this.radioButtonNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNO.ForeColor = System.Drawing.Color.Red;
            this.radioButtonNO.Location = new System.Drawing.Point(85, 4);
            this.radioButtonNO.Name = "radioButtonNO";
            this.radioButtonNO.Size = new System.Drawing.Size(47, 20);
            this.radioButtonNO.TabIndex = 1;
            this.radioButtonNO.TabStop = true;
            this.radioButtonNO.Text = "NO";
            this.radioButtonNO.UseVisualStyleBackColor = false;
            // 
            // radioButton1YES
            // 
            this.radioButton1YES.AutoSize = true;
            this.radioButton1YES.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1YES.ForeColor = System.Drawing.Color.Green;
            this.radioButton1YES.Location = new System.Drawing.Point(3, 4);
            this.radioButton1YES.Name = "radioButton1YES";
            this.radioButton1YES.Size = new System.Drawing.Size(55, 20);
            this.radioButton1YES.TabIndex = 0;
            this.radioButton1YES.TabStop = true;
            this.radioButton1YES.Text = "YES";
            this.radioButton1YES.UseVisualStyleBackColor = true;
            // 
            // radioButtonYES
            // 
            this.radioButtonYES.AutoSize = true;
            this.radioButtonYES.Location = new System.Drawing.Point(-1, 4);
            this.radioButtonYES.Name = "radioButtonYES";
            this.radioButtonYES.Size = new System.Drawing.Size(46, 17);
            this.radioButtonYES.TabIndex = 0;
            this.radioButtonYES.TabStop = true;
            this.radioButtonYES.Text = "YES";
            this.radioButtonYES.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Free :";
            // 
            // textBoxphone
            // 
            this.textBoxphone.Location = new System.Drawing.Point(141, 200);
            this.textBoxphone.Name = "textBoxphone";
            this.textBoxphone.Size = new System.Drawing.Size(149, 20);
            this.textBoxphone.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Phone :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Rooom Type :";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(141, 126);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(149, 20);
            this.textBoxNumber.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Room Number :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-72, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 79);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Room";
            // 
            // ManageRoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 494);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxRoomType);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRemoveRoom);
            this.Controls.Add(this.buttonEditRoom);
            this.Controls.Add(this.buttonAddRoom);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxphone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageRoomsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageRoomsForm";
            this.Load += new System.EventHandler(this.ManageRoomsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonRemoveRoom;
        private System.Windows.Forms.Button buttonEditRoom;
        private System.Windows.Forms.Button buttonAddRoom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButtonNO;
        private System.Windows.Forms.RadioButton radioButton1YES;
        private System.Windows.Forms.RadioButton radioButtonYES;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxphone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}