namespace DA_QLDV
{
    partial class Form_XuatDanhSachDoanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_XuatDanhSachDoanVien));
            this.DGrid = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnXuatdanhsach = new DevComponents.DotNetBar.ButtonX();
            this.btnIndanhsach = new DevComponents.DotNetBar.ButtonX();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnReload = new DevComponents.DotNetBar.ButtonX();
            this.btnTimkiem = new DevComponents.DotNetBar.ButtonX();
            this.txtTimkiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.rbtChucvu = new System.Windows.Forms.RadioButton();
            this.rbtGioitinh = new System.Windows.Forms.RadioButton();
            this.rbtChidoan = new System.Windows.Forms.RadioButton();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DGrid)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGrid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGrid.EnableHeadersVisualStyles = false;
            this.DGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DGrid.Location = new System.Drawing.Point(18, 204);
            this.DGrid.Name = "DGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGrid.RowHeadersWidth = 51;
            this.DGrid.RowTemplate.Height = 24;
            this.DGrid.Size = new System.Drawing.Size(1060, 422);
            this.DGrid.TabIndex = 0;
            // 
            // btnXuatdanhsach
            // 
            this.btnXuatdanhsach.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXuatdanhsach.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXuatdanhsach.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatdanhsach.Image = global::DA_QLDV.Properties.Resources.icons8_export_excel_96;
            this.btnXuatdanhsach.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnXuatdanhsach.Location = new System.Drawing.Point(394, 649);
            this.btnXuatdanhsach.Name = "btnXuatdanhsach";
            this.btnXuatdanhsach.Size = new System.Drawing.Size(153, 37);
            this.btnXuatdanhsach.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXuatdanhsach.TabIndex = 13;
            this.btnXuatdanhsach.Text = "Xuất file Excel";
            this.btnXuatdanhsach.Click += new System.EventHandler(this.btnXuatdanhsach_Click);
            // 
            // btnIndanhsach
            // 
            this.btnIndanhsach.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnIndanhsach.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnIndanhsach.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndanhsach.Image = global::DA_QLDV.Properties.Resources.iconfinder_printer_39263;
            this.btnIndanhsach.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnIndanhsach.Location = new System.Drawing.Point(563, 649);
            this.btnIndanhsach.Name = "btnIndanhsach";
            this.btnIndanhsach.Size = new System.Drawing.Size(153, 37);
            this.btnIndanhsach.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnIndanhsach.TabIndex = 13;
            this.btnIndanhsach.Text = "In danh sách";
            this.btnIndanhsach.Click += new System.EventHandler(this.btnIndanhsach_Click);
            // 
            // reflectionLabel1
            // 
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Font = new System.Drawing.Font("UVN Hong Ha Hep", 36F, System.Drawing.FontStyle.Bold);
            this.reflectionLabel1.ForeColor = System.Drawing.Color.Red;
            this.reflectionLabel1.Location = new System.Drawing.Point(249, 6);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(583, 100);
            this.reflectionLabel1.TabIndex = 22;
            this.reflectionLabel1.Text = "XUẤT DANH SÁCH ĐOÀN VIÊN";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnReload);
            this.groupPanel1.Controls.Add(this.btnTimkiem);
            this.groupPanel1.Controls.Add(this.txtTimkiem);
            this.groupPanel1.Controls.Add(this.rbtChucvu);
            this.groupPanel1.Controls.Add(this.rbtGioitinh);
            this.groupPanel1.Controls.Add(this.rbtChidoan);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(18, 98);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1060, 100);
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
            this.groupPanel1.TabIndex = 23;
            this.groupPanel1.Text = "Nhập danh sách cần xuất";
            // 
            // btnReload
            // 
            this.btnReload.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReload.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReload.Image = global::DA_QLDV.Properties.Resources.iconfinder_Symbol_Refresh_49265;
            this.btnReload.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnReload.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnReload.Location = new System.Drawing.Point(972, 6);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 64);
            this.btnReload.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReload.TabIndex = 5;
            this.btnReload.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimkiem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTimkiem.Image = global::DA_QLDV.Properties.Resources.iconfinder_gnome_searchtool_39022;
            this.btnTimkiem.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnTimkiem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnTimkiem.Location = new System.Drawing.Point(886, 6);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 64);
            this.btnTimkiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTimkiem.TabIndex = 5;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click_1);
            // 
            // txtTimkiem
            // 
            // 
            // 
            // 
            this.txtTimkiem.Border.Class = "TextBoxBorder";
            this.txtTimkiem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTimkiem.Location = new System.Drawing.Point(701, 25);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.PreventEnterBeep = true;
            this.txtTimkiem.Size = new System.Drawing.Size(173, 26);
            this.txtTimkiem.TabIndex = 4;
            // 
            // rbtChucvu
            // 
            this.rbtChucvu.AutoSize = true;
            this.rbtChucvu.BackColor = System.Drawing.Color.Transparent;
            this.rbtChucvu.Location = new System.Drawing.Point(491, 24);
            this.rbtChucvu.Name = "rbtChucvu";
            this.rbtChucvu.Size = new System.Drawing.Size(86, 24);
            this.rbtChucvu.TabIndex = 3;
            this.rbtChucvu.Text = "Chức vụ";
            this.rbtChucvu.UseVisualStyleBackColor = false;
            // 
            // rbtGioitinh
            // 
            this.rbtGioitinh.AutoSize = true;
            this.rbtGioitinh.BackColor = System.Drawing.Color.Transparent;
            this.rbtGioitinh.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbtGioitinh.Location = new System.Drawing.Point(380, 24);
            this.rbtGioitinh.Name = "rbtGioitinh";
            this.rbtGioitinh.Size = new System.Drawing.Size(91, 24);
            this.rbtGioitinh.TabIndex = 2;
            this.rbtGioitinh.Text = "Giới tính";
            this.rbtGioitinh.UseVisualStyleBackColor = false;
            // 
            // rbtChidoan
            // 
            this.rbtChidoan.AutoSize = true;
            this.rbtChidoan.BackColor = System.Drawing.Color.Transparent;
            this.rbtChidoan.Location = new System.Drawing.Point(259, 24);
            this.rbtChidoan.Name = "rbtChidoan";
            this.rbtChidoan.Size = new System.Drawing.Size(92, 24);
            this.rbtChidoan.TabIndex = 1;
            this.rbtChidoan.Text = "Chi đoàn";
            this.rbtChidoan.UseVisualStyleBackColor = false;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(620, 11);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 48);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Tìm kiếm";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(16, 18);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(227, 35);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Bạn muốn xuất danh sách theo";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form_XuatDanhSachDoanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 698);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.reflectionLabel1);
            this.Controls.Add(this.btnIndanhsach);
            this.Controls.Add(this.btnXuatdanhsach);
            this.Controls.Add(this.DGrid);
            this.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 10.8F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_XuatDanhSachDoanVien";
            this.Text = "Form_XuatDanhSachDoanVien";
            this.Load += new System.EventHandler(this.Form_XuatDanhSachDoanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGrid)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX DGrid;
        private DevComponents.DotNetBar.ButtonX btnXuatdanhsach;
        private DevComponents.DotNetBar.ButtonX btnIndanhsach;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btnTimkiem;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTimkiem;
        private System.Windows.Forms.RadioButton rbtChucvu;
        private System.Windows.Forms.RadioButton rbtGioitinh;
        private System.Windows.Forms.RadioButton rbtChidoan;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private DevComponents.DotNetBar.ButtonX btnReload;
    }
}