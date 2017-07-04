using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice._30DaysOfCode.Day4ClassVsInstance
{
	class Person
	{
		private int age;

		public Person(int initialAge)
		{
			// Add some more code to run some checks on initialAge
			if (initialAge > 0)
			{
				age = initialAge;
			}
			else
			{
				age = 0;
				Console.WriteLine("Age is not valid, setting age to 0.");
			}
		}

		public void amIOld()
		{
			// Write code determining if this person's age is old and print the correct statement:
			if (age < 13)
			{
				Console.WriteLine("You are young.");
			}
			else if (age > 13 && age < 18)
				Console.WriteLine("You are a teenager.");
			else
				Console.WriteLine("You are old.");
		}

		public void yearPasses()
		{
			// Increment this person's age.
			age = age + 1;
		}
	}
}
