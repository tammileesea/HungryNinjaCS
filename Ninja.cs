using System;
using System.Collections.Generic;

namespace HungryNinja
{
    // interface IConsumable
    // {
    //     string Name {get;set;}
    //     int Calories {get;set;}
    //     bool IsSpicy {get;set;}
    //     bool IsSweet {get;set;}
    //     string GetInfo();
    // }
    abstract class Ninja
    {
        protected int calorieIntake;
        public List<IConsumable> NomHistory;
        public Ninja()
        {
            calorieIntake = 0;
            NomHistory = new List<IConsumable>();
        }

        public abstract bool isFull();

        public abstract void Nom(IConsumable item);
    }
}