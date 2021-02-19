namespace DemoFlappyBird
{
    partial class FormTenNC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTenNC));
            this.btnVao = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txbTenNguoiChoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVao
            // 
            this.btnVao.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVao.Location = new System.Drawing.Point(245, 174);
            this.btnVao.Name = "btnVao";
            this.btnVao.Size = new System.Drawing.Size(79, 34);
            this.btnVao.TabIndex = 0;
            this.btnVao.Text = "Vào";
            this.btnVao.UseVisualStyleBackColor = true;
            this.btnVao.Click += new System.EventHandler(this.btnVao_Click);
            this.btnVao.MouseLeave += new System.EventHandler(this.btnVao_MouseLeave);
            this.btnVao.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnVao_MouseMove);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(345, 174);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(79, 34);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            this.btnThoat.MouseLeave += new System.EventHandler(this.btnThoat_MouseLeave);
            this.btnThoat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnThoat_MouseMove);
            // 
            // txbTenNguoiChoi
            // 
            this.txbTenNguoiChoi.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenNguoiChoi.Location = new System.Drawing.Point(208, 61);
            this.txbTenNguoiChoi.Name = "txbTenNguoiChoi";
            this.txbTenNguoiChoi.Size = new System.Drawing.Size(216, 32);
            this.txbTenNguoiChoi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên người chơi:";
            // 
            // FormTenNC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(461, 220);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbTenNguoiChoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnVao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTenNC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVao;
        private System.Windows.Forms.Button btnThoat;
        public System.Windows.Forms.TextBox txbTenNguoiChoi;
        private System.Windows.Forms.Label label1;
    }
}