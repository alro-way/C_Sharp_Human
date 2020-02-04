using System;
using System.Collections.Generic;

namespace C_Sharp_Human
{

    public class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int Health;

        
        // add a public "getter" property to access health

        public int HealthProp
        {
            get
            {
                return Health;
            }
        }
        
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string Hname)
        {
            this.Name = Hname;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }


        // Add a constructor to assign custom values to all fields
        public Human(string Hname, int Hstr, int Hintel, int Hdex, int HHeal)
        {
            this.Name = Hname;
            this.Strength = Hstr;
            this.Intelligence = Hintel;
            this.Dexterity = Hdex;
            this.Health = HHeal;
        }

        
        // Build Attack method
        public int Attack(object target)
        {
            Human temp = target as Human;
            temp.Health -= 5 * Strength;
            Console.WriteLine($"name: {this.Name}, health: {temp.HealthProp}");
            return temp.Health;

        }
    }

    // class program
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var NewHuman = new Human("Keo", 10, 50, 5, 20);
            Console.WriteLine($"This is first guy {NewHuman.Name}");
            Console.WriteLine(NewHuman.Strength);
            Console.WriteLine(NewHuman.Intelligence);
            Console.WriteLine(NewHuman.Dexterity);
            Console.WriteLine(NewHuman.HealthProp);
            var NewHuman2 = new Human("Oli");
            Console.WriteLine($"This is first guy {NewHuman2.Name}");
            Console.WriteLine(NewHuman2.Strength);
            Console.WriteLine(NewHuman2.Intelligence);
            Console.WriteLine(NewHuman2.Dexterity);
            Console.WriteLine(NewHuman2.HealthProp);
            NewHuman.Attack(NewHuman2);
            NewHuman.Attack(NewHuman2);





        }
    }
}
