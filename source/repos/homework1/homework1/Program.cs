using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.

            Console.WriteLine("Enter degrees in celsius: ");

            float c = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Converted into Fahrenheits: {0} ", (9 * c) / 5 + 32);

            //2.
            //firstly enter sting, then symbol to replace the blank space with

            //string line = Console.ReadLine();
            //char replace = Convert.ToChar(Console.ReadLine());

            //Console.WriteLine(line.Replace(' ', replace ));

            //3.

            //firstly enter your tree-digit number, then enter number to find it in the first nunber

            //string numb = Console.ReadLine();

            //char find = Convert.ToChar(Console.ReadLine());

            //if (Convert.ToBoolean(numb.Contains(find)))
            //{
            //    Console.WriteLine("{0} was found in {1} number", find, numb);
            //}
            //else
            //{
            //    Console.WriteLine("{0} was not found in {1} number", find, numb);
            //}

            //4. 
            //just enter number


            //string number = Convert.ToString(Console.ReadLine());
            //char[] reverseArr = number.ToCharArray();

            //string strReverse = "";

            //for(int i = reverseArr.Length-1; i > -1; i--)
            //{

            //    strReverse += reverseArr[i];
            //}

            //if (number == strReverse)
            //{
            //    Console.WriteLine("{0} IS a palindrome! ", number);
            //}
            //else
            //{
            //    Console.WriteLine("{0} is NOT a palindrome! ", number);
            //}




        }
    }
}
