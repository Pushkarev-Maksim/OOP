﻿namespace PersonLibrary
{
    /// <summary>
    /// Класс Adult.
    /// </summary>
    public class Adult : PersonBase
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
        /// Максимальный номер паспорта.
        /// </summary>
        public const int MaxNumberPassport = 999999;

        /// <summary>
        /// Минимальный номер паспорта.
        /// </summary>
        public const int MinNumberPassport = 111111;

        /// <summary>
        /// Максимальная серия паспорта.
        /// </summary>
        public const int MaxSeriesPassport = 9999;

        /// <summary>
        /// Минимальная серия паспорта.
        /// </summary>
        public const int MinSeriesPassport = 1111;

        /// <inheritdoc/>
        public override int MinAge { get; } = 18;

        /// <summary>
        /// Конструктор класса Adult.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="surname">Фамилия.</param>
        /// <param name="age">Возраст.</param>
        /// <param name="gender">Пол.</param>
        /// <param name="numberPassport">Номер паспорта.</param>
        /// <param name="seriesPassport">Серия паспорта.</param>
        /// <param name="partner">Партнер.</param>
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
        /// Конструктор класса Adult по умолчанию.
        /// </summary>
        public Adult() : this("Иван", "Иванов", 0, Gender.Male,
            0, 0, null, null)
        { }

        /// <summary>
        /// Задание номера паспорта.
        /// </summary>
        public int NumberPassport
        {
            get { return _numberPassport; }
            set { _numberPassport = value; }
        }

        /// <summary>
        /// Задание серии паспорта.
        /// </summary>
        public int SeriesPassport 
        {
            get { return _seriesPassport; }
            set { _seriesPassport = value; }
        }

        /// <summary>
        /// Задание партнера.
        /// </summary>
        public Adult Partner
        {
            get { return _partner; }
            set { _partner = value; }
        }
        
        /// <summary>
        /// Задание работы.
        /// </summary>
        public string Job
        {
            get { return _job; }
            set { _job = value; }
        }

        /// <summary>
        /// Получение информации о взрослом.
        /// </summary>
        /// <returns>Строка с данными полей объекта класса Adult.</returns>
        public override string GetInfo()
        {
            string partner = string.Empty;

            if (Gender == Gender.Male && Partner == null)
            {
                partner = "Не женат";
            }

            if (Gender == Gender.Female && Partner == null)
            {
                partner = "Не замужем";
            }

            if (Partner != null)
            {
                partner = Partner.Surname + " " + Partner.Name;
            }

            if (Job == null)
            {
                Job = "Безработный";
            }

            return base.GetInfo() + $", серия паспорта: {SeriesPassport}, " +
                $"номер паспорта: {NumberPassport}, партнер: {partner}, " +
                $"место работы: {Job}\n";
        }

        /// <summary>
        /// Метод для класса Adult.
        /// </summary>
        /// <returns>Строка.</returns>
        public string GetExtraIncome()
        {
            return "Ищет дополнительный заработок, чтобы содержать семью";
        }
    }
}