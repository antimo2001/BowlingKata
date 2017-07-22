using System.Collections;

namespace BowlingKata
{
    public class OpenFrame: IFrame
    {
        private int score;
        private ArrayList throws;
        private int startingThrow;

        public int Score()
        {
            return score;
        }

        public OpenFrame(ArrayList throws, int firstThrow, int secondThrow)
        {
            this.throws = throws;
            this.startingThrow = throws.Count;
            throws.Add(firstThrow);
            throws.Add(secondThrow);
            score = firstThrow + secondThrow;
        }
    }
}
