using System; 
using System.Collections.Generic;

public class Stack 
{
	private static class Node
	{
		// Stack is FIrst in Last out FILO or Last in First Out LIFO  
		private int data; 
		private Node next; 
		private Node(int data)
		{
			this.data = data; 
		}
		private Node top; 
		private bool IsEmpty()
		{
			return top==null;
		}
		public int Peek ()
		{
			return top.data;
		}

		public void Push (int data)
		{
			if (top == null)
			{
				throw new System.ArgumentException("The Stack is Empty"); 
			}
			Node node = new Node(data);
			node. next = top; 
			top = node; 
			
		}
		public int Pop()
		{
			if (top == null)
			{
				throw new System.ArgumentException("The Stack is Empty"); 
			}
			int data = top.data; 
			top= top.next;

			return data;
		}
	}
}