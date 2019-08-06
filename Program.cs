using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Food 
    {
        public string Name;
        public int Calories;
        public bool IsSpicy;
        public bool IsSweet;
        public Food (string NameInput, int CaloriesInput, bool SpicyInput, bool SweetInput)
        {
            Name = NameInput;
            Calories = CaloriesInput;
            IsSpicy = SpicyInput;
            IsSweet = SweetInput;
            // Console.WriteLine($"Name: {NameInput}, Calories: {CaloriesInput}, Spicy: {SpicyInput}, Sweet: {SweetInput}");
        }
    }

    class Buffet
    {
        public List<Food> Menu;

        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Salsa", 300, true, false),
                new Food("Chips", 380, false, false),
                new Food("Mashed Potatoes", 600, false, false),
                new Food("Green Beans", 250, false, false),
                new Food("Chicken", 460, false, false),
                new Food("Cookies", 520, false, true),
                new Food("Ice Cream", 500, false, true),
            };
        }
        public Food Serve()
        {
            Random food = new Random();
            int i = food.Next(0, Menu.Count);
            Food ServeFood = Menu[i];
            return ServeFood; 
        }
    }

    class Ninja
    {
        private int calorieIntake; 
        public List<Food> FoodHistory;
        public Ninja()
        {
            int calorieIntake = 1;
            calorieIntake -=1;
            FoodHistory = new List<Food>(){};
        }

        public bool isFull
        {
            get
            {
                if (calorieIntake > 1200)
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }
        }

        public void Eat(Food item)
        {
            if (isFull == false)
            {
                // Console.WriteLine($"EATING {item.Name}");
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                if (item.IsSpicy == true)
                {
                    Console.WriteLine($"Ninja is eating {item.Name} and it's spicy!!!"); 
                }
                if (item.IsSweet == true)
                {
                    Console.WriteLine($"Ninja is eating {item.Name} and it's sweeeet!!!"); 
                }
                if (item.IsSweet == true && item.IsSpicy == true)
                {
                    Console.WriteLine($"Ninja is eating {item.Name} and it's sweet and spicy!!!"); 
                }
                if (item.IsSweet != true && item.IsSpicy != true)
                {
                    Console.WriteLine($"Ninja is eating {item.Name} and it's practically flavorless :/"); 
                }
            }
            else 
            {
                Console.WriteLine($"Ninja is trying to eat {item.Name}, but is full and should stop eating! No body shaming here!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Buffet OldCountryBuffet = new Buffet();
            // Console.WriteLine(OldCountryBuffet.Menu[0].Name);

            Ninja tammi = new Ninja();
            // Food foodToEat = OldCountryBuffet.Serve();
            // tammi.Eat(foodToEat);
            tammi.Eat(OldCountryBuffet.Serve());
            tammi.Eat(OldCountryBuffet.Serve());
            tammi.Eat(OldCountryBuffet.Serve());
            tammi.Eat(OldCountryBuffet.Serve());
            tammi.Eat(OldCountryBuffet.Serve());
        }
    }
}