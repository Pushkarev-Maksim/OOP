using System;
using System.Globalization;
using System.IO;
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
        /// Конструктор класса по умолчанию.
        /// </summary>
        public Person()
        {
            name = "Default";
            surname = "Default";
            age = 0;
            gender = Gender.Male;
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
        /// Задание имени.
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set 
            {
                if (ValidNameOrSurname(value))
                {
                    name = CheckRegisterNameSurname(value);
                }
                else
                {
                    throw new ArgumentException("Имя должно быть написано " +
                        "на одном языке. Имя может быть двойным и записано " +
                        "через дефис.");
                }
            }
        }

        /// <summary>
        /// Задание фамилии.
        /// </summary>
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                if (ValidNameOrSurname(value) && ValidNameAndSurname(name, value))
                {
                    surname = CheckRegisterNameSurname(value);
                }
                else
                {
                    throw new ArgumentException("Фамилия должна быть написана " +
                        "на одном языке.\nФамилия может быть двойной и записана " +
                        "через дефис.\nФамилия и имя должны быть введены на одном " +
                        "языке. ");
                }
            }
        }

        /// <summary>
        /// Преобразование имени и фамилии в правильные регистры.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string CheckRegisterNameSurname(string name)
        {
            TextInfo txt = CultureInfo.CurrentCulture.TextInfo;
            return txt.ToTitleCase(name.ToLower());
        }

        /// <summary>
        /// Проверка того, что имя или фамилия введены на одном языке.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool ValidNameOrSurname(string name)
        {
            bool languageRussian = Regex.IsMatch(name,
                @"(^[а-яА-Я]+-?[а-яА-Я]+$)");
            bool languageEnglish = Regex.IsMatch(name,
                @"(^[a-zA-Z]+-?[a-zA-Z]+$)");

            return (languageRussian || languageEnglish);
        }

        /// <summary>
        /// Проверка того, что имя и фамили введены на одном языке
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <returns></returns>
        public bool ValidNameAndSurname(string name, string surname)
        {
            bool languageRussianName = Regex.IsMatch(name,
                @"(^[а-яА-Я]+-?[а-яА-Я]+$)");
            bool languageEnglishName = Regex.IsMatch(name,
                @"(^[a-zA-Z]+-?[a-zA-Z]+$)");

            bool languageRussianSurname = Regex.IsMatch(surname,
                @"(^[а-яА-Я]+-?[а-яА-Я]+$)");
            bool languageEnglishSurname = Regex.IsMatch(surname,
                @"(^[a-zA-Z]+-?[a-zA-Z]+$)");

            return (languageRussianName && languageRussianSurname) ||
                (languageEnglishName && languageEnglishSurname);
        }

        /// <summary>
        /// Задание возраста.
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