namespace Model
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
        /// Удаление всех персон.
        /// </summary>
        /// <param name="person">Персона.</param>
        public void RemovePerson(Person person)
        {
            persons.Clear();
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
                throw new IndexOutOfRangeException($"'Элемента с индексом " +
                    $"{index} нет в списке");
            }
        }

        /// <summary>
        /// Количество персон в списке.
        /// </summary>
        /// <returns>.</returns>
        public int GetCountPerson()
        {
            return persons.Count;
        }




        // Под вопросом???
        public int IndexOfPerson(Person person)
        {
            return persons.IndexOf(person);
        }
    }
}