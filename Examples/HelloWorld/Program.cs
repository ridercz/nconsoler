using System;
using NConsoler;

internal class Program
{
    private static void Main(string[] args) => Consolery.Run(typeof(Program), args);

    [Action]
    public static void ShowMessage(string message) => Console.WriteLine(message);
}
