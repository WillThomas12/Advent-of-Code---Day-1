using System;

class Program {
  public static void Main (string[] args) {
    string [] list = System.IO.File.ReadAllLines(@"Calories.txt");
    int Highest = 0;
    int Second = 0;
    int Third = 0;
    int temp = 0;
    int Total = 0;
    foreach(string i in list)
    {
      if (i != "")
      {
        temp+=Convert.ToInt32(i);
      }
      else
      {
        temp = 0;
      }
      if(temp > Highest)
      {
        Third = Second;
        Second = Highest;
        Highest = temp;
      }
      else if (temp > Second)
      {
        Third = Second;
        Second = temp;
      }
      
      else if (temp > Third)
      {
        Third = temp;
      }
    }
    Total = Highest + Second + Third;
    Console.WriteLine(Total);
  }
}