using Model;
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

            Person person1 = new Person("Тарас", "Кузнецов", 38, Gender.Male);
            Person person2 = new Person("Зоя", "Журавлева", 16, Gender.Female);
            Person person3 = new Person("Лаврентий", "Попов", 9, Gender.Male);

            Person person4 = new Person("Яна", "Степанова", 50, Gender.Female);
            Person person5 = new Person("Ефим", "Федоров", 90, Gender.Male);
            Person person6 = new Person("Анастасия", "Лебедева", 34, Gender.Female);

            personList1.AddPerson(person1);
            personList1.AddPerson(person2);
            personList1.AddPerson(person3);

            personList2.AddPerson(person4);
            personList2.AddPerson(person5);
            personList2.AddPerson(person6);

            // 3.b Вывод содержимого каждого списка на экран
            Console.WriteLine($"Список №1: {personList1.GetInfoAPersonList()}");
            Console.WriteLine($"Список №2: {personList2.GetInfoAPersonList()}");
        }
    }
}