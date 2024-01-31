using System;

namespace Lab3App
{
    public class Axe : Tool
    {
        public Axe(string description) 
        {
            Description = description;
        }
        public override void Display()
        {
            Console.WriteLine(String.Format("Axe {0} is displayed", Description));
        }
        public override void DoAction()
        {
            Console.WriteLine("Axe is used");
        }
    }
}
