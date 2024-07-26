namespace Roman_To_Integer
{
	internal class Program
	{
		static public int RomanToInt(string s)
		{
			int number = 0;
			if (s.Length > 15)
				return 0;

			for (int i = 0; i < s.Length; i++)
			{
				switch (s[i])
				{
					case 'I':
						if (i + 1 < s.Length && s[i + 1] == 'V')
						{
							number += 4;
							i++;
						}
						else if (i + 1 < s.Length && s[i + 1] == 'X')
						{
							number += 9;
							i++;
						}
						else
						{
							number++;
						}
						break;

					case 'V':
						number += 5;
						break;

					case 'X':
						if (i + 1 < s.Length && s[i + 1] == 'L')
						{
							number += 40;
							i++;
						}
						else if (i + 1 < s.Length && s[i + 1] == 'C')
						{
							number += 90;
							i++;
						}
						else
						{
							number += 10;
						}
						break;

					case 'L':
						number += 50;
						break;

					case 'C':
						if (i + 1 < s.Length && s[i + 1] == 'D')
						{
							number += 400;
							i++;
						}
						else if (i + 1 < s.Length && s[i + 1] == 'M')
						{
							number += 900;
							i++;
						}
						else
						{
							number += 100;
						}
						break;

					case 'D':
						number += 500;
						break;

					case 'M':
						number += 1000;
						break;

					default:
						return 0;
				}
			}
			return number;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(RomanToInt("III")); // Output: 3
			Console.WriteLine(RomanToInt("LVIII")); // Output: 58
			Console.WriteLine(RomanToInt("MCMXCIV")); // Output: 1994

			Console.ReadLine();
		}
	}
}
