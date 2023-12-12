using quanlihosonhansu.Admin__hosonhansu.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlihosonhansu.Admin__chucvu
{
    public partial class chucvu : Form
    {
        public chucvu()
        {
            InitializeComponent();
        }

        string sql = "";

        SqlConnection conn = Connection.Connection.GetSqlConnection();
        SqlCommand command = new SqlCommand();
        public static DataTable getData(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, Connection.Connection.GetSqlConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn Thêm không ?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string prevsql = sql;

                conn.Open();
                sql = "Insert into chucvu (ten, mo_ta) VALUES " +
                    "('" + textChucVu.Text +
                    "', '" + textMoTa.Text +
                    "')";
                command = conn.CreateCommand();
                command.CommandText = sql;
                command.ExecuteNonQuery();

                conn.Close();
                // delete kiluat and khenthuong similar to above if needed (if table have data)

                // re-Render
                dgvCV.DataSource = Getdata.getData(prevsql);
                sql = prevsql;

                MessageBox.Show("Thêm thành công");


            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không ?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string prevsql = sql;

                conn.Open();
                sql = "Update chucvu set " + "ten = '" + textChucVu.Text + "', " + "mo_ta = '" + textMoTa.Text + "' " + "Where id = '" + textId.Text + "' " + "";

                command = conn.CreateCommand();
                command.CommandText = sql;
                command.ExecuteNonQuery();

                conn.Close();
                // delete kiluat and khenthuong similar to above if needed (if table have data)

                // re-Render
                dgvCV.DataSource = Getdata.getData(prevsql);
                sql = prevsql;

                MessageBox.Show("Sửa thành công");


            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string prevsql = sql;
                string idChucVu = textId.Text;

                conn.Open();
                sql = "delete from chucvu where id = " + idChucVu;
                command = conn.CreateCommand();
                command.CommandText = sql;
                command.ExecuteNonQuery();

                conn.Close();
                // delete kiluat and khenthuong similar to above if needed (if table have data)

                // re-Render
                dgvCV.DataSource = Getdata.getData(prevsql);
                sql = prevsql;

                MessageBox.Show("Xóa thành công");

            }
        }

        private void dgvCV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;

            if (i >= 0)
            {
                // handling texts and datetime
                textId.Text = dgvCV.Rows[i].Cells[0].Value.ToString();
                textChucVu.Text = dgvCV.Rows[i].Cells[1].Value.ToString();
                textMoTa.Text = dgvCV.Rows[i].Cells[2].Value.ToString();
            }

        }

            private void chucvu_Load(object sender, EventArgs e)
        {
            sql = "select * from chucvu";
            dgvCV.DataSource = getData(sql);
            textId.Enabled = false;
        }

        private void textTimKiem_TextChanged(object sender, EventArgs e)
        {
            sql = "select * from chucvu WHERE ten LIKE '%" + textTimKiem.Text + "%' " +
                "OR mo_ta LIKE '%" + textTimKiem.Text + "%'";
            dgvCV.DataSource = getData(sql);
        }
    }
}
