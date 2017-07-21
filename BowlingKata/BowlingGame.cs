using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Spare(int firstThrow, int secondThrow)
        {
            frames.Add(new SpareFrame(throws, firstThrow, secondThrow));
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
