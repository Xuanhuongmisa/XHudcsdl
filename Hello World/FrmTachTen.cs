using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World
{
    public partial class FrmTachTen : Form
    {
        public FrmTachTen()
        {
            InitializeComponent();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTach_Click(object sender, EventArgs e)
        {
            string ht, ho, hodem, ten;
            int vtd, vtc, dd;
            ht = txtNhapht.Text.Trim();
            vtd = ht.IndexOf(" ");
            vtc = ht.LastIndexOf(" ");
            dd = ht.Length;
            ho = ht.Substring(0, vtd);
            ten = ht.Substring(vtc + 1);
            hodem = ht.Substring(vtd + 1, vtc - vtd - 1);
            txtHo.Text = ho;
            txtHoDem.Text = hodem;
            txtTen.Text = ten;

        }
    }
}
