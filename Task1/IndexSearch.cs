using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class IndexSearch
    {
        #region public methods
        /// <summary>
        /// Finds first index of an element which has equal left and right parts of an array. 
        /// </summary>
        /// <param name="array">Your array</param>
        /// <returns>Index of the first fitting element</returns>
        public static int FindIndex(int[] array)
        {
            return FindElementIndex(array);
        }
        #endregion
        #region private methods
        /// <summary>
        /// Private method that implements FindIndex method
        /// </summary>
        /// <param name="array">Your array</param>
        /// <returns>Index of the first fitting element</returns>
        private static int FindElementIndex(int[] array)
        {
            if (CheckIsEmpty(array)) throw new NullReferenceException();

            for (int i=0; i<array.Length; i++)
                if (FindSum(array, 0, i) == FindSum(array, i + 1, array.Length))
                    return i;

            return -1;
        }

        /// <summary>
        /// Private method that finds sum of the elements form left index till right index
        /// </summary>
        /// <param name="array">Your array</param>
        /// <param name="left">Start index</param>
        /// <param name="right">End index</param>
        /// <returns>Sum of the elements form left index till right index</returns>
        private static int FindSum(int[] array, int left, int right)
        {
            int sum = 0;

            for (int i = left; i<right; i++)
                sum += array[i];

            return sum;
        }

        /// <summary>
        /// Checks array for emptyness
        /// </summary>
        /// <param name="array">Your array</param>
        /// <returns>true if array is empty otherwise returns false</returns>
        private static bool CheckIsEmpty(int[] array)
        {
            if (ReferenceEquals(array, null)) return true;
            return false;
        }
        #endregion
    }
}
