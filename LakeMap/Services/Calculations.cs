using System;
using System.Collections.Generic;
using System.Linq;

namespace LakeMap.Services
{
	public static class Calculations
	{
		public static int CalculateLakeArea(char[][] matrix)
		{
			if (!matrix.All(e => e.Length == matrix.Length))
			{
				throw new FormatException("Please provide a squere map");
			}

			int lakes = 0;
			int lakeArea = 0;

			for (int i = 0; i < matrix.Length; i++)
			{
				for (int j = 0; j < matrix[i].Length; j++)
				{
					if (matrix[i][j] == 'O')
					{
						bool endOfLake = true;
						lakeArea++;

						//Checks if bottom node is wather
						if (i < matrix[i].Length - 1 && matrix[i + 1][j] == 'O') { endOfLake = false; }

						//Checks if right node is wather
						if (j < matrix[j].Length - 1 && matrix[i][j + 1] == 'O') { endOfLake = false; }

						//Checks if top node is wather
						if (i > 0 && matrix[i - 1][j] == 'O') { endOfLake = false; }

						//Checks if left node is wather
						if (j > 0 && matrix[i][j - 1] == 'O') { endOfLake = false; }

						//Determines if is the end of the lake in the last line
						if ((i == matrix.Length - 1 && j < matrix[j].Length - 1 && matrix[matrix.Length - 1][j + 1] != 'O') ||
							(i == matrix.Length - 1 && j == matrix[j].Length - 1 && matrix[matrix.Length - 1][j] == 'O'))
						{
							endOfLake = true;
						}

						if (endOfLake)
						{
							lakes++;
							if (lakes > 1) { throw new ArgumentException("Is only possible to have one lake in the map"); }
						}
					}
				}
			}
			return lakeArea;
		}
	}
}
