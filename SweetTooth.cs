using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class SweetTooth : Ninja{
        public override bool isFull(){
            if (calorieIntake >= 1500){
                return true;
            } else {
                return false;
            }
        }
        public override void Nom(IConsumable item){
            if (isFull() == false){
                calorieIntake += item.Calories;
                if (item.IsSweet){
                    calorieIntake += 10;
                }
                NomHistory.Add(item);
                item.GetInfo();
            } else {
                Console.WriteLine("SHWEETOOF is full and can't eat no mo'");
            }
        }
        public SweetTooth (){
            int calorieIntake = 1;
            calorieIntake -=1;
            NomHistory = new List<IConsumable>();
        }
    }
}