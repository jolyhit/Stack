using System;
namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack<int> stack = new Stack<int>();
			stack.Push(10);
			stack.Push(11);
			stack.Push(14);
			stack.Push(16);
			stack.Push(18);
			stack.Print();
			Console.WriteLine();
			stack.Pop();
			stack.Pop();
			stack.Print();
			Console.WriteLine();
			if (stack.IsEmpty() == true)
				Console.WriteLine("Стек пустой");
			else
				Console.WriteLine("Стек не пустой");
			Console.WriteLine("\nTop элемент: " + stack.Top());
			Console.ReadKey();
		}
	}
}
