using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace KenoGame
{
    public class Ticket
    {
        public int TicketNumber { get; set; }
        public List<int> CellSet { get; set; }
        public List<int> WinSet { get; set; }

        public int Bid { get; set; }
        private static readonly Random rand = new Random();


        public Ticket(List<int> cellSet, int bid)
        {
            CellSet = cellSet;
            Bid = bid;
        }

        public void ChooseWinsSet() {
            List<int> winningNumbers = new List<int>();
            while (winningNumbers.Count < 20)
            {
                int num = rand.Next(1, 81);
                if (!winningNumbers.Contains(num))
                {
                    winningNumbers.Add(num);
                }
            }
            WinSet = winningNumbers;
        }

        public int CalculateGain()
        {
            int matchCount = CellSet.Intersect(WinSet).Count();

            switch (matchCount)
            {
                case 10: return 10000 * Bid;
                case 9: return 4500 * Bid;
                case 8: return 1000 * Bid;
                case 7: return 142 * Bid;
                case 6: return 24 * Bid;
                case 5: return 5 * Bid;
                default: return 0 * Bid;
            }
        }
    }
}
