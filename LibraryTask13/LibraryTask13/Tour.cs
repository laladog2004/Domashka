using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTask13
{
    public class Tour
    {
        public string TourName { get; set; }
        public readonly string TourCode;
        public string TourPlace { get; set; }

        public readonly TransportType Transport;

        public string TourPrice { get; set; }
        public readonly DateTime StartDate;
        public readonly DateTime EndDate;

        public TimeSpan TourDuration => EndDate - StartDate;

        public string TourDescription;

        public Tour(string tourName, string tourCode, string tourPlace, TransportType transport,
            string tourPrice, string startDate, string endDate, string tourDescription)
        {
            TourName = tourName;
            TourCode = tourCode;
            TourPlace = tourPlace;
            Transport = transport;
            TourPrice = tourPrice;

            TourDescription = tourDescription;

            if (!DateTime.TryParse(endDate, out EndDate))
                throw new ArgumentException("Неверный формат даты");

            if (!DateTime.TryParse(startDate, out StartDate))
                throw new ArgumentException("Неверный формат даты");

        }

        public virtual string[] GetInfo()
        {
            var info = new string[5];

            info[0] = $"{TourName}";
            info[1] = $"{TourCode}";
            info[2] = $"{TourPlace}";


            string transport;
            if (Transport == TransportType.Plane)
                transport = "самолёт";
            else if (Transport == TransportType.Car)
                transport = "автомобиль";
            else if (Transport == TransportType.Train)
                transport = "ж/д";
            else transport = "водный транспорт";

            info[3] = $"Тип передвижения: {transport}";

            info[4] = $"Продолжительность: {TourDuration},Цена: {TourPrice}, дата начала: {StartDate:d}, дата окончания тура: {EndDate:d}, описание: {TourDescription}.";
            return info;
        }
        public enum TransportType
        {
            Car,
            Train,
            Plane,
            Waterborne
        }
    }
}
