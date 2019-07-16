using System;

namespace FlowerShop
{
    public class Tulip : Flower, IDescribable, IColor, IStemLength
    {
        public string Color { get; set; }

        public double StemLength { get; set; }

        public string Describe()
        {
            return $"A beautiful {Color} {GetType().Name}";
        }
    }
}