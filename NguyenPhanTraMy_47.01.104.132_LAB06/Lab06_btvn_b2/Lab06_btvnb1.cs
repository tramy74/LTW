using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06_btvn_b2
{
    public partial class Lab06_btvnb1 : Form
    {
        public Lab06_btvnb1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            i = 0;
            m = 30;
        }
        int i = 0;
        int m = 30;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i == 0)
            {
                m--;
                lblMinute.Text = m.ToString();
                i = 60;
            }
            i--;
            lblSeconds.Text = i.ToString();
            if (m == 0)
            {
                timer1.Stop();
                lblMinute.Text = "30";
                lblSeconds.Text = "00";
            }
        }
    }
}
