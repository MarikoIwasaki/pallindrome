using System;

namespace Pallindrome
{
    /*3) Write a function called pallindrome_number() that takes one integer number as parameter. 
     * The function will find if the number is palindrome or not and then print the results on the screen.
     */
    class Program
    {
        public static void Pallindrome(int n)
        {
            int remainder, reverse=0, temp;
            temp = n;
            while (n!= 0)
            {
                remainder = n % 10;
                reverse = reverse * 10 + remainder;
                n = n / 10;
            }
            if (temp == reverse)
            {   
                Console.WriteLine("number is pallindrome");
            }
            else
            {
                Console.WriteLine("number is not pallindrome");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter integer");
            int input;
            input = Convert.ToInt32(Console.ReadLine());
            Pallindrome(input);
        }
    }
}
