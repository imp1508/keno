using System;
using System.Collections.Generic;
using System.Linq;

namespace KenoGame
{
    public class Game
    {
        public int GameNumber { get; private set; }
        public int Balance { get; private set; }
        public int LastGain { get; private set; }

        public Game(int balance = 1000)
        {
            GameNumber = 1;
            Balance = balance;
        }

        public void AddBalance(int amount)
        {
            Balance += amount;
        }

        public void CloseGame()
        {
            GameNumber++;
        }

        public List<List<int>> PlayGame(int bid, List<int> selectedNumbers, int ticketCount)
        {
            Balance -= bid * ticketCount;

            Lottery lottery = new Lottery(bid, selectedNumbers);
            List<List<int>> winSets = lottery.lottery(ticketCount);
            int gain = lottery.GlobalGain;

            LastGain = gain;

            AddBalance(gain);

            return winSets;
        }
    }
}
