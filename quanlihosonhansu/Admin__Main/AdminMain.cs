using quanlihosonhansu.Admin__chucvu;
using quanlihosonhansu.Admin__hosonhansu;
using quanlihosonhansu.Admin__kiluat_luong_khenthuong;
using quanlihosonhansu.Admin__phongban;
using quanlihosonhansu.Authentication;
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

        private void mdi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dangnhap dn = new dangnhap();
            this.Hide();
            dn.Show();
        }

        private void traCứuTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //xemTacGia frmtacgia2 = new xemTacGia();
            //frmtacgia2.MdiParent = this;
            //frmtacgia2.Show();
        }



        private void mdi_Load(object sender, EventArgs e)
        {

        }
        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýHồSơNhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hosonhansu hsms = new hosonhansu();
            hsms.MdiParent = this;
            hsms.Show();
        }

        private void điềuNhânSựVàoDựÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addNhanSuVaoDuAn ad = new addNhanSuVaoDuAn();
            ad.MdiParent = this;
            ad.Show();
        }

        private void quảnLýDựÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLDuAn qlda = new frmQLDuAn();
            qlda.MdiParent = this;
            qlda.Show();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLKhachHang qlkh = new frmQLKhachHang();
            qlkh.MdiParent= this;
            qlkh.Show();
        }

        private void phongban_Click(object sender, EventArgs e)
        {
            phongban pb = new phongban();
            pb.MdiParent = this;
            pb.Show();
        }

        private void chucvu_Click(object sender, EventArgs e)
        {
            chucvu cv = new chucvu();
            cv.MdiParent = this;
            cv.Show();
        }

        private void luong_Click(object sender, EventArgs e)
        {
            frmLuong lg = new frmLuong();
            lg.MdiParent = this;
            lg.Show();
        }
    }
}
