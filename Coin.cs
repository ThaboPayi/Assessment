using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assessment.CoinAssessment
{
    public class Coin : ICoin
    {
        public Coin(decimal volume, decimal amount)
        {
            Amount = amount;
            Volume = volume;
            CoinJar jar = new CoinJar(Volume, Amount);
        }

        public decimal Amount { get; }

        public decimal Volume { get; }

        public void AddCoins()
        {
            var jar = new CoinJar();
            ICoin enteredCoin = new CoinJar();
         
            jar.TryParse(Amount.ToString() , ref enteredCoin);
        }
    }
}
