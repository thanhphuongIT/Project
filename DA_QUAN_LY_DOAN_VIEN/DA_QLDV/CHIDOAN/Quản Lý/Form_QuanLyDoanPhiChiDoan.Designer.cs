namespace DA_QLDV
{
    partial class Form_QuanLyDoanPhiChiDoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Dgrid = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cbxTinhtrang = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbxDaNop = new DevComponents.Editors.ComboItem();
            this.cbxChuanop = new DevComponents.Editors.ComboItem();
            this.btnReload = new DevComponents.DotNetBar.ButtonX();
            this.datetimeNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.bntLoc = new DevComponents.DotNetBar.ButtonX();
            this.rbtNamhoc = new System.Windows.Forms.RadioButton();
            this.rbtTinhtrang = new System.Windows.Forms.RadioButton();
            this.rbtChidoan = new System.Windows.Forms.RadioButton();
            this.rbtMSSV = new System.Windows.Forms.RadioButton();
            this.rbtTen = new System.Windows.Forms.RadioButton();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtMSSV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSotien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtNamhoc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMadoanphi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtLoc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtChidoan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtHoten = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.DataGrid = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgrid
            // 
            // 
            // 
            // 
            this.Dgrid.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Dgrid.Font = new System.Drawing.Font("UVN Hong Ha Hep", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgrid.ForeColor = System.Drawing.Color.Red;
            this.Dgrid.Location = new System.Drawing.Point(259, -2);
            this.Dgrid.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Dgrid.Name = "Dgrid";
            this.Dgrid.Size = new System.Drawing.Size(670, 111);
            this.Dgrid.TabIndex = 1;
            this.Dgrid.Text = "QUẢN LÝ ĐOÀN PHÍ ĐOÀN VIÊN";
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.cbxTinhtrang);
            this.groupPanel1.Controls.Add(this.btnReload);
            this.groupPanel1.Controls.Add(this.datetimeNgaysinh);
            this.groupPanel1.Controls.Add(this.picAnh);
            this.groupPanel1.Controls.Add(this.btnXoa);
            this.groupPanel1.Controls.Add(this.btnSua);
            this.groupPanel1.Controls.Add(this.btnThem);
            this.groupPanel1.Controls.Add(this.bntLoc);
            this.groupPanel1.Controls.Add(this.rbtNamhoc);
            this.groupPanel1.Controls.Add(this.rbtTinhtrang);
            this.groupPanel1.Controls.Add(this.rbtChidoan);
            this.groupPanel1.Controls.Add(this.rbtMSSV);
            this.groupPanel1.Controls.Add(this.rbtTen);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.txtMSSV);
            this.groupPanel1.Controls.Add(this.txtSotien);
            this.groupPanel1.Controls.Add(this.labelX10);
            this.groupPanel1.Controls.Add(this.labelX9);
            this.groupPanel1.Controls.Add(this.labelX8);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.txtNamhoc);
            this.groupPanel1.Controls.Add(this.txtMadoanphi);
            this.groupPanel1.Controls.Add(this.txtLoc);
            this.groupPanel1.Controls.Add(this.txtChidoan);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.txtHoten);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(17, 102);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1058, 282);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 2;
            this.groupPanel1.Text = "NHẬP ĐOÀN PHÍ";
            // 
            // cbxTinhtrang
            // 
            this.cbxTinhtrang.DisplayMember = "Text";
            this.cbxTinhtrang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxTinhtrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTinhtrang.ForeColor = System.Drawing.Color.Black;
            this.cbxTinhtrang.FormattingEnabled = true;
            this.cbxTinhtrang.ItemHeight = 21;
            this.cbxTinhtrang.Items.AddRange(new object[] {
            this.cbxDaNop,
            this.cbxChuanop});
            this.cbxTinhtrang.Location = new System.Drawing.Point(497, 101);
            this.cbxTinhtrang.Name = "cbxTinhtrang";
            this.cbxTinhtrang.Size = new System.Drawing.Size(172, 27);
            this.cbxTinhtrang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxTinhtrang.TabIndex = 9;
            // 
            // cbxDaNop
            // 
            this.cbxDaNop.FontName = "UVN Cat Bien Nhe";
            this.cbxDaNop.FontSize = 10.8F;
            this.cbxDaNop.FontStyle = System.Drawing.FontStyle.Bold;
            this.cbxDaNop.Text = "Đã nộp";
            // 
            // cbxChuanop
            // 
            this.cbxChuanop.FontName = "UVN Cat Bien Nhe";
            this.cbxChuanop.FontSize = 10.8F;
            this.cbxChuanop.FontStyle = System.Drawing.FontStyle.Bold;
            this.cbxChuanop.Text = "Chưa nộp";
            // 
            // btnReload
            // 
            this.btnReload.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReload.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReload.Image = global::DA_QLDV.Properties.Resources.iconfinder_Symbol_Refresh_49265;
            this.btnReload.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnReload.Location = new System.Drawing.Point(17, 210);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(112, 37);
            this.btnReload.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReload.TabIndex = 8;
            this.btnReload.Text = "  Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // datetimeNgaysinh
            // 
            this.datetimeNgaysinh.Enabled = false;
            this.datetimeNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimeNgaysinh.Location = new System.Drawing.Point(148, 135);
            this.datetimeNgaysinh.Name = "datetimeNgaysinh";
            this.datetimeNgaysinh.Size = new System.Drawing.Size(172, 26);
            this.datetimeNgaysinh.TabIndex = 7;
            this.datetimeNgaysinh.Value = new System.DateTime(2020, 4, 12, 0, 0, 0, 0);
            // 
            // picAnh
            // 
            this.picAnh.Enabled = false;
            this.picAnh.Location = new System.Drawing.Point(715, 32);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(164, 137);
            this.picAnh.TabIndex = 5;
            this.picAnh.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Image = global::DA_QLDV.Properties.Resources.icons8_remove_96;
            this.btnXoa.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnXoa.Location = new System.Drawing.Point(908, 124);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 39);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "  Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSua.Image = global::DA_QLDV.Properties.Resources.icons8_edit_property_96;
            this.btnSua.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnSua.Location = new System.Drawing.Point(908, 79);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 39);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "  Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Image = global::DA_QLDV.Properties.Resources.icons8_add_96;
            this.btnThem.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnThem.Location = new System.Drawing.Point(908, 34);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 39);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = " Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // bntLoc
            // 
            this.bntLoc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bntLoc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bntLoc.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntLoc.Image = global::DA_QLDV.Properties.Resources.iconfinder_filter_40778;
            this.bntLoc.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.bntLoc.Location = new System.Drawing.Point(908, 210);
            this.bntLoc.Name = "bntLoc";
            this.bntLoc.Size = new System.Drawing.Size(112, 37);
            this.bntLoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bntLoc.TabIndex = 4;
            this.bntLoc.Text = "   Lọc";
            this.bntLoc.Click += new System.EventHandler(this.bntLoc_Click);
            // 
            // rbtNamhoc
            // 
            this.rbtNamhoc.AutoSize = true;
            this.rbtNamhoc.BackColor = System.Drawing.Color.Transparent;
            this.rbtNamhoc.Location = new System.Drawing.Point(908, 177);
            this.rbtNamhoc.Name = "rbtNamhoc";
            this.rbtNamhoc.Size = new System.Drawing.Size(90, 24);
            this.rbtNamhoc.TabIndex = 3;
            this.rbtNamhoc.TabStop = true;
            this.rbtNamhoc.Text = "Năm học";
            this.rbtNamhoc.UseVisualStyleBackColor = false;
            // 
            // rbtTinhtrang
            // 
            this.rbtTinhtrang.AutoSize = true;
            this.rbtTinhtrang.BackColor = System.Drawing.Color.Transparent;
            this.rbtTinhtrang.Location = new System.Drawing.Point(691, 177);
            this.rbtTinhtrang.Name = "rbtTinhtrang";
            this.rbtTinhtrang.Size = new System.Drawing.Size(105, 24);
            this.rbtTinhtrang.TabIndex = 3;
            this.rbtTinhtrang.TabStop = true;
            this.rbtTinhtrang.Text = "Tình trạng";
            this.rbtTinhtrang.UseVisualStyleBackColor = false;
            // 
            // rbtChidoan
            // 
            this.rbtChidoan.AutoSize = true;
            this.rbtChidoan.BackColor = System.Drawing.Color.Transparent;
            this.rbtChidoan.Location = new System.Drawing.Point(497, 177);
            this.rbtChidoan.Name = "rbtChidoan";
            this.rbtChidoan.Size = new System.Drawing.Size(92, 24);
            this.rbtChidoan.TabIndex = 3;
            this.rbtChidoan.TabStop = true;
            this.rbtChidoan.Text = "Chi đoàn";
            this.rbtChidoan.UseVisualStyleBackColor = false;
            // 
            // rbtMSSV
            // 
            this.rbtMSSV.AutoSize = true;
            this.rbtMSSV.BackColor = System.Drawing.Color.Transparent;
            this.rbtMSSV.Location = new System.Drawing.Point(322, 177);
            this.rbtMSSV.Name = "rbtMSSV";
            this.rbtMSSV.Size = new System.Drawing.Size(68, 24);
            this.rbtMSSV.TabIndex = 3;
            this.rbtMSSV.TabStop = true;
            this.rbtMSSV.Text = "MSSV";
            this.rbtMSSV.UseVisualStyleBackColor = false;
            // 
            // rbtTen
            // 
            this.rbtTen.AutoSize = true;
            this.rbtTen.BackColor = System.Drawing.Color.Transparent;
            this.rbtTen.Location = new System.Drawing.Point(162, 177);
            this.rbtTen.Name = "rbtTen";
            this.rbtTen.Size = new System.Drawing.Size(54, 24);
            this.rbtTen.TabIndex = 3;
            this.rbtTen.TabStop = true;
            this.rbtTen.Text = "Tên";
            this.rbtTen.UseVisualStyleBackColor = false;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(363, 61);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(117, 30);
            this.labelX6.TabIndex = 1;
            this.labelX6.Text = "Số tiền";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(363, 28);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 1;
            this.labelX5.Text = "Chi đoàn";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(363, 135);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 30);
            this.labelX4.TabIndex = 1;
            this.labelX4.Text = "Năm học";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(363, 97);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(123, 32);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "Tình trạng";
            // 
            // txtMSSV
            // 
            this.txtMSSV.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtMSSV.Border.Class = "TextBoxBorder";
            this.txtMSSV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMSSV.DisabledBackColor = System.Drawing.Color.White;
            this.txtMSSV.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSSV.ForeColor = System.Drawing.Color.Black;
            this.txtMSSV.Location = new System.Drawing.Point(148, 65);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.PreventEnterBeep = true;
            this.txtMSSV.Size = new System.Drawing.Size(172, 26);
            this.txtMSSV.TabIndex = 0;
            this.txtMSSV.Leave += new System.EventHandler(this.txtMSSV_Leave);
            // 
            // txtSotien
            // 
            this.txtSotien.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSotien.Border.Class = "TextBoxBorder";
            this.txtSotien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSotien.DisabledBackColor = System.Drawing.Color.White;
            this.txtSotien.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSotien.ForeColor = System.Drawing.Color.Black;
            this.txtSotien.Location = new System.Drawing.Point(497, 64);
            this.txtSotien.Name = "txtSotien";
            this.txtSotien.PreventEnterBeep = true;
            this.txtSotien.Size = new System.Drawing.Size(172, 26);
            this.txtSotien.TabIndex = 0;
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelX10.Location = new System.Drawing.Point(778, -8);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(42, 34);
            this.labelX10.TabIndex = 1;
            this.labelX10.Text = "Ảnh";
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelX9.Location = new System.Drawing.Point(30, 133);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(99, 34);
            this.labelX9.TabIndex = 1;
            this.labelX9.Text = "Ngày sinh";
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelX8.Location = new System.Drawing.Point(30, 96);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(99, 34);
            this.labelX8.TabIndex = 1;
            this.labelX8.Text = "Họ và tên";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelX2.Location = new System.Drawing.Point(30, 61);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 31);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "MSSV";
            // 
            // txtNamhoc
            // 
            this.txtNamhoc.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNamhoc.Border.Class = "TextBoxBorder";
            this.txtNamhoc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNamhoc.DisabledBackColor = System.Drawing.Color.White;
            this.txtNamhoc.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamhoc.ForeColor = System.Drawing.Color.Black;
            this.txtNamhoc.Location = new System.Drawing.Point(497, 138);
            this.txtNamhoc.Name = "txtNamhoc";
            this.txtNamhoc.PreventEnterBeep = true;
            this.txtNamhoc.Size = new System.Drawing.Size(172, 26);
            this.txtNamhoc.TabIndex = 0;
            // 
            // txtMadoanphi
            // 
            this.txtMadoanphi.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtMadoanphi.Border.Class = "TextBoxBorder";
            this.txtMadoanphi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMadoanphi.DisabledBackColor = System.Drawing.Color.White;
            this.txtMadoanphi.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMadoanphi.ForeColor = System.Drawing.Color.Black;
            this.txtMadoanphi.Location = new System.Drawing.Point(148, 28);
            this.txtMadoanphi.Name = "txtMadoanphi";
            this.txtMadoanphi.PreventEnterBeep = true;
            this.txtMadoanphi.Size = new System.Drawing.Size(172, 26);
            this.txtMadoanphi.TabIndex = 0;
            // 
            // txtLoc
            // 
            this.txtLoc.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtLoc.Border.Class = "TextBoxBorder";
            this.txtLoc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLoc.DisabledBackColor = System.Drawing.Color.White;
            this.txtLoc.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoc.ForeColor = System.Drawing.Color.Black;
            this.txtLoc.Location = new System.Drawing.Point(148, 219);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.PreventEnterBeep = true;
            this.txtLoc.Size = new System.Drawing.Size(707, 26);
            this.txtLoc.TabIndex = 0;
            // 
            // txtChidoan
            // 
            this.txtChidoan.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtChidoan.Border.Class = "TextBoxBorder";
            this.txtChidoan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtChidoan.DisabledBackColor = System.Drawing.Color.White;
            this.txtChidoan.Enabled = false;
            this.txtChidoan.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChidoan.ForeColor = System.Drawing.Color.Black;
            this.txtChidoan.Location = new System.Drawing.Point(497, 27);
            this.txtChidoan.Name = "txtChidoan";
            this.txtChidoan.PreventEnterBeep = true;
            this.txtChidoan.Size = new System.Drawing.Size(172, 26);
            this.txtChidoan.TabIndex = 0;
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(30, 173);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(99, 31);
            this.labelX7.TabIndex = 1;
            this.labelX7.Text = "Lọc theo: ";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(30, 24);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(112, 31);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Mã đoàn phí";
            // 
            // txtHoten
            // 
            this.txtHoten.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtHoten.Border.Class = "TextBoxBorder";
            this.txtHoten.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHoten.DisabledBackColor = System.Drawing.Color.White;
            this.txtHoten.Enabled = false;
            this.txtHoten.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoten.ForeColor = System.Drawing.Color.Black;
            this.txtHoten.Location = new System.Drawing.Point(148, 101);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.PreventEnterBeep = true;
            this.txtHoten.Size = new System.Drawing.Size(172, 26);
            this.txtHoten.TabIndex = 0;
            // 
            // DataGrid
            // 
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataGrid.EnableHeadersVisualStyles = false;
            this.DataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DataGrid.Location = new System.Drawing.Point(17, 390);
            this.DataGrid.Name = "DataGrid";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGrid.RowHeadersWidth = 51;
            this.DataGrid.RowTemplate.Height = 24;
            this.DataGrid.Size = new System.Drawing.Size(1058, 302);
            this.DataGrid.TabIndex = 3;
            this.DataGrid.Click += new System.EventHandler(this.DataGrid_Click);
            // 
            // Form_QuanLyDoanPhiChiDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 698);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.Dgrid);
            this.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 10.8F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_QuanLyDoanPhiChiDoan";
            this.Text = "Form_QuanLyKyLuat";
            this.Load += new System.EventHandler(this.Form_QuanLyDoanPhiChiDoan_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ReflectionLabel Dgrid;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSotien;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNamhoc;
        private DevComponents.DotNetBar.Controls.TextBoxX txtChidoan;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX DataGrid;
        private DevComponents.DotNetBar.ButtonX bntLoc;
        private System.Windows.Forms.RadioButton rbtNamhoc;
        private System.Windows.Forms.RadioButton rbtTinhtrang;
        private System.Windows.Forms.RadioButton rbtChidoan;
        private System.Windows.Forms.RadioButton rbtMSSV;
        private System.Windows.Forms.RadioButton rbtTen;
        private DevComponents.DotNetBar.LabelX labelX7;
        private System.Windows.Forms.PictureBox picAnh;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHoten;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMSSV;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMadoanphi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLoc;
        private System.Windows.Forms.DateTimePicker datetimeNgaysinh;
        private DevComponents.DotNetBar.ButtonX btnReload;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxTinhtrang;
        private DevComponents.Editors.ComboItem cbxDaNop;
        private DevComponents.Editors.ComboItem cbxChuanop;
    }
}