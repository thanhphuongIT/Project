namespace DemoFlappyBird
{
    partial class FlappyBird
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlappyBird));
            this.timerNenDat = new System.Windows.Forms.Timer(this.components);
            this.timerCotNuoc = new System.Windows.Forms.Timer(this.components);
            this.timerBird = new System.Windows.Forms.Timer(this.components);
            this.lbDiem = new System.Windows.Forms.Label();
            this.pnGame = new System.Windows.Forms.Panel();
            this.btnThongTin = new System.Windows.Forms.Button();
            this.btnDiemCao = new System.Windows.Forms.Button();
            this.btnVaoGame = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerNenDat
            // 
            this.timerNenDat.Tick += new System.EventHandler(this.timerNenDat_Tick);
            // 
            // timerCotNuoc
            // 
            this.timerCotNuoc.Tick += new System.EventHandler(this.timerCotNuoc_Tick);
            // 
            // timerBird
            // 
            this.timerBird.Tick += new System.EventHandler(this.timerBird_Tick);
            // 
            // lbDiem
            // 
            resources.ApplyResources(this.lbDiem, "lbDiem");
            this.lbDiem.Name = "lbDiem";
            // 
            // pnGame
            // 
            this.pnGame.BackgroundImage = global::DemoFlappyBird.Properties.Resources.BT;
            this.pnGame.Controls.Add(this.btnThongTin);
            this.pnGame.Controls.Add(this.btnDiemCao);
            this.pnGame.Controls.Add(this.btnVaoGame);
            this.pnGame.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.pnGame, "pnGame");
            this.pnGame.Name = "pnGame";
            // 
            // btnThongTin
            // 
            resources.ApplyResources(this.btnThongTin, "btnThongTin");
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.UseVisualStyleBackColor = true;
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            this.btnThongTin.MouseLeave += new System.EventHandler(this.btnThongTin_MouseLeave);
            this.btnThongTin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button2_MouseMove);
            // 
            // btnDiemCao
            // 
            resources.ApplyResources(this.btnDiemCao, "btnDiemCao");
            this.btnDiemCao.Name = "btnDiemCao";
            this.btnDiemCao.UseVisualStyleBackColor = true;
            this.btnDiemCao.Click += new System.EventHandler(this.btnDiemCao_Click);
            this.btnDiemCao.MouseLeave += new System.EventHandler(this.btnDiemCao_MouseLeave);
            this.btnDiemCao.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnDiemCao_MouseMove);
            // 
            // btnVaoGame
            // 
            resources.ApplyResources(this.btnVaoGame, "btnVaoGame");
            this.btnVaoGame.Name = "btnVaoGame";
            this.btnVaoGame.UseVisualStyleBackColor = true;
            this.btnVaoGame.Click += new System.EventHandler(this.btnVaoGame_Click);
            this.btnVaoGame.MouseLeave += new System.EventHandler(this.btnVaoGame_MouseLeave);
            this.btnVaoGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnVaoGame_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::DemoFlappyBird.Properties.Resources.Flappybird;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // FlappyBird
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pnGame);
            this.Controls.Add(this.lbDiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FlappyBird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            this.pnGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerNenDat;
        private System.Windows.Forms.Timer timerCotNuoc;
        private System.Windows.Forms.Timer timerBird;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.Panel pnGame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDiemCao;
        private System.Windows.Forms.Button btnVaoGame;
        private System.Windows.Forms.Button btnThongTin;
    }
}

