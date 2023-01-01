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
    public partial class frmLab06_btvn_2 : Form
    {
        public frmLab06_btvn_2()
        {
            InitializeComponent();
        }

        private void bài1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lab06_bttlb1 bttlb1 = new Lab06_bttlb1();
            bttlb1.Show();
        }

        private void bài2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lab06_bttlb2 bttlb2 = new Lab06_bttlb2();
            bttlb2.Show();
        }

        private void bài3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lab06_btvnb1 btvnb1 = new Lab06_btvnb1();
            btvnb1.Show();
        }

        private void bài4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lab06_btncb1 btnc = new Lab06_btncb1();
            btnc.Show();
        }
    }
}
