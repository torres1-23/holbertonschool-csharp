using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
		string msg = "";
        int number = rndm.Next(-10, 10);
		if (number > 0)
		{
			msg = "is positive";
		}
		else if (number < 0)
		{
			msg = "is negative";
		}
		else if (number == 0)
		{
			msg = "is negative";
		}
		Console.WriteLine($"{number} {msg}");
    }
}
