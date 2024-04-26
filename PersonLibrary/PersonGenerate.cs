﻿using System;

namespace PersonLibrary
{
    /// <summary>
    /// Клас PersonGenerate для 
    /// создания рандомного человека.
    /// </summary>
    public class PersonGenerate
    {
        /// <summary>
        /// Метод присоения полям Person рандомных значений.
        /// </summary>
        /// <param name="person">Объект класса Person.</param>
        public static void SetRandomPerson(PersonBase person)
        {
            string[] maleName =
            {
                "Игорь", "Олег", "Геннадий", "Павел", 
                "Максим", "Ефим", "Руслан", "Лаврентий", 
                "Тарас", "Тимур",
            };

            string[] femaleName =
            {
                "Зоя", "Полина", "Валерия", "Ангелина", 
                "Анастасия", "Галина", "Оксана", "Марина", 
                "Елена", "Яна",
            };

            string[] maleSurname =
            {
                "Иванов", "Смирнов", "Кузнецов", "Попов", 
                "Васильев", "Петров", "Соколов", "Михайлов", 
                "Новиков", "Федоров",
            };

            string[] femaleSurname =
            {
                "Цветаева", "Лебедева", "Соболева", "Громова", 
                "Глебова", "Степанова", "Андреева", "Журавлева", 
                "Белова", "Дорохова",
            };

            Random random = new Random
                (Guid.NewGuid().GetHashCode());

            person.Age = random.Next(person.MinAge, person.MaxAge);

            person.Gender = (Gender)random.Next(2);

            switch (person.Gender)
            {
                case Gender.Male:
                {
                    person.Name = maleName
                            [random.Next(0, maleName.Length)];
                    person.Surname = maleSurname
                            [random.Next(0, maleSurname.Length)];
                    break;
                }
                case Gender.Female:
                {
                    person.Name = femaleName
                            [random.Next(0, femaleName.Length)];
                    person.Surname = femaleSurname
                            [random.Next(0, femaleSurname.Length)];
                    break;
                }
            }
        }

        /// <summary>
        /// Метод присоения полям Person рандомных значений
        /// с заданным полом.
        /// </summary>
        /// <param name="person">Объект класса Person.</param>
        public static void SetRandomPerson(PersonBase person,
            Gender gender)
        {
            string[] maleName =
            {
                "Игорь", "Олег", "Геннадий", "Павел", 
                "Максим", "Ефим", "Руслан", "Лаврентий", 
                "Тарас", "Тимур",
            };

            string[] femaleName =
            {
                "Зоя", "Полина", "Валерия", "Ангелина", 
                "Анастасия", "Галина", "Оксана", "Марина", 
                "Елена", "Яна",
            };

            string[] maleSurname =
            {
                "Иванов", "Смирнов", "Кузнецов", "Попов", 
                "Васильев", "Петров", "Соколов", "Михайлов", 
                "Новиков", "Федоров",
            };

            string[] femaleSurname =
            {
                "Цветаева", "Лебедева", "Соболева", "Громова", 
                "Глебова", "Степанова", "Андреева", "Журавлева", 
                "Белова", "Дорохова",
            };

            Random random = new Random
                (Guid.NewGuid().GetHashCode());

            person.Age = random.Next(person.MinAge, person.MaxAge);

            if (gender == Gender.Male)
            {
                person.Gender = Gender.Male;
            }
            else if (gender == Gender.Female)
            {
                person.Gender = Gender.Female;
            }
            
            switch (person.Gender)
            {
                case Gender.Male:
                {
                    person.Name = maleName
                            [random.Next(0, maleName.Length)];
                    person.Surname = maleSurname
                            [random.Next(0, maleSurname.Length)];
                    break;
                }
                case Gender.Female:
                {
                    person.Name = femaleName
                            [random.Next(0, femaleName.Length)];
                    person.Surname = femaleSurname
                            [random.Next(0, femaleSurname.Length)];
                    break;
                }
            }
        }

        /// <summary>
        /// Метод присоения полям Adult рандомных значений.
        /// </summary>
        /// <param name="adult">Объект класса Adult.</param>
        public static void SetRandomAdult(Adult adult)
        {
            Random random = new Random
                (Guid.NewGuid().GetHashCode());

            string[] jobPlace =
            {
                "Газпром нефть", "Роснефть", "Магнит", "Росатом", 
                "Почта России","Россети", "Сбер", "Роскосмос", 
                "Норильский никель", "Русгидро", "Тинькофф",
            };

            adult.Job = jobPlace[random.Next(0, jobPlace.Length)];

            adult.Age = random.Next(adult.MinAge, adult.MaxAge);

            //TODO: duplication
            string seriesPassport = "";
            for (int i = 0; i < Adult.PassportSeriesDigits; i++)
            {
                seriesPassport += random.Next(0, 10).ToString();
            }
            adult.SeriesPassport = seriesPassport;

            //TODO: duplication
            string numberPassport = "";
            for (int i = 0; i < Adult.PassportNumberDigits; i++)
            {
                numberPassport += random.Next(0, 10).ToString();
            }
            adult.NumberPassport = numberPassport;

            if (random.Next(2) == 0)
            {
                switch (adult.Gender)
                {
                    case Gender.Male:
                    {
                        adult.Partner = GetRandomAdult(Gender.Female);
                        break;
                    }
                    case Gender.Female:
                    {
                        adult.Partner = GetRandomAdult(Gender.Male);
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Метод заполнения полей обьекта класса Adult.
        /// </summary>
        /// <returns>Объект класса Adult.</returns>
        public static Adult GetRandomAdult()
        {
            Adult adult = new Adult();
            SetRandomPerson(adult);
            SetRandomAdult(adult);
            return adult;
        }

        /// <summary>
        /// Метод заполнения полей обьекта класса Adult
        /// с заданным полем.
        /// </summary>
        /// <param name="gender">Пол.</param>
        /// <returns>Объект класса Adult.</returns>
        public static Adult GetRandomAdult(Gender gender)
        {
            Adult adult = new Adult();
            SetRandomPerson(adult, gender);
            SetRandomAdult(adult);
            return adult;
        }

        /// <summary>
        /// Метод присоения полям Child рандомных значений.
        /// </summary>
        /// <param name="adult">Объект класса Adult.</param>
        public static void SetRandomChild(Child child)
        {
            Random random = new Random
                (Guid.NewGuid().GetHashCode());

            string[] placeOfStudy =
            {
                "МОУ «Гимназия им. В.А.Надькина»", "МОУ «СОШ №2»", 
                "МОУ «СОШ №4 им. Д.М.Перова»", "МОУ «СОШ №5»",
                "МОУ «СОШ №6»", "МОУ «СОШ №7»", "МОУ «СОШ №8»",
            };

            child.PlaceOfStudy = placeOfStudy
                [random.Next(0, placeOfStudy.Length)];

            child.Age = random.Next(child.MinAge, child.MaxAge);

            Adult father = GetRandomAdult(Gender.Male);
            child.Father = father;

            Adult mother = GetRandomAdult(Gender.Female);
            child.Mother = mother;

            mother.Surname = father.Surname;
            mother.Surname += "а";

            if (child.Gender == Gender.Male)
            {
                child.Surname = father.Surname;
            }
            else if (child.Gender == Gender.Female)
            {
                child.Surname = mother.Surname;
            }
        }

        /// <summary>
        /// Метод заполнения полей обьекта класса Child.
        /// </summary>
        /// <returns>Объект класса Child</returns>
        public static Child GetRandomChild()
        {
            Child child = new Child();
            SetRandomPerson(child);
            SetRandomChild(child);
            return child;
        }
    }
}