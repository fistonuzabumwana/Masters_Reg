using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Masters_Reg
{
    public partial class Logins : Form
    {
        public Logins()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signups signups = new Signups();
            signups.ShowDialog();
            this.Hide();
        }

        private void Logins_Load(object sender, EventArgs e)
        {

        }
    }
}
  