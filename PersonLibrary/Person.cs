using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace PersonLibrary
{
    /// <summary>
    /// Класс Person.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Имя.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Возраст.
        /// </summary>
        private int _age;

        /// <summary>
        /// Гендер.
        /// </summary>
        private Gender _gender;

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="surname">Фамилия.</param>
        /// <param name="age">Возраст.</param>
        /// <param name="gender">Гендер.</param>
        public Person(string name, string surname, int age, Gender gender)
        {
            _name = name;
            _surname = surname;
            _age = age;
            _gender = gender;
        }

        /// <summary>
        /// Конструктор класса по умолчанию.
        /// </summary>
        public Person() : this ("Иван", "Иванов", 0, Gender.Male)
        { }

        //TODO: RSDN
        /// <summary>
        /// Получение информации о персоне.
        /// </summary>
        /// <returns></returns>
        public string GetInfoAPersona()
        {
            return $"{_name} {_surname}, возраст: {_age}, пол: {_gender}\n";
        }

        /// <summary>
        /// Задание имени.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set 
            {
                if (ValidNameOrSurname(value))
                {
                    _name = CheckRegisterNameSurname(value);
                }
                else
                {
                    throw new ArgumentException(
                        "Имя должно быть написано на одном языке.\n" +
                        "Имя может быть двойным и записано через дефис.");
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
                return _surname;
            }
            set
            {
                if (ValidNameOrSurname(value) && ValidNameAndSurname(_name, value))
                {
                    _surname = CheckRegisterNameSurname(value);
                }
                else
                {
                    throw new ArgumentException("Фамилия должна быть написана " +
                        "на одном языке.\n" +
                        "Фамилия может быть двойной и записана через дефис.\n" +
                        "Фамилия и имя должны быть введены на одном языке. ");
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
        /// Проверка того, что имя и фамилия введены на одном языке
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

            return (languageRussianName && languageRussianSurname) 
                || (languageEnglishName && languageEnglishSurname);
        }

        /// <summary>
        /// Минимальный возраст.
        /// </summary>
        private const int _minAge = 1;

        /// <summary>
        /// Максимальный возраст.
        /// </summary>
        private const int _maxAge = 130;

        /// <summary>
        /// Задание возраста.
        /// </summary>
        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                if (value >= _minAge && value <= _maxAge)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentException($"Возраст должен находиться " +
                        $"в пределах от {_minAge} года до {_maxAge} лет");
                }
            }
        }

        //TODO: autoproperty
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