using System.Collections;

namespace BowlingKata
{
    public class OpenFrame: Frame
    {
        /**
        * Instantiates OpenFrame using the base class constructor
        */
        public OpenFrame(ArrayList throws) : base(throws)
        {
        }

        /**
        * Instantiates OpenFrame using another constructor and the 2 throws
        */
        public OpenFrame(ArrayList throws, int firstThrow, int secondThrow) : this(throws)
        {
            this.throws.Add(firstThrow);
            this.throws.Add(secondThrow);
        }

        /**
        * Overrides the Frame.Score method. Note this only sums the 2 throws in
        * this current frame and _not_ the running total sum of frames.
        */
        override public int Score()
        {
            int throw1 = (int)this.throws[this.startingThrow];
            int throw2 = (int)this.throws[this.startingThrow + 1];
            return throw1 + throw2;
        }

    }
}
