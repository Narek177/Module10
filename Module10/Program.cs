using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Module10;

public class Program
{
    //  static ILogger Logger { get; set; }
    static void Main(string[] args)
    {

        Calculator calculator = new Calculator();
        while (true)
        {
            try
            {
                Console.Write("x: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("y: ");
                int y = int.Parse(Console.ReadLine());
                int result = calculator.Addition(x, y);
                var resultText = $"x + y = {result}";
                Success(resultText);
            }
            catch (Exception ex)
            {
                Error(ex);
            }

            Console.ReadKey();
        }
    }

    private static void Success(object message)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void Error(Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(ex.Message);
        Console.ForegroundColor = ConsoleColor.White;
    }

}