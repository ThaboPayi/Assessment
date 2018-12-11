using System;
using System.Linq;
using System.Transactions;
using Assessment;
using Assessment.CoinAssessment;
using Assessment.StringAssessment;

namespace CollectionStringDisplayer
{
    class Program
    {
        static void Main(string[] args)
        {

            string stringInput;

            //Instatiation
            IStringCollection stringCollection = new StringCollection();
            CoinJar jar = new CoinJar();           

            Console.WriteLine("Strings");
            Console.WriteLine("//=======//");
            Console.WriteLine();
            //Just for demo purpose i will take only 5 strings, otherwise it can be set to any no you want
            stringInput = "Please enter five strings";
            Console.WriteLine(stringInput);
            Console.WriteLine("//==================================================//");
            //Catch input
            for(int i = 0; i <= 4; i++)
            {
                stringCollection.AddString(Console.ReadLine()?.ToString());
            }

            //Display String
            Console.WriteLine("Concatenated list of strings delimited with comma is:");
            Console.WriteLine(stringCollection.ToString());
            Console.WriteLine("....................................................");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Coinage");
            Console.WriteLine("//======//");
            Console.WriteLine();
            Console.WriteLine("Because there is a lot of countries using '$'other than U.S ....");
            Console.WriteLine("Please enter US coins, first enter coin amount with US currency code e.g '10USD' then enter its volume size");
            Console.WriteLine("//=========================================================================================================//");
            //Just for demo purpose i will take only 5 coins, otherwise it can be set to any no you want or to anything less than Jar Volume
            for (int i = 0; i <= 4 ; i++)
            {
                try
                {
                    string coinAmount = Console.ReadLine();
                    if (coinAmount != null)
                    {
                        string coinAmountWithOutCurrencyCode =  coinAmount.Remove(coinAmount.Length - 3);
                        decimal amount = decimal.Parse(coinAmountWithOutCurrencyCode);

                        decimal volume = decimal.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine();

                        Coin coin = new Coin(amount, volume);

                        ICoin enteredCoin = new CoinJar();
                        jar.TryParse(amount.ToString(), ref enteredCoin);
                        
                    }

                    if (jar.Message != null)
                    {
                        Console.WriteLine(jar.Message);
                        Console.ReadKey();
                    }
                    else
                    {

                        //Display TotalAmount of Coins Collected
                        Console.WriteLine("Total Amount is:");
                        Console.WriteLine(jar.TotalAmount);
                        Console.WriteLine("//==================================================//");
                        Console.WriteLine("Now lets empty the jar before it gets full");
                        jar.Reset();
                        Console.WriteLine(jar.TotalAmount);
                        Console.WriteLine("//====================End===========================//");
                        Console.ReadKey();
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("The Coin Amount or Coin Volume entered is in incorrect format, or null");
                }
                
            }
        }
    }
}
