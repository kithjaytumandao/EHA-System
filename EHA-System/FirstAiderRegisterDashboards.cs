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
    public partial class FirstAiderRegisterDashboards : Form
    {
        public FirstAiderRegisterDashboards()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FirstAiderRegisterDashboard_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FirstName_enter(object sender, EventArgs e)
        {
            if (Firstname_txtbx.Text == "First Name")
                Firstname_txtbx.Text = null;
            Firstname_txtbx.ForeColor = Color.Black;
        }

        private void Middlename_txtbx_Enter(object sender, EventArgs e)
        {
            if (Middlename_txtbx.Text == "Middle Name")
                Middlename_txtbx.Text = null;
                Middlename_txtbx.ForeColor = Color.Black;
        }

        private void Lastname_txtbx_Enter(object sender, EventArgs e)
        {
            if (Lastname_txtbx.Text == "Last Name")
                Lastname_txtbx.Text = null;
                Lastname_txtbx.ForeColor = Color.Black;
        }

        private void Age_txtbx_Enter(object sender, EventArgs e)
        {
            if (Age_txtbx.Text == "Age")
                Age_txtbx.Text = null;
                Age_txtbx.ForeColor = Color.Black;
        }

        private void Emailadd_txtbx_Enter(object sender, EventArgs e)
        {
            if (Emailadd_txtbx.Text == "Email Address")
                Emailadd_txtbx.Text = null;
                Emailadd_txtbx.ForeColor = Color.Black;
        }

        private void ContactNo_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContactNo_txtbx_Enter(object sender, EventArgs e)
        {
            if (ContactNo_txtbx.Text == "Contact Number")
                ContactNo_txtbx.Text = null;
                ContactNo_txtbx.ForeColor = Color.Black;
        }

        private void Search_txtbx_Enter(object sender, EventArgs e)
        {
            if (Search_txtbx.Text == "Search....")
                Search_txtbx.Text = null;
                Search_txtbx.ForeColor = Color.Black;
        }

        private void Firstname_txtbx_Leave(object sender, EventArgs e)
        {
            if (Firstname_txtbx.Text == "")
                Firstname_txtbx.Text = "First Name";
                Firstname_txtbx.ForeColor = Color.Silver;
        }

        private void Middlename_txtbx_Leave(object sender, EventArgs e)
        {
            if (Middlename_txtbx.Text == "")
                Middlename_txtbx.Text = "Middle Name";
                Middlename_txtbx.ForeColor = Color.Silver;
        }

        private void Lastname_txtbx_Leave(object sender, EventArgs e)
        {
            if (Lastname_txtbx.Text == "")
                Lastname_txtbx.Text = "Last Name";
                Lastname_txtbx.ForeColor = Color.Silver;
        }

      

        private void Emailadd_txtbx_Leave(object sender, EventArgs e)
        {
            if (Emailadd_txtbx.Text == "")
                Emailadd_txtbx.Text = "Email Address";
                Emailadd_txtbx.ForeColor = Color.Silver;
        }

        private void Age_txtbx_Leave(object sender, EventArgs e)
        {
            if (Age_txtbx.Text == "")
                Age_txtbx.Text = "Age";
                Age_txtbx.ForeColor = Color.Silver;
        }

        private void ContactNo_txtbx_Leave(object sender, EventArgs e)
        {
            if (ContactNo_txtbx.Text == "")
                ContactNo_txtbx.Text = "Contact Number";
                ContactNo_txtbx.ForeColor = Color.Silver;
        }

        private void Search_txtbx_Leave(object sender, EventArgs e)
        {
            if (Search_txtbx.Text == "")
                Search_txtbx.Text = "Search....";
                Search_txtbx.ForeColor = Color.Silver;
        }
    }
}
