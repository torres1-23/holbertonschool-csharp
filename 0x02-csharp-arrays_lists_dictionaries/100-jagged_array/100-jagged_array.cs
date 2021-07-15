using System;

class Program
{
	static void Main(string[] args)
	{
		int [][] jagger = new int[][]
        {
            new int[] {0, 1, 2, 3},
            new int[] {0, 1, 2, 3, 4, 5, 6},
            new int[] {0,1}
        };
        for (int i = 0; i < jagger.Length; i++)
        {
            for (int j = 0; j < jagger[i].Length - 1; j++)
            {
                Console.Write($"{jagger[i][j]} ");
            }
            Console.WriteLine(jagger[i][jagger[i].Length - 1]);
        }
	}
}
