// OOP practice 
using System; 
using System.Collections.Generic;

public class Node
{
  public object data;
  public Node next;


  public Node (object data)
    {
      this.data = data;
      this.next = null;
    } 
}

public class LinkedList  
{     
    public Node head;

    public void Print()
    {
      Node current = head; 

      while(current!= null)
      {
        Console.WriteLine(current.data);
        current= current.next;
      }
    }

    public void Append(object data)
    {
      if(head == null)
      {
        head = new Node(data);
        head.next = null;

      }
      else
      {
        Node toAdd = new Node(data);
        toAdd.data= data; 

        Node current = head;

        while (current.next!= null)
        {
          current= current.next; 
        }

        current.next = toAdd; 
     }

    }
  // adding to the start of the list
  public bool IsEmpty()
  {
    return head == null;
  } 
    public void Prepend(object data)
    {
      if (head == null)
      {
        head.data =data;
        head.next = null;
        return;
      }

      Node temp = new Node(data);
      temp.next = head; 
      head = temp;

    }
    public void Delete (object data)
    {
      if (head == null)
      {
        return;
      }

      if (head.data == data)
      {
        head = head.next;
      }

      Node current = head; 
      while (current.next!= null)
      {
        if (current.next.data == data)
        {
          current.next = current.next.next;
        }
        current= current.next;
      }

    }

    public int CountNodes()
    {
      int count =0; 
      Node current = head; 

      while(current!= null)
      {
        current = current.next;
        count++;
      }
      return count;
    }
    
  }
  

  class Program 
  {
    static void Main()
    {
      LinkedList myList = new LinkedList();
    

      myList.Append(1);
      myList.Append(17);
      myList.Append(18);
      
      myList.Prepend(2);
      myList.Prepend(34);
      myList.Append(35);
      myList.Delete(35);

      
      int count = myList.CountNodes();
      Console.WriteLine("Number of elements in the linked list is  {0}", count);
      myList.Print();

    }
  }
   
