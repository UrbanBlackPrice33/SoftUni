﻿using System;

namespace Задача_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit)
                    {
                        case "banana":
                            price = quantity * 2.50;
                            Console.WriteLine($"{price:f2}");
                            break;

                        case "apple":
                            price = quantity * 1.20;
                            Console.WriteLine($"{price:f2}");
                            break;

                        case "orange":
                            price = quantity * 0.85;
                            Console.WriteLine($"{price:f2}");
                            break;

                        case "grapefruit":
                            price = quantity * 1.45;
                            Console.WriteLine($"{price:f2}");
                            break;

                        case "kiwi":
                            price = quantity * 2.70;
                            Console.WriteLine($"{price:f2}");
                            break;

                        case "pineapple":
                            price = quantity * 5.50;
                            Console.WriteLine($"{price:f2}");
                            break;

                        case "grapes":
                            price = quantity * 3.85;
                            Console.WriteLine($"{price:f2}");
                            break;

                        default:
                            Console.WriteLine("error");
                            break;
                        
                    }
                    break;

                case "Saturday":
                case "Sunday":
                    
                    switch (fruit)
                    {
                        case "banana":
                            price = quantity * 2.70;
                            Console.WriteLine($"{price:f2}");
                            break;

                        case "apple":
                            price = quantity * 1.25;
                            Console.WriteLine($"{price:f2}");
                            break;

                        case "orange":
                            price = quantity * 0.90;
                            Console.WriteLine($"{price:f2}");
                            break;

                        case "grapefruit":
                            price = quantity * 1.60;
                            Console.WriteLine($"{price:f2}");
                            break;

                        case "kiwi":
                            price = quantity * 3.00;
                            Console.WriteLine($"{price:f2}");
                            break;

                        case "pineapple":
                            price = quantity * 5.60;
                            Console.WriteLine($"{price:f2}");
                            break;

                        case "grapes":
                            price = quantity * 4.20;
                            Console.WriteLine($"{price:f2}");
                            break;

                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;


                default:
                    Console.WriteLine("error");
                    break;

            }
          



            

        }
    }
}
