using System;

namespace Lab3App
{
	public class Diamond : Treasure
	{
		public Diamond(string description, int score)
		{
			Description = description;
			Score = score;
		}
		public override void Display()
		{
			Console.WriteLine(String.Format("Diamond {0} is displayed", Description));
		}
	}
}
