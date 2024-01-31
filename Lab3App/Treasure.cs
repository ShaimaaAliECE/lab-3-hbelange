using System;
using System.Collections.Generic;

namespace Lab3App
{
	public abstract class Treasure : Collectable
	{
		private int score;
		public int Score
		{
			get { return score; }
			set { score = value; }
		}
		public void UpdateTotalScore()
		{
			Board.TotalScore += score;
			Console.WriteLine("Total Score is updated to: {0}", Board.TotalScore);
		}
		public override void AddMe(List<Collectable> list)
		{
			base.AddMe(list);
			UpdateTotalScore();

		}
	}
}
