﻿using System;

namespace _03._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favorite = Console.ReadLine();

            string current = Console.ReadLine();
            int checkedBooks = 0;

            while (current != "No More Books" && current != favorite)
            {
                checkedBooks++; // we just procesed a book, incidate this!
                current = Console.ReadLine(); // get the next book
            }

            if (current == favorite)
                Console.WriteLine($"You checked {checkedBooks} books and found it.");
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {checkedBooks} books.");
            }
        }
    }
}
