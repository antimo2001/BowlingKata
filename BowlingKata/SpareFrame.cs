using System;
using System.Collections;

namespace BowlingKata
{
    public class SpareFrame: Frame
    {
        /**
        * Instantiates SpareFrame using the base class constructor
        */
        public SpareFrame(ArrayList throws) : base(throws)
        {
        }

        /**
        * Instantiates SpareFrame using another constructor and the first throw,
        * since the second-throw should be 10 minus the first.
        */
        public SpareFrame(ArrayList throws, int firstThrow) : this(throws)
        {
            this.throws.Add(firstThrow);
            this.throws.Add(10 - firstThrow);
        }

        /**
        * Overrides the Frame.Score method. Note this only sums the 2 throws in
        * this current frame and _not_ the running total sum of frames.
        */
        override public int Score()
        {
            int throw1 = (int)this.throws[this.startingThrow];
            int throw2 = (int)this.throws[this.startingThrow + 1];
            int next = (int)this.throws[this.startingThrow + 2];
            //Note that sum of both throws should equal 10 at this point
            if (throw1 + throw2 != 10)
            {
                Console.WriteLine($"***error: prior + current should equal 10: {throw1 + throw2}");
            }
            return throw1 + throw2 + next;
        }

    }
}
