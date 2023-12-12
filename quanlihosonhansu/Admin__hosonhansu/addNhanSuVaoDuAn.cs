using quanlihosonhansu.Admin__hosonhansu.Functions;
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
using System.Xml.Linq;

namespace quanlihosonhansu.Admin__hosonhansu
{
    public partial class addNhanSuVaoDuAn : Form
    {
        string sql = "";
        SqlConnection conn = Connection.Connection.GetSqlConnection();
        SqlCommand cmd;
        DataTable dt;
        string idNhanVienGlobal = "-1";
        string idDuAnGlobal;
        string idNVDAGlobal = "-1"; 
        public addNhanSuVaoDuAn()
        {
            InitializeComponent();
        }
        private bool checkIfDuplicated()
        {
            sql = "Select * from nhanvien_duan where nhanvien_id ='" + idNhanVienGlobal + "'" +
                " AND duan_id = '" + idDuAnGlobal + "'";
            dt = Getdata.getData(sql);
            if (dt.Rows.Count > 0) {
                return true;
            }
            return false;
        }

        private void addNhanSuVaoDuAn_Load(object sender, EventArgs e)
        {
            sql = "Select * from duan";
            dgvDuAn.DataSource = Getdata.getData(sql);

            sql = "SELECT n.id, n.ho_ten, n.ngay_sinh, " +
              "CASE n.gioi_tinh " +
              "   WHEN '0' THEN 'male' " +
              "   WHEN '1' THEN 'female' " +
              "   WHEN '2' THEN 'other' " +
              "   ELSE 'unknown' END AS gioi_tinh, " +
              "n.email, n.sdt, n.dia_chi, n.ngay_tham_gia, n.luong_co_ban, n.he_so_luong, " +
              "p.ten AS phong_ban_ten, n.trang_thai " +
              "FROM nhanvien n " +
              "INNER JOIN phongban p ON n.phong_ban_id = p.id";
            dgvNhanVien.DataSource = Getdata.getData(sql);

            dgvDuAn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNVDA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT n.id, n.ho_ten, n.ngay_sinh, " +
              "CASE n.gioi_tinh " +
              "   WHEN '0' THEN 'male' " +
              "   WHEN '1' THEN 'female' " +
              "   WHEN '2' THEN 'other' " +
              "   ELSE 'unknown' END AS gioi_tinh, " +
              "n.email, n.sdt, n.dia_chi, n.ngay_tham_gia, n.luong_co_ban, n.he_so_luong, " +
              "p.ten AS phong_ban_ten, n.trang_thai " +
              "FROM nhanvien n " +
              "INNER JOIN phongban p ON n.phong_ban_id = p.id " +
              "WHERE n.ho_ten LIKE '%" + txtSearchNS.Text + "%'";

            dt = Getdata.getData(sql);
            dgvNhanVien.DataSource = dt;
        }

        private void txtSearchDA_TextChanged(object sender, EventArgs e)
        {
            sql = "Select * from duan WHERE ten LIKE '%" + txtSearchDA.Text + "%'";
            dt = Getdata.getData(sql);
            dgvDuAn.DataSource = Getdata.getData(sql);
        }

        private void dgvDuAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int i;
            i = e.RowIndex;

            if (i >= 0)
            {
                // handling texts and datetime
                idDuAnGlobal = dgvDuAn.Rows[i].Cells[0].Value.ToString();
                sql = "Select nd.id, n.ho_ten, n.email, n.sdt, n.ngay_tham_gia from nhanvien_duan as nd, nhanvien as n where nd.duan_id = " + idDuAnGlobal + " " +
                    "AND nd.nhanvien_id = n.id";
                dgvNVDA.DataSource = Getdata.getData(sql);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (idNhanVienGlobal != "-1")
            {
                if (!checkIfDuplicated())
                {
                    if (MessageBox.Show("Bạn có muốn thêm không ?", "Thông Báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        conn.Open();
                        sql = "INSERT INTO nhanvien_duan (nhanvien_id, duan_id) " +
                            "VALUES ('" + idNhanVienGlobal + "','" + idDuAnGlobal + "')";
                        cmd = conn.CreateCommand();
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        sql = "Select nd.id, n.ho_ten, n.email, n.sdt, n.ngay_tham_gia from nhanvien_duan as nd, nhanvien as n where nd.duan_id = " + idDuAnGlobal + " " +
                            "AND nd.nhanvien_id = n.id";
                        dgvNVDA.DataSource = Getdata.getData(sql);

                        MessageBox.Show("Success!");
                    }
                } else
                {
                    MessageBox.Show("Da co nhan vien trong du an");
                }
                    
            }
            else
            {
                MessageBox.Show("Hay chon nhan vien ban muon xoa khoi du an");
            }

        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;

            if (i >= 0)
            {
                // handling texts and datetime
                idNhanVienGlobal = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            }
        }

        private void dgvNVDA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;

            if (i >= 0)
            {
                // handling texts and datetime
                idNVDAGlobal = dgvNVDA.Rows[i].Cells[0].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (idNVDAGlobal != "-1")
            {
                if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                        conn.Open();
                        sql = "DELETE FROM nhanvien_duan " +
                            "WHERE id = '" + idNVDAGlobal + "'";
                        cmd = conn.CreateCommand();
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        idNVDAGlobal = "-1";

                        sql = "Select nd.id, n.ho_ten, n.email, n.sdt, n.ngay_tham_gia from nhanvien_duan as nd, nhanvien as n where nd.duan_id = " + idDuAnGlobal + " " +
                            "AND nd.nhanvien_id = n.id";
                        dgvNVDA.DataSource = Getdata.getData(sql);

                        MessageBox.Show("Success!");
                }
            } else
            {
                MessageBox.Show("Hay chon nhan vien ban muon xoa khoi du an");
            }
        }
    }
}
