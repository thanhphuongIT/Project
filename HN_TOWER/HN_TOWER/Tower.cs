using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace HN_TOWER
{
    public partial class Tower : UserControl
    {
        public List<Button> listBtnPlate = new List<Button>();
        private Tower finish;
        event EventHandler outTower;
        public event EventHandler OutTower
        {
            add
            {
                outTower += value;
            }
            remove
            {
                outTower -= value;
            }
        }
        public Tower()
        {
            InitializeComponent();
        }
        public Button Plate
        {
            set
            {
                if (value != null)
                {
                    int test = btnC.Width - value.Width;
                    int x = btnC.Location.X + test / 2;
                    int y = btnC.Location.Y - btnC.Height;
                    for (int i = 0; i < listBtnPlate.Count; i++)
                    {
                        y -= listBtnPlate[i].Height;
                    }
                    this.Controls.Add(value);
                    value.Top = btnTowerC.Top;
                    value.Left = x;
                    while (value.Top <= y)
                    {
                        value.Top++;
                        Thread.Sleep(1);
                        this.Refresh();
                    }
                    listBtnPlate.Add(value);
                }
            }
            get
            {
                if (listBtnPlate.Count > 0)
                    return listBtnPlate[listBtnPlate.Count - 1];
                return null;
            }
        }
        public Button Remove()
        {
            int index = listBtnPlate.Count - 1;
            int i = btnTowerC.Top;
            while (listBtnPlate[index].Top >= i - 20)
            {
                Thread.Sleep(1);
                listBtnPlate[index].Top -= 2;
                this.Refresh();
            }
            outTower?.Invoke(listBtnPlate[index], new MyEventArgs() { TowerNext = this });
            Button btn = listBtnPlate[index];
            listBtnPlate.RemoveAt(index);
            return btn;
        }
        public string TextLabel
        {
            get
            {
                return btnC.Text;
            }
            set
            {
                btnC.Text = value;
            }
        }
        public Color BackGroundColor
        {
            get
            {
                return btnC.BackColor;
            }
            set
            {
                btnC.BackColor = value;
                btnTowerC.BackColor = value;
            }
        }

        public Tower Finish
        {
            get
            {
                return finish;
            }

            set
            {
                finish = value;
            }
        }
        private void Tower_SizeChanged(object sender, EventArgs e)
        {
            btnTowerC.Height = this.Height - btnC.Height;
            btnTowerC.Left = this.Width / 2 - 20;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
    class MyEventArgs : EventArgs
    {
        private Tower towerNext;

        public Tower TowerNext
        {
            get
            {
                return towerNext;
            }

            set
            {
                towerNext = value;
            }
        }
    }
}
