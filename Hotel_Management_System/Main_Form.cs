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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonAddManageClient_Click(object sender, EventArgs e)
        {
            ManageClientsForm manageCF = new ManageClientsForm();
            manageCF.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageRoomsForm manageRF = new ManageRoomsForm();
            manageRF.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageReservationsForm manageRSF = new ManageReservationsForm();
            manageRSF.Show();
            this.Hide();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
