using System;

class Program
{
    public static void Main(string[] args)
    {
        int a = cs.get_int("digite um numero inteiro ");
        bool b = cs.get_bool("digite um valor booleano ");
        double c = cs.get_double("digite um numero real ");
        char d = cs.get_char("digite um caracter ");
        string e = cs.get_string("digite uma string ");
        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);
        Console.WriteLine("c = {0}", c);
        Console.WriteLine("d = {0}", d);
        Console.WriteLine("e = {0}", e);
    }
}

class cs
{
    public static int get_int(string prompt)
    {
        int i;
        Console.Write(prompt);
        i = int.Parse(Console.ReadLine());
        return i;
    }

    public static double get_double(string prompt)
    {
        double i;
        Console.Write(prompt);
        i = double.Parse(Console.ReadLine());
        return i;
    }

    public static string get_string(string prompt)
    {
        string i;
        Console.Write(prompt);
        i = Console.ReadLine();
        return i;
    }

    public static bool get_bool(string prompt)
    {
        bool i;
        Console.Write(prompt);
        i = bool.Parse(Console.ReadLine());
        return i;
    }

    public static char get_char(string prompt)
    {
        char i;
        Console.Write(prompt);
        i = char.Parse(Console.ReadLine());
        return i;
    }

    public static void print(string prompt)
    {
        Console.Write(prompt);
    }
}