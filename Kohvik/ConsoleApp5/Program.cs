using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("1. telli kohvi");
            //string vastus = Console.ReadLine();
            //switch (vastus)
            //{

            //}
            var User = new User();
            var KaffeLatte = new Kaffe_Late();
            var MustKohv = new Must_kohv();
            var Cappuccino = new cappuccino();
            Console.WriteLine("Millist kohvi te osta tahate");
            Console.WriteLine("1. Kaffe Late");
            Console.WriteLine("2. Must kohv");
            Console.WriteLine("3. Cappuccino");
            string valik = Console.ReadLine();
            switch (valik)
            {
                case ("1"):
                    User.Shopping_cart.Add(KaffeLatte);
                    break;
                case ("2"):
                    User.Shopping_cart.Add(MustKohv);
                    break;
                case ("3"):
                    User.Shopping_cart.Add(Cappuccino);
                    break;
            }
            User.Shopping_cart.Add(KaffeLatte);

        }
    }
}
