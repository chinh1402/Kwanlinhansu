namespace quanlihosonhansu.Admin__chucvu
{
    partial class chucvu
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
            this.dgvCV = new System.Windows.Forms.DataGridView();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textChucVu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textMoTa = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textTimKiem = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCV
            // 
            this.dgvCV.AllowUserToAddRows = false;
            this.dgvCV.AllowUserToDeleteRows = false;
            this.dgvCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCV.Location = new System.Drawing.Point(125, 221);
            this.dgvCV.Name = "dgvCV";
            this.dgvCV.ReadOnly = true;
            this.dgvCV.RowTemplate.Height = 25;
            this.dgvCV.Size = new System.Drawing.Size(288, 170);
            this.dgvCV.TabIndex = 0;
            this.dgvCV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCV_CellClick);
            // 
            // btnTroLai
            // 
            this.btnTroLai.Location = new System.Drawing.Point(12, 11);
            this.btnTroLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(82, 22);
            this.btnTroLai.TabIndex = 33;
            this.btnTroLai.Text = "Trở lại ";
            this.btnTroLai.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(135, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(198, 32);
            this.label15.TabIndex = 34;
            this.label15.Text = "Quản lý chức vụ";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(93, 91);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(40, 23);
            this.textId.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "Tên Chức vụ";
            // 
            // textChucVu
            // 
            this.textChucVu.Location = new System.Drawing.Point(258, 91);
            this.textChucVu.Name = "textChucVu";
            this.textChucVu.Size = new System.Drawing.Size(155, 23);
            this.textChucVu.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "Mô tả";
            // 
            // textMoTa
            // 
            this.textMoTa.Location = new System.Drawing.Point(93, 131);
            this.textMoTa.Name = "textMoTa";
            this.textMoTa.Size = new System.Drawing.Size(320, 47);
            this.textMoTa.TabIndex = 40;
            this.textMoTa.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 42;
            this.label4.Text = "Tìm kiếm";
            // 
            // textTimKiem
            // 
            this.textTimKiem.Location = new System.Drawing.Point(214, 188);
            this.textTimKiem.Name = "textTimKiem";
            this.textTimKiem.Size = new System.Drawing.Size(200, 23);
            this.textTimKiem.TabIndex = 41;
            this.textTimKiem.TextChanged += new System.EventHandler(this.textTimKiem_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(44, 231);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 43);
            this.btnThem.TabIndex = 43;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(44, 280);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 43);
            this.btnSua.TabIndex = 44;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(44, 329);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 43);
            this.btnXoa.TabIndex = 45;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // chucvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 419);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textTimKiem);
            this.Controls.Add(this.textMoTa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textChucVu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.dgvCV);
            this.Name = "chucvu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "chucvu";
            this.Load += new System.EventHandler(this.chucvu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvCV;
        private Button btnTroLai;
        private Label label15;
        private TextBox textId;
        private Label label1;
        private Label label2;
        private TextBox textChucVu;
        private Label label3;
        private RichTextBox textMoTa;
        private Label label4;
        private TextBox textTimKiem;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
    }
}