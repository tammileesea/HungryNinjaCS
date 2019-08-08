using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Buffet
    {
        public List<IConsumable> Menu;

        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food("Salsa", 300, true, false),
                new Food("Chips", 380, false, false),
                new Food("Mashed Potatoes", 600, false, false),
                new Food("Green Beans", 250, false, false),
                new Food("Chicken", 460, false, false),
                new Food("Cookies", 520, false, true),
                new Food("Ice Cream", 500, false, true),
                new Drink("Mango Lasi", 450, false, true),
                new Drink("Coffee", 70, false, false)
            };
        }
        public IConsumable Serve()
        {
            Random eat = new Random();
            int i = eat.Next(0, Menu.Count);
            IConsumable ServeEat = Menu[i];
            return ServeEat;
        }
    }
}