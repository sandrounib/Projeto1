using System;

namespace Projeto2
{
    class Program
    {
        static void Main(string[] args)
        {
           int a = 2;
           
           Console.WriteLine(a);// Imprimi o valor da vaiável inteira a.
           
           FazerCafe("caramelo"); // chama o método FazerCafé,passa para o método o argumento caramelo e imprimi
           FazerCafe("melao"); // chama o método FazerCafé,passa para o método o argumento melao e imprimi
        }


        static void FazerCafe(string capsula)
        {
            System.Console.WriteLine("Esquentar agua");
            System.Console.WriteLine("colocar po de magia(cafe)");
            System.Console.WriteLine("Colocar " + capsula);
        }
    }
}