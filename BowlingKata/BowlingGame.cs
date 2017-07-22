using System.Collections;

namespace BowlingKata
{
    public class BowlingGame
    {
        private ArrayList frames;
        private ArrayList throws;

        public BowlingGame()
        {
            frames = new ArrayList();
            throws = new ArrayList();
        }

        public void OpenFrame(int firstThrow, int secondThrow)
        {
            frames.Add(new OpenFrame(throws, firstThrow, secondThrow));
        }

        public void Spare(int firstThrow)
        {
            frames.Add(new SpareFrame(throws, firstThrow));
        }

        public void Strike()
        {
            frames.Add(new StrikeFrame(throws));
        }

        public int Score()
        {
            int total = 0;
            foreach (IFrame f in frames)
            {
                total += f.Score();
            }
            return total;
        }
    }
}
