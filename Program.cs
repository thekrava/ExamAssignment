using System;

namespace ProgrammingAssignment1
{
	class Program
	{
		static void Main()
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.Title = "ProgrammingAssignment1";
			Console.WriteLine("Для перевірки класів використовуватимемо довільні цілі числа.");
			Console.WriteLine();
			Random random = new Random();

			Console.WriteLine("Перевіряємо клас BiIndex...");
			BiIndex<int> biIndex = new BiIndex<int>();
			biIndex[0] = random.Next();
			biIndex[1] = random.Next();
			try
			{
				for (int j = 0; j < 9999; j++)
				{
					Console.Write($"biIndex[{j}] = ");
					int a = biIndex[j];
					Console.WriteLine(a);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
			Console.WriteLine();

			Console.WriteLine("Перевіряємо клас DateOb...");
			DateOb dateOb = new DateOb(DateTime.Now); 
			int i = random.Next(-99_999, 100_000);
			Console.WriteLine($"Зараз {dateOb.Date:D}, i = {i}. i-тий день відносно цієї дати: {dateOb[i]:D}");
			Console.WriteLine();

			Console.WriteLine("А на цьому все! ProtectedArray та ProtectedCharArray у цій програмі не будуть розглядатися, бо їхній принцип роботи здається досить зрозумілим.");
			Console.WriteLine("Натисніть будь-яку клавішу, щоб продовжити...");

			while (Console.KeyAvailable)
			{
				Console.ReadKey(true);
			}
			Console.ReadKey(true);
		}
	}
}
