using System;

class Program
{
	static void Main(string[] args)
	{
		int i = 0;
		for (; i < 99; i++)
		{
			Console.Write($"{i:d2}, ");
		}
		Console.WriteLine($"{i:d2}");
	}
}
