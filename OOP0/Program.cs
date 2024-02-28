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
            // 3.a Создание двух списков персон по три человека
            PersonList personList1 = new PersonList();
            PersonList personList2 = new PersonList();

            Person persona1 = new Person("Тарас", "Кузнецов", 38, Gender.Male);
            Person persona2 = new Person("Зоя", "Журавлева", 16, Gender.Female);
            Person persona3 = new Person("Лаврентий", "Попов", 9, Gender.Male);

            Person persona4 = new Person("Яна", "Степанова", 50, Gender.Female);
            Person persona5 = new Person("Ефим", "Федоров", 90, Gender.Male);
            Person persona6 = new Person("Анастасия", "Лебедева", 34, Gender.Female);

            personList1.AddPerson(persona1);
            personList1.AddPerson(persona2);
            personList1.AddPerson(persona3);

            personList2.AddPerson(persona4);
            personList2.AddPerson(persona5);
            personList2.AddPerson(persona6);

            // 3.b Вывод содержимого каждого списка на экран
            Console.WriteLine($"Список №1:\n{personList1.GetInfoAPersonList()}");
            Console.WriteLine($"Список №2:\n{personList2.GetInfoAPersonList()}");

            // 3.c Добавление нового человека в первый список
            Person persona7 = new Person("Василий", "Пупкин", 25, Gender.Male);
            personList1.AddPerson(persona7);
            Console.WriteLine($"Список №1 после добавления нового человека:" +
                $"\n{personList1.GetInfoAPersonList()}");

            // 3.d Копирование второго человека из первого списка в конец второго
            Person a = personList1.GetPersonAtIndex(1);
            Console.WriteLine(a);
        }
    }
}