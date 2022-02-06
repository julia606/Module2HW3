// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace M2HW3
{
    using System;

    internal class Program
    {
        public static bool CandyGreater100(Chocolate candy)
        {
           return candy.Weight > 100;
        }

        public static void Main(string[] args)
        {
            Random random = new Random();

            Chocolate candy1 = new BubleChocolate(random.Next(50, 200));
            Chocolate candy2 = new WhiteChocolate(random.Next(50, 200));
            Chocolate candy3 = new CandyWithFilling(random.Next(50, 200));
            Chocolate candy4 = new CandyWithNoFilling(random.Next(50, 200));

            Chocolate[] candies = new Chocolate[] { candy1, candy2, candy3, candy4 };
            Gift gift = new Gift(candies);
            Array.Sort(candies);

            Console.WriteLine($"Вес подарка равен: {gift.CountWeight()} грамм");
            foreach (Chocolate cand in candies)
            {
                Console.WriteLine($"{cand.Type()} - {cand.Weight} грамм");
            }

            Console.WriteLine();
            ExtensionClass.Find(candies, CandyGreater100);
        }
    }
}