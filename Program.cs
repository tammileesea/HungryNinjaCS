using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet OldCountryBuffet = new Buffet();
            // Console.WriteLine(OldCountryBuffet.Menu[0].Name);
            // Ninja tammi = new Ninja();
            SweetTooth child = new SweetTooth();
            SpiceHound George = new SpiceHound();
            child.Nom(OldCountryBuffet.Serve());
            child.Nom(OldCountryBuffet.Serve());
            child.Nom(OldCountryBuffet.Serve());
            child.Nom(OldCountryBuffet.Serve());
            child.Nom(OldCountryBuffet.Serve());
            child.Nom(OldCountryBuffet.Serve());
            George.Nom(OldCountryBuffet.Serve());
            George.Nom(OldCountryBuffet.Serve());
            George.Nom(OldCountryBuffet.Serve());
            George.Nom(OldCountryBuffet.Serve());
            George.Nom(OldCountryBuffet.Serve());
            George.Nom(OldCountryBuffet.Serve());
            Console.WriteLine($"child ate {child.NomHistory.Count} foods/drinks!!!!!");
            Console.WriteLine($"George ate {George.NomHistory.Count} foods/drinks!!!!!");
            if (child.NomHistory.Count > George.NomHistory.Count){
                System.Console.WriteLine("Child at more than G and he is lzr");
            } else if (child.NomHistory.Count < George.NomHistory.Count){
                System.Console.WriteLine("G at more than child");
            } else {
                System.Console.WriteLine("G and child atttttt the same amount");
            }
        }
    }
}