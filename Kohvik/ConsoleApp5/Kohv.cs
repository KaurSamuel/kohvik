using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    abstract class Kohv
    {
        public string Nimi;
        public double Hind;
        public double Default_Price;
        public string Suurus;

        //public virtual String Telli_kohvi()
        //{
        //Console.WriteLine("Mis suurus?");
        //Console.WriteLine("1. Väike");
        //Console.WriteLine("2. Keskmine");
        //Console.WriteLine("3. Suur");
        //while (true)
        //{
        //    string valik = Console.ReadLine();
        //    switch (valik)
        //    {
        //        case ("1"):
        //            Suurus = "Väike";
        //            Hind = Deafult_Price;
        //            break;
        //        case ("2"):
        //            Suurus = "Keskmine";
        //            Hind = 1.5 + Deafult_Price;
        //            break;
        //        case ("3"):
        //            Suurus = "Suur";
        //            Hind = 2 + Deafult_Price;
        //            break;
        //        default:
        //            Console.WriteLine("Palun valige suurus mis on olemas! 1/2/3");
        //            break;
        //    }
        //    if (valik!= "1"&&valik!= "2"&&valik!="3")
        //    {
        //        break;
        //    }
        //}
        //
        //    return (Nimi+Suurus);
        //}
    }
}
