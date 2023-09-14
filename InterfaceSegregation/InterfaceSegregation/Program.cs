using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
            Kazak k = new Kazak();
            k.ID = 1;
            k.Tur = "Erkek Kazak";
            k.Renk = "Mor";

            Pantolon p = new Pantolon();
            p.Tur = "Kadın Pantolon";
            p.Renk = "Siyah";
            p.EnBoy = "26-24";
            Console.WriteLine(k.ID);
            Console.WriteLine(k.Tur);
            Console.WriteLine(k.Renk);

            Console.ReadLine();
        }
    }
}
