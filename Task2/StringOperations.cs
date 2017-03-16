using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class StringOperations
    {
        #region private fields and constants
        private const string alphabet = "abcdefhijklmnopqrstuvwxyz";
        #endregion

        #region public methods
        /// <summary>
        /// Concates two strings. Removes symbols that aren't present in the alphabet. Sorts resulted string in ascending order.
        /// </summary>
        /// <param name="firstString">first string</param>
        /// <param name="secondString">second string</param>
        /// <returns>new concatenated string</returns>
        public static string Concate(string firstString, string secondString)
        {
            return ConcateStrings(firstString, secondString);
        }
        #endregion
        #region private methods
        /// <summary>
        /// Private method that implements string concatenation and sorting
        /// </summary>
        /// <param name="firstString">first string</param>
        /// <param name="secondString">second string</param>
        /// <returns>new concatenated string</returns>
        private static string ConcateStrings(string firstString, string secondString)
        {
            string buffer;
            string resultString = "";

            if (CheckIsEmpty(firstString)) throw new NullReferenceException();
            if (CheckIsEmpty(secondString)) throw new NullReferenceException();

            buffer = firstString + secondString;
            foreach(char letter in buffer)
                if (CheckIsPresent(letter, alphabet))
                    if (!CheckIsPresent(letter, resultString)) resultString += letter;

            return SortString(resultString);
        }

        /// <summary>
        /// Checks given string for emptyness
        /// </summary>
        /// <param name="subject">subject string</param>
        /// <returns>true if string is empty otherwise returns false</returns>
        private static bool CheckIsEmpty(string subject)
        {
            if (ReferenceEquals(subject, null)) return true;
            return false;
        }

        /// <summary>
        /// Checks letter for presence in subject string
        /// </summary>
        /// <param name="letter">letter</param>
        /// <param name="subject">string that should contain letter</param>
        /// <returns>true if letter is present in the subject string, returns false otherwise</returns>
        private static bool CheckIsPresent(char letter, string subject)
        {
            letter = char.ToLower(letter);
            return subject.Contains(letter);
        }

        /// <summary>
        /// Sorts subject string
        /// </summary>
        /// <param name="subject">subject string</param>
        private static string SortString(string subject)
        {
            char[] charArray = subject.ToArray();
            Array.Sort(charArray);
            return new string(charArray);
        }
        #endregion
    }
}
