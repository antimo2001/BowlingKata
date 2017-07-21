using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingKata
{
    public class SpareFrame: IFrame
    {
        private ArrayList throws;
        private int startingThrow;

        public int Score()
        {
            int prior = (int)throws[this.startingThrow];
            int current = (int)throws[this.startingThrow+1];
            int next = (int)throws[this.startingThrow+2];
            //Note that the prior + current should equal 10 at this point
            if (prior + current != 10)
            {
                Console.WriteLine($"***error: prior + current should equal 10: {prior + current}");
            }
            return prior + current + next;
        }

        public SpareFrame(ArrayList throws, int firstThrow, int secondThrow)
        {
            this.throws = throws;
            this.startingThrow = throws.Count;
            throws.Add(firstThrow);
            throws.Add(secondThrow);
        }
    }
}
