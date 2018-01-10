using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11_jan_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            byte?[] miniarray = new byte?[20];
            int a = 0;

            for (int i = 0; i < miniarray.Length; i++)
            {
                while (miniarray[i] == null)
                {
                    try
                    {
                        a = rand.Next(-5, 28);
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    try
                    {
                        while (miniarray[a] == null)
                            miniarray[a] = (byte)rand.Next(0, 1000); // без (byte) оно не хочет рандомить
                    }
                    catch (OutOfMemoryException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

            }
            foreach (var item in miniarray)
            {
                Console.WriteLine(item);
            }

        }


    }
}

