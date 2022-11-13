using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WelcomeButton_Click(object sender, EventArgs e)
        {
            LoginForm loginCF = new LoginForm();
            loginCF.Show();
            this.Hide();
        }
    }
}
