using System;
using System.Collections.Generic;

class Matrix
{
	public static int[,] Square(int[,] myMatrix)
	{
		int height =myMatrix.GetLength(0);
		int width = myMatrix.GetLength(1);
		int[,] MultArray = new int[height, width];
		for(int i = 0; i < height; i++)
		{
			for(int j = 0; j < width; j++)
			{
				MultArray[i, j] = myMatrix[i, j] * myMatrix[i, j];
			}
		}
		return MultArray;
	}
}
