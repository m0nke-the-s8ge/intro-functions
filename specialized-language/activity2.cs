using System;

namespace MyApplication
{
    class Program
    {


        static void Main(string[] args)
        {

            //Console.WriteLine("Hellow");
            PrintPizzaArea(12.0f);
            // PrintPizzaArea(16.0);

        }


        static void  PrintPizzaArea(float pizzaDiameter)
        {

            //Declare Variables
            float piVal;
            float pizzaRadius;
            float pizzaArea;

            //Assign Values
            piVal = 3.14159265f;
            pizzaRadius = (float)(pizzaDiameter / 2.0);
            pizzaArea = (float)piVal * pizzaRadius * pizzaRadius;

            Console.WriteLine(pizzaDiameter);
            Console.WriteLine("in pizza is");
            Console.WriteLine("pizzaArea");
            Console.WriteLine("sq, in.\n");


        }








    }
}