using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Tests;
using NUnit.Compatibility;
using Task3;
using Task2;
using Task1;

namespace NUnit.Tests
{
    /// <summary>
    /// Task3 Tests
    /// </summary>
    [TestFixture]
    public class BinaryOperationsTests
    {
        [TestCase(8, 15, 0, 0, ExpectedResult = 9)]
        [TestCase(0, 15, 30, 30, ExpectedResult = 1073741824)]
        [TestCase(0, 15, 0, 30, ExpectedResult = 15)]
        [TestCase(int.MaxValue, int.MaxValue, 3, 5, ExpectedResult = int.MaxValue)]
        [TestCase(15, int.MaxValue, 3, 5, ExpectedResult = 63)]
        [TestCase(15, 15, 1, 3, ExpectedResult = 15)]
        [TestCase(15, 15, 1, 4, ExpectedResult = 31)]
        [TestCase(15, -15, 0, 4, ExpectedResult = 17)]//31
        [TestCase(15, -15, 1, 4, ExpectedResult = 3)]//15
        [TestCase(-8, -15, 1, 4, ExpectedResult = -30)]//-6
        public int Insert_PositiveTest(int first, int second, int startPosition, int finishPosition)
        {
            return BinaryOperations.Insert(first, second, startPosition, finishPosition);
        }

        [TestCase(8, 15, -1, 5)]
        [TestCase(8, 15, 5, -1)]
        [TestCase(8, 15, 31, 5)]//Неккоректный тест
        [TestCase(8, 15, 5, 31)]//Неккоректный тест
        public void Insert_ThrowsArgumentOutOfRangeException(int first, int second, int startPosition, int finishPosition)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => BinaryOperations.Insert(first, second, startPosition, finishPosition));
        }

        [TestCase(8, 15, 7, 5)]
        [TestCase(8, 15, 1, 0)]
        public void Insert_ThrowsArgumentException(int first, int second, int startPosition, int finishPosition)
        {
            Assert.Throws<ArgumentException>(() => BinaryOperations.Insert(first, second, startPosition, finishPosition));
        }
    }

    /// <summary>
    /// Task2 tests
    /// </summary>
    [TestFixture]
    public class StringOperationsTests
    {
        [TestCase("abcde", "abcde", ExpectedResult = "abcde")]
        [TestCase("edcba", "abcde", ExpectedResult = "abcde")]
        [TestCase("abcde", "123", ExpectedResult = "abcde")]
        [TestCase("123", "abcde", ExpectedResult = "abcde")]
        [TestCase("aaaa", "bcdee", ExpectedResult = "abcde")]
        [TestCase("123abc456", "789ed", ExpectedResult = "abcde")]
        public string Concate_Positive(string firstString, string secondString)
        {
            return StringOperations.Concate(firstString, secondString);
        }

        [TestCase(null, "abcde")]
        [TestCase("edcba", null)]
        [TestCase(null, null)]
        public void Concate_ThrowsNullReferenceException(string firstString, string secondString)
        {
            Assert.Throws<NullReferenceException>(() => StringOperations.Concate(firstString, secondString));
        }

        [TestCase("", "abcde")]
        [TestCase("edcba", "")]
        [TestCase("", "")]
        public void Concate_ArgumentException(string firstString, string secondString)
        {
            Assert.Throws<ArgumentException>(() => StringOperations.Concate(firstString, secondString));
        }
    }

    /// <summary>
    /// Task1 Tests
    /// </summary>
    [TestFixture]
    public class IndexSearchTests
    {
        [TestCase(new int[] { 1, 2, 3, 4, 3, 2, 1 }, ExpectedResult = 3)]
        [TestCase(new int[] { 1, 100, 50, -51, 1, 1 }, ExpectedResult = 1)]
        [TestCase(new int[] { 1, 4, 5 }, ExpectedResult = -1)]
        public int FindIndex_Positive(int[] array)
        {
            return IndexSearch.FindIndex(array);
        }

        [TestCase(null)]
        public void FindIndex_NullReferenceExeption(int[] array)
        {
            Assert.Throws<NullReferenceException>(() => IndexSearch.FindIndex(array));
        }

        [TestCase]
        public void FindIndex_ArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => IndexSearch.FindIndex(new int[1000]));
        }
    }
}
