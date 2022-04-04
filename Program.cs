using System;

namespace Stack1
{
	class Program
	{
		class Stack
		{
			private int[] st;
			private int top;
			private int max;
			public Stack(int size)
			{
				st = new int[size];
				top = -1;
				max = size;
			}

			public void push(int item)
			{
				if (top == max-1)
				{
					Console.WriteLine("Stack Overflow");
					return;
				}
				else
				{
					st[++top] = item;
				}
			}

			public int pop()
			{
				if (top == -1)
				{
					Console.WriteLine("Stack Underflow");
					return -1;
				}
				else
				{
					return st[top--];
				}
			}

			public void peek()
			{
				if (top == -1)
				{
					Console.WriteLine("Stack Underflow");
					return;
				}
				else
					Console.WriteLine(st[top]);
			}

			public void print()
			{
				if (top == -1)
				{
					Console.WriteLine("Stack is Empty");
					return;
				}
				else
				{
					for (int i = top; i >= 0; i--)
					{
						Console.WriteLine(st[i]);
					}
				}
			}
		}
		static void Main(string[] args)
		{
			Stack S = new Stack(5);

			S.push(10);
			S.push(20);
			S.push(30);
			S.push(40);
			S.push(50);

			S.print();

			S.pop();
			S.pop();
			S.pop();
			Console.WriteLine("Stack After Pop : ");
			S.print();

			Console.WriteLine("Stack Peek :");
			S.peek();
		}
	}
}
