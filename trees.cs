using System; 
using System.Collections.Generic;

public static class Node  
{
	Node right, left; 
	int data; 
	public Node (int data)
	{
		this.data = data;
	}	

	public void Insert(int value)
	{
		if (value <= data)
		{
			if (left== null)
			{
				left = new Node (value);
			}
			else // inserts recursively 
			{
				left.Insert(value);
			}
		}

		else 
		{
			if(right = mull)
			{
				right = new Node (value); 
			}
			else 
			{
				right.Insert(value);
			}
		}
	}

	public bool Contains( int value)
	{
		if (value == data)
		{
			return true; 
		}
		else if (value <= data)
		{
			if (left == null)
			{
				return false; 
			}
			else 
			{
				return left.Contains(value);
			}
		}

		else 
		{
			if (right == null)
			{
				return false; 
			}

			else 
			{
				return right.Contains(value);
			}
		}
	} 

	public void PrintInOrder()// in  order traversal
	{
		if (left!=null) // 1 - this is the left  
		{
			left.PrintInOrder();
		}
		Console.WriteLine(data); // 2m- this is the root 
		if(right!= null)
		{
			right.PrintInOrder(); // 3 - this is the right 
		}

	}

	// or pre order traversal it is 2 1 3 for post order it is 1 3 2 
}