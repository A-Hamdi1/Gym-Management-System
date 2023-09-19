using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtBoxUserName.Text == "admin" && txtBoxPass.Text == "admin")
            {
                GymManagementSystem gms = new GymManagementSystem();
                gms.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Incorrect UserName or Password", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
