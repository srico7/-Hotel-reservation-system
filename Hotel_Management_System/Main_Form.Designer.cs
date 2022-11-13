namespace Hotel_Management_System
{
    partial class Main_Form
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
            this.buttonAddManageClient = new System.Windows.Forms.Button();
            this.buttonAddManageRooms = new System.Windows.Forms.Button();
            this.buttonAddManageReservations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddManageClient
            // 
            this.buttonAddManageClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddManageClient.Location = new System.Drawing.Point(387, 186);
            this.buttonAddManageClient.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddManageClient.Name = "buttonAddManageClient";
            this.buttonAddManageClient.Size = new System.Drawing.Size(210, 28);
            this.buttonAddManageClient.TabIndex = 38;
            this.buttonAddManageClient.Text = "Manage Clients";
            this.buttonAddManageClient.UseVisualStyleBackColor = true;
            this.buttonAddManageClient.Click += new System.EventHandler(this.buttonAddManageClient_Click);
            // 
            // buttonAddManageRooms
            // 
            this.buttonAddManageRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddManageRooms.Location = new System.Drawing.Point(387, 249);
            this.buttonAddManageRooms.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddManageRooms.Name = "buttonAddManageRooms";
            this.buttonAddManageRooms.Size = new System.Drawing.Size(210, 28);
            this.buttonAddManageRooms.TabIndex = 40;
            this.buttonAddManageRooms.Text = "Manage Rooms";
            this.buttonAddManageRooms.UseVisualStyleBackColor = true;
            this.buttonAddManageRooms.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAddManageReservations
            // 
            this.buttonAddManageReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddManageReservations.Location = new System.Drawing.Point(387, 319);
            this.buttonAddManageReservations.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddManageReservations.Name = "buttonAddManageReservations";
            this.buttonAddManageReservations.Size = new System.Drawing.Size(210, 28);
            this.buttonAddManageReservations.TabIndex = 41;
            this.buttonAddManageReservations.Text = "Manage Reservations";
            this.buttonAddManageReservations.UseVisualStyleBackColor = true;
            this.buttonAddManageReservations.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonAddManageReservations);
            this.Controls.Add(this.buttonAddManageRooms);
            this.Controls.Add(this.buttonAddManageClient);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAddManageClient;
        private System.Windows.Forms.Button buttonAddManageRooms;
        private System.Windows.Forms.Button buttonAddManageReservations;
    }
}