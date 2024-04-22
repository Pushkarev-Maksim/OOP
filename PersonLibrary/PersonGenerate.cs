using System;

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
                "Игорь", "Олег", "Геннадий", "Павел", "Максим", "Ефим",
                "Руслан", "Лаврентий", "Тарас", "Тимур",
            };

            string[] femaleName =
            {
                "Зоя", "Полина", "Валерия", "Ангелина", "Анастасия",
                "Галина", "Оксана", "Марина", "Елена", "Яна",
            };

            string[] maleSurname =
            {
                "Иванов", "Смирнов", "Кузнецов", "Попов", "Васильев",
                "Петров", "Соколов", "Михайлов", "Новиков", "Федоров",
            };

            string[] femaleSurname =
            {
                "Цветаева", "Лебедева", "Соболева", "Громова", "Глебова",
                "Степанова", "Андреева", "Журавлева", "Белова", "Дорохова",
            };

            Random random = new Random();

            person.Age = random.Next(PersonBase.MinAge, PersonBase.MaxAge);

            person.Gender = (Gender)random.Next(2);

            switch (person.Gender)
            {
                case Gender.Male:
                    {
                        person.Name = maleName[
                        random.Next(0, maleName.Length)];
                        person.Surname = maleSurname
                            [random.Next(0, maleSurname.Length)];
                        break;
                    }
                case Gender.Female:
                    {
                        person.Name = femaleName[
                        random.Next(0, femaleName.Length)];
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
        public static void SetRandomPerson(PersonBase person, Gender gender)
        {
            string[] maleName =
            {
                "Игорь", "Олег", "Геннадий", "Павел", "Максим", "Ефим",
                "Руслан", "Лаврентий", "Тарас", "Тимур",
            };

            string[] femaleName =
            {
                "Зоя", "Полина", "Валерия", "Ангелина", "Анастасия",
                "Галина", "Оксана", "Марина", "Елена", "Яна",
            };

            string[] maleSurname =
            {
                "Иванов", "Смирнов", "Кузнецов", "Попов", "Васильев",
                "Петров", "Соколов", "Михайлов", "Новиков", "Федоров",
            };

            string[] femaleSurname =
            {
                "Цветаева", "Лебедева", "Соболева", "Громова", "Глебова",
                "Степанова", "Андреева", "Журавлева", "Белова", "Дорохова",
            };

            Random random = new Random();

            person.Age = random.Next(PersonBase.MinAge, PersonBase.MaxAge);

            if (gender == Gender.Male)
            {
                person.Gender = Gender.Male;
            }
            person.Gender = Gender.Female;

            switch (person.Gender)
            {
                case Gender.Male:
                    {
                        person.Name = maleName[
                        random.Next(0, maleName.Length)];
                        person.Surname = maleSurname
                            [random.Next(0, maleSurname.Length)];
                        break;
                    }
                case Gender.Female:
                    {
                        person.Name = femaleName[
                        random.Next(0, femaleName.Length)];
                        person.Surname = femaleSurname
                            [random.Next(0, femaleSurname.Length)];
                        break;
                    }
            }
        }

        /// <summary>
        /// Метод присоения полям Adult (кроме поля Patner) рандомных значений.
        /// </summary>
        /// <param name="adult">Объект класса Adult.</param>
        public static void SetRandomAdult(Adult adult)
        {
            Random random = new Random();

            string[] jobPlace =
            {
                "Газпром нефть", "Роснефть", "Магнит", "Росатом", "Почта России",
                "Россети", "Сбер", "Роскосмос", "Норильский никель", "Русгидро",
            };

            adult.Age = random.Next(PersonBase.MinAge, PersonBase.MaxAge);

            adult.NumberPassport = random.Next(111111, 999999);
            adult.SeriesPassport = random.Next(1111, 9999);

            adult.Job = jobPlace[random.Next(0, jobPlace.Length)];

            if (random.Next(2) != 0)
            {
                switch (adult.Gender)
                {
                    case Gender.Male:
                        adult.Partner = GetRandomAdult(Gender.Female);
                        break;

                    case Gender.Female:
                        adult.Partner = GetRandomAdult(Gender.Male);
                        break;
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
        /// <param name="adult"></param>
        public static void SetRandomChild(Child child)
        {
            Random random = new Random();

            string[] placeOfStudy =
            {
                "МОУ «Гимназия им. В.А.Надькина»", "МОУ «СОШ №2»", 
                "МОУ «СОШ №4 им. Д.М.Перова»", "МОУ «СОШ №5", 
                "МОУ «СОШ №6", "МОУ «СОШ №7", "МОУ «СОШ №8",
            };

            child.PlaceOfStudy = placeOfStudy[random.Next(0, placeOfStudy.Length)];

            child.Father = GetRandomAdult(Gender.Male);

            child.Mother = GetRandomAdult(Gender.Female);
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