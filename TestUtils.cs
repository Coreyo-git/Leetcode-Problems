using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public static class TestUtils
    {
        /// <summary>
        /// Formats the error message for a test case by including the test name, expected result, and actual result.
        /// </summary>
        /// <param name="test">The name or description of the test case.</param>
        /// <param name="expected">The expected result of the test case.</param>
        /// <param name="actual">The actual result obtained during the test case.</param>
        /// <returns>A formatted error message that includes the test case details.</returns>
        public static string formatTestErrorMessage<T>(int testNumber, T expected, T actual)
        {
            if (typeof(T).IsArray && typeof(T).GetElementType() == typeof(int))
            {
                int[] expectedArray = (int[])(object)expected!;
                int[] actualArray = (int[])(object)actual!;

                string expectedString = "[" + string.Join(", ", expectedArray!) + "]";
                string actualString = "[" + string.Join(", ", actualArray!) + "]";

                return $"-----\nTest {testNumber.ToString()} Failed\nExpected: {expectedString}\nActual: {actualString}\n-----";
            }

            else
            {
                string expectedString = expected?.ToString() ?? "null";
                string actualString = actual?.ToString() ?? "null";

                return $"-----\nTest {testNumber.ToString()} Failed\nExpected: {expectedString}\nActual: {actualString}\n-----";
            }
        }
    }
}
