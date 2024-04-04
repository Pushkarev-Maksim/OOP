﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary
{
    internal class Adult : Person
    {
        /// <summary>
        /// Поле номера паспорта.
        /// </summary>
        private int _numberPassport;

        /// <summary>
        /// Поле серии паспорта.
        /// </summary>
        private int _seriesPassport;

        /// <summary>
        /// Поле партнера.
        /// </summary>
        private Adult _partner;

        /// <summary>
        /// Поле работы.
        /// </summary>
        private string _job;

        /// <summary>
        /// Конструктор класса Adult.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="surname">Фамилия.</param>
        /// <param name="age">Возраст.</param>
        /// <param name="gender">Пол.</param>
        /// <param name="numberPassport">Номер паспорта.</param>
        /// <param name="seriesPassport">Серия паспорта.</param>
        /// <param name="marriage">Партнер.</param>
        /// <param name="job">Работа.</param>
        public Adult(string name, string surname, int age, Gender gender,
            int numberPassport, int seriesPassport, Adult partner, 
            string job)
            : base(name, surname, age, gender)
        {
            _numberPassport = numberPassport;
            _seriesPassport = seriesPassport;
            _partner = partner;
            _job = job;
        }

        /// <summary>
        /// Задание номера паспорта.
        /// </summary>
        public int NumberPassport 
        { get {return _numberPassport;} }

        /// <summary>
        /// Задание серии паспорта.
        /// </summary>
        public int SeriesPassport 
        { get {return _seriesPassport;} }

        /// <summary>
        /// Задание партнера.
        /// </summary>
        public Adult Partner
        { get { return _partner; } }
        
        /// <summary>
        /// Задание работы.
        /// </summary>
        public string Job 
        { get { return _job; } }

        /// <summary>
        /// Получение информации о ребенке.
        /// </summary>
        /// <returns>Строка с данными полей объекта класса Child.</returns>
        public new string GetInfo()
        {
            return $"{Name} {Surname}, возраст: {Age}, " +
                $"пол: {Gender}, номер павспорта: {NumberPassport}, " +
                $"серия паспорта: {SeriesPassport}, партнер: {Partner}" +
                $"место работы: {Job}\n";
        }
    }
}
