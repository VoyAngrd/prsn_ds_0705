using System;

class MainClass
{
    public static void Main (string[] args)
    {
        Pessoa pessoa1 = new Pessoa();
        pessoa1.getInfo();

        Pessoa pessoa2 = new Pessoa();
        pessoa2.getInfo();

        Pessoa pessoa3 = new Pessoa();
        pessoa3.getInfo();
        
        pessoa1.showInfo("Pessoa 1");
        pessoa2.showInfo("Pessoa 2");
        pessoa3.showInfo("Pessoa 3");
        
        Console.ReadLine();
    }
}