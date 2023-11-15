namespace Task3;

internal class Program
{
	private static void Main()
	{
		int[] array = { 1, 2, 3, 4, 5, 6, 7 };
		PrintArray(array);

		int[] reversedArray = Reverse(array);

		Console.WriteLine("Reversed array: ");
		PrintArray(reversedArray);

		Console.WriteLine("To split array enter parameters:");

		Console.Write("Index: ");
		int index = Convert.ToInt32(Console.ReadLine());

		Console.Write("Count: ");
		int count = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Sub array: ");
		PrintArray(SubArray(array, index, count));
	}

	private static int[] Reverse(int[] array)
	{
		int[] reversedArray = new int[array.Length];

		for (int i = 0; i < array.Length; i++)
		{
			reversedArray[i] = array[array.Length - i - 1];
		}

		return reversedArray;
	}
	
	private static void ReverseWithoutMemoryAllocation(int[] array)
	{
		for (int i = 0; i < array.Length / 2; i++)
		{
			int temp = array[i];
			array[i] = array[array.Length - i - 1];
			array[array.Length - i - 1] = temp;
		}
	}
	
	private static void PrintArray(int[] array)
	{
		Console.Write(array[0]);

		for (int i = 1; i < array.Length; i++)
			Console.Write(", " + array[i]);

		Console.WriteLine();
	}

	private static int[] SubArray(int[] array, int index, int count)
	{
		int[] subArray = new int[count];

		for (int i = 0; i < count; i++)
		{
			if (index < array.Length)
			{
				subArray[i] = array[index];
			}
			else
			{
				subArray[i] = 1;
			}

			index++;
		}

		return subArray;
	}
}