using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
		string msg = "";
		int last = number % 10;
		if (last < 6 && last != 0)
		{
			msg = "and is less than 6 and not 0";
		}
		else if (last > 5)
		{
			msg = "and is greater than 5";
		}
		else if (last == 0)
		{
			msg = "and is 0";
		}
		Console.WriteLine($"The last digit of {number} is {last} {msg}");
    }
}
