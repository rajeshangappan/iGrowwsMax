using System;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main()
		{
			int i = 0;
			int[] j = new int[5];
			Console.WriteLine("Enter array elements : ");
			for (i = 0; i < j.Length; i++)
			{
				Console.Write("Element[" + (i + 1) + "]: ");
				j[i] = int.Parse(Console.ReadLine());
			}


			for (i = 0; i < j.Length; i++)
			{
				if (j[i] % 2 == 0)
				{
					Console.WriteLine("Even Numbers in array:");
					Console.Write(j[i] + " ");
				}

			}

		}
	}
}
	
