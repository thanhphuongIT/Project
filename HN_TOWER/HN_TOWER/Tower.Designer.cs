namespace HN_TOWER
{
    partial class Tower
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnC = new System.Windows.Forms.Button();
            this.btnTowerC = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.DarkRed;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.ForeColor = System.Drawing.Color.White;
            this.btnC.Location = new System.Drawing.Point(0, 127);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(111, 23);
            this.btnC.TabIndex = 0;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTowerC
            // 
            this.btnTowerC.BackColor = System.Drawing.Color.Blue;
            this.btnTowerC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTowerC.ForeColor = System.Drawing.Color.Black;
            this.btnTowerC.Location = new System.Drawing.Point(49, 1);
            this.btnTowerC.Name = "btnTowerC";
            this.btnTowerC.Size = new System.Drawing.Size(12, 127);
            this.btnTowerC.TabIndex = 4;
            this.btnTowerC.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 11);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Tower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTowerC);
            this.Controls.Add(this.btnC);
            this.Name = "Tower";
            this.Size = new System.Drawing.Size(112, 153);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnTowerC;
        private System.Windows.Forms.Button button2;
    }
}
