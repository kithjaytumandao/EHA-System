using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EHA_System
{
    public partial class Loginpage : Form
    {
        public Loginpage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Usernname_txtbx.Clear();
            Password_txtbx.Clear();
            Usernname_txtbx.Focus();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage open = new MainPage();
            open.Show();

        }
    }
}
