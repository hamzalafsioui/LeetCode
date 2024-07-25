using System;

namespace Reverse_Integer
{
	internal class Program
	{


		static public int Reverse(int x)
		{
			int numberReverse = 0;

			while (x != 0)
			{
				int temp = x % 10;
				x /= 10;

				if (numberReverse > (int.MaxValue / 10) || (numberReverse == (int.MaxValue / 10) && temp > 7)) // int.Max = 2147483647
				{
					return 0;
				}
				if (numberReverse < (int.MinValue / 10) || (numberReverse == (int.MinValue / 10) && temp < -8)) // int.Min = 2147483648
				{
					return 0;
				}

				numberReverse = numberReverse * 10 + temp;
			}

			return numberReverse;
		}


		static void Main(string[] args)
		{
			int Number1 = Reverse(-2147483412);
			int Number2 = Reverse(-24);
			int Number3 = Reverse(627);
			Console.WriteLine(Number1);
			Console.WriteLine(Number2);
			Console.WriteLine(Number3);

			Console.ReadLine();
		}
	}
}
