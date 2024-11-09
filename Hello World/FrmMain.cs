using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Hello_World
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void danhMụcToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
          
        }

        private void tiệnÍchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form1();
            f.Show(); // hoặc f.showdialog();

        }

        private void táchTênNgườiViếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            status1.Text = "Chức năng tách tên người Việt";
            Form abc = new FrmTachTen();
            abc.ShowDialog();
            status1.Text = "READY!";
        }

        private void kếtThúcChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form f = new Form1();
            f.ShowDialog();
        }

        private void đăngNhậpHệThốngToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void táchTênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FrmTachTen();
            f.ShowDialog();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {
            status3.Text = System.DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            status3.Text = System.DateTime.Now.ToString();
        }

        private void danhMụcHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdmhh f = new frmdmhh();
            f.Show();
        }
    }
}
