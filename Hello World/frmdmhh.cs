using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hello_World
{
    public partial class frmdmhh : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr;
        public frmdmhh()
        {
            InitializeComponent();
        }

        private void GrdData_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void GrdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GrdData.CurrentCell = GrdData[0, 0];
            NapCT();
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            int i = GrdData.CurrentRow.Index;
            if (i > 0)
            {
                GrdData.CurrentCell = GrdData[0, i - 1];
                NapCT();
            } 
                

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int i = GrdData.CurrentRow.Index;
            if (i < GrdData.RowCount -1 )
            {
                GrdData.CurrentCell = GrdData[0, i + 1];
                NapCT();
            }

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            GrdData.CurrentCell = GrdData[0, GrdData.RowCount-1];
            NapCT();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmdmhh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHDataSet.tblDMHH' table. You can move, or remove it, as needed.
            this.tblDMHHTableAdapter.Fill(this.qLBHDataSet.tblDMHH);
            constr = "Data Source=DESKTOP-BJFO4IR\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "Select *From tbldmhh order by MaHH";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            GrdData.DataSource = dt;
            GrdData.Refresh();
            NapCT();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comTenTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = " select distinct " + comTenTruong.Text + " From tblDMHH order by " + comTenTruong.Text;
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comGT.DataSource = comdt;
            comGT.DisplayMember = comTenTruong.Text.Trim();


        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            sql = "select * from tblDMHH Where " + comTenTruong.Text + "='" + comGT.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            GrdData.DataSource = dt;
            GrdData.Refresh();
            NapCT();



        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            sql = "select * from tblDMHH ";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            GrdData.DataSource = dt;
            GrdData.Refresh();
            NapCT();
        }

        private void comGT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void NapCT()
        {
            int i = GrdData.CurrentRow.Index;//lấy số thứ tự dòng hiện thời
            txtMaNhom.Text = GrdData.Rows[i].Cells["MaNhom"].Value.ToString();
            txtTenHH.Text = GrdData.Rows[i].Cells["TenHH"].Value.ToString();
            txtDvt.Text = GrdData.Rows[i].Cells["Dvt"].Value.ToString();
            txtDgvnd.Text = GrdData.Rows[i].Cells["Dgvnd"].Value.ToString();
            txtSanxuat.Text = GrdData.Rows[i].Cells["SanXuat"].Value.ToString();
            txtMaHH.Text = GrdData.Rows[i].Cells["MaHH"].Value.ToString();
            txtDgusd.Text = GrdData.Rows[i].Cells["Dgusd"].Value.ToString();
        }
    }
}
