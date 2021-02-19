using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace HN_TOWER
{
    public partial class TowerKQ : Form
    {
        private List<Button> listBtn;
        private StackCustom<TowerGroup> stackTower;

        public StackCustom<TowerGroup> StackTower
        {
            get
            {
                return stackTower;
            }

            set
            {
                stackTower = value;
            }
        }
        public TowerKQ()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            listBtn = new List<Button>();
            towerA.OutTower += TowerA_OutTower;
            towerB.OutTower += TowerA_OutTower;
            towerC.OutTower += TowerA_OutTower;
            stackTower = new StackCustom<TowerGroup>();
        }
        private void TowerA_OutTower(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Tower parent = btn.Parent as Tower;
            pnMain.Controls.Add(btn);
            btn.Top = parent.Top - 80;
            btn.Left = parent.Left;
            if (parent.Left < parent.Finish.Left)
            {
                while (btn.Left <= parent.Finish.Left + 10)
                {
                    Thread.Sleep(1);
                    btn.Left += 2;
                    pnMain.Refresh();
                }
            }
            else
            {
                while (btn.Left >= parent.Finish.Left + 10)
                {
                    Thread.Sleep(1);
                    btn.Left -= 2;
                    pnMain.Refresh();
                }
            }
            while (btn.Top <= parent.Finish.Top)
            {
                Thread.Sleep(1);
                btn.Top += 2;
                pnMain.Refresh();
            }
        }

        private void TowerKQ_Load(object sender, EventArgs e)
        {

        }

        private void tower1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            CreatePlate();
            Thread t = new Thread(() =>
            {
                HNTowerByStack();
            });
            t.Start();
        }
        void CreatePlate()
        {
            int width = 100;
            for (int i = 0; i < nuNumberOfPlate.Value; i++)
            {
                Button btn = new Button();
                btn.Width = width;
                btn.Height = 15;
                towerA.Plate = btn;
                width -= 10;
            }
        }
        public void MovePlate(int number, Tower source, Tower finish)
        {
            source.Finish = finish;
            Button btn = source.Remove();
            finish.Plate = btn;
        }

        public void HNTowerByStack()
        {
            TowerGroup groupBegin = new TowerGroup()
            {
                NumberOfPlate = int.Parse(nuNumberOfPlate.Value.ToString()),
                TowerA = towerA,
                TowerB = towerB,
                TowerC = towerC
            };
            stackTower.Push(groupBegin);
            while (stackTower.isEmpty() == false)
            {
                TowerGroup group = stackTower.Pop();
                if (group.NumberOfPlate == 1)
                {
                    MovePlate(group.NumberOfPlate, group.TowerA, group.TowerC);
                }
                else
                {
                    TowerGroup groupNew = new TowerGroup()
                    {
                        NumberOfPlate = group.NumberOfPlate - 1,
                        TowerA = group.TowerB,
                        TowerB = group.TowerA,
                        TowerC = group.TowerC
                    };
                    stackTower.Push(groupNew);
                    //
                    TowerGroup groupNew1 = new TowerGroup()
                    {
                        NumberOfPlate = 1,
                        TowerA = group.TowerA,
                        TowerB = group.TowerB,
                        TowerC = group.TowerC
                    };
                    stackTower.Push(groupNew1);
                    //
                    TowerGroup groupNew2 = new TowerGroup()
                    {
                        NumberOfPlate = group.NumberOfPlate - 1,
                        TowerA = group.TowerA,
                        TowerB = group.TowerC,
                        TowerC = group.TowerB
                    };
                    stackTower.Push(groupNew2);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();      
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
