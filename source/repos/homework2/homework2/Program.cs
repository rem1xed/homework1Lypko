using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.

            Console.WriteLine("Enter a string: ");

            string text1 = Console.ReadLine();

            int option;

            Console.WriteLine("1.Display a string\n2.Display the length of a string\n3.Find a word in a string \n4.Replace a specific word in a string \n5.Delete a specific word in a string\nYour option: ");

            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine(text1);
                    break;
                case 2:
                    Console.WriteLine("This string is {0} in length", text1.Length);
                    break;
                case 3:
                    Console.WriteLine("Enter word to find: ");
                    string find = Console.ReadLine();
                    if (text1.Contains(find))
                    {
                        Console.WriteLine("Word {0} is found in a \" {1} \" string ", find, text1);
                    }
                    else
                    {
                        Console.WriteLine("Word {0} is NOT found in a \" {1} \" string ", find, text1);
                    }
                    break;
                case 4:
                    Console.WriteLine("Enter a word to replace ");
                    string replace = Console.ReadLine();
                    Console.WriteLine("Enter a new word");
                    string newW = Console.ReadLine();
                    Console.WriteLine("your string with replaced word:\n {0}", text1.Replace(replace, newW));
                    break;
                case 5:
                    Console.WriteLine("Enter a word to delete ");
                    string delete = Console.ReadLine();
                    Console.WriteLine("your string with replaced word:\n {0}", text1.Replace(delete, ""));
                    break;
            }

            //2.

            //int[,] array = new int[10, 8];

            //Random rand = new Random();

            //Console.WriteLine("Enter number(from -10 to 10) to find in matrix: ");
            //int find = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
            //        array[i, j] = rand.Next(-10, 10);
            //        if (array[i, j] == find)
            //        {
            //            count++;
            //        }
            //        Console.Write("{0}\t",array[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("\n{0} number was found {1} times in array", find, count);

            //3.

            //int[,] array = new int[7, 8];

            //Random rand = new Random();

            //for (int i = 0; i < 7; i++)
            //{
            //    int max = 0;
            //    for (int j = 0; j < 8; j++)
            //    {
            //        array[i, j] = rand.Next(-100, 100);
            //        if(max < array[i,j])
            //        {
            //            max = array[i, j];
            //        }      
            //            Console.Write("{0}\t", array[i, j]); 
            //    }
            //    Console.Write("Max: {0}", max);
            //    Console.WriteLine();
            //}









        }
    }
}
