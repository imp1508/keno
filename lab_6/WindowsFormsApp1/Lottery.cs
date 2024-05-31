using System;
using System.Collections.Generic;
using System.Linq;

namespace KenoGame
{
    public class Lottery
    {
        public int LotteryNumber { get; set; }
        public int Bid { get; set; }
        public List<int> CellSet { get; set; }
        public int GlobalGain { get; set; }

        public Lottery(int bid, List<int> cellSet)
        {
            Bid = bid;
            CellSet = cellSet;
        }

        public List<List<int>> lottery(int ticketCount) { 
            List<List<int>> winSets = new List<List<int>>();

            for (int i = 0; i < ticketCount; i++)
            {
                Ticket ticket = new Ticket(CellSet, Bid);
                ticket.ChooseWinsSet();
                GlobalGain += ticket.CalculateGain();

                winSets.Add(ticket.WinSet);
            }

            return winSets;
        }
    }
}
