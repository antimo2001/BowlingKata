using System;
using System.Collections;

namespace BowlingKata
{
    public class StrikeFrame: Frame
    {
        /**
        * Instantiates StrikeFrame using the base class constructor
        */
        public StrikeFrame(ArrayList throws) : base(throws)
        {
            this.throws.Add(10);
        }

        /**
        * Overrides the Frame.Score method. Note this only sums the 1 throw in
        * this current frame and _not_ the running total sum of frames.
        */
        override public int Score()
        {
            return 10 + FirstFollowingBall() + SecondFollowingBall();
        }

        private int FirstFollowingBall()
        {
            return (int)throws[startingThrow + 1];
        }

        private int SecondFollowingBall()
        {
            return (int)throws[startingThrow + 2];
        }
    }
}
