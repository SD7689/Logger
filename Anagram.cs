namespace ConsoleApp1
{ 
using System;

    / <summary>
    / Anagram class
    / </summary>
    public class Anagram
    {
        / <summary>
        / The log
        / </summary>
        private static readonly log4net.ILog Log = LogHelper.GetLogger();

        / <summary>
        / Ana the gram.
        / </summary>
        public static void AnaGram()
        {
            try
            {
                Console.WriteLine("Enter String one:");
                string s1 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter String Two");
                string s2 = Convert.ToString(Console.ReadLine());
                char[] ch1 = s1.ToLower().ToCharArray();
                char[] ch2 = s2.ToLower().ToCharArray();

                Array.Sort(ch1);
                Array.Sort(ch2);

                string str1 = new string(ch1);
                string str2 = new string(ch2);

                if (str1 == str2)
                {                  
                    Console.WriteLine("String are Anagaram");
                }
                else
                {
                    Log.Error("Two strings are not Same or Equal ");
                    Console.WriteLine("Strings are Not Anagram");
                }
            }
            catch(Exception)
            {
                Log.Error("Strings are not of same length!!");
                throw;
            }
        }
    }
}
