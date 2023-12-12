namespace quanlihosonhansu
{
    partial class frmQLDuAn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnTroLai = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMaDA = new TextBox();
            txtTenDA = new TextBox();
            txtMoTa = new TextBox();
            txtKhachHangID = new TextBox();
            txtTimKiem = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            dgvDA = new DataGridView();
            btnNhap = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDA).BeginInit();
            SuspendLayout();
            // 
            // btnTroLai
            // 
            btnTroLai.Image = Properties.Resources.backPic;
            btnTroLai.ImageAlign = ContentAlignment.MiddleLeft;
            btnTroLai.Location = new Point(12, 12);
            btnTroLai.Name = "btnTroLai";
            btnTroLai.Size = new Size(98, 45);
            btnTroLai.TabIndex = 0;
            btnTroLai.Text = "Trở lại ";
            btnTroLai.TextAlign = ContentAlignment.MiddleRight;
            btnTroLai.UseVisualStyleBackColor = true;
            btnTroLai.Click += btnTroLai_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(295, 42);
            label1.Name = "label1";
            label1.Size = new Size(199, 38);
            label1.TabIndex = 1;
            label1.Text = "Quản lý Dự Án";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 102);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 2;
            label2.Text = "Mã DA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(132, 153);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 3;
            label3.Text = "Tên DA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(456, 153);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 4;
            label4.Text = "Mã KH";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(456, 102);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 5;
            label5.Text = "Mô tả";
            // 
            // txtMaDA
            // 
            txtMaDA.Location = new Point(211, 99);
            txtMaDA.Name = "txtMaDA";
            txtMaDA.ReadOnly = true;
            txtMaDA.Size = new Size(199, 27);
            txtMaDA.TabIndex = 6;
            // 
            // txtTenDA
            // 
            txtTenDA.Location = new Point(211, 150);
            txtTenDA.Name = "txtTenDA";
            txtTenDA.Size = new Size(199, 27);
            txtTenDA.TabIndex = 7;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(517, 99);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(199, 27);
            txtMoTa.TabIndex = 8;
            // 
            // txtKhachHangID
            // 
            txtKhachHangID.Location = new Point(517, 150);
            txtKhachHangID.Name = "txtKhachHangID";
            txtKhachHangID.Size = new Size(199, 27);
            txtKhachHangID.TabIndex = 9;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(167, 200);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(170, 27);
            txtTimKiem.TabIndex = 11;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources.addPic;
            btnThem.ImageAlign = ContentAlignment.MiddleRight;
            btnThem.Location = new Point(456, 191);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(98, 45);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleLeft;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.updatePic;
            btnSua.ImageAlign = ContentAlignment.MiddleRight;
            btnSua.Location = new Point(560, 192);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(98, 45);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleLeft;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.deletePic;
            btnXoa.ImageAlign = ContentAlignment.MiddleRight;
            btnXoa.Location = new Point(664, 192);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(98, 45);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleLeft;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // dgvDA
            // 
            dgvDA.BackgroundColor = Color.White;
            dgvDA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDA.GridColor = Color.White;
            dgvDA.Location = new Point(47, 250);
            dgvDA.Name = "dgvDA";
            dgvDA.RowHeadersWidth = 51;
            dgvDA.RowTemplate.Height = 29;
            dgvDA.Size = new Size(734, 188);
            dgvDA.TabIndex = 15;
            dgvDA.CellContentClick += dgvDA_CellContentClick;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(352, 191);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(98, 45);
            btnNhap.TabIndex = 16;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(88, 204);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 17;
            label6.Text = "Tìm kiếm";
            // 
            // frmQLDuAn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 462);
            Controls.Add(label6);
            Controls.Add(btnNhap);
            Controls.Add(dgvDA);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtTimKiem);
            Controls.Add(txtKhachHangID);
            Controls.Add(txtMoTa);
            Controls.Add(txtTenDA);
            Controls.Add(txtMaDA);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnTroLai);
            Name = "frmQLDuAn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Quản lý dự án";
            FormClosing += frmQLDuAn_FormClosing;
            Load += frmQLDuAn_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTroLai;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMaDA;
        private TextBox txtTenDA;
        private TextBox txtMoTa;
        private TextBox txtKhachHangID;
        private TextBox txtTimKiem;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private DataGridView dgvDA;
        private Button btnNhap;
        private Label label6;
    }
}