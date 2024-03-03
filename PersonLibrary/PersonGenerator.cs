using System;

namespace PersonLibrary
{
    //TODO: XML +
    /// <summary>
    /// Клас PersonGenerator для 
    /// создания рандомного человека.
    /// </summary>
    public class PersonGenerator
    {
        //TODO: XML +
        /// <summary>
        /// Метод создания рандомного человека.
        /// </summary>
        /// <returns>Объект класса Person.</returns>
        public Person GeneratorRandomPerson()
        {
            string[] maleNames =
            {
                "Игорь", "Олег", "Геннадий", "Павел", "Максим", "Ефим",
                "Руслан", "Лаврентий", "Тарас", "Тимур",
            };

            string[] femaleNames =
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

            string name;
            string surname;
            //TODO: duplication +
            int age = random.Next(Person._minAge, Person._maxAge);
            Gender gender = (Gender)random.Next(2);

            if (gender == Gender.Male)
            {
                name = maleNames[new Random().Next(1, maleNames.Length)];
                surname = maleSurname[new Random().Next(1, maleSurname.Length)];
            }
            else
            {
                name = femaleNames[new Random().Next(1, maleNames.Length)];
                surname = femaleSurname[new Random().Next(1, maleSurname.Length)];
            }

            return new Person(name, surname, age, gender);
        }
    }
}