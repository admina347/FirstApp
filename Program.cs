using System;

class MainClass
{
	public static void Main(string[] args)
	{
		(string name, int age) anketa;
		Console.Write("Введите имя: ");
		anketa.name = Console.ReadLine();
		Console.Write("Введите возраст: ");
		anketa.age = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Your name is {0} and age is {1} ", anketa.name, anketa.age);

		Console.ReadKey();
	}
}