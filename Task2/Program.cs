namespace Task2;

internal static class Program
{
	private static void Main()
	{
		int[] array = InitializeArray();

		Console.WriteLine("Array initialized.");
		PrintArray(array);

		Console.WriteLine($"Max element is: {FindMax(array)}");
		Console.WriteLine($"Min element is: {FindMin(array)}");
		Console.WriteLine($"Sum of all elements is: {Sum(array)}");
		Console.WriteLine($"Average is: {Average(array)}");
		Console.Write("Odd elements are: ");
		PrintOdds(array);

		Console.WriteLine("\nPress any key to continue...");
		Console.ReadKey();
	}

	private static int[] InitializeArray()
	{
		int arraySize;

		do
		{
			Console.WriteLine("Enter array size: ");
		} while (
			!int.TryParse(Console.ReadLine(), out arraySize)
			|| arraySize == 0);

		var array = new int[arraySize];

		var random = new Random();

		for (var i = 0; i < array.Length; i++)
			array[i] = random.Next(arraySize * 10);

		return array;
	}

	private static int FindMax(int[] array)
	{
		int maxElement = array[0];

		for (var i = 1; i < array.Length; i++)
		{
			if (array[i] > maxElement)
				maxElement = array[i];
		}

		return maxElement;
	}

	private static int FindMin(int[] array)
	{
		int minElement = array[0];

		for (var i = 1; i < array.Length; i++)
		{
			if (array[i] < minElement)
				minElement = array[i];
		}

		return minElement;
	}

	private static int Sum(int[] array)
	{
		int sum = 0;

		for (int i = 0; i < array.Length; i++)
			sum += array[i];

		return sum;
	}

	private static float Average(int[] array)
	{
		int sum = 0;

		for (int i = 0; i < array.Length; i++)
			sum += array[i];

		return sum / array.Length;
	}

	private static void PrintOdds(int[] array)
	{
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] % 2 == 1)
			{
				Console.Write(array[i] + " ");
			}
		}

		Console.WriteLine();
	}

	private static void PrintArray(int[] array)
	{
		Console.Write(array[0]);

		for (int i = 1; i < array.Length; i++)
			Console.Write(", " + array[i]);

		Console.WriteLine();
	}
}