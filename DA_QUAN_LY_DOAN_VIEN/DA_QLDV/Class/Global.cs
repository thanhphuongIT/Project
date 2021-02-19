using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DA_QLDV
{
    static class Global
    {
        public static string GlobalLop { get; private set; }
        public static void SetGlobalLop(string Lop)
        {
            GlobalLop = Lop;
        }
    }
}
