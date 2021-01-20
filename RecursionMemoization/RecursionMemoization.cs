using System;

namespace RecursionMemoization
{
    class RecursionMemoization
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int sum(int[] list)
        {
            return sum(list, 0);
        }

        private static int sum(int[] list, int index)
        {
            if (index == list.Length) return 0;
            return list[index] + sum(list, index + 1);
        }

        static Boolean is_Palindrome(string text)
        {
            if (text.Length <= 1) return true;
            return text[0].Equals(text[text.Length - 1]) && is_Palindrome(text.Substring(1, text.Length - 2));
        }
    }
}
