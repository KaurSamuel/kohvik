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
            while (true)
            {
                var User = new User();
                Console.WriteLine("1. Telli kohvi");
                Console.WriteLine("2. Telli toitu");
                Console.WriteLine("3.Vaata rahakotti");
                Console.WriteLine("4.Vaata ostukorvi");
                string vastus = Console.ReadLine();
                if (vastus == "3")
                {
                    Console.WriteLine("Teie rahakotis tundub praegu olevat");
                    Console.WriteLine(User.Balance+" eurot");
                    if (User.Balance == 0)
                    {
                        Console.WriteLine("you broke af");
                    }

                }
                if (vastus == "1")
                {
                    var KaffeLatte = new Kaffe_Late();
                    var MustKohv = new Must_kohv();
                    var Cappuccino = new cappuccino();
                    Console.WriteLine("Millist kohvi te osta tahate");
                    Console.WriteLine("1. Kaffe Late");
                    Console.WriteLine("2. Must kohv");
                    Console.WriteLine("3. Cappuccino");
                    string valik = Console.ReadLine();
                    bool oige = true;
                    while (true)
                    {
                        switch (valik)
                        {
                            case ("1"):
                                User.Shopping_cart.Add(KaffeLatte);
                                User.Balance -= KaffeLatte.Default_Price;
                                break;
                            case ("2"):
                                User.Shopping_cart.Add(MustKohv);
                                User.Balance -= MustKohv.Default_Price;
                                break;
                            case ("3"):
                                User.Shopping_cart.Add(Cappuccino);
                                User.Balance -= Cappuccino.Default_Price;
                                break;
                            default:
                                Console.WriteLine("palun valige õige vastusevariant 1/2/3");
                                oige = false;
                                break;
                        }
                        if (oige == true)
                        {
                            break;
                        }
                    }
                }
                if (vastus == "2")
                {
                    var salat = new Salat();
                    var õunakook = new õunakook();
                    var test = new Toidud();
                    Console.WriteLine("Mida te osta tahate?");
                }
            }
        }       
    }
}
