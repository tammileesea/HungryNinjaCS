using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Drink : IConsumable
    {
        public string Name {get; set;}
        public int Calories {get;set;}
        public bool IsSpicy {get;set;}
        public bool IsSweet {get;set;}

        public string GetInfo()
        {
            return $"{Name} (Drink).  Calories: {Calories}.  Spicy?: {IsSpicy}, Sweet?: {IsSweet}";
        }
        public Drink (string NameInput, int CaloriesInput, bool SpicyInput, bool SweetInput)
        {
            Name = NameInput;
            Calories = CaloriesInput;
            IsSpicy = SpicyInput;
            IsSweet = SweetInput;
            // Console.WriteLine($"Name: {NameInput}, Calories: {CaloriesInput}, Spicy: {SpicyInput}, Sweet: {SweetInput}");
        }
    }
}