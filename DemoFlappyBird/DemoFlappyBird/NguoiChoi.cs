using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFlappyBird
{
    public class NguoiChoi: IComparable<NguoiChoi>
    {
        public string Hovaten;
        public int diem;
        public NguoiChoi(string HoVaTen, int Diem)
        {
            this.Hovaten = HoVaTen;
            this.diem = Diem;
        }

        public int CompareTo(NguoiChoi nc)
        {
            return -diem.CompareTo(nc.diem);// sắp xếp từ cao xuống thấp, so sánh theo kiểu [1] vs [0]
        }
    }
}
