namespace quanlihosonhansu.User__things
{
    partial class UserForm
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
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.functionFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.resetButton = new System.Windows.Forms.Button();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doiMatKhauStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenu = new System.Windows.Forms.MenuStrip();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lấyThôngTinNgườiĐầuTiênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iDNgườiĐăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tongLuongThucNhanTable = new System.Windows.Forms.TableLayoutPanel();
            this.tongLuongLabel = new System.Windows.Forms.Label();
            this.tongLuongHienThiLabel = new System.Windows.Forms.Label();
            this.chiTietLuongTable = new System.Windows.Forms.TableLayoutPanel();
            this.quyLabel = new System.Windows.Forms.Label();
            this.luongCoBanLabel = new System.Windows.Forms.Label();
            this.heSoLuong = new System.Windows.Forms.Label();
            this.luongThuongLabel = new System.Windows.Forms.Label();
            this.luongPhatLabel = new System.Windows.Forms.Label();
            this.hienThiLuongLabel = new System.Windows.Forms.Label();
            this.hienThiHSLuongLabel = new System.Windows.Forms.Label();
            this.hienThiLuongThuongLabel = new System.Windows.Forms.Label();
            this.hienThiLuongPhatLabel = new System.Windows.Forms.Label();
            this.projectDataGridView = new System.Windows.Forms.DataGridView();
            this.thongTinTable = new System.Windows.Forms.TableLayoutPanel();
            this.gioiTinhLabel = new System.Windows.Forms.Label();
            this.phongBanLabel = new System.Windows.Forms.Label();
            this.chucVuLabel = new System.Windows.Forms.Label();
            this.diaChiLabel = new System.Windows.Forms.Label();
            this.sdtLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.hoTenTextBox = new System.Windows.Forms.TextBox();
            this.ngaySinhLabel = new System.Windows.Forms.Label();
            this.hoTenLabel = new System.Windows.Forms.Label();
            this.ngaySinhTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.soDienThoaiTextBox = new System.Windows.Forms.TextBox();
            this.diaChiTextBox = new System.Windows.Forms.TextBox();
            this.chucVuTextBox = new System.Windows.Forms.TextBox();
            this.phongBanTextBox = new System.Windows.Forms.TextBox();
            this.gioiTinhComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ngayThamGiaTextBox = new System.Windows.Forms.TextBox();
            this.trangThaiTextBox = new System.Windows.Forms.TextBox();
            this.ngayThamGiaLabel = new System.Windows.Forms.Label();
            this.trangThaiLabel = new System.Windows.Forms.Label();
            this.luongTable = new System.Windows.Forms.TableLayoutPanel();
            this.functionFlowPanel.SuspendLayout();
            this.stripMenu.SuspendLayout();
            this.tongLuongThucNhanTable.SuspendLayout();
            this.chiTietLuongTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataGridView)).BeginInit();
            this.thongTinTable.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.luongTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Transparent;
            this.saveButton.Enabled = false;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Image = global::quanlihosonhansu.Properties.Resources.saveIcon;
            this.saveButton.Location = new System.Drawing.Point(5, 5);
            this.saveButton.Margin = new System.Windows.Forms.Padding(5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(127, 39);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Lưu thay đổi";
            this.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Image = global::quanlihosonhansu.Properties.Resources.eraserIcon;
            this.deleteButton.Location = new System.Drawing.Point(140, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(127, 39);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Xóa tất cả";
            this.deleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // functionFlowPanel
            // 
            this.functionFlowPanel.AutoSize = true;
            this.functionFlowPanel.Controls.Add(this.saveButton);
            this.functionFlowPanel.Controls.Add(this.deleteButton);
            this.functionFlowPanel.Controls.Add(this.resetButton);
            this.functionFlowPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.functionFlowPanel.Location = new System.Drawing.Point(15, 24);
            this.functionFlowPanel.Margin = new System.Windows.Forms.Padding(5);
            this.functionFlowPanel.Name = "functionFlowPanel";
            this.functionFlowPanel.Size = new System.Drawing.Size(1016, 49);
            this.functionFlowPanel.TabIndex = 4;
            // 
            // resetButton
            // 
            this.resetButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.resetButton.BackColor = System.Drawing.Color.Transparent;
            this.resetButton.Enabled = false;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetButton.Image = global::quanlihosonhansu.Properties.Resources.resetICon;
            this.resetButton.Location = new System.Drawing.Point(273, 5);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(132, 39);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Đặt lại thay đổi";
            this.resetButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doiMatKhauStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinCáNhânToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin";
            // 
            // doiMatKhauStripMenuItem
            // 
            this.doiMatKhauStripMenuItem.Name = "doiMatKhauStripMenuItem";
            this.doiMatKhauStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.doiMatKhauStripMenuItem.Text = "Đổi mật khẩu";
            this.doiMatKhauStripMenuItem.Click += new System.EventHandler(this.doiMatKhauStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // stripMenu
            // 
            this.stripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.stripMenu.Location = new System.Drawing.Point(15, 0);
            this.stripMenu.Name = "stripMenu";
            this.stripMenu.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.stripMenu.Size = new System.Drawing.Size(1016, 24);
            this.stripMenu.TabIndex = 3;
            this.stripMenu.Text = "menuStrip1";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lấyThôngTinNgườiĐầuTiênToolStripMenuItem,
            this.iDNgườiĐăngNhậpToolStripMenuItem});
            this.debugToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // lấyThôngTinNgườiĐầuTiênToolStripMenuItem
            // 
            this.lấyThôngTinNgườiĐầuTiênToolStripMenuItem.Name = "lấyThôngTinNgườiĐầuTiênToolStripMenuItem";
            this.lấyThôngTinNgườiĐầuTiênToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.lấyThôngTinNgườiĐầuTiênToolStripMenuItem.Text = "Lấy thông tin người đầu tiên";
            this.lấyThôngTinNgườiĐầuTiênToolStripMenuItem.Click += new System.EventHandler(this.lấyThôngTinNgườiĐầuTiênToolStripMenuItem_Click);
            // 
            // iDNgườiĐăngNhậpToolStripMenuItem
            // 
            this.iDNgườiĐăngNhậpToolStripMenuItem.Name = "iDNgườiĐăngNhậpToolStripMenuItem";
            this.iDNgườiĐăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.iDNgườiĐăngNhậpToolStripMenuItem.Text = "ID người đăng nhập";
            this.iDNgườiĐăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.iDNgườiĐăngNhậpToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.88035F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.70655F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.70655F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.70655F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(508, 3);
            this.panel1.Name = "panel1";
            this.luongTable.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(1, 332);
            this.panel1.TabIndex = 11;
            // 
            // tongLuongThucNhanTable
            // 
            this.tongLuongThucNhanTable.BackColor = System.Drawing.Color.Transparent;
            this.tongLuongThucNhanTable.ColumnCount = 3;
            this.tongLuongThucNhanTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.50235F));
            this.tongLuongThucNhanTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.49765F));
            this.tongLuongThucNhanTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tongLuongThucNhanTable.Controls.Add(this.tongLuongLabel, 0, 0);
            this.tongLuongThucNhanTable.Controls.Add(this.tongLuongHienThiLabel, 1, 0);
            this.tongLuongThucNhanTable.Location = new System.Drawing.Point(3, 299);
            this.tongLuongThucNhanTable.Name = "tongLuongThucNhanTable";
            this.tongLuongThucNhanTable.RowCount = 1;
            this.tongLuongThucNhanTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tongLuongThucNhanTable.Size = new System.Drawing.Size(499, 36);
            this.tongLuongThucNhanTable.TabIndex = 10;
            // 
            // tongLuongLabel
            // 
            this.tongLuongLabel.AutoSize = true;
            this.tongLuongLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tongLuongLabel.Location = new System.Drawing.Point(3, 0);
            this.tongLuongLabel.Name = "tongLuongLabel";
            this.tongLuongLabel.Size = new System.Drawing.Size(233, 23);
            this.tongLuongLabel.TabIndex = 0;
            this.tongLuongLabel.Text = "Tổng Lương Thực Nhận";
            // 
            // tongLuongHienThiLabel
            // 
            this.tongLuongHienThiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tongLuongHienThiLabel.AutoSize = true;
            this.tongLuongHienThiLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tongLuongHienThiLabel.Location = new System.Drawing.Point(392, 0);
            this.tongLuongHienThiLabel.Name = "tongLuongHienThiLabel";
            this.tongLuongHienThiLabel.Size = new System.Drawing.Size(68, 23);
            this.tongLuongHienThiLabel.TabIndex = 1;
            this.tongLuongHienThiLabel.Text = "label1";
            // 
            // chiTietLuongTable
            // 
            this.chiTietLuongTable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chiTietLuongTable.BackColor = System.Drawing.Color.Transparent;
            this.chiTietLuongTable.ColumnCount = 3;
            this.chiTietLuongTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.chiTietLuongTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.12024F));
            this.chiTietLuongTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.613226F));
            this.chiTietLuongTable.Controls.Add(this.quyLabel, 0, 0);
            this.chiTietLuongTable.Controls.Add(this.luongCoBanLabel, 0, 1);
            this.chiTietLuongTable.Controls.Add(this.heSoLuong, 0, 2);
            this.chiTietLuongTable.Controls.Add(this.luongThuongLabel, 0, 3);
            this.chiTietLuongTable.Controls.Add(this.luongPhatLabel, 0, 4);
            this.chiTietLuongTable.Controls.Add(this.hienThiLuongLabel, 1, 1);
            this.chiTietLuongTable.Controls.Add(this.hienThiHSLuongLabel, 1, 2);
            this.chiTietLuongTable.Controls.Add(this.hienThiLuongThuongLabel, 1, 3);
            this.chiTietLuongTable.Controls.Add(this.hienThiLuongPhatLabel, 1, 4);
            this.chiTietLuongTable.Location = new System.Drawing.Point(3, 9);
            this.chiTietLuongTable.Name = "chiTietLuongTable";
            this.chiTietLuongTable.RowCount = 5;
            this.chiTietLuongTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.chiTietLuongTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.chiTietLuongTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.chiTietLuongTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.chiTietLuongTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.chiTietLuongTable.Size = new System.Drawing.Size(499, 278);
            this.chiTietLuongTable.TabIndex = 6;
            // 
            // quyLabel
            // 
            this.quyLabel.AutoSize = true;
            this.quyLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quyLabel.Location = new System.Drawing.Point(3, 0);
            this.quyLabel.Name = "quyLabel";
            this.quyLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.quyLabel.Size = new System.Drawing.Size(44, 24);
            this.quyLabel.TabIndex = 0;
            this.quyLabel.Text = "QUÝ";
            // 
            // luongCoBanLabel
            // 
            this.luongCoBanLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.luongCoBanLabel.AutoSize = true;
            this.luongCoBanLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.luongCoBanLabel.Location = new System.Drawing.Point(3, 74);
            this.luongCoBanLabel.Name = "luongCoBanLabel";
            this.luongCoBanLabel.Size = new System.Drawing.Size(86, 16);
            this.luongCoBanLabel.TabIndex = 1;
            this.luongCoBanLabel.Text = "Lương Cơ Bản";
            // 
            // heSoLuong
            // 
            this.heSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.heSoLuong.AutoSize = true;
            this.heSoLuong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.heSoLuong.Location = new System.Drawing.Point(3, 129);
            this.heSoLuong.Name = "heSoLuong";
            this.heSoLuong.Size = new System.Drawing.Size(80, 16);
            this.heSoLuong.TabIndex = 2;
            this.heSoLuong.Text = "Hệ Số Lương";
            // 
            // luongThuongLabel
            // 
            this.luongThuongLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.luongThuongLabel.AutoSize = true;
            this.luongThuongLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.luongThuongLabel.Location = new System.Drawing.Point(3, 184);
            this.luongThuongLabel.Name = "luongThuongLabel";
            this.luongThuongLabel.Size = new System.Drawing.Size(90, 16);
            this.luongThuongLabel.TabIndex = 3;
            this.luongThuongLabel.Text = "Lương Thưởng";
            // 
            // luongPhatLabel
            // 
            this.luongPhatLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.luongPhatLabel.AutoSize = true;
            this.luongPhatLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.luongPhatLabel.Location = new System.Drawing.Point(3, 241);
            this.luongPhatLabel.Name = "luongPhatLabel";
            this.luongPhatLabel.Size = new System.Drawing.Size(71, 16);
            this.luongPhatLabel.TabIndex = 4;
            this.luongPhatLabel.Text = "Lương Phạt";
            // 
            // hienThiLuongLabel
            // 
            this.hienThiLuongLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.hienThiLuongLabel.AutoSize = true;
            this.hienThiLuongLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hienThiLuongLabel.Location = new System.Drawing.Point(417, 74);
            this.hienThiLuongLabel.Name = "hienThiLuongLabel";
            this.hienThiLuongLabel.Size = new System.Drawing.Size(45, 16);
            this.hienThiLuongLabel.TabIndex = 5;
            this.hienThiLuongLabel.Text = "label6";
            // 
            // hienThiHSLuongLabel
            // 
            this.hienThiHSLuongLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.hienThiHSLuongLabel.AutoSize = true;
            this.hienThiHSLuongLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hienThiHSLuongLabel.Location = new System.Drawing.Point(417, 129);
            this.hienThiHSLuongLabel.Name = "hienThiHSLuongLabel";
            this.hienThiHSLuongLabel.Size = new System.Drawing.Size(45, 17);
            this.hienThiHSLuongLabel.TabIndex = 6;
            this.hienThiHSLuongLabel.Text = "label7";
            // 
            // hienThiLuongThuongLabel
            // 
            this.hienThiLuongThuongLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.hienThiLuongThuongLabel.AutoSize = true;
            this.hienThiLuongThuongLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hienThiLuongThuongLabel.Location = new System.Drawing.Point(417, 184);
            this.hienThiLuongThuongLabel.Name = "hienThiLuongThuongLabel";
            this.hienThiLuongThuongLabel.Size = new System.Drawing.Size(45, 16);
            this.hienThiLuongThuongLabel.TabIndex = 7;
            this.hienThiLuongThuongLabel.Text = "label8";
            // 
            // hienThiLuongPhatLabel
            // 
            this.hienThiLuongPhatLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.hienThiLuongPhatLabel.AutoSize = true;
            this.hienThiLuongPhatLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hienThiLuongPhatLabel.Location = new System.Drawing.Point(417, 240);
            this.hienThiLuongPhatLabel.Name = "hienThiLuongPhatLabel";
            this.hienThiLuongPhatLabel.Size = new System.Drawing.Size(45, 17);
            this.hienThiLuongPhatLabel.TabIndex = 8;
            this.hienThiLuongPhatLabel.Text = "label9";
            // 
            // projectDataGridView
            // 
            this.projectDataGridView.AllowUserToAddRows = false;
            this.projectDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.projectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luongTable.SetColumnSpan(this.projectDataGridView, 3);
            this.projectDataGridView.Location = new System.Drawing.Point(3, 341);
            this.projectDataGridView.Name = "projectDataGridView";
            this.projectDataGridView.ReadOnly = true;
            this.projectDataGridView.RowHeadersVisible = false;
            this.projectDataGridView.RowHeadersWidth = 51;
            this.projectDataGridView.RowTemplate.Height = 25;
            this.projectDataGridView.Size = new System.Drawing.Size(1004, 138);
            this.projectDataGridView.TabIndex = 4;
            // 
            // thongTinTable
            // 
            this.thongTinTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thongTinTable.BackColor = System.Drawing.Color.Transparent;
            this.thongTinTable.ColumnCount = 2;
            this.thongTinTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.thongTinTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.thongTinTable.Controls.Add(this.gioiTinhLabel, 0, 2);
            this.thongTinTable.Controls.Add(this.phongBanLabel, 0, 9);
            this.thongTinTable.Controls.Add(this.chucVuLabel, 0, 8);
            this.thongTinTable.Controls.Add(this.diaChiLabel, 0, 6);
            this.thongTinTable.Controls.Add(this.sdtLabel, 0, 5);
            this.thongTinTable.Controls.Add(this.emailLabel, 0, 4);
            this.thongTinTable.Controls.Add(this.hoTenTextBox, 1, 0);
            this.thongTinTable.Controls.Add(this.ngaySinhLabel, 0, 1);
            this.thongTinTable.Controls.Add(this.hoTenLabel, 0, 0);
            this.thongTinTable.Controls.Add(this.ngaySinhTextBox, 1, 1);
            this.thongTinTable.Controls.Add(this.emailTextBox, 1, 4);
            this.thongTinTable.Controls.Add(this.soDienThoaiTextBox, 1, 5);
            this.thongTinTable.Controls.Add(this.diaChiTextBox, 1, 6);
            this.thongTinTable.Controls.Add(this.chucVuTextBox, 1, 8);
            this.thongTinTable.Controls.Add(this.phongBanTextBox, 1, 9);
            this.thongTinTable.Controls.Add(this.gioiTinhComboBox, 1, 2);
            this.thongTinTable.Location = new System.Drawing.Point(513, 3);
            this.thongTinTable.Name = "thongTinTable";
            this.thongTinTable.RowCount = 10;
            this.thongTinTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.thongTinTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.thongTinTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.thongTinTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.thongTinTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.thongTinTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.thongTinTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.thongTinTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.thongTinTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.thongTinTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.thongTinTable.Size = new System.Drawing.Size(500, 290);
            this.thongTinTable.TabIndex = 1;
            // 
            // gioiTinhLabel
            // 
            this.gioiTinhLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gioiTinhLabel.AutoSize = true;
            this.gioiTinhLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gioiTinhLabel.Location = new System.Drawing.Point(3, 65);
            this.gioiTinhLabel.Name = "gioiTinhLabel";
            this.gioiTinhLabel.Size = new System.Drawing.Size(54, 14);
            this.gioiTinhLabel.TabIndex = 2;
            this.gioiTinhLabel.Text = "Giới Tính";
            this.gioiTinhLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // phongBanLabel
            // 
            this.phongBanLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.phongBanLabel.AutoSize = true;
            this.phongBanLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phongBanLabel.Location = new System.Drawing.Point(3, 268);
            this.phongBanLabel.Name = "phongBanLabel";
            this.phongBanLabel.Size = new System.Drawing.Size(66, 14);
            this.phongBanLabel.TabIndex = 7;
            this.phongBanLabel.Text = "Phòng Ban";
            this.phongBanLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chucVuLabel
            // 
            this.chucVuLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chucVuLabel.AutoSize = true;
            this.chucVuLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chucVuLabel.Location = new System.Drawing.Point(3, 239);
            this.chucVuLabel.Name = "chucVuLabel";
            this.chucVuLabel.Size = new System.Drawing.Size(54, 14);
            this.chucVuLabel.TabIndex = 6;
            this.chucVuLabel.Text = "Chức Vụ";
            this.chucVuLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // diaChiLabel
            // 
            this.diaChiLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.diaChiLabel.AutoSize = true;
            this.diaChiLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diaChiLabel.Location = new System.Drawing.Point(3, 181);
            this.diaChiLabel.Name = "diaChiLabel";
            this.diaChiLabel.Size = new System.Drawing.Size(43, 14);
            this.diaChiLabel.TabIndex = 5;
            this.diaChiLabel.Text = "Địa Chỉ";
            this.diaChiLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sdtLabel
            // 
            this.sdtLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sdtLabel.AutoSize = true;
            this.sdtLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sdtLabel.Location = new System.Drawing.Point(3, 152);
            this.sdtLabel.Name = "sdtLabel";
            this.sdtLabel.Size = new System.Drawing.Size(83, 14);
            this.sdtLabel.TabIndex = 4;
            this.sdtLabel.Text = "Số Điện Thoại";
            this.sdtLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.Location = new System.Drawing.Point(3, 123);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(34, 14);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // hoTenTextBox
            // 
            this.hoTenTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hoTenTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.hoTenTextBox.Enabled = false;
            this.hoTenTextBox.Location = new System.Drawing.Point(103, 3);
            this.hoTenTextBox.Name = "hoTenTextBox";
            this.hoTenTextBox.ReadOnly = true;
            this.hoTenTextBox.Size = new System.Drawing.Size(393, 23);
            this.hoTenTextBox.TabIndex = 8;
            // 
            // ngaySinhLabel
            // 
            this.ngaySinhLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ngaySinhLabel.AutoSize = true;
            this.ngaySinhLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ngaySinhLabel.Location = new System.Drawing.Point(3, 36);
            this.ngaySinhLabel.Name = "ngaySinhLabel";
            this.ngaySinhLabel.Size = new System.Drawing.Size(61, 14);
            this.ngaySinhLabel.TabIndex = 1;
            this.ngaySinhLabel.Text = "Ngày Sinh";
            this.ngaySinhLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // hoTenLabel
            // 
            this.hoTenLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.hoTenLabel.AutoSize = true;
            this.hoTenLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hoTenLabel.Location = new System.Drawing.Point(3, 7);
            this.hoTenLabel.Name = "hoTenLabel";
            this.hoTenLabel.Size = new System.Drawing.Size(48, 14);
            this.hoTenLabel.TabIndex = 9;
            this.hoTenLabel.Text = "Họ Tên";
            // 
            // ngaySinhTextBox
            // 
            this.ngaySinhTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ngaySinhTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ngaySinhTextBox.Enabled = false;
            this.ngaySinhTextBox.Location = new System.Drawing.Point(103, 32);
            this.ngaySinhTextBox.Name = "ngaySinhTextBox";
            this.ngaySinhTextBox.ReadOnly = true;
            this.ngaySinhTextBox.Size = new System.Drawing.Size(393, 23);
            this.ngaySinhTextBox.TabIndex = 10;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailTextBox.Location = new System.Drawing.Point(103, 119);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(393, 23);
            this.emailTextBox.TabIndex = 12;
            this.emailTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // soDienThoaiTextBox
            // 
            this.soDienThoaiTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.soDienThoaiTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.soDienThoaiTextBox.Location = new System.Drawing.Point(103, 148);
            this.soDienThoaiTextBox.Name = "soDienThoaiTextBox";
            this.soDienThoaiTextBox.Size = new System.Drawing.Size(393, 23);
            this.soDienThoaiTextBox.TabIndex = 13;
            this.soDienThoaiTextBox.Leave += new System.EventHandler(this.soDienThoaiTextBox_Leave);
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.diaChiTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diaChiTextBox.Location = new System.Drawing.Point(103, 177);
            this.diaChiTextBox.Name = "diaChiTextBox";
            this.diaChiTextBox.Size = new System.Drawing.Size(393, 23);
            this.diaChiTextBox.TabIndex = 14;
            this.diaChiTextBox.Leave += new System.EventHandler(this.diaChiTextBox_Leave);
            // 
            // chucVuTextBox
            // 
            this.chucVuTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chucVuTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.chucVuTextBox.Enabled = false;
            this.chucVuTextBox.Location = new System.Drawing.Point(103, 235);
            this.chucVuTextBox.Name = "chucVuTextBox";
            this.chucVuTextBox.ReadOnly = true;
            this.chucVuTextBox.Size = new System.Drawing.Size(393, 23);
            this.chucVuTextBox.TabIndex = 15;
            // 
            // phongBanTextBox
            // 
            this.phongBanTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.phongBanTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.phongBanTextBox.Enabled = false;
            this.phongBanTextBox.Location = new System.Drawing.Point(103, 264);
            this.phongBanTextBox.Name = "phongBanTextBox";
            this.phongBanTextBox.ReadOnly = true;
            this.phongBanTextBox.Size = new System.Drawing.Size(393, 23);
            this.phongBanTextBox.TabIndex = 16;
            // 
            // gioiTinhComboBox
            // 
            this.gioiTinhComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.gioiTinhComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gioiTinhComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gioiTinhComboBox.Enabled = false;
            this.gioiTinhComboBox.FormattingEnabled = true;
            this.gioiTinhComboBox.Items.AddRange(new object[] {
            "Nữ",
            "Nam"});
            this.gioiTinhComboBox.Location = new System.Drawing.Point(103, 61);
            this.gioiTinhComboBox.Name = "gioiTinhComboBox";
            this.gioiTinhComboBox.Size = new System.Drawing.Size(394, 23);
            this.gioiTinhComboBox.TabIndex = 17;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.88035F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.70655F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.70655F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.70655F));
            this.tableLayoutPanel3.Controls.Add(this.ngayThamGiaTextBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.trangThaiTextBox, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.ngayThamGiaLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.trangThaiLabel, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(513, 299);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(500, 36);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // ngayThamGiaTextBox
            // 
            this.ngayThamGiaTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ngayThamGiaTextBox.Enabled = false;
            this.ngayThamGiaTextBox.Location = new System.Drawing.Point(102, 3);
            this.ngayThamGiaTextBox.Name = "ngayThamGiaTextBox";
            this.ngayThamGiaTextBox.ReadOnly = true;
            this.ngayThamGiaTextBox.Size = new System.Drawing.Size(119, 23);
            this.ngayThamGiaTextBox.TabIndex = 2;
            // 
            // trangThaiTextBox
            // 
            this.trangThaiTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.trangThaiTextBox.Enabled = false;
            this.trangThaiTextBox.Location = new System.Drawing.Point(368, 3);
            this.trangThaiTextBox.Name = "trangThaiTextBox";
            this.trangThaiTextBox.ReadOnly = true;
            this.trangThaiTextBox.Size = new System.Drawing.Size(128, 23);
            this.trangThaiTextBox.TabIndex = 3;
            // 
            // ngayThamGiaLabel
            // 
            this.ngayThamGiaLabel.AutoSize = true;
            this.ngayThamGiaLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ngayThamGiaLabel.Location = new System.Drawing.Point(3, 0);
            this.ngayThamGiaLabel.Name = "ngayThamGiaLabel";
            this.ngayThamGiaLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ngayThamGiaLabel.Size = new System.Drawing.Size(89, 19);
            this.ngayThamGiaLabel.TabIndex = 0;
            this.ngayThamGiaLabel.Text = "Ngày Tham Gia";
            // 
            // trangThaiLabel
            // 
            this.trangThaiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trangThaiLabel.AutoSize = true;
            this.trangThaiLabel.Location = new System.Drawing.Point(301, 0);
            this.trangThaiLabel.Name = "trangThaiLabel";
            this.trangThaiLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.trangThaiLabel.Size = new System.Drawing.Size(61, 20);
            this.trangThaiLabel.TabIndex = 4;
            this.trangThaiLabel.Text = "Trạng Thái";
            // 
            // luongTable
            // 
            this.luongTable.BackColor = System.Drawing.Color.Transparent;
            this.luongTable.ColumnCount = 3;
            this.luongTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.luongTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.luongTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.luongTable.Controls.Add(this.tableLayoutPanel3, 2, 1);
            this.luongTable.Controls.Add(this.thongTinTable, 2, 0);
            this.luongTable.Controls.Add(this.chiTietLuongTable, 0, 0);
            this.luongTable.Controls.Add(this.tongLuongThucNhanTable, 0, 1);
            this.luongTable.Controls.Add(this.panel1, 1, 0);
            this.luongTable.Controls.Add(this.projectDataGridView, 0, 2);
            this.luongTable.Location = new System.Drawing.Point(15, 71);
            this.luongTable.Name = "luongTable";
            this.luongTable.RowCount = 3;
            this.luongTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.41079F));
            this.luongTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.713693F));
            this.luongTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.66805F));
            this.luongTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.luongTable.Size = new System.Drawing.Size(1016, 482);
            this.luongTable.TabIndex = 5;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1046, 562);
            this.Controls.Add(this.luongTable);
            this.Controls.Add(this.functionFlowPanel);
            this.Controls.Add(this.stripMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.stripMenu;
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.Text = "Thông tin nhân viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.functionFlowPanel.ResumeLayout(false);
            this.stripMenu.ResumeLayout(false);
            this.stripMenu.PerformLayout();
            this.tongLuongThucNhanTable.ResumeLayout(false);
            this.tongLuongThucNhanTable.PerformLayout();
            this.chiTietLuongTable.ResumeLayout(false);
            this.chiTietLuongTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataGridView)).EndInit();
            this.thongTinTable.ResumeLayout(false);
            this.thongTinTable.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.luongTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button saveButton;
        private Button deleteButton;
        private FlowLayoutPanel functionFlowPanel;
        private Button resetButton;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem doiMatKhauStripMenuItem;
        private MenuStrip stripMenu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolStripMenuItem debugToolStripMenuItem;
        private ToolStripMenuItem lấyThôngTinNgườiĐầuTiênToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel luongTable;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox ngayThamGiaTextBox;
        private TextBox trangThaiTextBox;
        private Label ngayThamGiaLabel;
        private Label trangThaiLabel;
        private TableLayoutPanel thongTinTable;
        private Label gioiTinhLabel;
        private Label phongBanLabel;
        private Label chucVuLabel;
        private Label diaChiLabel;
        private Label sdtLabel;
        private Label emailLabel;
        private TextBox hoTenTextBox;
        private Label ngaySinhLabel;
        private Label hoTenLabel;
        private TextBox ngaySinhTextBox;
        private TextBox emailTextBox;
        private TextBox soDienThoaiTextBox;
        private TextBox diaChiTextBox;
        private TextBox chucVuTextBox;
        private TextBox phongBanTextBox;
        private ComboBox gioiTinhComboBox;
        private DataGridView projectDataGridView;
        private TableLayoutPanel chiTietLuongTable;
        private Label quyLabel;
        private Label luongCoBanLabel;
        private Label heSoLuong;
        private Label luongThuongLabel;
        private Label luongPhatLabel;
        private Label hienThiLuongLabel;
        private Label hienThiHSLuongLabel;
        private Label hienThiLuongThuongLabel;
        private Label hienThiLuongPhatLabel;
        private TableLayoutPanel tongLuongThucNhanTable;
        private Label tongLuongLabel;
        private Label tongLuongHienThiLabel;
        private ToolStripMenuItem iDNgườiĐăngNhậpToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }

}