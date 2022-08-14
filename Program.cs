using System;

class MainClass
{
    public static void Main(string[] args)
    {

		Console.Write("Введите имя: ");
		var name = Console.ReadLine();
		Console.Write("Введите возраст: ");
		var age = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Your name is {0} and age is {1} ", name, age);
		Console.Write("Введите дату рождения: ");
		var birthdate = Console.ReadLine();
		Console.WriteLine("Your birthdate is: {0}", birthdate);

		Console.WriteLine(myName);

        Console.ReadKey();
    }
}