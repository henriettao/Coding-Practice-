
// OOP practice 
using System; 
using System.Collections.Generic;

public class LinkedList
{
    public class Node  
    {    
      int data;
      Node next;

      Node (int data)
      {
        this.data = data;
      } 
      Node head;
      pubic void Append(int data)
      {
        if(head ==null)
        {
          head = new Node(data);
          return;
        }
        Node current = head; 
        while (current,nect!- null)
        {
          current= current.next; 
        }

        curren.next = new Node(data); 

      }
    // adding to the start of the list 
      public void Prepend(int data)
      {
        if (head == null)
        {
          head = new Node (data)
        }

        Node temp = new Node(data);
        temp.next = head; 
        head = temp;

      }

      public void Delete (int data)
      {
        if (head == null)
        {
          return;
        }

        if (head.data == data)
        {
          head = head.next;
          return
        }

        Node current = head; 
        while (current.next! =null)
        {
          if (current.next.data == data)
          {
            current.next = current.next.next;
          }
          current= current.next;
        }
      }
      static int countNodes(Node *head)
      {
        int count =0; 
        Node current = head 

        while(current.next!= null)
        {
          current = current.next;
          count++
        }
        return count;
      }
    }

  static void Main ()
  {
        
     Node head = new Node (4);
     Node nodeB= new Node (2);
     Node nodeC= new Node (3);
     Node nodeD= new Node (10);
     Node nodeE= new Node (2);

     head.next=nodeB; 
     nodeB.next=nodeC; 
     nodeC.next=nodeD; 
     nodeD.next=nodeE; 
      
  }
  
}    
   // test method for generalizedGCD 



