using System;
using System.Collections;
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
		public static string FormatTestErrorMessage<T>(int testNumber, T expected, T actual)
		{
			string expectedString, actualString;

			expectedString = formatObject(expected);
			actualString = formatObject(actual);

			return $"-----\nTest {testNumber} Failed\nExpected: {expectedString}\nActual: {actualString}\n-----";
		}

		/// <summary>
		/// Formats an object based on its type, handling arrays, lists, and other types.
		/// </summary>
		/// <param name="obj">The object to format.</param>
		/// <returns>A string representation of the object.</returns>
		private static string formatObject<T>(T obj)
		{
			if (obj == null)
			{
				return "null";
			}

			Type type = obj.GetType();

			if (type.IsArray)
			{
				Type elementType = type.GetElementType();
				if (elementType == typeof(int))
				{
					var array = obj as int[];
					return "[" + string.Join(", ", array) + "]";
				}
			}
			else if (obj is IEnumerable)
			{
				// recursively format elements of nested collections
				var sb = new StringBuilder();
				sb.Append("[");
				foreach (var item in obj as IEnumerable)
				{
					sb.Append(formatObject(item));
					sb.Append(", ");
				}
				if (sb.Length > 1)
					sb.Remove(sb.Length - 2, 2); // Cuts the last comma and space
				sb.Append("]");
				return sb.ToString();
			}

			return obj.ToString();
		}
	}
}
