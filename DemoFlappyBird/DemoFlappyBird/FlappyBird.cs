using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace DemoFlappyBird
{
    public partial class FlappyBird : Form
    {
        FormTenNC fnc;
        public FlappyBird()
        {
            InitializeComponent();
        }
        
        PictureBox nenDat = new PictureBox();
        PictureBox nendat2 = new PictureBox();
        PictureBox Bird = new PictureBox();
        PictureBox OngncT = new PictureBox();
        PictureBox OngncT1 = new PictureBox();
        PictureBox OngncD = new PictureBox();
        PictureBox OngncD1 = new PictureBox();

        SoundPlayer msQuaCot = new SoundPlayer("QuaCot.wav");
        SoundPlayer msKetThuc = new SoundPlayer("STUPID.wav");
        SoundPlayer msGame = new SoundPlayer("High.wav");

        List<NguoiChoi> xhNguoiChoi = new List<NguoiChoi>();
        Label lbgame = new Label();
        Random rd = new Random();

        int x = 300, x1 = 565;
        int ybrid = 100; //Toa do Y cua Bird : 100;
        int rdyT = -350, rdyT1 = -350;
        int rdyD = 250, rdyD1 = 250;
        int saveC = 300, saveC1 = 565;
        int diem = 0;
        bool flag = false, flagBird = false;
        bool flag1 = true, flag2 = false, flag3 = false, flag4 = false;


        private void TaoNenDat()
        {
            nenDat.Location = new Point(0,400);
            nenDat.Size = new Size(700, 100);
            nenDat.BackgroundImage = Properties.Resources.NenDat;

            this.Controls.Add(nenDat);
        }

        private void TaoBird()
        {
            Bird.Location = new Point(30, 100);
            Bird.Size = new Size(50,50);
            Bird.BackgroundImage = Properties.Resources.Rong1;
            Bird.BackgroundImageLayout = ImageLayout.Stretch;
            this.Controls.Add(Bird);
        }

        private void TaoOng()
        {
            OngncT.Location = new Point(300,-350);
            OngncT.Size = new Size(65, 500);
            OngncT.BackgroundImage = Properties.Resources.OngnuocTren;
            OngncT.BackColor = Color.Transparent;

            OngncD.Location = new Point(300,250);
            OngncD.Size = new Size(65, 500);
            OngncD.BackgroundImage = Properties.Resources.OngnuocDuoi;
            OngncD.BackColor = Color.Transparent;

            OngncT1.Location = new Point(565, -350);
            OngncT1.Size = new Size(65, 500);
            OngncT1.BackgroundImage = Properties.Resources.OngnuocTren;
            OngncT1.BackColor = Color.Transparent;

            OngncD1.Location = new Point(565, 250);
            OngncD1.Size = new Size(65, 500);
            OngncD1.BackgroundImage = Properties.Resources.OngnuocDuoi;
            OngncD1.BackColor = Color.Transparent;

            this.Controls.Add(OngncT);
            this.Controls.Add(OngncT1);
            this.Controls.Add(OngncD);
            this.Controls.Add(OngncD1);
        }

        private void TaoLabelGame()
        {
            lbgame.Location = new Point(130, 180);
            lbgame.Size = new Size(300, 50);
            lbgame.BackColor = Color.Transparent;
            lbgame.Font = new Font("Consolas", 14, FontStyle.Bold);
            lbgame.Text = "Hãy nhấp Space để chơi";

            this.Controls.Add(lbgame);
        }

        private void btnDiemCao_Click(object sender, EventArgs e)
        {
            FormDiem fd = new FormDiem();
            fd.ShowDialog();
            if (fd.DialogResult == DialogResult.Cancel)
                pnGame.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pnGame.Hide();
            TaoBird();
            TaoNenDat();
            TaoOng();
            ReadFile();
            TaoLabelGame();
            msGame.Play();

            this.BackgroundImage = Properties.Resources.BT;
            this.Bird.BackColor = Color.Transparent;
            this.lbDiem.BackColor = Color.Transparent;
            timerCotNuoc.Interval = 20;
            timerBird.Interval = 10;
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void btnVaoGame_Click(object sender, EventArgs e)
        {
            fnc = new DemoFlappyBird.FormTenNC();
            fnc.ShowDialog();
            if (fnc.DialogResult == DialogResult.Cancel)
                pnGame.Focus();
            else
            {
                msGame.Stop();
                pnGame.Hide();
                this.Focus();
            }
        }

        private void timerCotNuoc_Tick(object sender, EventArgs e)
        {
            x -= 3;
            saveC = x;
            x1 -= 3;
            saveC1 = x1;


            OngncT.Location = new Point(x, rdyT);
            OngncD.Location = new Point(x, rdyD);
            OngncT1.Location = new Point(x1, rdyT1);
            OngncD1.Location = new Point(x1, rdyD1);
            if (x <= -60)
            {
                x = 500;
                rdyT = rd.Next(-350, -300);
                rdyD = rd.Next(270, 300);
            }
            if (x1 <= -60)
            {
                x1 = 500;
                rdyT1 = rd.Next(-350, -300);
                rdyD1 = rd.Next(270, 300);
            }
            CongDiem();
        }

        private void timerBird_Tick(object sender, EventArgs e)
        {
            if(flagBird == true)
            {
                ybrid += 3;
                if (flag1 == true)
                {
                    Bird.BackgroundImage = Properties.Resources.Rong1;
                    Bird.Location = new Point(50, ybrid);
                    flag1 = false;
                    flag2 = true;
                    flag3 = false;
                    flag4 = false;
                }
                else if (flag2 == true)
                {
                    Bird.BackgroundImage = Properties.Resources.Rong2;
                    Bird.Location = new Point(50, ybrid);
                    flag1 = false;
                    flag2 = false;
                    flag3 = true;
                    flag4 = false;
                }
                else if (flag3 == true)
                {
                    Bird.BackgroundImage = Properties.Resources.Rong3;
                    Bird.Location = new Point(50, ybrid);
                    flag1 = false;
                    flag2 = false;
                    flag3 = false;
                    flag4 = true;
                }
                else if (flag4 == true)
                {
                    Bird.BackgroundImage = Properties.Resources.Rong4;
                    Bird.Location = new Point(50, ybrid);
                    flag1 = true;
                    flag2 = false;
                    flag3 = false;
                    flag4 = false;
                }
                XuLiVaCham();
            }
            if (ybrid >= 354)
            {
                this.Bird.BackgroundImage = Properties.Resources.GameOver;
                timerBird.Stop();
            }
        }

        private void btnVaoGame_MouseMove(object sender, MouseEventArgs e)
        {
            btnVaoGame.BackColor = Color.SkyBlue;
            btnVaoGame.ForeColor = Color.DarkRed;
        }

        private void btnVaoGame_MouseLeave(object sender, EventArgs e)
        {
            btnVaoGame.BackColor = Color.Transparent;
            btnVaoGame.ForeColor = Color.Black;
        }

        private void btnDiemCao_MouseMove(object sender, MouseEventArgs e)
        {
            btnDiemCao.BackColor = Color.SkyBlue;
            btnDiemCao.ForeColor = Color.DarkRed;
        }

        private void btnDiemCao_MouseLeave(object sender, EventArgs e)
        {
            btnDiemCao.BackColor = Color.Transparent;
            btnDiemCao.ForeColor = Color.Black;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            btnThongTin.BackColor = Color.SkyBlue;
            btnThongTin.ForeColor = Color.DarkRed;
        }

        private void btnThongTin_MouseLeave(object sender, EventArgs e)
        {
            btnThongTin.BackColor = Color.Transparent;
            btnThongTin.ForeColor = Color.Black;
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            FormThongTin ftt = new FormThongTin();
            ftt.ShowDialog();
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            lbgame.Hide();
            if (e.KeyCode == Keys.Space)
            {
                timerCotNuoc.Start();
                timerBird.Start();
                ybrid -= 30;
                this.Bird.BackgroundImage = Properties.Resources.Rong1;
                this.Bird.BackColor = Color.Transparent;
                this.Bird.Location = new Point(50, ybrid);
                //XuLiVaCham();
                flagBird = true;
            }
        }

        private void timerNenDat_Tick(object sender, EventArgs e)
        {
            do
            {
                if (x <= 0 && x1 <=500)
                {
                    x -= 10;
                    x1 -= 10;
                    nenDat.Location = new Point(x, 400);
                    nendat2.Location = new Point(x1, 400);
                }
                if (x == -500)
                {
                    timerNenDat.Stop();
                    break;
                }
            } while (flag == true);
        }

        //Toa do Bird : (x=50->95,y=100)
        // nếu tọa độ x của cột trên <=75 và tọa độ x của cột trên >=50.

        private void XuLiVaCham()
        {
            
            //Xử lí va chạm cột trên dưới.
            //saveC là tọa độ cột.
            int X = saveC + 65;
            if ((saveC <= 90 && saveC >= 50) && ybrid <= (rdyT + 500) ||
                ((saveC + 65) <= 75 && (saveC + 65) >= 50 && ybrid <= (rdyT + 500)) ||
                ((X + saveC) / 2 <= 75 && ((X + saveC) / 2) >= 50 && ybrid <= (rdyT + 500))
                )
            {
                timerBird.Stop();
                timerCotNuoc.Stop();
                ThongBaoKetThuc("Game Over");
            }

            
            else if ( saveC <= 90 && saveC >= 50 && (ybrid+45) >= rdyD ||
                ((saveC + 65) <= 75 && (saveC + 65) >= 50 && (ybrid+45) >= rdyD) ||
                (((X + saveC) / 2) <= 75 && ((X + saveC) / 2) >= 50 && (ybrid +45) >= rdyD)
                )
            {
                timerBird.Stop();
                timerCotNuoc.Stop();
                ThongBaoKetThuc("Game Over");
            }


            //Xử lí va chạm cột trên dưới 1.
            int X1 = saveC1 + 65;
            if ((saveC1 <= 90 && saveC1 >= 50) && ybrid <= (rdyT1 + 500) ||
               ((saveC1 + 65) <= 75 && (saveC1 + 65) >= 50 && ybrid <= (rdyT1 + 500)) ||
               ((X1 + saveC1) / 2 <= 75 && ((X1 + saveC1) / 2) >= 50 && ybrid <= (rdyT1 + 500))
               )
            {
                timerBird.Stop();
                timerCotNuoc.Stop();
                ThongBaoKetThuc("Game Over");
            }


            else if (saveC1 <= 90 && saveC1 >= 50 && (ybrid + 45) >= rdyD1 ||
                ((saveC1 + 65) <= 75 && (saveC1 + 65) >= 50 && (ybrid + 45) >= rdyD1 ) ||
                (((X1 + saveC1) / 2) <= 75 && ((X1 + saveC1) / 2) >= 50 && (ybrid + 45) >= rdyD1)
                )
            {
                timerBird.Stop();
                timerCotNuoc.Stop();
                ThongBaoKetThuc("Game Over");
            }

        }

        private void CongDiem()
        {
            if( (x+65) == 50 || (x1 + 65) == 45 || (x + 65) == 31 || (x1 + 65) == 37)
            {
                diem++;
                msQuaCot.Play();
                this.lbDiem.Text = diem.ToString();
            }
        }


        private void WriteFile()
        {
            FileStream fs = File.Create("C:\\BXH.txt");
            StreamWriter sw = new StreamWriter(fs);
            foreach(var NC in xhNguoiChoi)
            {
                sw.WriteLine(NC.Hovaten.ToString().ToUpper() + " - " + NC.diem);
            }
            sw.Close();
            fs.Close();
        }
        private void CatChuoi(string line, ref string s1, ref int i2)
        {
            string s2 = "";
            int i = 0;
            foreach (var item in line)
            {
                i++;
                if (item == '-')
                    break;
                s1 += item;
            }
            for (int j = i + 1; j < line.Length; j++)
            {
                i++;
                if (line[j] == '-')
                    break;
                if (char.IsDigit(line[j]))//kiểm tra xem có phải là hệ cơ số 10 hay không.
                    s2 += (char)line[j];
                i2 = int.Parse(s2);
            }
        }
        private void ReadFile()
        {
            FileStream fs = File.Open("C:\\BXH.txt", FileMode.Open, FileAccess.Read, FileShare.None);
            StreamReader sr = new StreamReader(fs);
            NguoiChoi nc;
            string line = "";
            int Diem = 0;
            string HvT = "";
            while ((line = sr.ReadLine()) != null)
            {
                CatChuoi(line, ref HvT, ref Diem);
                nc = new NguoiChoi(HvT, Diem);
                xhNguoiChoi.Add(nc);
                HvT = "";
            }
            sr.Close();
            fs.Close();

        }

        private void ThongBaoKetThuc(string mess)
        {
            msKetThuc.Play();
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show(Owner, mess+"\n"+"Số điểm : "+
                lbDiem.Text.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            if (dr == DialogResult.OK)
            {
                xhNguoiChoi.Add(new NguoiChoi(fnc.Tenngchoi,int.Parse(lbDiem.Text)));
                xhNguoiChoi.Sort();
                WriteFile();
                fnc.txbTenNguoiChoi.Text = "";
                timerBird.Stop();
                timerCotNuoc.Stop();
                TaoBird();
                TaoNenDat();
                TaoOng();
                lbgame.Show();
                this.BackgroundImage = Properties.Resources.BT;
                this.Bird.BackColor = Color.Transparent;
                this.lbDiem.BackColor = Color.Transparent;
                this.lbDiem.Text = "0";
                timerCotNuoc.Interval = 20;
                timerBird.Interval = 10;
                x = 300; x1 = 565;
                ybrid = 100; //Toa do Y cua Bird : 100;
                rdyT = -350;
                rdyT1 = -350;
                rdyD = 250; rdyD1 = 250;
                saveC = 300; saveC1 = 565;
                diem = 0;
                flag = false; flagBird = false;
                flag1 = true; flag2 = false; flag3 = false; flag4 = false;
                pnGame.Show();//show panel game ra.
                msGame.Play();
            }
        }




    }
}
