using System;

namespace Lab3App
{
	public class MagicWand : Tool
	{
		public MagicWand(string description)
		{
			Description = description;
		}

		public override void Display()
		{
			Console.WriteLine(String.Format("MagicWand {0} is displayed", Description));
		}
		public override void DoAction()
		{
			Console.WriteLine("MagicWand is used");
		}
	}
}
