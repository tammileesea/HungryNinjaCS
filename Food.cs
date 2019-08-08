using System;
using System.Collections.Generic;

namespace HungryNinja
{
    interface IConsumable
    {
        string Name {get;set;}
        int Calories {get;set;}
        bool IsSpicy {get;set;}
        bool IsSweet {get;set;}
        string GetInfo();
    }
    
    class Food : IConsumable
    {
        public string Name {get; set;}
        public int Calories {get; set;}
        public bool IsSpicy {get; set;}
        public bool IsSweet {get; set;}
        public string GetInfo()
        {
            return $"{Name} (Food).  Calories: {Calories}.  Spicy?: {IsSpicy}, Sweet?: {IsSweet}";
        }
        public Food (string NameInput, int CaloriesInput, bool SpicyInput, bool SweetInput)
        {
            Name = NameInput;
            Calories = CaloriesInput;
            IsSpicy = SpicyInput;
            IsSweet = SweetInput;
            // Console.WriteLine($"Name: {NameInput}, Calories: {CaloriesInput}, Spicy: {SpicyInput}, Sweet: {SweetInput}");
        }
    }
}