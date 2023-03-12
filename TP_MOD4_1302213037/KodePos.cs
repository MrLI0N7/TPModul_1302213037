using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MOD4_1302213037
{
    internal class KodePos
    {
        public enum Kelurahan
        {
            Batununggal, Kujangsari, Mengger, Wates,
            Cijaura, Jatisar, Margasari, Sekejati, Kebonwaru, Maleer, Samoja
        }
        public int getKodePos(Kelurahan k)
        {
            int[] kode = { 40266, 40287, 40267, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };

            return kode[(int)k];
        }
    }
}
