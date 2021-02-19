namespace DA_QLDV
{
    partial class Form_Login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.TextBox_Username = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TextBox_Password = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.rbtCapkhoa = new System.Windows.Forms.RadioButton();
            this.rbtCapchidoan = new System.Windows.Forms.RadioButton();
            this.cbxChidoan = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DA_QLDV.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(151, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DA_QLDV.Properties.Resources.iconfinder_icons_password_1564520;
            this.pictureBox2.Location = new System.Drawing.Point(28, 312);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DA_QLDV.Properties.Resources.iconfinder_user_216498;
            this.pictureBox3.Location = new System.Drawing.Point(24, 261);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("UVN Bay Buom Hep", 24F, System.Drawing.FontStyle.Bold);
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(70, 261);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(117, 36);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Username";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("UVN Bay Buom Hep", 24F, System.Drawing.FontStyle.Bold);
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(70, 309);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(117, 36);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Password";
            // 
            // TextBox_Username
            // 
            this.TextBox_Username.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBox_Username.Border.Class = "TextBoxBorder";
            this.TextBox_Username.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBox_Username.DisabledBackColor = System.Drawing.Color.White;
            this.TextBox_Username.Font = new System.Drawing.Font("UVN Chim Bien", 14.25F, System.Drawing.FontStyle.Bold);
            this.TextBox_Username.ForeColor = System.Drawing.Color.Black;
            this.TextBox_Username.Location = new System.Drawing.Point(193, 265);
            this.TextBox_Username.Name = "TextBox_Username";
            this.TextBox_Username.PreventEnterBeep = true;
            this.TextBox_Username.Size = new System.Drawing.Size(267, 34);
            this.TextBox_Username.TabIndex = 2;
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBox_Password.Border.Class = "TextBoxBorder";
            this.TextBox_Password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBox_Password.DisabledBackColor = System.Drawing.Color.White;
            this.TextBox_Password.Font = new System.Drawing.Font("UVN Chim Bien", 14.25F, System.Drawing.FontStyle.Bold);
            this.TextBox_Password.ForeColor = System.Drawing.Color.Black;
            this.TextBox_Password.Location = new System.Drawing.Point(193, 313);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.PasswordChar = '*';
            this.TextBox_Password.PreventEnterBeep = true;
            this.TextBox_Password.Size = new System.Drawing.Size(267, 34);
            this.TextBox_Password.TabIndex = 3;
            // 
            // rbtCapkhoa
            // 
            this.rbtCapkhoa.AutoSize = true;
            this.rbtCapkhoa.Font = new System.Drawing.Font("UVN Bay Buom Hep", 18F, System.Drawing.FontStyle.Bold);
            this.rbtCapkhoa.ForeColor = System.Drawing.Color.Black;
            this.rbtCapkhoa.Location = new System.Drawing.Point(45, 372);
            this.rbtCapkhoa.Name = "rbtCapkhoa";
            this.rbtCapkhoa.Size = new System.Drawing.Size(174, 34);
            this.rbtCapkhoa.TabIndex = 4;
            this.rbtCapkhoa.TabStop = true;
            this.rbtCapkhoa.Text = "Cán bộ cấp khoa";
            this.rbtCapkhoa.UseVisualStyleBackColor = true;
            this.rbtCapkhoa.CheckedChanged += new System.EventHandler(this.rbtCapkhoa_CheckedChanged);
            // 
            // rbtCapchidoan
            // 
            this.rbtCapchidoan.AutoSize = true;
            this.rbtCapchidoan.Font = new System.Drawing.Font("UVN Bay Buom Hep", 18F, System.Drawing.FontStyle.Bold);
            this.rbtCapchidoan.ForeColor = System.Drawing.Color.Black;
            this.rbtCapchidoan.Location = new System.Drawing.Point(249, 372);
            this.rbtCapchidoan.Name = "rbtCapchidoan";
            this.rbtCapchidoan.Size = new System.Drawing.Size(202, 34);
            this.rbtCapchidoan.TabIndex = 4;
            this.rbtCapchidoan.TabStop = true;
            this.rbtCapchidoan.Text = "Cán bộ cấp chi đoàn";
            this.rbtCapchidoan.UseVisualStyleBackColor = true;
            this.rbtCapchidoan.CheckedChanged += new System.EventHandler(this.rbtCapchidoan_CheckedChanged);
            // 
            // cbxChidoan
            // 
            this.cbxChidoan.DisplayMember = "Text";
            this.cbxChidoan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxChidoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChidoan.Font = new System.Drawing.Font("UVN Chim Bien", 14.25F);
            this.cbxChidoan.ForeColor = System.Drawing.Color.Black;
            this.cbxChidoan.FormattingEnabled = true;
            this.cbxChidoan.ItemHeight = 29;
            this.cbxChidoan.Location = new System.Drawing.Point(130, 474);
            this.cbxChidoan.Name = "cbxChidoan";
            this.cbxChidoan.Size = new System.Drawing.Size(219, 35);
            this.cbxChidoan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxChidoan.TabIndex = 5;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("UVN Bay Buom Hep", 18F, System.Drawing.FontStyle.Bold);
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(181, 427);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(141, 37);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "Chọn chi đoàn";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::DA_QLDV.Properties.Resources.iconfinder_Log_Out_27856;
            this.buttonX1.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.buttonX1.Location = new System.Drawing.Point(46, 543);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(182, 54);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 6;
            this.buttonX1.Text = "  Thoát";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Image = global::DA_QLDV.Properties.Resources.iconfinder_Log_Out_278562;
            this.buttonX2.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.buttonX2.Location = new System.Drawing.Point(258, 543);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(182, 54);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 6;
            this.buttonX2.Text = "  Đăng Nhập";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("UVN Van", 30F, System.Drawing.FontStyle.Bold);
            this.labelX4.ForeColor = System.Drawing.Color.Red;
            this.labelX4.Location = new System.Drawing.Point(127, 181);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(243, 57);
            this.labelX4.TabIndex = 1;
            this.labelX4.Text = "ĐĂNG NHẬP";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(488, 621);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.cbxChidoan);
            this.Controls.Add(this.rbtCapchidoan);
            this.Controls.Add(this.rbtCapkhoa);
            this.Controls.Add(this.TextBox_Password);
            this.Controls.Add(this.TextBox_Username);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("UVN Bay Buom Hep", 16.2F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX TextBox_Username;
        private DevComponents.DotNetBar.Controls.TextBoxX TextBox_Password;
        private System.Windows.Forms.RadioButton rbtCapkhoa;
        private System.Windows.Forms.RadioButton rbtCapchidoan;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxChidoan;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.LabelX labelX4;
    }
}