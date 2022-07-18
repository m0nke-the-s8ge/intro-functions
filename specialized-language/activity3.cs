using System;

namespace MyApplication
{
  class Program
  {
     static void Main(string[] args)
     {
        PrintPizzaVolume (12.0f, 0.3f);
      PrintPizzaVolume (12.0f, 0.8f);
      PrintPizzaVolume (16.0f, 0.8f);
    
     
    }
    static void PrintPizzaVolume(float pizzaDiameter, float pizzaHeight)
    {
     //Declare Variables
     float piVal;
     float pizzaRadius;
     float pizzaVolume;
     float pizzaArea;
     
     //Assign Values
     piVal = 3.14159265f;
     pizzaRadius = (float)(pizzaDiameter / 2.0);
     pizzaArea = (float)(piVal * pizzaRadius * pizzaRadius);
     pizzaVolume = (float)(pizzaArea * pizzaHeight);
     
     
     Console.WriteLine(pizzaDiameter);
     Console.WriteLine(" x ");
     Console.WriteLine(pizzaHeight);
     Console.WriteLine(" inch pizza is ");
     Console.WriteLine(pizzaVolume);
     Console.WriteLine(" cubic inches.\n ");
     
     
     
     
    
  }
  }
}