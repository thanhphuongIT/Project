namespace HN_TOWER
{
    partial class TowerKQ
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
            this.btnStart = new System.Windows.Forms.Button();
            this.nuNumberOfPlate = new System.Windows.Forms.NumericUpDown();
            this.pnMain = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.towerC = new HN_TOWER.Tower();
            this.towerB = new HN_TOWER.Tower();
            this.towerA = new HN_TOWER.Tower();
            ((System.ComponentModel.ISupportInitialize)(this.nuNumberOfPlate)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 14);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(69, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Result";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // nuNumberOfPlate
            // 
            this.nuNumberOfPlate.Location = new System.Drawing.Point(6, 43);
            this.nuNumberOfPlate.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nuNumberOfPlate.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nuNumberOfPlate.Name = "nuNumberOfPlate";
            this.nuNumberOfPlate.Size = new System.Drawing.Size(69, 20);
            this.nuNumberOfPlate.TabIndex = 2;
            this.nuNumberOfPlate.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // pnMain
            // 
            this.pnMain.Location = new System.Drawing.Point(2, 2);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(438, 75);
            this.pnMain.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(6, 69);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.nuNumberOfPlate);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Location = new System.Drawing.Point(356, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(84, 107);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(2, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 40);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(162, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Conduction";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // towerC
            // 
            this.towerC.BackGroundColor = System.Drawing.Color.Yellow;
            this.towerC.Finish = null;
            this.towerC.Location = new System.Drawing.Point(238, 80);
            this.towerC.Name = "towerC";
            this.towerC.Plate = null;
            this.towerC.Size = new System.Drawing.Size(112, 153);
            this.towerC.TabIndex = 0;
            this.towerC.TextLabel = "C";
            this.towerC.Load += new System.EventHandler(this.tower1_Load);
            // 
            // towerB
            // 
            this.towerB.BackGroundColor = System.Drawing.Color.Lime;
            this.towerB.Finish = null;
            this.towerB.Location = new System.Drawing.Point(120, 80);
            this.towerB.Name = "towerB";
            this.towerB.Plate = null;
            this.towerB.Size = new System.Drawing.Size(112, 153);
            this.towerB.TabIndex = 0;
            this.towerB.TextLabel = "B";
            this.towerB.Load += new System.EventHandler(this.tower1_Load);
            // 
            // towerA
            // 
            this.towerA.BackGroundColor = System.Drawing.Color.Red;
            this.towerA.Finish = null;
            this.towerA.Location = new System.Drawing.Point(2, 80);
            this.towerA.Name = "towerA";
            this.towerA.Plate = null;
            this.towerA.Size = new System.Drawing.Size(112, 153);
            this.towerA.TabIndex = 0;
            this.towerA.TextLabel = "A";
            this.towerA.Load += new System.EventHandler(this.tower1_Load);
            // 
            // TowerKQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(440, 275);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.towerC);
            this.Controls.Add(this.towerB);
            this.Controls.Add(this.towerA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TowerKQ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TowerKQ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuNumberOfPlate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Tower towerA;
        private Tower towerB;
        private Tower towerC;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown nuNumberOfPlate;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

