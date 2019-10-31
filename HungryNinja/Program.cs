using System;
using System.Collections.Generic;

namespace HungryNinja
{
    public class Food
	{
		public string Name;
		public int Calories;
		public bool IsSpicy;
		public bool IsSweet;

		public Food(string Name, int Calories, bool IsSpicy, bool isSweet)
		{
			this.Name = Name;
			this.Calories = Calories;
			this.IsSpicy = IsSpicy;
			this.IsSweet = IsSweet;
		}
	}
    public class Buffet
    {
        private List<Food> Menu;
        public Buffet()
        {
            Menu = new List<Food>() {
                new Food("Dan Dan Mian", 1000, true, false),
				new Food("Bibimbap", 800, true, false),
				new Food("Oyako Don", 1200, false, true),
				new Food("Otoro", 2000, false, false),
				new Food("Dao Shao Mian", 1000, true, false),
				new Food("Pho", 600, false, false),
				new Food("Musubi", 800, false, false)
            };
        }
        public Food Serve() 
        {
            Random r = new Random();
            return Menu[r.Next(Menu.Count)];
        }
    }
    public class Ninja
    {
        public string Name;
        protected int CalorieIntake = 0;
        protected int CalorieLimit;
        public List<Food> Stomach;
        public bool isFull {
            get { return CalorieIntake >= CalorieLimit; }
        }
        public Ninja (string Name, int CalorieLimit=1500)
        {
            this.Name = Name;
            this.CalorieLimit = 1500;
            this.Stomach = new List<Food>();
        }
        public virtual void Eat(Food Item)
        {
            Console.WriteLine($"{Name} is about to eat a delicious {Item.Name}");
            if(isFull) 
            {
                throw new NinjaIsFullException($"Ninja is Full! Stop Feeding {Name}!");
            }
            this.CalorieIntake += Item.Calories;
            this.Stomach.Add(Item);
        }
    }
    public class NinjaIsFullException : Exception
    {
        public NinjaIsFullException(string message) : base(message) {}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Buffet BuffetMari = new Buffet();
            Ninja Sombat = new Ninja("Sombat");
            while(!Sombat.isFull)
            {
                Sombat.Eat(BuffetMari.Serve());
            }
            foreach(var Item in Sombat.Stomach)
            {
                Console.WriteLine($"{Item.Name} {Item.Calories}");
            }
            Sombat.Eat(BuffetMari.Serve());
        }
    }
}
