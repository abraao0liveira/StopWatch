using System.ComponentModel.Design;
using System.Data;
using System.Runtime.CompilerServices;

namespace StopWatch
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();

      Console.WriteLine("S = Seconds => 10s = 10 seconds\nM = Minutes => 1m = 1 minute\n0 = Exist");
      Console.WriteLine("How long do you want to count?");

      string data = (Console.ReadLine() ?? "").ToLower();
      char type = char.Parse(data.Substring(data.Length - 1, 1)); // Pega o último caractere da string
      int time = int.Parse(data.Substring(0, data.Length - 1)); // Pega todos os caracteres menos o último

      int multiplier = 1;

      if (type == 'm')
      {
        multiplier = 60;
      }
      else if (time == 0)
      {
        Environment.Exit(0);
      }
      else
      {
        PreStart(time * multiplier);
      }
    }

    static void PreStart(int time)
    {
      Console.Clear();
      Console.WriteLine("Ready...");
      Thread.Sleep(1000);
      Console.WriteLine("Set...");
      Thread.Sleep(1000);
      Console.WriteLine("Go!");
      Thread.Sleep(2500);

      Start(time);
    }

    static void Start(int time)
    {
      int currentTime = 0;

      while (currentTime != time)
      {
        Console.Clear();

        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
      }

      Console.Clear();
      Console.WriteLine("Time's up!");
      Thread.Sleep(1000);
      Menu();
    }
  }
}