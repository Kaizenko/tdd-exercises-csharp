using System;

namespace Kaizenko.Vending
{
    public class VendingMachine
    {
        int money;
        public int ReleaseChange()
        {
            int change = money;
            money = 0;
            return change;
        }

        public void InsertCoin()
        {
            money += 25;
        }

        public Product BuyProduct()
        {
            if (money >= 50)
            {
                money = money - 50;
                return new Product();
            }
            else
            {
                return null;
            }
            
        }
    }
}
