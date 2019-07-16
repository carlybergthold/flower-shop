using System;

namespace FlowerShop
{
    public class Rose : Flower, IDescribable, IColor
    {
        public string Color { get; set; }

        public bool HasThorns { get; set; }

        public string Describe()
        {
            return $"A beautiful {Color} Rose";
        }
    }
}