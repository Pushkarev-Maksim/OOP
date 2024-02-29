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
            
            bool x = true;

            while (x)
            {
                try
                {
                    Console.Write("Имя: ");
                    person.Name = Console.ReadLine();
                    x = false;
                }
                catch (ArgumentException ex)
                {
                    x = true;
                    Console.WriteLine(ex.Message);
                }
            }

            while (x)
            {
                try
                {
                    Console.Write("Фамилия: ");
                    person.Surname = Console.ReadLine();
                    x = false;
                }
                catch (Exception ex)
                {
                    x = true;
                    Console.WriteLine(ex.Message);
                }
            }

            while (x)
            {
                try
                {
                    Console.Write("Возраст: ");
                    person.Age = Convert.ToInt32(Console.ReadLine());
                    x = false;
                }
                catch (ArgumentException ex)
                {
                    x = true;
                    Console.WriteLine(ex.Message);
                }
            }

            Console.Write("Пол: 0 - мужской, 1 - женский\n");
            int gender1 = Convert.ToInt32(Console.ReadLine());
            Gender gender = (Gender)gender1;

            return person;
        }
    }
}
