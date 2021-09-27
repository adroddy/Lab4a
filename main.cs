using System;

class Program {
  public static void Main (string[] args) {
    

    int counter = 0;
    int total = 0;

    while(counter < 7)
    {

      Console.WriteLine("Enter the distance covered by int car");
      int distance = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(distance);
      
      Console.WriteLine("Enter the time taken by int car");
      int time = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(time);

      int speed = (distance/time);

      Console.WriteLine("The speed of this car is {0} miles per hour", (distance / time));

      
      total = total + speed;
      counter++;
    }

    double average = total / 7;
    
    Console.WriteLine("Average = " + average);
  }
}