using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsOverloads
{
	internal class Program
	{
		static void Main(string[] args)
		{
			PersonModel person = new PersonModel
			{
				FirstName = "What is your first name: ".RequestString(),
				LastName = "What is your last name: ".RequestString(),
				Age = "What is your age: ".RequestInt(1, 120),
				Salary = "What is your salary: ".RequestDecimal()
			};

			_ = person.PrintInfo();

			_ = Console.ReadLine();
		}
	}
}
