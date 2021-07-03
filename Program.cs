using System;

namespace Assignment
{
    class Program
    {
        static int[] array;        static int order, currentIndex;

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
        {            for (int i = 0; i < (order * order); i++)
            {                if (array[i] == 1)                    return i;            }            return 0;        }

        void read()
        {            Console.Write("Enter order of matrix: ");            order = int.Parse(Console.ReadLine());            array = new int[order * order];            array[0] = 1;        }

        void print()
        {            for (int i = 0; i < (order * order); i++)
            {                if (i % order == 0)
                {
                    Console.WriteLine();
                }                Console.Write(array[i] + " ");            }        }

        static void Main()
        {
            Program t1 = new Program();            t1.read();            t1.user();

        }
    }
}
