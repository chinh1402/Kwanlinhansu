namespace quanlihosonhansu.Admin__hosonhansu
{
    partial class addNhanSuVaoDuAn
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
            this.dgvDuAn = new System.Windows.Forms.DataGridView();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtSearchDA = new System.Windows.Forms.TextBox();
            this.txtSearchNS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvNVDA = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNVDA)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDuAn
            // 
            this.dgvDuAn.AllowUserToAddRows = false;
            this.dgvDuAn.AllowUserToDeleteRows = false;
            this.dgvDuAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuAn.Location = new System.Drawing.Point(60, 125);
            this.dgvDuAn.Name = "dgvDuAn";
            this.dgvDuAn.ReadOnly = true;
            this.dgvDuAn.RowTemplate.Height = 25;
            this.dgvDuAn.Size = new System.Drawing.Size(374, 164);
            this.dgvDuAn.TabIndex = 0;
            this.dgvDuAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDuAn_CellClick);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(522, 125);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowTemplate.Height = 25;
            this.dgvNhanVien.Size = new System.Drawing.Size(342, 332);
            this.dgvNhanVien.TabIndex = 1;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(294, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(296, 32);
            this.label15.TabIndex = 31;
            this.label15.Text = "Thêm nhân sự vào dự án";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // btnTroLai
            // 
            this.btnTroLai.Location = new System.Drawing.Point(12, 11);
            this.btnTroLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(82, 22);
            this.btnTroLai.TabIndex = 32;
            this.btnTroLai.Text = "Trở lại ";
            this.btnTroLai.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(522, 472);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 45);
            this.btnThem.TabIndex = 33;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(359, 472);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 45);
            this.btnXoa.TabIndex = 34;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtSearchDA
            // 
            this.txtSearchDA.Location = new System.Drawing.Point(155, 90);
            this.txtSearchDA.Name = "txtSearchDA";
            this.txtSearchDA.Size = new System.Drawing.Size(279, 23);
            this.txtSearchDA.TabIndex = 37;
            this.txtSearchDA.TextChanged += new System.EventHandler(this.txtSearchDA_TextChanged);
            // 
            // txtSearchNS
            // 
            this.txtSearchNS.Location = new System.Drawing.Point(624, 87);
            this.txtSearchNS.Name = "txtSearchNS";
            this.txtSearchNS.Size = new System.Drawing.Size(240, 23);
            this.txtSearchNS.TabIndex = 38;
            this.txtSearchNS.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "Tìm kiếm dự án";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 40;
            this.label4.Text = "Tìm kiếm nhân sự";
            // 
            // dgvNVDA
            // 
            this.dgvNVDA.AllowUserToAddRows = false;
            this.dgvNVDA.AllowUserToDeleteRows = false;
            this.dgvNVDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNVDA.Location = new System.Drawing.Point(60, 337);
            this.dgvNVDA.Name = "dgvNVDA";
            this.dgvNVDA.ReadOnly = true;
            this.dgvNVDA.RowTemplate.Height = 25;
            this.dgvNVDA.Size = new System.Drawing.Size(374, 120);
            this.dgvNVDA.TabIndex = 41;
            this.dgvNVDA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNVDA_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "Nhân viên trong dự án";
            // 
            // addNhanSuVaoDuAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNVDA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearchNS);
            this.Controls.Add(this.txtSearchDA);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.dgvDuAn);
            this.Name = "addNhanSuVaoDuAn";
            this.Text = "addNhanSuVaoDuAn";
            this.Load += new System.EventHandler(this.addNhanSuVaoDuAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNVDA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvDuAn;
        private DataGridView dgvNhanVien;
        private Label label15;
        private Button btnTroLai;
        private Button btnThem;
        private Button btnXoa;
        private TextBox txtSearchDA;
        private TextBox txtSearchNS;
        private Label label3;
        private Label label4;
        private DataGridView dgvNVDA;
        private Label label1;
    }
}