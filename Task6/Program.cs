namespace Task6;

internal class Program
{
	private static void Main()
	{
		int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

		Console.WriteLine("Initial array: ");
		PrintArray(array);

		Console.WriteLine("Reversed array: ");
		PrintReversedArray(array);
	}

	private static void PrintArray(int[] array)
	{
		for (int i = 0; i < array.Length; i++)
			Console.Write(array[i] + " ");

		Console.WriteLine();
	}

	private static void PrintReversedArray(int[] array)
	{
		for (int i = array.Length - 1; i >= 0; i--)
			Console.Write(array[i] + " ");
		
		Console.WriteLine();
	}
}