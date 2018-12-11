using System;

namespace NumeralSystem
{
	class Program
	{
		static void Main(string[] args)
		{ //Превърни числото 2058 в двоична, осмична и шестнадесетична бройна система.
			string number = "2058";
			int value = 2058;
			string binary = Convert.ToString(value, 2);
			string binary1 = Convert.ToString(value, 8);
			string binary2 = Convert.ToString(value, 16);
			Console.WriteLine($"Числото 2058 в двоична бройна система е :{binary}");
			Console.WriteLine($"Числото 2058 в осмична бройна система е: {binary1}");
			Console.WriteLine($"Числото 2058 в шестнадесетична бройна система е: {binary2}");
		}
	}
}
