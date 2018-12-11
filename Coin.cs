using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace Assessment.CoinAssessment
{
    public class Coin : ICoin
    {
        private readonly decimal _amount;
        private readonly decimal _volume;

        public Coin(decimal amount, decimal volume)
        {
            _amount = amount;
            _volume = volume;

        }

        public decimal Amount
        {
            get
            {
                //Because there is a fixed amount and volume of certain coin, i will do switch to validate given amount
                //For example purposes i have just given random figures
                switch (_volume)
                {
                    default:
                        return 0;
                    case 10:
                        return 2;
                    case 20:
                        return 5;
                    case 30:
                        return 7;
                    case 40:
                        return 10;
                }
            }
        }

        public decimal Volume
        {
            get
            {
                //Because there is a fixed amount and volume of certain coin, i will do switch to validate given volume
                //For example purposes i have just given random figures
                switch (_amount)
                {
                    default:
                        return 0;
                    case 2:
                        return 10;
                    case 5:
                        return 20;
                    case 7:
                        return 30;
                    case 10:
                        return 40;
                }
            }
        }
    }
}
