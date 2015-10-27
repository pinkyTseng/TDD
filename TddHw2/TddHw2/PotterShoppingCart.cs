using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddHw2
{
    public class PotterShoppingCart
    {
        public int calculateFee(int[] orderCountArray)
        {
            int total = 0;
            Hashtable remainOrders= initHashtable(orderCountArray);
            while (remainOrders.Count > 0)
            {
                total += getMaxDiffCounts(remainOrders);
            }



            return total;
        }

        Hashtable initHashtable(int[] orderCountArray)
        {
            Hashtable remainOrders = new Hashtable();
            for (int i = 0; i < orderCountArray.Length; i++)
            {
                if (orderCountArray[i] != 0)
                {
                    remainOrders.Add(i + 1, orderCountArray[i]);
                }
                //remainOrders.Add(i+1, orderCountArray[i]);
            }
            return remainOrders;
        }

        int getMaxDiffCounts(Hashtable remainOrders )
        {
            int diffCounts = 0;
            List<int> list = remainOrders.Keys.Cast<int>().ToList();
            foreach (int key in list)
            {
                int vNew = (int) remainOrders[key];
                if (vNew >= 1)
                {
                    diffCounts++;
                    vNew--;
                    remainOrders[key] = vNew;
                    if (vNew == 0)
                    {
                        remainOrders.Remove(key);
                    }
                    
                    //e.Value = vNew;
                }
                //Console.WriteLine("{0, -15} {1, -15}", e.Key, e.Value);
            }
            return calculateDiscount(diffCounts);
        }

        int calculateDiscount(int count)
        {
            int basePrice = 100;
            double discount = 1;
            switch (count)
            {
                case 2:
                    discount = 0.95;
                    break;
                case 3:
                    discount = 0.9;
                    break;
                case 4:
                    discount = 0.8;
                    break;
                case 5:
                    discount = 0.75;
                    break;
                default:
                    discount = 1;
                    break;

            }
            return (int) (basePrice*count*discount);
        }
    }
}
