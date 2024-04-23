﻿using PersonLibrary;
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

            for (int i = 0; i < 7; i++)
            {
                if (random.NextDouble() < 0.5)
                {
                    personList.AddPerson(PersonGenerate.GetRandomAdult());
                }
                else
                {
                    personList.AddPerson(PersonGenerate.GetRandomChild());
                }
            }

            Console.WriteLine(personList.GetInfo());

            if (personList.GetCountPerson() > 3)
            {
                var fourthPerson = personList.GetPersonAtIndex(3);
                Console.WriteLine($"Тип четвертого человека: {fourthPerson.GetType()}");

                switch (fourthPerson)
                {
                    case Adult adult:
                        Console.WriteLine($"Четвертый взрослый: {adult.Surname} {adult.Name}");
                        Console.WriteLine(adult.GetExtraIncome());
                        break;
                    case Child child:
                        Console.WriteLine($"Четвертый ребенок: {child.Surname} {child.Name}");
                        Console.WriteLine(child.GetChewingGum());
                        break;
                }
            }
        }
    }
}