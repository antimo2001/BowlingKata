using System;
using System.Collections;

namespace BowlingKata
{
    public class BonusFrame: Frame
    {
        public BonusFrame(ArrayList throws) : base(throws)
        {
        }

        public BonusFrame(ArrayList throws, int pins) : this(throws)
        {
            this.throws.Add(pins);
        }

        public override int Score()
        {
            return 0;
        }
    }
}