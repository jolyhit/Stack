using System;
namespace ConsoleApp2
{
	class Stack<T>
	{
		private Node<T> head;
		private Node<T> prev;
		private Node<T> stack;
		public int count = -1;
		private static Node<T> delEl;
		public int Size { get; set; }
		public Node<T> GetLast()
		{
			Node<T> current = stack;
			while (current.next != null)
				current = current.next;
			return current;
		}
		public void Push(T num)
		{
			Node<T> el = new Node<T>(num);
			if (stack != null)
			{
				count++;
				GetLast().next = el;
				GetLast().prev = prev;
				prev = GetLast();
				return;
			}
			stack = el;
			head = stack;
			prev = stack;
		}
		public void Print()
		{
			Node<T> Head = head;
			while (Head != null)
			{
				Console.Write(Head.value + "   ");
				Head = Head.next;	
			}
			Console.WriteLine();
		}
		public Node<T> Pop()
		{
			GetLast().prev.next = null;
			delEl = GetLast();
			return delEl;
		}
		public bool IsEmpty()
		{
			bool isEmpty = true;
			if (count > 0)
				isEmpty = false;
			return isEmpty;
		}
		public T Top()
		{
			Node<T> current = stack;
			T Value;
			while (current.next != null)
				current = current.next;
			Value = current.value;
			return Value;
		}
	}
}
