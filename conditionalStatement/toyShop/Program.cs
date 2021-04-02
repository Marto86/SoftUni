using System;

namespace toyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripprice = double.Parse(Console.ReadLine());
            double puzzelcount= double.Parse(Console.ReadLine()); 
            double dollscount = double.Parse(Console.ReadLine()); 
            double bearscount = double.Parse(Console.ReadLine()); 
            double minionscount = double.Parse(Console.ReadLine()); 
            double truckscount = double.Parse(Console.ReadLine());


            double puzzelprice = puzzelcount * 2.60;
            double dollsprice = dollscount * 3;
            double bearsprice = bearscount * 4.10;
            double minionsprice = minionscount * 8.20;
            double truckprice = truckscount * 2.00;

            double totalcount = puzzelcount + dollscount + bearscount + minionscount + truckscount;
            double totalpriceprice = puzzelprice + dollsprice + bearsprice + minionsprice + truckprice;
            double discountprice = totalpriceprice * 0.75;
            double rentprice = 0;
            double profit = 0;


            if (totalcount >= 50 )
            {
                totalpriceprice = totalpriceprice - discountprice;
                rentprice = totalpriceprice - (totalpriceprice * 0.1);
                profit = totalpriceprice - rentprice;

                



            }







            
        }
    }
}

