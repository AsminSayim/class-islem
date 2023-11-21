using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_4_islem
{
    internal class İslem
    {
       public int sayi1;
       public int sayi2;
       
        public double Topla()
        {
            return sayi1 + sayi2;
        }

        public double Fark()
        {
            return sayi1 - sayi2;
        }


        public double Carpim()
        {
            return sayi1 * sayi2;
        }

        public double Bolüm()
        {
            return sayi1/ sayi2;
        }


    }
}
