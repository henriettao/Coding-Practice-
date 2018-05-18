using System; 
using System.Collections.Generic;

public static class Queue 
{
	// Queue is first in first out FIFO 
	private static class Node
	{
		private int data; 
		private Node next; 
		private Node (int data)
		{
			this.data= data;
		}

		private head; // delete from here 
		private tail; //insert from here 

		public bool IsEmpty()
		{
			return head == null;
		}

		public int Peek()
		{
			if (head == null)
			{
				throw new System.ArgumentException("The Queue is empty");
			}
			return head.data;
		}

		public void Add(int data)
		{
			// add to the tail
			Node node = new Node(data)
			if (tail! = null)
			{
				tail.next = node 
			}
			tail= node;

			if (head== null)
			{
				head= node;
			}

		}

		public int remove ()
		{
			int data = head.data; 
			head = head.next; 
			if (head == null)
			{
				tail = null; 
			} 
			return data;
		}

	}
}
