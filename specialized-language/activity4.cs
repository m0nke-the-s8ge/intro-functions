using System;

namespace MyApplication
{
  class Program
  {
    static void Main()
    {
        //Declare Variable
        int squaredVal;
      
      squaredVal = Computesquare(7);
      Console.WriteLine(squaredVal);
    }
     
     
     
     
     static int Computesquare(int numToSquare)
     {
        //Declare Varible
        int numSquared;

        numSquared = numToSquare * numToSquare;
     	
       return numSquared;

     }
     
    }
  }