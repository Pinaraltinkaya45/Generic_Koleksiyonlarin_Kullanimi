using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Koleksiyonlarin_Kullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Musteri> musteriler = new List<Musteri>();

            musteriler.Add(new Musteri(1, "pınar", "altınkaya", "pinar.3@gmail.com"));
            musteriler.Add(new Musteri(2, "enes", "bayram", "enes@gmail.com"));
            musteriler.Add(new Musteri(2, "zeynep", "özdemir", "zeynep@gmail.com"));


            Console.WriteLine("Koleksiyonumuzun Boyutu : " + musteriler.Count);



            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri);
            }


            Console.ReadLine();
        }
    }
}
