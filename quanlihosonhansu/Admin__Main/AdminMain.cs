using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlihosonhansu
{
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void quảnLýNhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //QLNXB nxb = new QLNXB();
            //nxb.MdiParent = AdminMain.ActiveForm;
            //nxb.Show();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Debug.WriteLine(this.ActiveMdiChild);
            //TrangChu trangchu = new TrangChu();
            //trangchu.MdiParent = AdminMain.ActiveForm;
            //trangchu.Show();
        }

        private void quảnLýPhiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //mt_admin mtadmin = new mt_admin();
            //mtadmin.MdiParent = AdminMain.ActiveForm;
            //mtadmin.Show();
        }

        private void quảnLýPhiếuPhạtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pp_admin ppadmin = new pp_admin();
            //ppadmin.MdiParent = AdminMain.ActiveForm;
            //ppadmin.Show();
        }

        private void mdi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýThểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //QLTL qlyTL = new QLTL();
            //qlyTL.MdiParent = AdminMain.ActiveForm;
            //qlyTL.Show();
        }

        private void quảnLýĐầuSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //QLSach qlySach = new QLSach();
            //qlySach.MdiParent = AdminMain.ActiveForm;
            //qlySach.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đây là phần About!");
        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DangNhap dangnhap = new DangNhap();
            //this.Hide();
            //dangnhap.Show();
        }

        private void danhMụcTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //suaxoatg frmtacgia1 = new suaxoatg();
            //frmtacgia1.MdiParent = this;
            //frmtacgia1.Show();
        }

        private void traCứuTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //xemTacGia frmtacgia2 = new xemTacGia();
            //frmtacgia2.MdiParent = this;
            //frmtacgia2.Show();
        }

        private void xemThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //thongkeSach thongkeSach = new thongkeSach();
            //thongkeSach.MdiParent = this;
            //thongkeSach.Show();
        }

        private void xóaTàiKhoảnNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //XoaTaiKhoanUser deleteuser = new XoaTaiKhoanUser();
            //deleteuser.MdiParent = this;
            //deleteuser.Show();
        }

        private void mdi_Load(object sender, EventArgs e)
        {

        }
    }
}
