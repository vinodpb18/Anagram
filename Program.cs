using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first string: ");
            string firstString = Console.ReadLine();

            Console.Write("Enter second string: ");
            string secondString = Console.ReadLine();

            if (IsAnagram(firstString, secondString))
                Console.WriteLine("These strings are anagrams.");
            else
                Console.WriteLine("These strings are not anagrams.");

            Console.WriteLine();
        }

        /// <summary>
        /// Comparing two string whether Anagram or not and return result 
        /// </summary>
        /// <param name="firstString"></param>
        /// <param name="secondString"></param>
        /// <returns>bool</returns>
        private static bool IsAnagram(string firstString, string secondString)
        {
            try
            {
                // To remove the special character from string
                firstString = Regex.Replace(firstString, @"[^0-9a-zA-Z]+", "");
                secondString = Regex.Replace(secondString, @"[^0-9a-zA-Z]+", "");

                // check if both strings length not same, return false
                if (firstString.Length != secondString.Length)
                {
                    return false;
                }

                char[] firstStrChar = firstString.ToLower().ToCharArray();
                char[] secondStrChar = secondString.ToLower().ToCharArray();

                // Sorting character array
                Array.Sort(firstStrChar);
                Array.Sort(secondStrChar);

                string firstFinalStr = new string(firstStrChar);
                string secondFinalStr = new string(secondStrChar);

                if (firstFinalStr == secondFinalStr)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }
    }
}
