﻿using System;

namespace Задача_13
{
    class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string feedBack = Console.ReadLine();

            double pricePerNight = 0;
            double discount = 0;


            switch (roomType)
            {
                case "room for one person":
                    pricePerNight = 18;
                    break;

                case "apartment":
                    pricePerNight = 25;

                    if (days < 10)
                    {
                        discount = 0.30;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        discount = 0.35;
                    }
                    else if (days > 15)
                    {
                        discount = 0.50;
                    }
                    break;

                case "president apartment":
                    pricePerNight = 35;

                    if (days < 10)
                    {
                        discount = 0.10;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        discount = 0.15;
                    }
                    else if (days > 15)
                    {
                        discount = 0.20;
                    }
                    break;
            }


            double total = pricePerNight * (days - 1);
            total -= total * discount;

            if (feedBack == "positive")
            {
                total += total * 0.25;
            }

            else
            {
                total -= total * 0.10;
            }

            Console.WriteLine($"{total:f2}"); 
            
        }
    }
}
