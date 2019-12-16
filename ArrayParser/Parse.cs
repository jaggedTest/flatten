using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayParser
{
	/// <summary>
	/// ArrayParser - Parses .NET Arrays, flattening them out into a single dimension array.
	/// </summary>
    public static class Flattener
    {
		/// <summary>
		/// Parses 3 dimensional jagged arrays.
		/// Because .NET does not allow the type of array requested in the assignment, 
		/// I decided to parse the most difficult to parse using .NET. 
		/// Well, not exactly that difficult.
		/// All members of jaggedArray must be arrays, but can be arrays of any size.
		/// </summary>
		/// <param name="jaggedArray"></param>
		/// <returns></returns>
        public static int[] FlattenJaggedArray(int[][,] jaggedArray)
        {
			// Adding items to a list for simplicity sake.
			// This could be optimized to use a StringBuilder or Array or other to optimize it.
			// If optimizing, I would run the same test using large amounts of data/calls to generate data 
			// on which to base a decision on how best to optimize.
			List<int> l = new List<int>();

			// Travese outer array.
			for (int x = 0; x <= jaggedArray.GetUpperBound(0); x++)
			{
				// Traverse "X" axis of inner array.
				for (int ix = 0; ix <= jaggedArray[x].GetUpperBound(0); ix++)
				{
					// Traverse "Y" axis of inner array.
					for (int iy = 0; iy <= jaggedArray[x].GetUpperBound(1); iy++)
					{
						l.Add(jaggedArray[x][ix, iy]);
					}
				}
			}
			// Simply execute ToArray() to convert the list to an array.
			return l.ToArray();
        }

    }
}
