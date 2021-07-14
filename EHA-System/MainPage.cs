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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();

            this.panelFormLoader.Controls.Clear();
            HomeDashBoard homeDashBoard = new HomeDashBoard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            homeDashBoard.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(homeDashBoard);
            homeDashBoard.Show();

            this.panelFormLoader.Controls.Clear();
            AmbulanceDashboard ambulanceDashboard = new AmbulanceDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ambulanceDashboard.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(ambulanceDashboard);
            ambulanceDashboard.Show();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Notification_btn_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            panel3.Height = Home_btn.Height;
            panel3.Top = Home_btn.Top;
            panel3.Left = Home_btn.Left;
            this.panelFormLoader.Controls.Clear();
            HomeDashBoard homeDashBoard = new HomeDashBoard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            homeDashBoard.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(homeDashBoard);
            homeDashBoard.Show();
        }

        private void Ambulance_btn_Click(object sender, EventArgs e)
        {
            panel3.Height = Ambulance_btn.Height;
            panel3.Top = Ambulance_btn.Top;
            panel3.Left = Ambulance_btn.Left;
            this.panelFormLoader.Controls.Clear();
            AmbulanceDashboard ambulanceDashboard = new AmbulanceDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ambulanceDashboard.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(ambulanceDashboard);
            ambulanceDashboard.Show();
        }

        private void FirstAider_btn_click(object sender, EventArgs e)
        {
            panel3.Height = Aider_reg.Height;
            panel3.Top = Aider_reg.Top;
            panel3.Left = Aider_reg.Left;
            this.panelFormLoader.Controls.Clear();
            HomeDashBoard homeDashBoard = new HomeDashBoard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            homeDashBoard.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(homeDashBoard);
            homeDashBoard.Show();
        }

        private void Reports_btn_click(object sender, EventArgs e)
        {
            panel3.Height = Reports_btn.Height;
            panel3.Top = Reports_btn.Top;
            panel3.Left = Reports_btn.Left;
            this.panelFormLoader.Controls.Clear();
            HomeDashBoard homeDashBoard = new HomeDashBoard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            homeDashBoard.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(homeDashBoard);
            homeDashBoard.Show();
        }
    }
}
