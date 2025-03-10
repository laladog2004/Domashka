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
        public string TourPlace {  get; set; }

        public readonly TransportType Transport;

        public string TourPrice {  get; set; }
        public DateTime StartDate { get; set; }
        public readonly DateTime EndDate;

        public TimeSpan TourDuration => EndDate - StartDate;

        public string TourDescription;
 
        public Tour(string tourName, string tourCode, string tourPlace, TransportType transport, 
            string tourPrice, DateTime startDate, string endDate, string tourDescription)
        {
            TourName = tourName;
            TourCode = tourCode;
            TourPlace = tourPlace;
            Transport = transport;
            TourPrice = tourPrice;
            StartDate = startDate;
            
            TourDescription = tourDescription;

            if (!DateTime.TryParse(endDate, out EndDate))
                throw new ArgumentException("Неверный формат даты");

        }

        public virtual string[] GetInfo()
        {
            var info = new string[2];

            info[0] = $"{TourName}";
            info[1] = $"{TourCode}";
            info[2] = $"{TourPlace}";


            string transport;
            if (Transport == TransportType.Plane)
                transport = "самолет";
            else if (Transport == TransportType.Car)
                transport = "автомобиль";
            else if (Transport == TransportType.Train)
                transport = "ж/д";
            else if (Transport == TransportType.Waterborne)
                transport = "водный транспорт";

            info[3] = $"Тип передвижения: {Transport}.";

            info[4] = $"Продолжительность: {TourDuration},Цена: {TourPrice}, дата начала: {StartDate}," +
                $" дата окончания тура: {EndDate}, описание: {TourDescription}.";
            return info;
        }
            
        }
    public enum TransportType
    {
        Car,
        Train,
        Plane,
        Waterborne
    }
}
