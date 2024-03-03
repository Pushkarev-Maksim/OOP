using System;
using System.Collections.Generic;

namespace PersonLibrary
{
    //TODO: XML +
    /// <summary>
    /// Класс PersonList.
    /// </summary>
    public class PersonList
    {
        /// <summary>
        /// Объявление списка объектов типа Person.
        /// </summary>
        private List<Person> persons = new List<Person>();

        /// <summary>
        /// Добавление персоны.
        /// </summary>
        /// <param name="person">Объект класса Person.</param>
        public void AddPerson(Person person)
        {
            persons.Add(person);
        }

        /// <summary>
        /// Удаление персон.
        /// </summary>
        /// <param name="person">Объект класса Person.</param>
        public void RemovePerson(Person person)
        {
            persons.Remove(person);
        }

        /// <summary>
        /// Удаление персон по индексу.
        /// </summary>
        /// <param name="index">Индекс объекта.</param>
        /// <exception cref="IndexOutOfRangeException">Исключение, которое
        /// генерируется, если введенный индекс находится за пределами его
        /// границ.</exception>
        public void RemovePersonAtIndex(int index)
        {
            if (index >= 0 && index < persons.Count)
            {
                persons.RemoveAt(index);
            }
            else
            {
                throw new IndexOutOfRangeException($"'Элемента с индексом " +
                    $"{index} нет в списке");
            }
        }

        /// <summary>
        /// Поиск персоны по указанному индексу.
        /// </summary>
        /// <param name="index">Индекс объекта.</param>
        /// <returns>index</returns>
        /// <exception cref="IndexOutOfRangeException">Исключение, которое
        /// генерируется, если введенный индекс находится за пределами его
        /// границ.</exception>
        public Person GetPersonAtIndex(int index)
        {
            if (index >= 0 && index < persons.Count)
            {
                return persons[index];
            }
            else
            {
                throw new IndexOutOfRangeException($"Элемента с индексом " +
                    $"{index} нет в списке");
            }
        }

        /// <summary>
        /// Получение индекса по персоне.
        /// </summary>
        /// <param name="person">Объект класса Person.</param>
        /// <returns>Индекс объекта.</returns>
        public int ReturnIndexPerson(Person person)
        {
            if (persons.Contains(person))
            {
                return persons.IndexOf(person);
            }
            else
            {
                throw new ArgumentException("Данной персоны не " +
                    "существует");
            }
        }

        /// <summary>
        /// Удаление всех персон.
        /// </summary>
        public void RemovePerson()
        {
            persons.Clear();
        }

        /// <summary>
        /// Количество персон в списке.
        /// </summary>
        /// <returns>Количество персон в списке.</returns>
        public int GetCountPerson()
        {
            return persons.Count;
        }

        /// <summary>
        /// Получение информации о списке персон.
        /// </summary>
        /// <returns>Строка с данными полей объектов списка.</returns>
        public string GetInfoPersonList()
        {
            string infoPerson = default;
            foreach (Person persona in persons)
            {
                infoPerson += persona.GetInfoPerson();
            }
            return infoPerson;
        }
    }
}