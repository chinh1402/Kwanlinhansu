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

namespace quanlihosonhansu.Admin__kiluat_luong_khenthuong
{
    public partial class frmLuong : Form
    {

        public frmLuong()
        {
            InitializeComponent();
        }
        SqlConnection conn = Connection.Connection.GetSqlConnection();
        private void frmLuong_Load(object sender, EventArgs e)
        {
            conn.Open();
            dgvLuong.DataSource = loadData("Select dbo.luong.id as id,dbo.luong.nhan_vien_id as NhanVienID, dbo.nhanvien.ho_ten as HoTen, dbo.luong.thang as Thang, dbo.luong.nam as Nam, dbo.luong.luong_co_ban as LuongCoBan , dbo.luong.he_so_luong as HeSoLuong,dbo.luong.luong_thuong as LuongThuong,dbo.luong.luong_phat, dbo.nhanvien.email, dbo.nhanvien.sdt as LuongPhat from dbo.luong INNER JOIN dbo.nhanvien ON dbo.luong.nhan_vien_id = dbo.nhanvien.id ORDER BY nhan_vien_id ASC");
            conn.Close();
        }
        DataTable loadData(string sql)
        {
            var cmd = new SqlCommand(sql, conn);
            var da = new SqlDataAdapter(cmd); // Lay du lieu
            var dt = new DataTable();
            da.Fill(dt); // Do du lieu vao bang dt
            da.Dispose(); // Giai phong
            return dt;
        }

        private void dgvLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLuong.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLuong.Rows[e.RowIndex];
                txtIDNV.Text = row.Cells[1].Value.ToString();
                txtThang.Text = row.Cells[3].Value.ToString();
                txtNam.Text = row.Cells[4].Value.ToString();
                txtHeSoLuong.Text = row.Cells[6].Value.ToString();
                txtLuongCoBan.Text = row.Cells[5].Value.ToString();
                txtLuongThuong.Text = row.Cells[7].Value.ToString();
                txtLuongPhat.Text = row.Cells[8].Value.ToString();

