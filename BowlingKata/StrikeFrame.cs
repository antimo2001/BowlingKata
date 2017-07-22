using System;
using System.Collections;

namespace BowlingKata
{
    public class StrikeFrame: IFrame
    {
        ArrayList throws;
        int startingThrow;

        public StrikeFrame(ArrayList throws)
        {
            this.throws = throws;
            this.startingThrow = throws.Count;
            throws.Add(10);
        }

        private int FirstFollowingBall()
        {
            return (int)throws[startingThrow + 1];
        }

        private int SecondFollowingBall()
        {
            return (int)throws[startingThrow + 2];
        }

        public int Score()
        {
            return 10 + FirstFollowingBall() + SecondFollowingBall();
        }
    }
}
