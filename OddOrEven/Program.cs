using System;
using System.Transactions;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsOdd(5));
            
        }
         public static bool IsOdd(int x)
        { 
          
                if(x%2 != 0)
            {
                Console.WriteLine(true);
                return true;
            }
            else
            {
                Console.WriteLine(false);
                return false;
            }
        }

        //accepts an integer as a parameter and determines if that integer is odd.
       
            

        
        
        
        
        
    }
}
