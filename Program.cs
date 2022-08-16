using System;

class MainClass
{
	public static void Main(string[] args)
	{
		var (name, age) = ("Евгения", 27);
		Console.WriteLine("Ваше имя: {0}", name);
		Console.WriteLine("Ваш возраст: {0}", age);
		Console.Write("Введите имя: ");
		name = Console.ReadLine();
		Console.Write("Введите возраст: ");
		age = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Ваше имя: {0}", name);
		Console.WriteLine("Ваш возраст: {0}", age);

		Console.ReadKey();
	}
}