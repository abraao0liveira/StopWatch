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

      Console.WriteLine("S = Seconds => 10s = 10 seconds\nM = Minutes => 1m = 1 minute\nH = Hours => 1h = 1 hour\n0 = Exist");
      Console.WriteLine("How long do you want to count?");

      string data = (Console.ReadLine() ?? "").ToLower();

      if (data == "0")
      {
        Console.Clear();
        Environment.Exit(0);
      }

      char type = char.Parse(data.Substring(data.Length - 1, 1)); // Pega o último caractere da string
      int time = int.Parse(data.Substring(0, data.Length - 1)); // Pega todos os caracteres menos o último

      Console.WriteLine("Progressive or regressive time? (P/R)");
      char progress = char.Parse((Console.ReadLine() ?? "").ToLower());

      if (progress == 'p')
      {
        int multiplier = 1;
        if (type == 'm')
        {
          multiplier = 60;
        }
        else if (type == 'h')
        {
          multiplier = 3600;
        }
        else
        {
          PreStartProgressive(time * multiplier);
        }
      }
      else if (progress == 'r')
      {
        int multiplier = 1;
        if (type == 'm')
        {
          multiplier = 60;
        }
        else if (type == 'h')
        {
          multiplier = 3600;
        }
        else
        {
          PreStartRegressive(time * multiplier);
        }
      }
      else
      {
        Menu();
      }
    }

    static void PreStartProgressive(int time)
    {
      Console.Clear();
      Console.WriteLine("Ready...");
      Thread.Sleep(1000);
      Console.WriteLine("Set...");
      Thread.Sleep(1000);
      Console.WriteLine("Go!");
      Thread.Sleep(2500);

      StartProgressive(time);
    }

    static void PreStartRegressive(int time)
    {
      Console.Clear();
      Console.WriteLine("Ready...");
      Thread.Sleep(1000);
      Console.WriteLine("Set...");
      Thread.Sleep(1000);
      Console.WriteLine("Go!");
      Thread.Sleep(2500);

      StartRegressive(time);
    }

    static void StartProgressive(int time)
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

    static void StartRegressive(int time)
    {
      while (time != 0)
      {
        Console.Clear();
        Console.WriteLine(time);
        Thread.Sleep(1000);
        time--;
      }

      Console.Clear();
      Console.WriteLine("Time's up!");
      Thread.Sleep(1000);
      Menu();
    }
  }
}