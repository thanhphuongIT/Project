namespace DA_QLDV
{
    partial class Form_TaoTaiKhoan
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
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.btnTaotaikhoan = new DevComponents.DotNetBar.ButtonX();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtUsername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbxChidoan = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.rbtCapkhoa = new System.Windows.Forms.RadioButton();
            this.rbtCapchidoan = new System.Windows.Forms.RadioButton();
            this.txtPassword_lai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DA_QLDV.Properties.Resources.iconfinder_user_143817;
            this.pictureBox1.Location = new System.Drawing.Point(466, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // reflectionLabel1
            // 
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Font = new System.Drawing.Font("UVN Hong Ha Hep", 36F, System.Drawing.FontStyle.Bold);
            this.reflectionLabel1.ForeColor = System.Drawing.Color.Red;
            this.reflectionLabel1.Location = new System.Drawing.Point(406, 177);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(307, 114);
            this.reflectionLabel1.TabIndex = 4;
            this.reflectionLabel1.Text = "TẠO TÀI KHOẢN";
            // 
            // btnTaotaikhoan
            // 
            this.btnTaotaikhoan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTaotaikhoan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTaotaikhoan.Font = new System.Drawing.Font("UVN Bay Buom Hep", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnTaotaikhoan.Image = global::DA_QLDV.Properties.Resources.icons8_user_account_80;
            this.btnTaotaikhoan.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btnTaotaikhoan.Location = new System.Drawing.Point(470, 603);
            this.btnTaotaikhoan.Name = "btnTaotaikhoan";
            this.btnTaotaikhoan.Size = new System.Drawing.Size(189, 66);
            this.btnTaotaikhoan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTaotaikhoan.TabIndex = 13;
            this.btnTaotaikhoan.Text = "Tạo tài khoản";
            this.btnTaotaikhoan.Click += new System.EventHandler(this.btnTaotaikhoan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UVN Bay Buom Hep", 16.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(311, 525);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Chọn chi đoàn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UVN Bay Buom Hep", 16.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(311, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Chọn chức vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UVN Bay Buom Hep", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(311, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nhập Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UVN Bay Buom Hep", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(310, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nhập Username ";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPassword.Border.Class = "TextBoxBorder";
            this.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPassword.DisabledBackColor = System.Drawing.Color.White;
            this.txtPassword.Font = new System.Drawing.Font("UVN Chim Bien", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(546, 345);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PreventEnterBeep = true;
            this.txtPassword.Size = new System.Drawing.Size(243, 30);
            this.txtPassword.TabIndex = 6;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtUsername.Border.Class = "TextBoxBorder";
            this.txtUsername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUsername.DisabledBackColor = System.Drawing.Color.White;
            this.txtUsername.Font = new System.Drawing.Font("UVN Chim Bien", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(546, 295);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PreventEnterBeep = true;
            this.txtUsername.Size = new System.Drawing.Size(243, 30);
            this.txtUsername.TabIndex = 8;
            // 
            // cbxChidoan
            // 
            this.cbxChidoan.DisplayMember = "Text";
            this.cbxChidoan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxChidoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChidoan.Enabled = false;
            this.cbxChidoan.Font = new System.Drawing.Font("UVN Chim Bien", 12F, System.Drawing.FontStyle.Bold);
            this.cbxChidoan.ForeColor = System.Drawing.Color.Black;
            this.cbxChidoan.FormattingEnabled = true;
            this.cbxChidoan.ItemHeight = 25;
            this.cbxChidoan.Location = new System.Drawing.Point(546, 525);
            this.cbxChidoan.Name = "cbxChidoan";
            this.cbxChidoan.Size = new System.Drawing.Size(243, 31);
            this.cbxChidoan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxChidoan.TabIndex = 2;
            // 
            // rbtCapkhoa
            // 
            this.rbtCapkhoa.AutoSize = true;
            this.rbtCapkhoa.Location = new System.Drawing.Point(546, 446);
            this.rbtCapkhoa.Name = "rbtCapkhoa";
            this.rbtCapkhoa.Size = new System.Drawing.Size(149, 24);
            this.rbtCapkhoa.TabIndex = 14;
            this.rbtCapkhoa.TabStop = true;
            this.rbtCapkhoa.Text = "Cán bộ cấp khoa";
            this.rbtCapkhoa.UseVisualStyleBackColor = true;
            this.rbtCapkhoa.CheckedChanged += new System.EventHandler(this.rbtCapkhoa_CheckedChanged);
            // 
            // rbtCapchidoan
            // 
            this.rbtCapchidoan.AutoSize = true;
            this.rbtCapchidoan.Location = new System.Drawing.Point(546, 485);
            this.rbtCapchidoan.Name = "rbtCapchidoan";
            this.rbtCapchidoan.Size = new System.Drawing.Size(176, 24);
            this.rbtCapchidoan.TabIndex = 14;
            this.rbtCapchidoan.TabStop = true;
            this.rbtCapchidoan.Text = "Cán bộ cấp chi đoàn";
            this.rbtCapchidoan.UseVisualStyleBackColor = true;
            this.rbtCapchidoan.CheckedChanged += new System.EventHandler(this.rbtCapchidoan_CheckedChanged);
            // 
            // txtPassword_lai
            // 
            this.txtPassword_lai.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPassword_lai.Border.Class = "TextBoxBorder";
            this.txtPassword_lai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPassword_lai.DisabledBackColor = System.Drawing.Color.White;
            this.txtPassword_lai.Font = new System.Drawing.Font("UVN Chim Bien", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword_lai.ForeColor = System.Drawing.Color.Black;
            this.txtPassword_lai.Location = new System.Drawing.Point(546, 394);
            this.txtPassword_lai.Name = "txtPassword_lai";
            this.txtPassword_lai.PasswordChar = '*';
            this.txtPassword_lai.PreventEnterBeep = true;
            this.txtPassword_lai.Size = new System.Drawing.Size(243, 30);
            this.txtPassword_lai.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("UVN Bay Buom Hep", 16.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(310, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nhập lại Password";
            // 
            // Form_TaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1084, 698);
            this.Controls.Add(this.rbtCapchidoan);
            this.Controls.Add(this.rbtCapkhoa);
            this.Controls.Add(this.btnTaotaikhoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword_lai);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.reflectionLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbxChidoan);
            this.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 10.8F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_TaoTaiKhoan";
            this.Text = "Form_Taotaikhoan";
            this.Load += new System.EventHandler(this.Form_TaoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.ButtonX btnTaotaikhoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUsername;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxChidoan;
        private System.Windows.Forms.RadioButton rbtCapkhoa;
        private System.Windows.Forms.RadioButton rbtCapchidoan;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPassword_lai;
        private System.Windows.Forms.Label label5;
    }
}