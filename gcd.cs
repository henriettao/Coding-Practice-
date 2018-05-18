
// practice question from Amazon Demo questions
using System; 
using System.Collections.Generic;


public class GCD 
{        
    // METHOD SIGNATURE BEGINS, THIS METHOD IS REQUIRED
    public static int generalizedGCD(int num, int[] arr)
    {
        int gcd =0; 
        
        if (num ==1)
        {
            gcd = arr[0]; 
        }
        
       int gcd_min = arr[0];
       for (int i = 0; i<arr.Length; i++)  // for loop worst time complexity O(n) space complexity is O(1)
       {
           if(arr[i]< gcd_min)
           {
               gcd_min = arr[i];
           }
       }
        gcd= gcd_min; 
        
        for (int i = 1; i< arr.Length; i++ ) // second for loop time complesity O(n) space complexity is O(1)
        {
            if (arr[i]%gcd!=0)
            {
                gcd =1; 
            }
            else if (arr[i]%gcd==0 && arr[i]> gcd)
            {
               gcd = gcd_min;
            }
        }
        return gcd; 
        // Overall time complexity of function is O(n)
    }
   // test method for generalizedGCD 
    static void Main ()
    {
        int [] test1 = new int [] {2, 4, 6, 7, 8 ,10};
        int [] test2 = new int [] {1, 2, 5, 7, 9, 11, 13, 17, 19, 23};
        int [] test3 = new int [] {5, 25, 35,45,85, 95,105, 170, 16};
        // calculates the GCD of three arrays 
        int gcd1 = generalizedGCD(test1.Length, test1);  
        int gcd2 = generalizedGCD(test2.Length, test2);  
        int gcd3 = generalizedGCD(test3.Length, test3);  
        
        
        Console.WriteLine("The GCD of first array is {0}", gcd1);
        Console.WriteLine();

        Console.WriteLine("The GCD of second array is {0}", gcd2);
        Console.WriteLine();

        Console.WriteLine("The GCD of third array is {0}",  gcd3);
    
    }
  }


