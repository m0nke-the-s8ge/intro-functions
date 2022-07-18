using System;

namespace HelloWorld
{
  class Program
  {
    static void Main()
    {
      //Declare Variables
      int userFt;
      int userin;
      
      //Assign Value
      Console.WriteLine("How many feet tall are you?");
      userFt = Int32.Parse(Console.ReadLine());
      Console.WriteLine("How many inches tall are you?");
      userin = Int32.Parse(Console.ReadLine());
      
      Console.WriteLine(" Centimeter ");
      Console.WriteLine( HeightFtintoCm (userFt, userin));
      
     
     
     
     static int HeightFtintoCm(int heightFt, int heightIn)
     { 
     
     	//Declare Varibles
        double cmPerInch;
        int inchesPerFeet;
        int totalInches;
        double heightCm;
        
        //Assign Value
        cmPerInch = 2.54;
        inchesPerFeet = 12;
        totalInches = (heightFt * inchesPerFeet) + heightIn;
        heightCm = totalInches * cmPerInch;
        
        return (int) heightCm;
        
      } 
    }
  }
}