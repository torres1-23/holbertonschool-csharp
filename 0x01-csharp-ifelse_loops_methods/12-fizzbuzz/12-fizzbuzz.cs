﻿using System;

class Program
{
	static void Main(string[] args)
	{
		int i = 1;
		for (; i < 100; i++)
		{
			if (i % 3 == 0 && i % 5 == 0)
			{
				Console.Write("FizzBuzz ");
			}
			else if (i % 3 == 0)
			{
				Console.Write("Fizz ");
			}
			else if (i % 5 == 0)
			{
				Console.Write("Buzz ");
			}
			else
			{
				Console.Write($"{i} ");
			}
		}
		Console.WriteLine("Buzz");
	}
}
