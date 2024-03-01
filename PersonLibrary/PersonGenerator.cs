﻿using System;

namespace PersonLibrary
{
    //TODO: XML
    public class PersonGenerator
    {
        //TODO: RSDN
        private static Random random = new Random();

        //TODO: XML
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

            string name;
            string surname;
            //TODO: duplication
            int age = random.Next(1, 150);
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