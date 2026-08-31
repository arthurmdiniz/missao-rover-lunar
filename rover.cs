using System;

class Rover
{
    static void InicializarRover()
    {
        Console.WriteLine("Sistemas do Rover iniciados!");
        Console.WriteLine("Painéis solares: OK");
        Console.WriteLine("Nível de bateria: 100%");
    }
    static void Main()
    {
        InicializarRover();
        
        Console.WriteLine("Pressione Enter para sair...");
        Console.ReadLine();
    
    }
}