namespace Hotel_Management_System
{
    partial class Welcome
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
            this.WelcomeButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WelcomeButton
            // 
            this.WelcomeButton.Location = new System.Drawing.Point(571, 390);
            this.WelcomeButton.Name = "WelcomeButton";
            this.WelcomeButton.Size = new System.Drawing.Size(410, 95);
            this.WelcomeButton.TabIndex = 0;
            this.WelcomeButton.Text = "GO";
            this.WelcomeButton.UseVisualStyleBackColor = true;
            this.WelcomeButton.Click += new System.EventHandler(this.WelcomeButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(447, 169);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(695, 140);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Hotel Reservation System";
            // 
            // Welcome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1545, 782);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.WelcomeButton);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WelcomeButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}