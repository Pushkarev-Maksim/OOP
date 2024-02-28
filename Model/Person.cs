using System;

namespace Model
{
    public class Person
    {
        /// <summary>
        /// Имя.
        /// </summary>
        private string name;

        /// <summary>
        /// Фамилия.
        /// </summary>
        private string surname;

        /// <summary>
        /// Возраст.
        /// </summary>
        private int age;

        /// <summary>
        /// Гендер.
        /// </summary>
        private Gender gender;

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// Конструктор класса.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="surname">Фамилия.</param>
        /// <param name="age">Возраст.</param>
        /// <param name="gender">Гендер.</param>
        public Person(string name, string surname, int age, Gender gender)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.gender = gender;
        }

        /// <summary>
        /// Получение информации о персоне.
        /// </summary>
        /// <returns></returns>
        public string GetInfoAPersona()
        {
            return $"{name} {surname}, {age} лет, пол: {gender}";
        }

        /// <summary>
        /// Проверка возраста.
        /// </summary>
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value >= 1 && value <= 150)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException($"Возраст должен находиться" +
                        $" в пределах от 1 до 150");
                }
            }
        }

        /// <summary>
        /// Задание гендера.
        /// </summary>
        public Gender Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }
    }
}