                txtTongNhan.Text = Convert.ToString(int.Parse(row.Cells[6].Value.ToString())
                                                    * int.Parse(row.Cells[5].Value.ToString())
                                                    + int.Parse(row.Cells[7].Value.ToString())
                                                    - int.Parse(row.Cells[8].Value.ToString()));
                txtEmail.Text = row.Cells[9].Value.ToString();
                txtSDT.Text = row.Cells[10].Value.ToString();

            }
        }



        private void btnThem_Click(object sender, EventArgs e)
        {


            if (txtIDNV.Text != "" && txtThang.Text != "" && txtNam.Text != ""
            && txtHeSoLuong.Text != "" && txtLuongCoBan.Text != "" && txtLuongThuong.Text != "" && txtLuongPhat.Text != "")
            {
                if (ktraTonTai() == false)
                {
                    if (txtTongNhan.Text == "") { btnKiemTra_Click(sender, e); return; };
                    String sql = "Insert Into dbo.luong(nhan_vien_id, thang, nam, he_so_luong, luong_co_ban, luong_thuong, luong_phat, tong_nhan) Values(@1, @2, @3, @4,@5,@6,@7,@8)";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.Add("@1", SqlDbType.Int).Value = Convert.ToInt32(txtIDNV.Text);
                    cmd.Parameters.Add("@2", SqlDbType.Int).Value = Convert.ToInt32(txtThang.Text);
                    cmd.Parameters.Add("@3", SqlDbType.Int).Value = Convert.ToInt32(txtNam.Text);
                    cmd.Parameters.Add("@4", SqlDbType.Int).Value = Convert.ToInt32(txtHeSoLuong.Text);
                    cmd.Parameters.Add("@5", SqlDbType.Int).Value = Convert.ToInt32(txtLuongCoBan.Text);
                    cmd.Parameters.Add("@6", SqlDbType.Int).Value = Convert.ToInt32(txtLuongThuong.Text);
                    cmd.Parameters.Add("@7", SqlDbType.Int).Value = Convert.ToInt32(txtLuongPhat.Text);
                    cmd.Parameters.Add("@8", SqlDbType.Int).Value = Convert.ToInt32(txtTongNhan.Text);

                    int result = cmd.ExecuteNonQuery();
                    dgvLuong.DataSource = loadData("Select dbo.luong.id as id,dbo.luong.nhan_vien_id as NhanVienID, dbo.nhanvien.ho_ten as HoTen, dbo.luong.thang as Thang, dbo.luong.nam as Nam, dbo.luong.luong_co_ban as LuongCoBan , dbo.luong.he_so_luong as HeSoLuong,dbo.luong.luong_thuong as LuongThuong,dbo.luong.luong_phat, dbo.nhanvien.email, dbo.nhanvien.sdt as LuongPhat from dbo.luong INNER JOIN dbo.nhanvien ON dbo.luong.nhan_vien_id = dbo.nhanvien.id ORDER BY nhan_vien_id ASC");

                    if (MessageBox.Show("Bạn có chắc muốn thêm khung lương vừa nhập?", "Thông Báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (result > 0)
                        {
                            MessageBox.Show("Bạn đã thêm khung lương thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtIDNV.Text = "";
                            txtThang.Text = "";
                            txtNam.Text = "";
                            txtHeSoLuong.Text = "";
                            txtLuongCoBan.Text = "";
                            txtLuongThuong.Text = "";
                            txtLuongPhat.Text = "";
                            txtTongNhan.Text = "";
                            txtEmail.Text = "";
                            txtSDT.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Bạn đã thêm khung lương không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Khung lương này đã tôn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin khung lương cần thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtIDNV.Text == "")
                {
                    txtIDNV.Focus();
                }
                else if (txtThang.Text == "")
                {
                    txtThang.Focus();
                }
                else if (txtNam.Text == "")
                {
                    txtNam.Focus();
                }
                else if (txtLuongCoBan.Text == "")
                {
                    txtLuongCoBan.Focus();
                }
                else if (txtHeSoLuong.Text == "")
                {
                    txtHeSoLuong.Focus();
                }
                else if (txtLuongPhat.Text == "")
                {
                    txtLuongPhat.Focus();
                }
                else if (txtLuongThuong.Text == "")
                {
                    txtLuongThuong.Focus();
                }
            }


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtIDNV.Text != "" && txtThang.Text != "" && txtNam.Text != ""
                && txtHeSoLuong.Text != "" && txtLuongCoBan.Text != "" && txtLuongThuong.Text != "" && txtLuongPhat.Text != "")
            {
                if (txtTongNhan.Text == "") { btnKiemTra_Click(sender, e); return; };
                string sql = "Update dbo.luong Set   he_so_luong = @4, luong_co_ban = @5, luong_thuong = @6, luong_phat = @7,tong_nhan = @8 Where nhan_vien_id = @1 and thang = @2 and nam = @3";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@1", SqlDbType.Int).Value = Convert.ToInt32(txtIDNV.Text);
                cmd.Parameters.Add("@2", SqlDbType.Int).Value = Convert.ToInt32(txtThang.Text);
                cmd.Parameters.Add("@3", SqlDbType.Int).Value = Convert.ToInt32(txtNam.Text);
                cmd.Parameters.Add("@4", SqlDbType.Int).Value = Convert.ToInt32(txtHeSoLuong.Text);
                cmd.Parameters.Add("@5", SqlDbType.Int).Value = Convert.ToInt32(txtLuongCoBan.Text);
                cmd.Parameters.Add("@6", SqlDbType.Int).Value = Convert.ToInt32(txtLuongThuong.Text);
                cmd.Parameters.Add("@7", SqlDbType.Int).Value = Convert.ToInt32(txtLuongPhat.Text);
                cmd.Parameters.Add("@8", SqlDbType.Int).Value = Convert.ToInt32(txtTongNhan.Text);
                int result = cmd.ExecuteNonQuery();
                dgvLuong.DataSource = loadData("Select dbo.luong.id as id,dbo.luong.nhan_vien_id as NhanVienID, dbo.nhanvien.ho_ten as HoTen, dbo.luong.thang as Thang, dbo.luong.nam as Nam, dbo.luong.luong_co_ban as LuongCoBan , dbo.luong.he_so_luong as HeSoLuong,dbo.luong.luong_thuong as LuongThuong,dbo.luong.luong_phat, dbo.nhanvien.email, dbo.nhanvien.sdt as LuongPhat from dbo.luong INNER JOIN dbo.nhanvien ON dbo.luong.nhan_vien_id = dbo.nhanvien.id ORDER BY nhan_vien_id ASC");

                if (MessageBox.Show("Bạn muốn sửa khung lương đang chọn với thông tin trên?", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (result > 0)
                    {
                        MessageBox.Show("Bạn đã sửa thông tin khung lương thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtIDNV.Text = "";
                        txtThang.Text = "";
                        txtNam.Text = "";
                        txtHeSoLuong.Text = "";
                        txtLuongCoBan.Text = "";
                        txtLuongThuong.Text = "";
                        txtLuongPhat.Text = "";
                        txtTongNhan.Text = "";
                        txtEmail.Text = "";
                        txtSDT.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã sửa thông tin khung lương không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Bạn cần chọn khung lương cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtIDNV.Text == "")
                {
                    txtIDNV.Focus();
                }
                else if (txtThang.Text == "")
                {
                    txtThang.Focus();
                }
                else if (txtNam.Text == "")
                {
                    txtNam.Focus();
                }
                else if (txtLuongCoBan.Text == "")
                {
                    txtLuongCoBan.Focus();
                }
                else if (txtHeSoLuong.Text == "")
                {
                    txtHeSoLuong.Focus();
                }
                else if (txtLuongPhat.Text == "")
                {
                    txtLuongPhat.Focus();
                }
                else if (txtLuongThuong.Text == "")
                {
                    txtLuongThuong.Focus();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete From dbo.luong Where nhan_vien_id = @1 and thang = @2 and nam = @3";
            conn.Open();
            if (txtIDNV.Text != "" && txtThang.Text != "" && txtNam.Text != ""
                && txtHeSoLuong.Text != "" && txtLuongCoBan.Text != "" && txtLuongThuong.Text != "" && txtLuongPhat.Text != "")
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@1", SqlDbType.Int).Value = Convert.ToInt32(txtIDNV.Text);
                cmd.Parameters.Add("@2", SqlDbType.Int).Value = Convert.ToInt32(txtThang.Text);
                cmd.Parameters.Add("@3", SqlDbType.Int).Value = Convert.ToInt32(txtNam.Text);

                if (MessageBox.Show("Bạn có muốn xóa khung lương đang chọn không?", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int result = cmd.ExecuteNonQuery();
                    dgvLuong.DataSource = loadData("Select dbo.luong.id as id,dbo.luong.nhan_vien_id as NhanVienID, dbo.nhanvien.ho_ten as HoTen, dbo.luong.thang as Thang, dbo.luong.nam as Nam, dbo.luong.luong_co_ban as LuongCoBan , dbo.luong.he_so_luong as HeSoLuong,dbo.luong.luong_thuong as LuongThuong,dbo.luong.luong_phat, dbo.nhanvien.email, dbo.nhanvien.sdt as LuongPhat from dbo.luong INNER JOIN dbo.nhanvien ON dbo.luong.nhan_vien_id = dbo.nhanvien.id ORDER BY nhan_vien_id ASC");
                    if (result > 0)
                    {
                        MessageBox.Show("Bạn đã xóa khung lương thành công!" , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtIDNV.Text = "";
                        txtThang.Text = "";
                        txtNam.Text = "";
                        txtHeSoLuong.Text = "";
                        txtLuongCoBan.Text = "";
                        txtLuongThuong.Text = "";
                        txtLuongPhat.Text = "";
                        txtTongNhan.Text = "";
                        txtEmail.Text = "";
                        txtSDT.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã xóa khung lương không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            conn.Close();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool ktraTonTai()
        {
            string kt = "Select dbo.luong.nhan_vien_id , dbo.luong.thang , dbo.luong.nam From dbo.luong Where nhan_vien_id = @1 and thang = @2 and nam = @3";
            conn.Open();

            SqlCommand cmd = new SqlCommand(kt, conn);
            cmd.Parameters.Add("@1", SqlDbType.Int).Value = Convert.ToInt32(txtIDNV.Text);
            cmd.Parameters.Add("@2", SqlDbType.Int).Value = Convert.ToInt32(txtThang.Text);
            cmd.Parameters.Add("@3", SqlDbType.Int).Value = Convert.ToInt32(txtNam.Text);

            int result = cmd.ExecuteScalar() as int? ?? 0; ;
            if (result > 0)
            {
                //MessageBox.Show("Khung lương này đã tôn tại!" + result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                return true;
            }
            else
            {
                //MessageBox.Show("Khung lương này chưa tôn tại!" + result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                return false;

            }


        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if (txtIDNV.Text != "" && txtThang.Text != "" && txtNam.Text != ""
            && txtHeSoLuong.Text != "" && txtLuongCoBan.Text != "" && txtLuongThuong.Text != "" && txtLuongPhat.Text != "")
            {

                //dien textbox email va sdt
                String sql = "Select  dbo.nhanvien.email, dbo.nhanvien.sdt from dbo.nhanvien where dbo.nhanvien.id = @1";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@1", SqlDbType.Int).Value = Convert.ToInt32(txtIDNV.Text);

                String sdt, email;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        sdt = (String)reader.GetValue(1);
                        email = (String)reader.GetValue(0);
                        txtEmail.Text = email;
                        txtSDT.Text = sdt;
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("ID nhân viên CHƯA TỒN TẠI!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                //dien textbox tong nhan
                txtTongNhan.Text = Convert.ToString(int.Parse(txtHeSoLuong.Text)
                                                * int.Parse(txtLuongCoBan.Text)
                                                + int.Parse(txtLuongThuong.Text)
                                                - int.Parse(txtLuongPhat.Text));


                conn.Close();

            }
            else
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin khung lương cần thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtIDNV.Text == "")
                {
                    txtIDNV.Focus();
                }
                else if (txtThang.Text == "")
                {
                    txtThang.Focus();
                }
                else if (txtNam.Text == "")
                {
                    txtNam.Focus();
                }
                else if (txtLuongCoBan.Text == "")
                {
                    txtLuongCoBan.Focus();
                }
                else if (txtHeSoLuong.Text == "")
                {
                    txtHeSoLuong.Focus();
                }
                else if (txtLuongPhat.Text == "")
                {
                    txtLuongPhat.Focus();
                }
                else if (txtLuongThuong.Text == "")
                {
                    txtLuongThuong.Focus();
                }
            }
        }
    }
}
