using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
     //Declare Variable
     double piVal;
     double pizzaDiameter;
     double pizzaRadius;
     double pizzaArea;
     
     //Assign Value
     piVal = 3.14159265;
     pizzaDiameter = 12.0;   
     pizzaRadius = pizzaDiameter/2.0;
     pizzaArea = piVal * pizzaRadius * pizzaRadius;

      Console.WriteLine(pizzaDiameter);

      Console.WriteLine("in. pizza is");

      Console.WriteLine(pizzaArea);

      Console.WriteLine("sq. in.\n");
      }
  	}
}