using PersonLibrary;
using System;

namespace OOP0
{
    public class ConsoleInputPerson
    {
        public static Person ReadPersonFromConsole()
        {
            Console.WriteLine("Введите данные о персоне:");
            Console.Write("Имя: ");
            string name = Console.ReadLine();

            Console.Write("Фамилия: ");
            string surname = Console.ReadLine();

            Console.Write("Возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Пол: 0 - мужской, 1 - женский\n");
            int gender1 = Convert.ToInt32(Console.ReadLine());
            Gender gender = (Gender)gender1;

            return new Person(name, surname, age, gender);
        }
    }
}
