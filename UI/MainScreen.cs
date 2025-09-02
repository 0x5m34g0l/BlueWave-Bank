using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueWave_Bank
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            if (Global.CurrentUser != null)
            {
                lblWelcome.Visible = true;
                lblCurrentUsername.Text = Global.CurrentUser.FirstName + "!";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd, MMMM yyyy");

            lblTimer.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            githubLink.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/0x5m34g0l");
        }
    }
}
