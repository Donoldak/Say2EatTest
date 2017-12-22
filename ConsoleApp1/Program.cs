using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace say2EatTests
{
    public class Program
    {
        private static readonly string[] maindish = new string[] { "pizza", "toast" };
        private static string[] addons = new string[] { "black olives", "green olives", "extra cheese", "mushrooms" };

        static void Main(string[] args)
        {
            string resualt = "";
            do
            {
                Console.WriteLine("insert your order");
                resualt = AnalizeInput(Console.ReadLine());
                Console.WriteLine(resualt);
                
            } while (resualt == "Please try again");
            Console.ReadKey();
        }

        public static string AnalizeInput(string input)
        {
            var resualt = "";
            int countMainDish = 0;
            int countAddons = 0;

            if (!string.IsNullOrEmpty(input))
            {
                Order order = new Order();

                String[] arr = input.Split(' ');


                foreach(var word in arr)
                {
                    foreach(var item in maindish)
                    {
                        if(word == item)
                        {
                            countMainDish++;
                        }
                    }

                    foreach (var item in addons)
                    {
                        if (word == item)
                        {
                            countAddons++;
                        }
                    }
                }

                if(countMainDish > 1)
                {
                    return "Please try again";
                }

                foreach (var item in maindish)
                {

                    if (input.Contains(item))
                    {
                        order.main = item;
                    }
                }
                if(order.main == null)
                {
                    return "Please try again";
                }

                foreach (var item in addons)
                {

                    if (input.Contains(item))
                    {
                        if (order.addons == null)
                        {
                            order.addons += item;
                        }
                        else
                        {
                            order.addons += ", " + item;
                        }

                    }
                }

                if(order.addons == null)
                {
                    resualt = "Your " + order.main + " is on the way";
                }
                else
                {
                    resualt =  "Your " + order.main + " with " + order.addons + " is on the way";

                }
            }
            else
            {
                return "Please try again";
                
            }

            return resualt;
        }

        public class Order
        {
            public string addons;
            public string main;
        }
    }
}

