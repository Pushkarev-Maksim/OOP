using PersonLibrary;
using System;

namespace OOP1
{
    // TODO: XML +

    /// <summary>
    /// Класс ConsoleInputPerson.
    /// </summary>
    public class ConsoleInputPerson
    {
        /// <summary>
        /// Чтение персоны с клавиатуры.
        /// </summary>
        /// <returns>Объект класса Person.</returns>
        public static Person ReadPersonFromConsole()
        {
            Console.WriteLine("Введите данные о персоне:");

            Person person = new Person();

            // TODO: duplication
            bool nameIncorrect = true;
            do
            {
                try
                {
                    Console.Write("Имя: ");
                    person.Name = Console.ReadLine();
                    nameIncorrect = false;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (nameIncorrect);

            // TODO: duplication
            bool surnameIncorrect = true;
            do
            {
                try
                {
                    Console.Write("Фамилия: ");
                    person.Surname = Console.ReadLine();
                    surnameIncorrect = false;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (surnameIncorrect);

            // TODO: duplication
            bool ageIncorrect = true;
            do
            {
                try
                {
                    Console.Write("Возраст: ");
                    person.Age = Convert.ToInt32(Console.ReadLine());
                    ageIncorrect = false;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Возраст - это число=)");
                }
            }
            while (ageIncorrect);

            // TODO: duplication
            bool genderIncorrect = true;
            do
            {
                try
                {
                    Console.Write("Пол: 0, 'м' или 'M' для Мужского; " +
                        "1, 'ж' или 'F' для Женского\n");
                    string genderConsole = Console.ReadLine().ToLower();

                    switch (genderConsole)
                    {
                        case "0":
                        case "м":
                        case "m":
                            person.Gender = Gender.Male;
                            break;
                        case "1":
                        case "ж":
                        case "f":
                            person.Gender = Gender.Female;
                            break;
                        default:
                            throw new Exception();
                    }

                    genderIncorrect = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Некорректный ввод пола.");
                }
            }
            while (genderIncorrect);

            return person;
        }
    }
}