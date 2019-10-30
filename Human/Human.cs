using System;

namespace Human
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
		public string AccessHealth
		{
			get
			{
				return $"{Name}'s health is {Health}";
			}
		}

		// Add a constructor that takes a value to set Name, and set the remaining fields to default values
		public Human (string Name)
		{
			this.Name = Name;
			this.Strength = 3;
			this.Intelligence = 3;
			this.Dexterity = 3;
			this.Health = 100;
		}
		
		// Add a constructor to assign custom values to all fields
		public Human (string Name, int Strength, int Intelligence, int Dexterity, int Health)
		{
			this.Name = Name;
			this.Strength = Strength;
			this.Intelligence = Intelligence;
			this.Dexterity = Dexterity;
			this.Health = Health;
		}
		
		// Build Attack method
		public int Attack(Human Target)
		{
			Target.Health = Target.Health - (Strength * 5);
			Console.WriteLine(Target.Health);
			return Target.Health;
		}
	}
}
