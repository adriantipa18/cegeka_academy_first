using homework3.Interfaces;
using System;

namespace homework3.Services
{
    class Validate : IValidate
    {

        public bool NameEquals(Item item, string compareTo)
        {
            try
            {
                if (item.Name == compareTo)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e);
                return false;
            }
        }


        public bool QualityLowerThan(Item item, int compareTo)
        {
            try
            {
                if (item.Quality < compareTo)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e);
                return false;
            }
        }


        public bool SellInLowerThan(Item item, int compareTo)
        {
            try
            {
                if (item.SellIn < compareTo)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e);
                return false;
            }
        }
    }
}
