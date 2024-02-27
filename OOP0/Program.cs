using Model;

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
            PersonList personList1 = new PersonList();
            PersonList personList2 = new PersonList();

            // 3.a. Заполнение первого списка
            personList1.AddPerson(PersonGenerator.GeneratorRandomPerson());
            personList1.AddPerson(PersonGenerator.GeneratorRandomPerson());
            personList1.AddPerson(PersonGenerator.GeneratorRandomPerson());

            // 3.a. Заполнение второго списка
            personList2.AddPerson(PersonGenerator.GeneratorRandomPerson());
            personList2.AddPerson(PersonGenerator.GeneratorRandomPerson());
            personList2.AddPerson(PersonGenerator.GeneratorRandomPerson());

            // 3.b. Вывод содержимого каждого списка на экран
            Console.WriteLine($"Содержимое первого списка: {personList1}");
            Console.WriteLine($"Содержимое второго списка: {personList2}");
        }
    }
}