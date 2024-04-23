using PersonLibrary;
using System;

namespace OOP1
{
    /// <summary>
    /// Основной класс программы.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        private static void Main()
        {
            // 5.a. Создание списка PersonList, состоящего из рандомного кол-ва
            // взрослых и детей
            PersonList personList = new PersonList();
            Console.WriteLine("Рандомный список взрослых и детей:\n");
            
            Random random = new Random();
            
            int numAdults = random.Next(6, 10);
            int numChildren = random.Next(6, 10);

            for (int i = 0; i < numAdults; i++)
            {
                personList.AddPerson(PersonGenerate.GetRandomAdult());
            }

            for (int i = 0; i < numChildren; i++)
            {
                personList.AddPerson(PersonGenerate.GetRandomChild());
            }
            
            Console.WriteLine(personList.GetInfo());
        }
    }
}