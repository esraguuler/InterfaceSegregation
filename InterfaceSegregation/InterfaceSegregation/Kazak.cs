using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    class Kazak : IKiyafet
    {
        public int ID { get; set; }
        public string Tur { get; set; }
        public string Renk { get; set; }
        public double Fiyat { get; set; }
        public char Size { get; set; }
        public string Yaka { get; set; }
        public string ozellik1 { get; set; }

    }
}
