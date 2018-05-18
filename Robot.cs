
// OOP practice 
using System; 
using System.Collections.Generic;


public class Robot 
{    
  string name; 
  string color; 
  int weight;

   Robot(string name, string color, int weight)
   {
    this.name= name;
    this.color = color; 
    this.weight= weight; 
   }
   
    void IntroduceSelf()
    {
      Console.WriteLine("My name is {0}", name);
    }
   // test method for generalizedGCD 
    static void Main ()
    {
        
      Robot r1 = new Robot("Tom", "Red", 30);
      Robot r2 = new Robot("Jerry", "Blue", 40);

      r1.IntroduceSelf();
      r2.IntroduceSelf();
    
    }
  }


