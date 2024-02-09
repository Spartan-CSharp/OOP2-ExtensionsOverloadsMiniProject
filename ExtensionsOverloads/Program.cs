using System;

namespace ExtensionsOverloads
{
	internal class Program
	{
		private static void Main()
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
