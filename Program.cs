using System;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var redTulip = new Tulip() { Color = "red" };
            Console.WriteLine(redTulip.Describe());

            Flowershop myShop = new Flowershop();
        }
    }
}
