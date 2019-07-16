using System.Collections.Generic;

namespace FlowerShop
{
    public class Flowershop
    {
        public List<Rose> Roses = new List<Rose>();

        public List<Lily> Lilies = new List<Lily>();

        public List<Tulip> Tulips = new List<Tulip>();

        public List<Sunflower> Sunflowers = new List<Sunflower>();

        //any flower that goes in the Mother's Day arrangment must have a stem length property
        public List<IStemLength> MothersDayArrangment = new List<IStemLength>()
        {
            new Sunflower() { PetalCount = 27, Price = 3.00 },
            new Tulip() { PetalCount = 50, Price = 5.00 }
        };

        //any flower that goes in the Mother's Day arrangment must have a color property
        public List<IColor> BirthdayArrangement = new List<IColor>()
        {
            new Rose() { PetalCount = 27, Price = 3.00, Color = "Red" },
            new Tulip() { PetalCount = 50, Price = 5.00, Color = "Yellow" }
        };
    }
}