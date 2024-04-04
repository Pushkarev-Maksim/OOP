using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary
{
    internal class Child : Person
    {
        /// <summary>
        /// Поле мамы.
        /// </summary>
        private Adult _mother;

        /// <summary>
        /// Поле папы.
        /// </summary>
        private Adult _father;

        /// <summary>
        /// Поле места обучения.
        /// </summary>
        private string _placeOfStudy;

        public Child(string name, string surname, int age, Gender gender, 
            Adult mother, Adult father, string placeOfStudy)
            : base(name, surname, age, gender)
        {
            _mother = mother;
            _father = father;
            _placeOfStudy = placeOfStudy;
        }

        /// <summary>
        /// Задание мамы.
        /// </summary>
        public Adult Mother 
        { get { return _mother; } }

        /// <summary>
        /// Задание папы.
        /// </summary>
        public Adult Father 
        { get { return _father; } }

        /// <summary>
        /// Задание места обучения.
        /// </summary>
        public string PlaceOfStudy 
        { get { return _placeOfStudy; } }

        /// <summary>
        /// Получение информации о ребенке.
        /// </summary>
        /// <returns>Строка с данными полей объекта класса Child.</returns>
        public new string GetInfo()
        {
            return $"{Name} {Surname}, возраст: {Age}, пол: {Gender}, " +
                $"мама: {Mother}, папа: {Father}, " +
                $"место обучения: {PlaceOfStudy}\n";
        }
    }
}
