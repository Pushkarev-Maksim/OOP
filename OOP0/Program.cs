using PersonLibrary;
using System;

namespace OOP1
{
    /// <summary>
    /// Основной класс программы.
    /// </summary>
    internal class Program
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

            Console.Write("Пол: ");
            int gender1 = Convert.ToInt32(Console.ReadLine());
            Gender gender = (Gender)gender1;

            return new Person(name, surname, age, gender);
        }

        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        private static void Main()
        {
            // 3.a Создание двух списков персон по три человека
            PersonList personList1 = new PersonList();
            PersonList personList2 = new PersonList();

            Person persona1 = new Person("Тарас", "Кузнецов", 
                38, Gender.Male);
            Person persona2 = new Person("Зоя", "Журавлева", 
                16, Gender.Female);
            Person persona3 = new Person("Лаврентий", "Попов", 
                9, Gender.Male);

            Person persona4 = new Person("Яна", "Степанова", 
                50, Gender.Female);
            Person persona5 = new Person("Ефим", "Федоров", 
                90, Gender.Male);
            Person persona6 = new Person("Анастасия", "Лебедева", 
                34, Gender.Female);

            personList1.AddPerson(persona1);
            personList1.AddPerson(persona2);
            personList1.AddPerson(persona3);

            personList2.AddPerson(persona4);
            personList2.AddPerson(persona5);
            personList2.AddPerson(persona6);

            // 3.b Вывод содержимого каждого списка на экран
            Console.WriteLine($"Список №1:" +
                $"\n{personList1.GetInfoAPersonList()}");
            Console.WriteLine($"Список №2:" +
                $"\n{personList2.GetInfoAPersonList()}");
            Console.ReadKey(true);

            // 3.c Добавление нового человека в первый список
            Person persona7 = new Person("Василий", "Пупкин", 
                25, Gender.Male);
            personList1.AddPerson(persona7);
            Console.WriteLine($"В первый список добавлен новый человек.\n" +
                $"Список №1:\n{personList1.GetInfoAPersonList()}");
            Console.ReadKey(true);

            // 3.d Копирование второго человека из первого списка в конец
            // второго
            Console.WriteLine("Во второй список добавлен второй человек из" +
                " первого списка:");
            personList2.AddPerson(personList1.GetPersonAtIndex(1));
            Console.WriteLine($"Список №1:" +
                $"\n{personList1.GetInfoAPersonList()}");
            Console.WriteLine($"Список №2:" +
                $"\n{personList2.GetInfoAPersonList()}");
            Console.ReadKey(true);

            // 3.e Удаление второго человека из первого списка
            personList1.RemovePersonAtIndex(1);
            Console.WriteLine("В первом списке удален второй человек:");
            Console.WriteLine($"Список №1:" +
                $"\n{personList1.GetInfoAPersonList()}");
            Console.WriteLine($"Список №2:" +
                $"\n{personList2.GetInfoAPersonList()}");
            Console.ReadKey(true);

            // 3.f Очистка второго списка
            personList2.RemovePerson();
            Console.WriteLine("Второй список очищен");
            Console.WriteLine($"Список №1:" +
                $"\n{personList1.GetInfoAPersonList()}");
            Console.WriteLine($"Список №2:" +
                $"\n{personList2.GetInfoAPersonList()}");

            Person person3 = ReadPersonFromConsole();
            Console.WriteLine(person3.GetInfoAPersona());
        }
    }
}