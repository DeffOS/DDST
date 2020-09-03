using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDST
{
    public partial class DDTH : Form
    {
        Form Hub;
        public DDTH()
        {
            Hub = this;
            InitializeComponent();
        }

        private void DDST_Click(object sender, EventArgs e)
        {
            DDMB DDMB = new DDMB();
            Hub.Hide();
            DDMB.ShowDialog();
            Hub.Close();
        }

        private void DDMM_Click(object sender, EventArgs e)
        {
            DDMM DDMM = new DDMM();
            Hub.Hide();
            DDMM.ShowDialog();
            Hub.Close();
        }
    }
}
