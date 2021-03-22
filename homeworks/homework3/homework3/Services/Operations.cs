using homework3.Interfaces;
using System;

namespace homework3.Services
{
    class Operations : IOperations

    {
        public void DecrementQuality(Item item, int minusThis)
        {
            try
            {
                item.Quality -= minusThis;   
            }
            catch (System.ArithmeticException e)
            {
                Console.WriteLine("Exception: " + e);
                throw e;
            }
        }

        public void IncrementQuality(Item item, int plusThis)
        {
            try
            {
                item.Quality += plusThis;
            }
            catch (System.ArithmeticException e)
            {
                Console.WriteLine("Exception: " + e);
                throw e;
            }
        }
        public void DecrementSellIn(Item item, int minusThis)
        {
            try
            {
                item.SellIn -= minusThis;
            }
            catch (System.ArithmeticException e)
            {
                Console.WriteLine("Exception: " + e);
                throw e;
            }
        }

        public void IncrementSellIn(Item item, int plusThis)
        {
            try
            {
                item.SellIn+= plusThis;
            }
            catch (System.ArithmeticException e)
            {
                Console.WriteLine("Exception: " + e);
                throw e;
            }
        }
    }
}
