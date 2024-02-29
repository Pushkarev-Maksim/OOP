using System;
using System.Collections.Generic;

namespace PersonLibrary
{
    public class PersonList
    {
        /// <summary>
        /// Объявление списка объектов типа Person.
        /// </summary>
        private List<Person> persons = new List<Person>();

        /// <summary>
        /// Добавление персоны.
        /// </summary>
        /// <param name="person">Персона.</param>
        public void AddPerson(Person person)
        {
            persons.Add(person);
        }

        /// <summary>
        /// Удаление персон.
        /// </summary>
        /// <param name="person"></param>
        public void RemovePerson(Person person)
        {
            persons.Remove(person);
        }

        /// <summary>
        /// Удаление персон по индексу.
        /// </summary>
        /// <param name="index">Индекс.</param>
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
        /// <param name="index">Индекс.</param>
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
        /// <param name="person"></param>
        /// <returns></returns>
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
        /// <param name="person">Персона.</param>
        public void RemovePerson()
        {
            persons.Clear();
        }

        /// <summary>
        /// Количество персон в списке.
        /// </summary>
        /// <returns>.</returns>
        public int GetCountPerson()
        {
            return persons.Count;
        }

        /// <summary>
        /// Получение информации о списке персон.
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public string GetInfoAPersonList()
        {
            string infoPerson = default;
            foreach (Person persona in persons)
            {
                infoPerson += persona.GetInfoAPersona();
            }
            return infoPerson;
        }
    }
}