using System;

namespace Lab3App
{
	public class CollectionBoard
	{
		private int totalScore;
		private int totalValue;
		public CollectionBoard()
		{
			this.totalScore = 0;
			this.totalValue = 0;
		}
		public int TotalScore
		{
			get { return totalScore; }
			set { totalScore = value; }

		}
		public int TotalValue
		{
			get { return totalValue; }
			set { totalValue = value; }
		}
	}
}

