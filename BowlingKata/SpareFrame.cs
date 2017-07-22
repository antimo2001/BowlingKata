using System;
using System.Collections;

namespace BowlingKata
{
    public class SpareFrame: IFrame
    {
        private ArrayList throws;
        private int startingThrow;

        public int Score()
        {
            int throw1 = (int)throws[this.startingThrow];
            int throw2 = (int)throws[this.startingThrow+1];
            int next = (int)throws[this.startingThrow+2];
            //Note that sum of both throws should equal 10 at this point
            if (throw1 + throw2 != 10)
            {
                Console.WriteLine($"***error: prior + current should equal 10: {throw1 + throw2}");
            }
            return throw1 + throw2 + next;
        }

        public SpareFrame(ArrayList throws, int firstThrow)
        {
            int secondThrow = 10 - firstThrow;
            this.throws = throws;
            this.startingThrow = throws.Count;
            throws.Add(firstThrow);
            throws.Add(secondThrow);
        }
    }
}
