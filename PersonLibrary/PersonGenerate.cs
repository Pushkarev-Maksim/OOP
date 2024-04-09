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
        /// Метод создания рандомного человека.
        /// </summary>
        /// <returns>Объект класса Person.</returns>
        public static Person GenerateRandomPerson()
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

            Person person = new Person();

            person.Age = random.Next(Person.MinAge, Person.MaxAge);

            person.Gender = (Gender)random.Next(2);

            switch (person.Gender)
            {
                case Gender.Male:
                    {
                        person.Name = maleName[
                        random.Next(0, maleName.Length)];
                        person.Surname = maleSurname[
                            random.Next(0, maleSurname.Length)];
                        break;
                    }
                case Gender.Female:
                    {
                        person.Name = femaleName[
                        random.Next(0, femaleName.Length)];
                        person.Surname = femaleSurname[
                            random.Next(0, femaleSurname.Length)];
                        break;
                    }
            }

            return person;
        }

        public static void GenerateRandomAdult(Adult adult)
        {
            Random random = new Random();

            string[] jobPlace =
            {
                "Газпром нефть", "Роснефть", "Магнит", "Росатом", "Почта России", 
                "Россети", "Сбер", "Роскосмос", "Норильский никель", "Русгидро",
            };

            adult.Age = random.Next(Person.MinAge, Person.MaxAge);

            adult.NumberPassport = random.Next(0*000000, 0*999999);
            adult.SeriesPassport = random.Next(0*0000, 0*9999);

            adult.Job = jobPlace[random.Next(0, jobPlace.Length)];
        }

        public static void GenerateRandomPartner(Adult adult)
        {
            Random random = new Random();

            Gender partnerGender;
            if (adult.Gender == Gender.Male)
            {
                partnerGender = Gender.Female;
            }
            else
            {
                partnerGender = Gender.Male;
            }
        }
    }
}