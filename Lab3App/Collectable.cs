using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lab3App
{
    public abstract class Collectable : Displayable
    {
        private string description;
        public String Description
        {
            get { return description; }
            set { description = value; }
        }
        private CollectionBoard board;
        public CollectionBoard Board
        {
            get { return board; }
            set { board = value; }
        }
        public virtual void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine(String.Format("{0} Collected, Congrats!!!!", description));
        }
        public abstract void Display();
    }
}
