using System;

namespace Projeto2
{
    class Program
    {
        static void Main(string[] args)
        {
           int a = 2;
           Console.WriteLine(a);
           FazerCafe("caramelo") ;
           FazerCafe("melao");
        }


        static void FazerCafe(string capsula)
        {
            System.Console.WriteLine("Esquentar agua");
            System.Console.WriteLine("colocar po de magia(cafe)");
            System.Console.WriteLine("Colocar " + capsula);
        }
    }
}