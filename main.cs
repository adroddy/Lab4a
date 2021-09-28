using System;

class Program {
  public static void Main (string[] args) {
    

    double counter = 0;
    double total = 0;

    while(counter < 7)
    {

      Console.WriteLine("Enter the distance covered by int car");
      double distance = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine(distance);
      
      Console.WriteLine("Enter the time taken by int car");
      double time = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine(time);

      double speed = (distance/time);

      Console.WriteLine("The speed of this car is {0} miles per hour", (distance / time));

      
      total = total + speed;
      counter++;
    }

    double average = total / 7;
    
    Console.WriteLine("Average = " + average);
  }
}