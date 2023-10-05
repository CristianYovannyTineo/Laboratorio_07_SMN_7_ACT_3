// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int Actualidad = DateTime.Now.Year; //DateTime = Hora Local de la Actualidad
        int Inicio = 1900;

        Console.WriteLine("Años bisiestos desde 1900 hasta el año {0}:", Actualidad); //Resultado tabulado
        Console.WriteLine("============================================");
        Console.WriteLine(" Año ");
        Console.WriteLine("=====");
        for (int Año = Inicio; Año <= Actualidad; Año++)
        {
            if (EsBisiesto(Año))
            {
                Console.WriteLine(Año);
            }
        }Console.WriteLine("=====");
        Console.ReadLine();
    }
    static bool EsBisiesto(int Año)
    {
        if ((Año % 4 == 0 && Año % 100 != 0) || (Año % 400 == 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
