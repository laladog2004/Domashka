using static LibraryTask13.Tour;

namespace LibraryTask13.UnitTests
{
    [TestFixture]
    public class TourUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var moscow = CreateTestTour();

            Assert.That(moscow.TourName, Is.EqualTo("Тур по Москве"));
            Assert.That(moscow.TourCode, Is.EqualTo("MOS-011"));
            Assert.That(moscow.TourPlace, Is.EqualTo("Москва"));
            Assert.That(moscow.Transport, Is.EqualTo(TransportType.Plane));
            Assert.That(moscow.TourDuration, Is.EqualTo(moscow.EndDate - moscow.StartDate));
            Assert.That(moscow.TourPrice, Is.EqualTo("70,000 рублей"));
            Assert.That(moscow.StartDate.ToShortDateString(), Is.EqualTo("10.03.2025"));
            Assert.That(moscow.EndDate.ToShortDateString(), Is.EqualTo("30.03.2025"));
            Assert.That(moscow.TourDescription, Is.EqualTo("Отель и питание включены в стоимость"));
        }


        [Test]
        public void GetInfoTest()
        {
            var moscow = CreateTestTour();
            var info = moscow.GetInfo();

            Assert.That(info.Length, Is.EqualTo(5));

            Assert.That(info[0], Is.EqualTo("Тур по Москве"));
            Assert.That(info[1], Is.EqualTo("MOS-011"));
            Assert.That(info[2], Is.EqualTo("Москва"));
            Assert.That(info[3], Is.EqualTo("Тип передвижения: самолёт"));

            Assert.That($"Продолжительность: {moscow.EndDate - moscow.StartDate},Цена: 70,000 рублей, дата начала: 10.03.2025, дата окончания тура: 30.03.2025, описание: Отель и питание включены в стоимость.",
                Is.EqualTo(info[4]));

        }

        private Tour CreateTestTour()
        {
            return new Tour("Тур по Москве", "MOS-011", "Москва", TransportType.Plane, "70,000 рублей", "10.03.2025", "30.03.2025", "Отель и питание включены в стоимость");
        }
    }
}