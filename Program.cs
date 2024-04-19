using System;
class Program {
	static void Main(string[] args)
	{
		Console.WriteLine("Oficina de Github");

        Console.Write("Insira um Numero: ");
		double num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Insira um outro Numero: ");
        double num2 = Convert.ToInt32(Console.ReadLine());


        double soma = num1 + num2;

        Console.WriteLine($"A soma dos números é {soma}");

        Console.ReadKey();//oi

    }
}

