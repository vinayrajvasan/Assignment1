﻿using System;

namespace Assignment
{
    class Program
    {
        static int[] array;

        void user()
        {
            int choice = 0;
            while (choice != 1)
            {
                print();
                Console.Write("\nEnter the operation(1.Exit): ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Exiting...\n");
                        break;
                    case 2:
                        operation2();
                        break;
                    case 4:
                        operation4();
                        break;
                    case 6:
                        operation6();
                        break;
                    case 8:
                        operation8();
                        break;
                    default:
                        Console.WriteLine("Please choose a valid key...\n");
                        break;
                }
            }
        }

        static void operation2()
        {
            currentIndex = indexOf1();
            if ((currentIndex / order) != order - 1)
            {
                array[currentIndex + order] = 1;
                array[currentIndex] = 0;
            }
        }

        static void operation4()
        {
            currentIndex = indexOf1();
            if ((currentIndex % order) != 0)
            {
                array[currentIndex - 1] = 1;
                array[currentIndex] = 0;
            }
        }

        static void operation6()
        {
            currentIndex = indexOf1();
            if ((currentIndex % order) != order - 1)
            {
                array[currentIndex + 1] = 1;
                array[currentIndex] = 0;
            }
        }

        static void operation8()
        {
            currentIndex = indexOf1();
            if ((currentIndex / order) != 0)
            {
                array[currentIndex - order] = 1;
                array[currentIndex] = 0;
            }
        }

        static int indexOf1()
        {
            {

        void read()
        {

        void print()
        {
            {
                {
                    Console.WriteLine();
                }

        static void Main()
        {
            Program t1 = new Program();

        }
    }
}