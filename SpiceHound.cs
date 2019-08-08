using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class SpiceHound : Ninja{
        public override bool isFull(){
            if (calorieIntake >= 1200){
                return true;
            } else {
                return false;
            }
        }
        public override void Nom(IConsumable item){
            if (isFull() == false){
                calorieIntake += item.Calories;
                if (item.IsSpicy){
                    calorieIntake -= 5;
                }
                NomHistory.Add(item);
                item.GetInfo();
            } else {
                Console.WriteLine("SpiceHOUND is full and can't eat no mo'");
            }
        }
        public SpiceHound (){
            calorieIntake = 0;
            NomHistory = new List<IConsumable>();
        }
    }
}