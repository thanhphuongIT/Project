namespace DA_QLDV
{
    partial class Form_XuatDanhSachDoanVienBiKyLuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_XuatDanhSachDoanVienBiKyLuat));
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.btnIndanhsach = new DevComponents.DotNetBar.ButtonX();
            this.btnXuatdanhsach = new DevComponents.DotNetBar.ButtonX();
            this.DGrid = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.DGrid)).BeginInit();
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
            this.reflectionLabel1.Text = "XUẤT DANH SÁCH ĐOÀN VIÊN BỊ KỶ LUẬT";
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
            this.DGrid.Location = new System.Drawing.Point(18, 118);
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
            this.DGrid.Size = new System.Drawing.Size(1060, 508);
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
            // printDocument1
            //             // 
            // Form_XuatDanhSachDoanVienBiKyLuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 698);
            this.Controls.Add(this.reflectionLabel1);
            this.Controls.Add(this.btnIndanhsach);
            this.Controls.Add(this.btnXuatdanhsach);
            this.Controls.Add(this.DGrid);
            this.Name = "Form_XuatDanhSachDoanVienBiKyLuat";
            this.Text = "Form_XuatDanhSachDoanVienBiKyLuat";
            this.Load += new System.EventHandler(this.Form_XuatDanhSachDoanVienBiKyLuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGrid)).EndInit();
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
    }
}