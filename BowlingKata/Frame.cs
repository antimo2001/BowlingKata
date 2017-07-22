using System.Collections;

namespace BowlingKata
{
    abstract public class Frame
    {
        protected ArrayList throws;
        protected int startingThrow;

        public Frame(ArrayList throws)
        {
            this.throws = throws;
            this.startingThrow = throws.Count;
        }

        abstract public int Score();
    }
}
