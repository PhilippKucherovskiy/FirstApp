using System;

class MainClass
{
	public static void Main(string[] args)
	{

		Console.Write("Здравствуйте. Давайте найдем Вам пару по Знаку Зодиака. \nДа соединят Вас звезды!\n\n Введите Ваше имя: ");
		var name = Console.ReadLine();
		
		Console.Write("Введите Ваш возраст: ");
		var age = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("\n\nВас зовут {0}, какое красивое имя. \nИ самый хороший возраст для поиска пары, {1}. ", name, age);

		Console.Write("\nДавайте продолжим составлять идеальную анкету. \n\nКакая у Вас точная дата рождения (необходима для расчета кармического асцендента совместимости)? ");
		var birthdate = Console.ReadLine();
		Console.Write("\nВаш Знак Зодиака? ");
		var zodiac = Console.ReadLine();

		Console.WriteLine("\nТаким образом Ваша анкета выглядит так: \nИмя: \t{0} \nВозраст: \t{1} лет \nДата Вашего рождения: \t{2} \nЗнак Зодиака:\t {3}\n Удачных поисков!",name, age, birthdate, zodiac);

	}
}