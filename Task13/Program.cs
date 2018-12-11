using System;

namespace Task13
{
	class Program
	{
		static void Main(string[] args)

		{
			Console.WriteLine("Въведете положително седемцифрено число!");

			int a = int.Parse(Console.ReadLine());

			if(a<1000000||a>9999999)
			{
				Console.WriteLine("Въведеното число не е положително или не е седемцифрено!");
			}
			else
			{
				int[] k = new int[a];
				Random randomDigit = new Random();
				int p = randomDigit.Next(1, 7);


				Console.WriteLine("Изведена произволна цифра:" + p);


			}
			
			
			


		}
	}
}
