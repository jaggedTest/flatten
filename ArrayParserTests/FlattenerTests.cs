using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArrayParserTests
{
	[TestClass]
	public class FlattenerTests
	{
		// Test array is processed correctly.
		[TestMethod]
		public void TestFlattenJaggedArraySuccess()
		{
			int[][,] jaggedArray = new int[4][,]
			{
				new int[,] { {1,3}, {5,7} },
				new int[,] { { 33 }, { 44 } },
				new int[,] { {0,2,3,6}, {4,6,7,8}, {8,10,11,12} },
				new int[,] { {11,22,33}, {99,88,77}, {0,3,9} }
			};

			int[] expected = new int[] { 1, 3, 5, 7, 33, 44, 0, 2, 3, 6, 4, 6, 7, 8, 8, 10, 11, 12, 11, 22, 33, 99, 88, 77, 0, 3, 9 };

			int[] actual = ArrayParser.Flattener.FlattenJaggedArray(jaggedArray);
			CollectionAssert.AreEqual(expected, actual, "Multi-Dimensional Array Parsed Correctly");

		}

		// Test with a single empty array.
		[TestMethod]
		public void TestFlattenJaggedArrayWithNull1()
		{ 
			int[][,] jaggedArray4 = new int[][,]
			{
				new int[,] {  },
				new int[,] { { 33 }, { 44 } },
				new	int[,] { {0,2,3,6}, {4,6,7,8}, {8,10,11,12} },
				new int[,] { {11,22,33}, {99,88,77}, {0,3,9} }
			};

			int[] expected = new int[] {  33, 44, 0, 2, 3, 6, 4, 6, 7, 8, 8, 10, 11, 12, 11, 22, 33, 99, 88, 77, 0, 3, 9 };
			int[] actual = ArrayParser.Flattener.FlattenJaggedArray(jaggedArray4);
			CollectionAssert.AreEqual(expected, actual, "Multi-Dimensional Array Parsed Correctly");
		}

		// Test with all empty arrays. 
		[TestMethod]
		public void TestFlattenJaggedArrayWithNull2()
		{
			int[][,] jaggedArray4 = new int[][,]
			{
				new int[,] { { }, { } },
				new int[,] { {}, {}, {} },
				new int[,] {  },
				new int[,] { {}, {}, {} }
			};

			int[] expected = new int[] {  };
			int[] actual = ArrayParser.Flattener.FlattenJaggedArray(jaggedArray4);
			CollectionAssert.AreEqual(expected, actual, "Multi-Dimensional Array Parsed Correctly");
		}

	}
}
