using System;

namespace StringRelated
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Hi! My name is Mustafa.";
            try
            {
                Console.WriteLine(ReverseString(myString));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Reverses a input string
        /// Throws exception if null string is passed as input
        /// </summary>
        /// <param name="myString"></param>
        /// <returns></returns>
        public static string ReverseString(string myString)
        {
            if (myString.Length >= 1)
            {
                var charArray = myString.ToCharArray();
                char[] reversedCharArray = new char[charArray.Length];
                for (var i = charArray.Length; i > 0; i--)
                {
                    reversedCharArray[i - 1] = charArray[charArray.Length - i];
                }
                string reversedString = new string(reversedCharArray);
                return reversedString;
            }
            else
            {
                throw new Exception("Null String!");
            }
        }
    }
}
