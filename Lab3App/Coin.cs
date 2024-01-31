using System;
using System.Collections.Generic;

namespace Lab3App
{
	public class Coin : Treasure
	{
		private int value;
		public int Value
		{
			get { return value; }
			set { this.value = value; }
		}
		public Coin(string description, int score, int value)
		{
			Description = description;
			Score = score; 
			Value = value;
		}
		public void UpdateTotalValue()
		{
			Board.TotalValue += value;
		}
		public override void Display()
		{
			Console.WriteLine(String.Format("Coin {0} is displayed", Description));
		}
        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
			UpdateTotalValue();
        }
    }
}
