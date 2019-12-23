using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human myHuman = new Human("Angelo", 100, 100, 100, 500);
            Human otherHuman = new Human("Bob");

            System.Console.WriteLine($"Name: {otherHuman.Name}, Strength: {otherHuman.Strength}, Intelligence: {otherHuman.Intelligence}, Dexterity: {otherHuman.Dexterity}, Health: {otherHuman.Health}");
            myHuman.Attack(otherHuman);

            System.Console.WriteLine($"Name: {myHuman.Name}, Strength: {myHuman.Strength}, Intelligence: {myHuman.Intelligence}, Dexterity: {myHuman.Dexterity}, Health: {myHuman.Health}");
            System.Console.WriteLine($"Name: {otherHuman.Name}, Strength: {otherHuman.Strength}, Intelligence: {otherHuman.Intelligence}, Dexterity: {otherHuman.Dexterity}, Health: {otherHuman.Health}");
        }
    }
    class Human
    {
        // Fields for Human
        public string Name {get;set;}
        public int Strength {get;set;}
        public int Intelligence {get;set;}
        public int Dexterity {get;set;}
        private int health {get;set;}
         
        // add a public "getter" property to access health
        public int Health
        {
            get { return health; }
        }
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human (string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        // Add a constructor to assign custom values to all fields
        public Human (string nam, int Str, int Int, int Dex, int Hea)
        {
            Name = nam;
            Strength = Str;
            Intelligence = Int;
            Dexterity = Dex;
            health = Hea;
        }
        // Build Attack method
        public int Attack(Human target)
        {
            int damage = this.Strength * 5;
            target.health = target.health - damage;
            return target.health;
        }
    }

}
