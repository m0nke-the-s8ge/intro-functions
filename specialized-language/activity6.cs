using System;

namespace HelloWorld
{
  class Program
  {
    static void Main()
    {
     //Declare Variables
     double pizzaDiameter;
     
     //Assign Value
     pizzaDiameter = Int32.Parse(Console.ReadLine());
    
     Console.WriteLine(pizzaDiameter);
     Console.WriteLine(" inch pizza has ");
     Console.WriteLine(PizzaCalories(pizzaDiameter));
     Console.WriteLine(" calories .\n ");
    }
     
    static double PizzaCalories(double pizzaDiameter)
    {
     
     //Declare Variables
     double caloriesPerSquareInch;
     double totalCalories;
     
     //Assign Value
     caloriesPerSquareInch = 16.7;
     totalCalories = CircleArea(pizzaDiameter) * caloriesPerSquareInch;
     
     return totalCalories;
    }
    
    
    static double CircleArea(double circleDiameter)
    {
    
    //Declare Variable
    double circleRadius;
    double piVal;
    double circleArea;
    
    //Assign Values
    piVal = 3.14159265;
    circleRadius = circleDiameter / 2.0;
    circleArea = piVal * circleRadius * circleRadius;
    
    return circleArea;
     }
  }
}