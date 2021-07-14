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
    public partial class AmbulanceDashboard : Form
    {
        public AmbulanceDashboard()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Distress_Signal_ID_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Location_Click(object sender, EventArgs e)
        {

        }

        private void First_Aider_name_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void day_label_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void All_req_btn_Click(object sender, EventArgs e)
        {
            
            
            panel4.Left = All_req_btn.Left;
            
        }

        private void Pending_req_btn_Click(object sender, EventArgs e)
        {
            
            
            panel4.Left = Pending_req_btn.Left;
        }

        private void Completed_req_Click(object sender, EventArgs e)
        {
           
            
            panel4.Left = Completed_req_btn.Left;
        }
    }
}
