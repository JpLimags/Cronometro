namespace Cronometro;

public class Cronometro
{

    static void Main()
    {
        Menu();   
        //Start();
    }

    static void Menu()
    {
        
        Console.Clear();
        Console.WriteLine("S = Segundo => 10s = 10 sgundos");
        Console.WriteLine("M = Minuto => 1m = 1minuto");
        Console.WriteLine("0-Sair");
        Console.WriteLine("Quanto tempo deseja contar?");

        string data = Console.ReadLine()!.ToLower();
        char type = char.Parse(data.Substring(data.Length-1,1));
        int time = int.Parse(data.Substring(00, data.Length - 1));
        int multiplier = 1;

        if (type == 'm')
        {
            multiplier = 60;
        }

        if (time == 0)
        {
            Environment.Exit(0);
        }
        
        PreStart(time * multiplier);
 
    }

    static void PreStart(int time)
    {
        
        Console.Clear();
        Console.WriteLine("Start...");
        Thread.Sleep(1000);
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
        Console.WriteLine("Stopwatch finalizado");
        Thread.Sleep(2000);
        Menu();
    }
}