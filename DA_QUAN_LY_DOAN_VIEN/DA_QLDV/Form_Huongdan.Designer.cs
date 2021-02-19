namespace DA_QLDV
{
    partial class Form_Huongdan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Huongdan));
            this.MDAvideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btndung = new DevComponents.DotNetBar.ButtonX();
            this.btnxem = new DevComponents.DotNetBar.ButtonX();
            this.btntamdung = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.MDAvideo)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MDAvideo
            // 
            this.MDAvideo.Enabled = true;
            this.MDAvideo.Location = new System.Drawing.Point(12, 12);
            this.MDAvideo.Name = "MDAvideo";
            this.MDAvideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MDAvideo.OcxState")));
            this.MDAvideo.Size = new System.Drawing.Size(1058, 557);
            this.MDAvideo.TabIndex = 0;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btntamdung);
            this.groupPanel1.Controls.Add(this.btnxem);
            this.groupPanel1.Controls.Add(this.btndung);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(12, 575);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1058, 100);
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
            this.groupPanel1.TabIndex = 1;
            this.groupPanel1.Text = "Trình điều khiển";
            // 
            // btndung
            // 
            this.btndung.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btndung.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btndung.Location = new System.Drawing.Point(219, 15);
            this.btndung.Name = "btndung";
            this.btndung.Size = new System.Drawing.Size(171, 51);
            this.btndung.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btndung.TabIndex = 0;
            this.btndung.Text = "DỪNG";
            this.btndung.Click += new System.EventHandler(this.btndung_Click);
            // 
            // btnxem
            // 
            this.btnxem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxem.Location = new System.Drawing.Point(446, 15);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(171, 51);
            this.btnxem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnxem.TabIndex = 0;
            this.btnxem.Text = "XEM HƯỚNG DẪN";
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // btntamdung
            // 
            this.btntamdung.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btntamdung.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btntamdung.Location = new System.Drawing.Point(671, 15);
            this.btntamdung.Name = "btntamdung";
            this.btntamdung.Size = new System.Drawing.Size(171, 51);
            this.btntamdung.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btntamdung.TabIndex = 0;
            this.btntamdung.Text = "TẠM DỪNG";
            this.btntamdung.Click += new System.EventHandler(this.btntamdung_Click);
            // 
            // Form_Huongdan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 698);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.MDAvideo);
            this.Name = "Form_Huongdan";
            this.Text = "Form_Huongdan";
            ((System.ComponentModel.ISupportInitialize)(this.MDAvideo)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer MDAvideo;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btntamdung;
        private DevComponents.DotNetBar.ButtonX btnxem;
        private DevComponents.DotNetBar.ButtonX btndung;
    }
}