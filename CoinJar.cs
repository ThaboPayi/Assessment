using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace Assessment.CoinAssessment
{
    public class CoinJar : ICoinJar
    {
        public string Message;
        public decimal JarVolume = 42;

        public CoinJar()
        {

        }

        public CoinJar(decimal _volume, decimal _amount)
        {
            Volume = _volume;
            Amount = _amount;
        }

        public void AddCoin(ICoin coin)
        {
            //var type = this.GetType();
            //var prop = type.GetProperty($"{coin}USD");
            //var val = prop?.GetValue(this);
           

            if (coin != null && JarVolume > 0)
            {
                JarVolume -= coin.Volume;
                _coins.Add(coin); 
            }
            else
            {
                Message = "Error occured: Its either there is no coin entered or the Jar is full";
            }
        }

        public void Reset()
        {
            _coins.Clear();

        }

        public void TryParse(string enteredCoin, ref ICoin collectedCoin)
        {   
            AddCoin(collectedCoin);
        }

        public decimal TotalAmount
        {
            get { return _coins.Sum(m => m.Amount); }
        }
        public decimal Amount { get; }
        public decimal Volume { get; }

        private List<ICoin> _coins = new List<ICoin>();
    }
}
