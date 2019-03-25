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

namespace DemoConnectSQLServer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=P4JWHARILBCOWAZ\SQLEXPRESS;Initial Catalog=TEDU;Integrated Security=True");

        private void frmMain_Load(object sender, EventArgs e)
        {
            var dap = new SqlDataAdapter("SELECT * FROM PhongBan", conn);
            var table = new DataTable();
            dap.Fill(table);
            cbPhongBan.DisplayMember = "tenPB";
            cbPhongBan.ValueMember = "ID";
            cbPhongBan.DataSource = table;
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", cbPhongBan.DataSource, "ID");
            txtTenPB.DataBindings.Clear();
            txtTenPB.DataBindings.Add("Text", cbPhongBan.DataSource, "tenPB");
        }

        private void cbPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbPhongBan.SelectedValue);
            var dap = new SqlDataAdapter("SELECT * FROM SinhVien WHERE id = " + id, conn);
            var table = new DataTable();
            dap.Fill(table);
            dgvNhanVien.DataSource = table;
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", dgvNhanVien.DataSource, "maSV");
            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", dgvNhanVien.DataSource, "hoTen");
            txtQueQuan.DataBindings.Clear();
            txtQueQuan.DataBindings.Add("Text", dgvNhanVien.DataSource, "queQuan");
        }

        bool addPB = false;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtTenPB.Text = "";
            txtTenPB.Focus();
            addPB = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(addPB == true)
            {
                conn.Open();
                var cmd = new SqlCommand("INSERT INTO PhongBan(tenPB) VALUES(N'" + txtTenPB.Text + "')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                frmMain_Load(sender, e);
                addPB = false;
            }
            else
            {
                conn.Open();
                var cmd = new SqlCommand("UPDATE PhongBan SET tenPB = N'" + 
                    txtTenPB.Text + "' WHERE ID = " + Convert.ToInt32(cbPhongBan.SelectedValue), conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                frmMain_Load(sender, e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            var cmd = new SqlCommand("DELETE FROM PhongBan WHERE ID =" + Convert.ToInt32(cbPhongBan.SelectedValue), conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            frmMain_Load(sender, e);
        }

        bool addNV = false;

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            txtQueQuan.Text = "";
            txtHoTen.Focus();
            addNV = true;
        }

        private void btnUpdateNV_Click(object sender, EventArgs e)
        {
            if (addNV == true)
            {
                conn.Open();
                var cmd = new SqlCommand("INSERT INTO SinhVien(hoTen,queQuan) VALUES(N'" + txtTenPB.Text + "')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                frmMain_Load(sender, e);
                addPB = false;
            }
            else
            {
                conn.Open();
                var cmd = new SqlCommand("UPDATE PhongBan SET tenPB = N'" +
                    txtTenPB.Text + "' WHERE ID = " + Convert.ToInt32(cbPhongBan.SelectedValue), conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                frmMain_Load(sender, e);
            }
        }
    }
}
