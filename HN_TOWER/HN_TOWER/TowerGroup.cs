using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HN_TOWER
{
    public class TowerGroup
    {
        private int numberOfPlate;

        public int NumberOfPlate
        {
            get
            {
                return numberOfPlate;
            }

            set
            {
                numberOfPlate = value;
            }
        }

        public Tower TowerA
        {
            get; set;
        }
        public Tower TowerB
        {
            get; set;
        }
        public Tower TowerC
        {
            get; set;
        }
    }
}
