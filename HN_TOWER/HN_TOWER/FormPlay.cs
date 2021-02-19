using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HN_TOWER
{
    public partial class FormPlay : Form
    {
        TimeSpan time;
        PictureBox[] disks;
        int movecount;
        Stack<PictureBox> diskA, diskB, diskC, Firstclick, Secondclick;
        const int firstY = 462, Diskhight = 20, rodtodisk = 26;
        public FormPlay()
        {
            InitializeComponent();
            disks = new PictureBox[] { pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8 };
            picrod1.Tag = diskA = new Stack<PictureBox>();
            picrod2.Tag = diskB = new Stack<PictureBox>();
            picrod3.Tag = diskC = new Stack<PictureBox>();
        }

        private void btnthua_Click(object sender, EventArgs e)
        {
            tmrtime.Stop();
            nudllevel.Enabled = true;
            btnthua.Enabled = false;
            btnconduction.Enabled = true;
        }

        private void btnrule_Click(object sender, EventArgs e)
        {
            Conduction dlg1 = new Conduction();
            dlg1.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (nudllevel.Enabled) return;//is not play
            PictureBox clickrod = (PictureBox)sender;
            Stack<PictureBox> diskofclickrod = (Stack<PictureBox>)clickrod.Tag;
            if (Firstclick == null)
            {
                if (diskofclickrod.Count == 0) return;
                Firstclick = diskofclickrod;
                clickrod.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (Secondclick == null)
            {
                if (diskofclickrod == Firstclick)
                {
                    Firstclick = null;
                    clickrod.BorderStyle = BorderStyle.None;
                    return;
                }
                Secondclick = diskofclickrod;
                ProcessMovingDisk(clickrod);
            }
        }
        private void ProcessMovingDisk(PictureBox clickrod)
        {
            if (Secondclick.Count == 0)
                MoveDick(new Point(clickrod.Location.X + rodtodisk, firstY));
            else
            {
                PictureBox FirstTopDisk = Firstclick.Peek();
                PictureBox SecondTopDisk = Secondclick.Peek();
                if (int.Parse(FirstTopDisk.Tag.ToString()) < int.Parse(SecondTopDisk.Tag.ToString()))
                {
                    MoveDick(new Point(SecondTopDisk.Location.X, SecondTopDisk.Location.Y - Diskhight));
                }
                else
                    Secondclick = null;

            }
        }
        private void MoveDick(Point point)
        {
            PictureBox FirstTopDisk = Firstclick.Pop();
            FirstTopDisk.Location = point;
            Secondclick.Push(FirstTopDisk);
            ++movecount;
            lbldichuyen.Text = string.Format("Di Chuyển: {0} Lần", movecount);
            Firstclick = Secondclick = null;
            picrod1.BorderStyle = picrod2.BorderStyle = picrod3.BorderStyle = BorderStyle.None;
            if (diskC.Count == nudllevel.Value)
            {
                btnthua.PerformClick();
                btnconduction.Enabled = true;
                MessageBox.Show("CHÚC MỪNG BẠN ĐÃ CHIẾN THẮNG", "WINER");
            }
        }

        private void btnconduction_Click(object sender, EventArgs e)
        {
            TowerKQ dlg2 = new TowerKQ();
            dlg2.ShowDialog();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PictureBox clickDisk = (PictureBox)sender;
            if (diskA.Contains(clickDisk))
                pictureBox1_Click(picrod1, new EventArgs());
            else if (diskB.Contains(clickDisk))
                pictureBox1_Click(picrod2, new EventArgs());
            else pictureBox1_Click(picrod3, new EventArgs());
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thoát ?", "THOÁT",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (ret == DialogResult.Yes) Close();
        }
        private void FormPlay_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //reset
            tmrtime.Stop();
            foreach (PictureBox i in disks)
                i.Visible = false;
            time = new TimeSpan(0);
            movecount = 0;
            lbltime.Text = "Thời Gian:00:00:00";
            lbldichuyen.Text = "Di Chuyển: 0 Lần";
            diskA.Clear(); diskB.Clear(); diskC.Clear();
            picrod1.BorderStyle = picrod2.BorderStyle = picrod3.BorderStyle = BorderStyle.None;
            Firstclick = Secondclick = null;
            //initialze
            nudllevel.Enabled = false;
            btnthua.Enabled = true;
            int x = picrod1.Location.X + rodtodisk, y = firstY;
            for (int i = (int)nudllevel.Value - 1; i >= 0; i--, y -= Diskhight)
            {
                disks[i].Location = new Point(x, y);
                disks[i].Visible = true;
                diskA.Push(disks[i]);
            }
            tmrtime.Start();
            btnconduction.Enabled = false;
        }
        private void tmrtime_Tick(object sender, EventArgs e)
        {
            time = time.Add(new TimeSpan(0, 0, 1));
            lbltime.Text = string.Format("Thời Gian:{0:00}:{1:00}:{2:00}", time.Hours, time.Minutes, time.Seconds);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
