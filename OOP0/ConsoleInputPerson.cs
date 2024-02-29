using PersonLibrary;
using System;

namespace OOP0
{
    public class ConsoleInputPerson
    {
        /// <summary>
        /// Чтение персоны с клавиатуры.
        /// </summary>
        /// <returns></returns>
        public static Person ReadPersonFromConsole()
        {
            Console.WriteLine("Введите данные о персоне:");

            Person person = new Person(); 
            
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
            }
            while (ageIncorrect);

            Console.Write("Пол: 0 - мужской, 1 - женский\n");
            int genderConsole = Convert.ToInt32(Console.ReadLine());
            Gender gender = (Gender)genderConsole;

            return person;
        }
    }
}