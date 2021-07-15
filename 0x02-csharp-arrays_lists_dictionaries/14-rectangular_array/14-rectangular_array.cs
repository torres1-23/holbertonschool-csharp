using System;

class Program
{
	static void Main(string[] args)
	{
		int[,] MultiArray = new int[5,5];
        MultiArray[2, 2] = 1;
		for(int i = 0; i < MultiArray.GetLength(0); i++)
		{
			for(int j = 0; j <  MultiArray.GetLength(1) - 1; j++)
			{
				Console.Write($"{MultiArray[i, j]} ");
			}
			Console.WriteLine($"{MultiArray[MultiArray.GetLength(0) - 1, MultiArray.GetLength(1) - 1]}");
		}
	}
}
