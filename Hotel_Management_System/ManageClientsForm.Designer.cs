namespace Hotel_Management_System
{
    partial class ManageClientsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonRemoveClient = new System.Windows.Forms.Button();
            this.buttonEditClient = new System.Windows.Forms.Button();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonB = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.buttonB);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.buttonRemoveClient);
            this.panel1.Controls.Add(this.buttonEditClient);
            this.panel1.Controls.Add(this.buttonAddClient);
            this.panel1.Controls.Add(this.textBoxCountry);
            this.panel1.Controls.Add(this.textBoxPhone);
            this.panel1.Controls.Add(this.textBoxLastName);
            this.panel1.Controls.Add(this.textBoxFirstName);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 554);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(507, 133);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(525, 406);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(29, 425);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(376, 34);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "Clear Fields";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonRemoveClient
            // 
            this.buttonRemoveClient.Location = new System.Drawing.Point(281, 378);
            this.buttonRemoveClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRemoveClient.Name = "buttonRemoveClient";
            this.buttonRemoveClient.Size = new System.Drawing.Size(124, 39);
            this.buttonRemoveClient.TabIndex = 13;
            this.buttonRemoveClient.Text = "Remove";
            this.buttonRemoveClient.UseVisualStyleBackColor = true;
            this.buttonRemoveClient.Click += new System.EventHandler(this.buttonRemoveClient_Click);
            // 
            // buttonEditClient
            // 
            this.buttonEditClient.Location = new System.Drawing.Point(192, 379);
            this.buttonEditClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEditClient.Name = "buttonEditClient";
            this.buttonEditClient.Size = new System.Drawing.Size(81, 38);
            this.buttonEditClient.TabIndex = 12;
            this.buttonEditClient.Text = "Edit";
            this.buttonEditClient.UseVisualStyleBackColor = true;
            this.buttonEditClient.Click += new System.EventHandler(this.buttonEditClient_Click);
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Location = new System.Drawing.Point(29, 378);
            this.buttonAddClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(155, 38);
            this.buttonAddClient.TabIndex = 11;
            this.buttonAddClient.Text = "Add New Client";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(159, 315);
            this.textBoxCountry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(245, 22);
            this.textBoxCountry.TabIndex = 10;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(159, 271);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(245, 22);
            this.textBoxPhone.TabIndex = 9;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(159, 229);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(245, 22);
            this.textBoxLastName.TabIndex = 8;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(159, 180);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(245, 22);
            this.textBoxFirstName.TabIndex = 7;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(159, 133);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(132, 22);
            this.textBoxID.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 315);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Country:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 273);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 84);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1067, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Clients";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonB
            // 
            this.buttonB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonB.Location = new System.Drawing.Point(176, 476);
            this.buttonB.Margin = new System.Windows.Forms.Padding(4);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(97, 28);
            this.buttonB.TabIndex = 30;
            this.buttonB.Text = "Back";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // ManageClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManageClientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageClientsForm";
            this.Load += new System.EventHandler(this.ManageClientsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonRemoveClient;
        private System.Windows.Forms.Button buttonEditClient;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonB;
    }
}