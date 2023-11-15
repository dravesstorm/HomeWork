namespace Task4;

internal class Program
{
	private static void Main()
	{
		int[] array = { 1, 2, 3, 4, 5, 6, 7 };
		PrintArray(array);

		IncrementCapacity(ref array);
		Console.WriteLine("Array capacity incremented");
		PrintArray(array);

		Console.Write("Enter value to insert at start of array: ");
		int value = Convert.ToInt32(Console.ReadLine());

		IncrementCapacityWithValue(ref array, value);
		Console.WriteLine("Value inserted");
		PrintArray(array);
	}

	private static void PrintArray(int[] array)
	{
		Console.Write(array[0]);

		for (int i = 1; i < array.Length; i++)
			Console.Write(", " + array[i]);

		Console.WriteLine();
	}

	private static void IncrementCapacity(ref int[] array)
	{
		int[] extendedArray = new int[array.Length + 1];

		for (int i = 0; i < array.Length; i++)
		{
			extendedArray[i] = array[i];
		}

		array = extendedArray;
	}

	private static void IncrementCapacityWithValue(ref int[] array, int value)
	{
		int[] extendedArray = new int[array.Length + 1];
		extendedArray[0] = value;
		
		for (int i = 1; i < array.Length; i++)
		{
			extendedArray[i] = array[i - 1];
		}

		array = extendedArray;
	}
}