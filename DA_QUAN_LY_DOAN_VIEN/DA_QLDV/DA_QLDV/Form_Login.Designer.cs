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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Button_DangNhap = new DevComponents.DotNetBar.ButtonX();
            this.Button_Thoat = new DevComponents.DotNetBar.ButtonX();
            this.TextBox_Password = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TextBox_Username = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.CheckBox_Canbokhoa = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.CheckBox_Canbochidoan = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.ComboBox_Canbochidoan = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(44, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(44, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // Button_DangNhap
            // 
            this.Button_DangNhap.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Button_DangNhap.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Button_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Button_DangNhap.Location = new System.Drawing.Point(48, 414);
            this.Button_DangNhap.Name = "Button_DangNhap";
            this.Button_DangNhap.Size = new System.Drawing.Size(164, 50);
            this.Button_DangNhap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Button_DangNhap.TabIndex = 4;
            this.Button_DangNhap.Text = "ĐĂNG NHẬP";
            this.Button_DangNhap.Click += new System.EventHandler(this.Button_DangNhap_Click);
            // 
            // Button_Thoat
            // 
            this.Button_Thoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Button_Thoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Button_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Button_Thoat.Location = new System.Drawing.Point(224, 414);
            this.Button_Thoat.Name = "Button_Thoat";
            this.Button_Thoat.Size = new System.Drawing.Size(164, 50);
            this.Button_Thoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Button_Thoat.TabIndex = 5;
            this.Button_Thoat.Text = "THOÁT";
            // 
            // TextBox_Password
            // 
            // 
            // 
            // 
            this.TextBox_Password.Border.Class = "TextBoxBorder";
            this.TextBox_Password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.TextBox_Password.Location = new System.Drawing.Point(133, 228);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.PreventEnterBeep = true;
            this.TextBox_Password.Size = new System.Drawing.Size(269, 26);
            this.TextBox_Password.TabIndex = 6;
            // 
            // TextBox_Username
            // 
            // 
            // 
            // 
            this.TextBox_Username.Border.Class = "TextBoxBorder";
            this.TextBox_Username.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBox_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.TextBox_Username.Location = new System.Drawing.Point(133, 180);
            this.TextBox_Username.Name = "TextBox_Username";
            this.TextBox_Username.PreventEnterBeep = true;
            this.TextBox_Username.Size = new System.Drawing.Size(269, 26);
            this.TextBox_Username.TabIndex = 7;
            // 
            // CheckBox_Canbokhoa
            // 
            // 
            // 
            // 
            this.CheckBox_Canbokhoa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckBox_Canbokhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.CheckBox_Canbokhoa.Location = new System.Drawing.Point(75, 279);
            this.CheckBox_Canbokhoa.Name = "CheckBox_Canbokhoa";
            this.CheckBox_Canbokhoa.Size = new System.Drawing.Size(145, 23);
            this.CheckBox_Canbokhoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.CheckBox_Canbokhoa.TabIndex = 8;
            this.CheckBox_Canbokhoa.Text = "Cán bộ cấp khoa";
            this.CheckBox_Canbokhoa.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CheckBox_Canbokhoa.Click += new System.EventHandler(this.CheckBox_Canbokhoa_Click);
            // 
            // CheckBox_Canbochidoan
            // 
            // 
            // 
            // 
            this.CheckBox_Canbochidoan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckBox_Canbochidoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.CheckBox_Canbochidoan.Location = new System.Drawing.Point(226, 279);
            this.CheckBox_Canbochidoan.Name = "CheckBox_Canbochidoan";
            this.CheckBox_Canbochidoan.Size = new System.Drawing.Size(166, 23);
            this.CheckBox_Canbochidoan.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.CheckBox_Canbochidoan.TabIndex = 9;
            this.CheckBox_Canbochidoan.Text = "Cán bộ cấp chi đoàn";
            this.CheckBox_Canbochidoan.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CheckBox_Canbochidoan.CheckedChanged += new System.EventHandler(this.CheckBox_Canbochidoan_CheckedChanged);
            // 
            // ComboBox_Canbochidoan
            // 
            this.ComboBox_Canbochidoan.DisplayMember = "Text";
            this.ComboBox_Canbochidoan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_Canbochidoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBox_Canbochidoan.FormattingEnabled = true;
            this.ComboBox_Canbochidoan.ItemHeight = 28;
            this.ComboBox_Canbochidoan.Location = new System.Drawing.Point(140, 362);
            this.ComboBox_Canbochidoan.Name = "ComboBox_Canbochidoan";
            this.ComboBox_Canbochidoan.Size = new System.Drawing.Size(166, 34);
            this.ComboBox_Canbochidoan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBox_Canbochidoan.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(178, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 55);
            this.label3.TabIndex = 11;
            this.label3.Text = "ĐĂNG NHẬP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::DA_QLDV.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(168, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Chọn chi đoàn";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(434, 488);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboBox_Canbochidoan);
            this.Controls.Add(this.CheckBox_Canbochidoan);
            this.Controls.Add(this.CheckBox_Canbokhoa);
            this.Controls.Add(this.TextBox_Username);
            this.Controls.Add(this.TextBox_Password);
            this.Controls.Add(this.Button_Thoat);
            this.Controls.Add(this.Button_DangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "From_Login";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.ButtonX Button_DangNhap;
        private DevComponents.DotNetBar.ButtonX Button_Thoat;
        private DevComponents.DotNetBar.Controls.TextBoxX TextBox_Password;
        private DevComponents.DotNetBar.Controls.TextBoxX TextBox_Username;
        private DevComponents.DotNetBar.Controls.CheckBoxX CheckBox_Canbokhoa;
        private DevComponents.DotNetBar.Controls.CheckBoxX CheckBox_Canbochidoan;
        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBox_Canbochidoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}