namespace DA_QLDV
{
    partial class Form_Xuatdanhgiachidoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Xuatdanhgiachidoan));
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.btnIndanhsach = new DevComponents.DotNetBar.ButtonX();
            this.btnXuatdanhsach = new DevComponents.DotNetBar.ButtonX();
            this.DGrid = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.btnTimkiem = new DevComponents.DotNetBar.ButtonX();
            this.rbtot = new System.Windows.Forms.RadioButton();
            this.rbchuatot = new System.Windows.Forms.RadioButton();
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
            this.reflectionLabel1.Location = new System.Drawing.Point(150, 12);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(829, 100);
            this.reflectionLabel1.TabIndex = 26;
            this.reflectionLabel1.Text = "XUẤT DANH SÁCH ĐÁNH GIÁ ĐOÀN VIÊN";
            // 
            // btnIndanhsach
            // 
            this.btnIndanhsach.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnIndanhsach.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnIndanhsach.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndanhsach.Image = global::DA_QLDV.Properties.Resources.iconfinder_printer_39263;
            this.btnIndanhsach.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnIndanhsach.Location = new System.Drawing.Point(565, 651);
            this.btnIndanhsach.Name = "btnIndanhsach";
            this.btnIndanhsach.Size = new System.Drawing.Size(153, 37);
            this.btnIndanhsach.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnIndanhsach.TabIndex = 24;
            this.btnIndanhsach.Text = "In danh sách";
            this.btnIndanhsach.Click += new System.EventHandler(this.btnIndanhsach_Click);
            // 
            // btnXuatdanhsach
            // 
            this.btnXuatdanhsach.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXuatdanhsach.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXuatdanhsach.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatdanhsach.Image = global::DA_QLDV.Properties.Resources.icons8_export_excel_96;
            this.btnXuatdanhsach.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnXuatdanhsach.Location = new System.Drawing.Point(396, 651);
            this.btnXuatdanhsach.Name = "btnXuatdanhsach";
            this.btnXuatdanhsach.Size = new System.Drawing.Size(153, 37);
            this.btnXuatdanhsach.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXuatdanhsach.TabIndex = 25;
            this.btnXuatdanhsach.Text = "Xuất file Excel";
            this.btnXuatdanhsach.Click += new System.EventHandler(this.btnXuatdanhsach_Click);
            // 
            // DGrid
            // 
            this.DGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.DGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DGrid.Location = new System.Drawing.Point(18, 226);
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
            this.DGrid.Size = new System.Drawing.Size(1060, 400);
            this.DGrid.TabIndex = 23;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
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
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.rbAll);
            this.groupPanel1.Controls.Add(this.btnTimkiem);
            this.groupPanel1.Controls.Add(this.rbtot);
            this.groupPanel1.Controls.Add(this.rbchuatot);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(18, 108);
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
            this.groupPanel1.TabIndex = 31;
            this.groupPanel1.Text = "Nhập danh sách cần xuất";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.BackColor = System.Drawing.Color.Transparent;
            this.rbAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAll.Location = new System.Drawing.Point(404, 29);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(41, 22);
            this.rbAll.TabIndex = 6;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = false;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimkiem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Image = global::DA_QLDV.Properties.Resources.iconfinder_filter_40778;
            this.btnTimkiem.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnTimkiem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnTimkiem.Location = new System.Drawing.Point(705, 1);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(84, 73);
            this.btnTimkiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTimkiem.TabIndex = 5;
            this.btnTimkiem.Text = "Lọc";
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // rbtot
            // 
            this.rbtot.AutoSize = true;
            this.rbtot.BackColor = System.Drawing.Color.Transparent;
            this.rbtot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtot.Location = new System.Drawing.Point(616, 30);
            this.rbtot.Name = "rbtot";
            this.rbtot.Size = new System.Drawing.Size(48, 22);
            this.rbtot.TabIndex = 3;
            this.rbtot.Text = "Tốt";
            this.rbtot.UseVisualStyleBackColor = false;
            // 
            // rbchuatot
            // 
            this.rbchuatot.AutoSize = true;
            this.rbchuatot.BackColor = System.Drawing.Color.Transparent;
            this.rbchuatot.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbchuatot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbchuatot.Location = new System.Drawing.Point(490, 29);
            this.rbchuatot.Name = "rbchuatot";
            this.rbchuatot.Size = new System.Drawing.Size(82, 22);
            this.rbchuatot.TabIndex = 2;
            this.rbchuatot.Text = "Chưa tốt";
            this.rbchuatot.UseVisualStyleBackColor = false;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(127, 19);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(259, 35);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "<b>Chọn Xếp loại mà bạn muốn xuất</b>";
            // 
            // Form_Xuatdanhgiachidoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 698);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.reflectionLabel1);
            this.Controls.Add(this.btnIndanhsach);
            this.Controls.Add(this.btnXuatdanhsach);
            this.Controls.Add(this.DGrid);
            this.Name = "Form_Xuatdanhgiachidoan";
            this.Text = "Form_XuatDanhSachDanhGia";
            this.Load += new System.EventHandler(this.Form_Xuatdanhgiachidoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGrid)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.ButtonX btnIndanhsach;
        private DevComponents.DotNetBar.ButtonX btnXuatdanhsach;
        private DevComponents.DotNetBar.Controls.DataGridViewX DGrid;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.RadioButton rbAll;
        private DevComponents.DotNetBar.ButtonX btnTimkiem;
        private System.Windows.Forms.RadioButton rbtot;
        private System.Windows.Forms.RadioButton rbchuatot;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}