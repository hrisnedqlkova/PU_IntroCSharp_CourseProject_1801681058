using System;

namespace Task36e
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Въведете стойност за x:");
			int x = int.Parse(Console.ReadLine());
			Console.Write("Въведете стойност за y:");
			int y = int.Parse(Console.ReadLine());
			Console.Write("Въведете стойност за z:");
			int z = int.Parse(Console.ReadLine());

			if (x > 0 || y > 0 || z > 0) 
			{
				Console.WriteLine("Изразът (x*y*z)^3>0 е верен!");

			} 
		    else
			{
				Console.WriteLine("Изразът (x*y*z)^3>0 не е верен!");
			}
		}
	}
}
