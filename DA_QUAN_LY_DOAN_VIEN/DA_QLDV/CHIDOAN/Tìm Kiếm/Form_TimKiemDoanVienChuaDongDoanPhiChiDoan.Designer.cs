namespace DA_QLDV
{
    partial class Form_TimKiemDoanVienChuaDongDoanPhiChiDoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.DGrid = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnReload = new DevComponents.DotNetBar.ButtonX();
            this.btnTimkiem = new DevComponents.DotNetBar.ButtonX();
            this.txtTimkiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.rbtChidoan = new System.Windows.Forms.RadioButton();
            this.rbtMssv = new System.Windows.Forms.RadioButton();
            this.rbtNamhoc = new System.Windows.Forms.RadioButton();
            this.rbtTen = new System.Windows.Forms.RadioButton();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.DGrid)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reflectionLabel1
            // 
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Font = new System.Drawing.Font("UVN Hong Ha Hep", 36F, System.Drawing.FontStyle.Bold);
            this.reflectionLabel1.ForeColor = System.Drawing.Color.Red;
            this.reflectionLabel1.Location = new System.Drawing.Point(113, -14);
            this.reflectionLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(924, 138);
            this.reflectionLabel1.TabIndex = 26;
            this.reflectionLabel1.Text = "TÌM KIẾM ĐOÀN VIÊN CHƯA ĐÓNG ĐOÀN PHÍ";
            // 
            // DGrid
            // 
            this.DGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGrid.DefaultCellStyle = dataGridViewCellStyle11;
            this.DGrid.EnableHeadersVisualStyles = false;
            this.DGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DGrid.Location = new System.Drawing.Point(21, 252);
            this.DGrid.Margin = new System.Windows.Forms.Padding(4);
            this.DGrid.Name = "DGrid";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DGrid.RowHeadersWidth = 51;
            this.DGrid.RowTemplate.Height = 24;
            this.DGrid.Size = new System.Drawing.Size(1055, 441);
            this.DGrid.TabIndex = 23;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnReload);
            this.groupPanel1.Controls.Add(this.btnTimkiem);
            this.groupPanel1.Controls.Add(this.txtTimkiem);
            this.groupPanel1.Controls.Add(this.rbtChidoan);
            this.groupPanel1.Controls.Add(this.rbtMssv);
            this.groupPanel1.Controls.Add(this.rbtNamhoc);
            this.groupPanel1.Controls.Add(this.rbtTen);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(21, 105);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1055, 139);
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
            this.groupPanel1.TabIndex = 27;
            this.groupPanel1.Text = "NHẬP TÌM KIẾM";
            // 
            // btnReload
            // 
            this.btnReload.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReload.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReload.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Image = global::DA_QLDV.Properties.Resources.iconfinder_Symbol_Refresh_49265;
            this.btnReload.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnReload.Location = new System.Drawing.Point(885, 27);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(144, 62);
            this.btnReload.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReload.TabIndex = 13;
            this.btnReload.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimkiem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTimkiem.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Image = global::DA_QLDV.Properties.Resources.iconfinder_gnome_searchtool_39022;
            this.btnTimkiem.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnTimkiem.Location = new System.Drawing.Point(730, 27);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(144, 62);
            this.btnTimkiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTimkiem.TabIndex = 14;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTimkiem.Border.Class = "TextBoxBorder";
            this.txtTimkiem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTimkiem.DisabledBackColor = System.Drawing.Color.White;
            this.txtTimkiem.ForeColor = System.Drawing.Color.Black;
            this.txtTimkiem.Location = new System.Drawing.Point(275, 63);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.PreventEnterBeep = true;
            this.txtTimkiem.Size = new System.Drawing.Size(437, 26);
            this.txtTimkiem.TabIndex = 12;
            // 
            // rbtChidoan
            // 
            this.rbtChidoan.AutoSize = true;
            this.rbtChidoan.BackColor = System.Drawing.Color.Transparent;
            this.rbtChidoan.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtChidoan.Location = new System.Drawing.Point(493, 25);
            this.rbtChidoan.Margin = new System.Windows.Forms.Padding(4);
            this.rbtChidoan.Name = "rbtChidoan";
            this.rbtChidoan.Size = new System.Drawing.Size(94, 25);
            this.rbtChidoan.TabIndex = 7;
            this.rbtChidoan.Text = "Chi đoàn";
            this.rbtChidoan.UseVisualStyleBackColor = false;
            // 
            // rbtMssv
            // 
            this.rbtMssv.AutoSize = true;
            this.rbtMssv.BackColor = System.Drawing.Color.Transparent;
            this.rbtMssv.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 10.8F, System.Drawing.FontStyle.Bold);
            this.rbtMssv.Location = new System.Drawing.Point(380, 27);
            this.rbtMssv.Margin = new System.Windows.Forms.Padding(4);
            this.rbtMssv.Name = "rbtMssv";
            this.rbtMssv.Size = new System.Drawing.Size(68, 24);
            this.rbtMssv.TabIndex = 9;
            this.rbtMssv.Text = "MSSV";
            this.rbtMssv.UseVisualStyleBackColor = false;
            // 
            // rbtNamhoc
            // 
            this.rbtNamhoc.AutoSize = true;
            this.rbtNamhoc.BackColor = System.Drawing.Color.Transparent;
            this.rbtNamhoc.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 10.8F, System.Drawing.FontStyle.Bold);
            this.rbtNamhoc.Location = new System.Drawing.Point(622, 27);
            this.rbtNamhoc.Margin = new System.Windows.Forms.Padding(4);
            this.rbtNamhoc.Name = "rbtNamhoc";
            this.rbtNamhoc.Size = new System.Drawing.Size(90, 24);
            this.rbtNamhoc.TabIndex = 10;
            this.rbtNamhoc.Text = "Năm học";
            this.rbtNamhoc.UseVisualStyleBackColor = false;
            // 
            // rbtTen
            // 
            this.rbtTen.AutoSize = true;
            this.rbtTen.BackColor = System.Drawing.Color.Transparent;
            this.rbtTen.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 10.8F, System.Drawing.FontStyle.Bold);
            this.rbtTen.Location = new System.Drawing.Point(275, 26);
            this.rbtTen.Margin = new System.Windows.Forms.Padding(4);
            this.rbtTen.Name = "rbtTen";
            this.rbtTen.Size = new System.Drawing.Size(54, 24);
            this.rbtTen.TabIndex = 11;
            this.rbtTen.Text = "Tên";
            this.rbtTen.UseVisualStyleBackColor = false;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(20, 48);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(224, 52);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "Nhập tìm kiếm:";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(20, 12);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(224, 52);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "Bạn muốn tìm kiếm theo: ";
            // 
            // Form_TimKiemDoanVienChuaDongDoanPhiChiDoan
            // 
            this.AcceptButton = this.btnTimkiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 698);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.reflectionLabel1);
            this.Controls.Add(this.DGrid);
            this.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 10.8F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_TimKiemDoanVienChuaDongDoanPhiChiDoan";
            this.Text = "Form_XuatDanhSachDoanVienBiKyLuat";
            this.Load += new System.EventHandler(this.Form_TimKiemDoanVienChuaDongDoanPhiChiDoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGrid)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX DGrid;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btnReload;
        private DevComponents.DotNetBar.ButtonX btnTimkiem;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTimkiem;
        private System.Windows.Forms.RadioButton rbtChidoan;
        private System.Windows.Forms.RadioButton rbtMssv;
        private System.Windows.Forms.RadioButton rbtTen;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.RadioButton rbtNamhoc;
    }
}