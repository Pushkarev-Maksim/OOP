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
        public static void SetRandomPerson(Person person)
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

            person.Age = random.Next(Person.MinAge, Person.MaxAge);

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
        /// Метод присоения полям Adult рандомных значений.
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

            adult.Age = random.Next(Person.MinAge, Person.MaxAge);

            adult.NumberPassport = random.Next(111111, 999999);
            adult.SeriesPassport = random.Next(1111, 9999);

            adult.Job = jobPlace[random.Next(0, jobPlace.Length)];
        }

        /// <summary>
        /// Метод присвоения полю Partner класса Adult значений.
        /// </summary>
        /// <param name="adult">Объект класса Adult.</param>
        public static void SetRandomPartner(Adult adult)
        {
            Adult partner = new Adult();

            Random random = new Random();

            if (random.Next(3) == 0)
            {
                switch (adult.Gender)
                {
                    case Gender.Male:
                        partner = GetRandomAdult(Gender.Female);
                        break;

                    case Gender.Female:
                        partner = GetRandomAdult(Gender.Male);
                        break;
                }

                adult.Partner = partner;
            }
        }

        /// <summary>
        /// Метод заполнения полей обьекта класса Person.
        /// </summary>
        /// <returns>Объект класса Person.</returns>
        public static Person GetRandomPerson()
        {
            Person person = new Person();
            SetRandomPerson(person);
            return person;
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
            SetRandomPartner(adult);
            return adult;
        }

        public static Adult GetRandomAdult(Gender gender)
        {
            Adult adult = new Adult();
            adult.Gender = gender;
            SetRandomPerson(adult);
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
        }
    }
}