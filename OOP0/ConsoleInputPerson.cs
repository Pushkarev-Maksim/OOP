using PersonLibrary;
using System;

namespace OOP1
{
    //TODO: XML
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
            
            //TODO: duplication
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

            //TODO: duplication
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

            //TODO: duplication
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

            //TODO: duplication
            Console.Write("Пол: 0 - Male, 1 - Female\n");
            int genderConsole = Convert.ToInt32(Console.ReadLine());
            person.Gender = (Gender)genderConsole;

            return person;
        }
    }
}