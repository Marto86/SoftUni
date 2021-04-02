using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int tourists = int.Parse(Console.ReadLine());
            string touriststype = Console.ReadLine();
            string day = Console.ReadLine();
            decimal price = 0;
            decimal totalprice = 0;
            

            if (day == "Friday")
            {
                switch (touriststype)
                {
                    case "Students":
                        price = 8.45M;
                        break;
                    case "Business":
                        price = 10.90M;
                        break;
                    case "Regular":
                        price = 15;
                        break;
                }

            }
            else if (day == "Saturday")
            {
                switch (touriststype)
                {
                    case "Students":
                        price = 9.8M;
                        break;
                    case "Business":
                        price = 15.60m;
                        break;
                    case "Regular":
                        price = 20;
                        break;
                }
            }
            else if (day == "Sunday")
            {
                switch (touriststype)
                {
                    case "Students":
                        price = 10.46M;
                        break;
                    case "Business":
                        price = 16M;
                        break;
                    case "Regular":
                        price = 22.50M;
                        break;
                }
            }

            totalprice = price * tourists;

            if (tourists >= 30 && touriststype == "Students")
            {
                totalprice *= 0.85m;
            }
            else if (tourists >= 100 && touriststype == "Business")
            {
                totalprice = (tourists - 10) * price;
            }
            else if (tourists >= 10 && tourists<= 20)
            {
                totalprice *= 0.95M;
            }
            Console.WriteLine($"Total price: {totalprice:F2}");






        }
    }
}
