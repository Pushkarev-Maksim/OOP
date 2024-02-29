using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace PersonLibrary
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
            return $"{name} {surname}, возраст: {age}, пол: {gender}\n";
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

        // Проверка на ввод имени и фамилии на одном языке
        public string Name
        {
            get
            {
                return name;
            }
            set 
            {
                if (ValidNameAndSurname(value))
                {
                    name = CheckRegisterNameSurname(value);
                }
                else
                {
                    throw new ArgumentException("При вводе имени " +
                        "используйте только буквы русского или " +
                        "английского алфавита. Имя может быть двойным.");
                }
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                if (ValidNameAndSurname(value))
                {
                    surname = CheckRegisterNameSurname(value);
                }
                else
                {
                    throw new ArgumentException("При вводе фамилии " +
                        "используйте только буквы русского или " +
                        "английского алфавита. Фамилия может быть двойной.");
                }
            }

        }

        /// <summary>
        /// Преобразование имени и фамилии в првильные регистры.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string CheckRegisterNameSurname(string name)
        {
            TextInfo txt = CultureInfo.CurrentCulture.TextInfo;
            return txt.ToTitleCase(name.ToLower());
        }

        /// <summary>
        /// Проверка на соответствие имени и фамилии одному языку.
        /// Учтена возможность ввода двойного имени и двойной фамили
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool ValidNameAndSurname(string name)
        {
            return Regex.IsMatch(name, @"(^[а-яА-Я]+-?[а-яА-Я]+$)") ||
                   Regex.IsMatch(name, @"(^[a-zA-Z]+-?[a-zA-Z]+$)");
        }
    }
}