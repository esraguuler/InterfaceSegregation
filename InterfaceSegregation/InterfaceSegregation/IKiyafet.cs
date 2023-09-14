using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public interface IKiyafet
    {
        int ID  { get; set; }
        string Tur { get; set; }
        string Renk { get; set; }
        double Fiyat { get; set; }
        char Size { get; set; }
        

    }
}
