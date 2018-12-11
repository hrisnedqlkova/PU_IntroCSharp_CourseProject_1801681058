using System;
using System.Linq;
using System.Text;

namespace Task213e
{
	class Program
		// Да се изчисли израза: страница 126 задача 213е
	{
		static void Main(string[] args)
		{

			double result = 0.0;
			Console.WriteLine(" Пресметни израза ");
			Console.WriteLine(" ");

			for (int i = 49; i >= 1; i--)
			{
				result = Math.Sqrt(i + result);
			}
			Console.WriteLine("Резултатът е = " + result);
			Console.ReadKey(true);


		}
	}
}

