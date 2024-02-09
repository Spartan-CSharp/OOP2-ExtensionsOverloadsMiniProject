using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsOverloads
{
	public static class ConsoleHelper
	{
		public static PersonModel PrintInfo(this PersonModel per)
		{
			Console.WriteLine($"{per.FirstName} {per.LastName} is {per.Age} years old and earns ${per.Salary}.");
			return per;
		}

		public static string RequestString(this string message)
		{
			string output = "";

			while ( string.IsNullOrWhiteSpace(output) )
			{
				Console.Write(message);
				output = Console.ReadLine();
			}

			return output;
		}

		public static int RequestInt(this string message)
		{
			return message.RequestInt(false);
		}

		public static int RequestInt(this string message, int minValue, int maxValue)
		{
			return message.RequestInt(true, minValue, maxValue);
		}

		private static int RequestInt(this string message, bool bounded, int minVal = 0, int maxVal = 0)
		{
			int output = 0;
			bool isvalidint = false;
			bool isinrange = true;

			while ( !isvalidint || !isinrange )
			{
				Console.Write(message);
				isvalidint = int.TryParse(Console.ReadLine(), out output);

				if ( bounded )
				{
					isinrange = output >= minVal && output <= maxVal;
				}
			}

			return output;
		}

		public static decimal RequestDecimal(this string message)
		{
			return message.RequestDecimal(false);
		}

		public static decimal RequestDecimal(this string message, decimal minValue, decimal maxValue)
		{
			return message.RequestDecimal(true, minValue, maxValue);
		}

		private static decimal RequestDecimal(this string message, bool bounded, decimal minVal = 0.00M, decimal maxVal = 0.00M)
		{
			decimal output = 0.00M;
			bool isvaliddecimal = false;
			bool isinrange = true;

			while ( !isvaliddecimal || !isinrange )
			{
				Console.Write(message);
				isvaliddecimal = decimal.TryParse(Console.ReadLine(), out output);

				if ( bounded )
				{
					isinrange = output >= minVal && output <= maxVal;
				}
			}

			return output;
		}
	}
}
