using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tek_çift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayiTekmiCiftMi sayibul = new SayiTekmiCiftMi();
            bool sonuc = sayibul.TekCift(3);
            if (sonuc)
            {
                Console.WriteLine("Sayı tektir");
            }
            else
            {
                Console.WriteLine("sayı çifttir");
            }


        }
    }
    public class SayiTekmiCiftMi
    {
        public bool TekCift(int sayi)
        {
            if (sayi % 2 == 1)
            {
                return true;
            }
            return false;
        }
    }
}
