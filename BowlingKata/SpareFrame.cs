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
        * this current frame and next throw.
        */
        override public int Score()
        {
            int next = (int)this.throws[this.startingThrow + 2];
            return 10 + next;
        }

    }
}
