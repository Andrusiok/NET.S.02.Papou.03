﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class BinaryOperations
    {
        #region public methods
        /// <summary>
        /// Inserts bits from sorce int to destination int starting from index
        /// </summary>
        /// <param name="destination">destination int</param>
        /// <param name="source">source int</param>
        /// <param name="startIndex">start index of destination int bits</param>
        /// <param name="endIndex">end index of destination int bits</param>
        /// <returns>changed destination int</returns>
        public static int Insert(int destination, int source, int startIndex, int endIndex)
        {
            return InsertNumber(destination, source, startIndex, endIndex);
        }
        #endregion
        #region private methods
        /// <summary>
        /// Private method inserts bits from sorce int to destination int starting from index
        /// </summary>
        /// <param name="destination">destination int</param>
        /// <param name="source">source int</param>
        /// <param name="startIndex">start index of destination int bits</param>
        /// <param name="endIndex">end index of destination int bits</param>
        /// <returns>changed destination int</returns>
        private static int InsertNumber(int destination, int source, int startIndex, int endIndex)
        {
            BitArray destinationBits = new BitArray(BitConverter.GetBytes(destination));
            BitArray sourceBits = new BitArray(BitConverter.GetBytes(source));

            if (startIndex < endIndex) throw new ArgumentOutOfRangeException();
            if (destinationBits.Length<endIndex) throw new ArgumentOutOfRangeException();

            int j = 0;
            for (int i=0; i<endIndex+1; i++)
            {
                destinationBits[i] = sourceBits[j];
                j++;
            }

            int[] result = new int[1];
            destinationBits.CopyTo(result, 0);

            return result[0];
        }
        #endregion
    }
}
