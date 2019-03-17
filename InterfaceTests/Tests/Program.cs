using AnimalBehaviourTests;
using InterfaceTests;
using SerializationTest;
using System;
using System.Collections.Generic;
using VehicleTest;
using Newtonsoft.Json;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {


            var cards = new List<Card>()
            {
                new NbaCard()
                {
                    Title = "Bird",
                    Link = "https://c1.staticflickr.com/9/8370/8406752121_379eee2281_z.jp"
                },

                new NbaCard()
                {
                    Title = "Jordan",
                    Link = "https://c1.staticflickr.com/9/8370/8406752121_379eee2281_z.jp"
                },
                new NbaCard()
                {
                    Title = "Lebron",
                    Link = "https://c1.staticflickr.com/9/8370/8406752121_379eee2281_z.jp"
                },
                new NbaCard()
                {
                    Title = "Rodman",
                    Link = "https://c1.staticflickr.com/9/8370/8406752121_379eee2281_z.jp"
                },
                new NbaCard()
                {
                    Title = "Shaq",
                    Link = "https://c1.staticflickr.com/9/8370/8406752121_379eee2281_z.jp"
                },

                new NflCard()
                {
                    Title = "Lynch",
                    Link = "https://c.o0bc.com/wp-content/uploads/2015/09/09012008_01jvlynch-6862915-5013-850x478$large.jpg"
                },
                new NflCard()
                {
                    Title = "Brady",
                    Link = "https://media.profootballfocus.com/2016/10/GettyImages-619283346.jpg?w=916&h=720"
                }
            };


            foreach ( var card in cards)
            {

                var serializedCardInfo = JsonConvert.SerializeObject(card);
                Console.WriteLine(serializedCardInfo);
               
                var deserializedCardInfo = JsonConvert.DeserializeObject<NbaCard>(serializedCardInfo);
                Console.WriteLine("New " + deserializedCardInfo.ShowCard());

                Console.WriteLine(Environment.NewLine);
            }
            Console.ReadLine();

           




        //    [
        //    {
        //        title: 'bird',
        //        link: 'https://c1.staticflickr.com/9/8370/8406752121_379eee2281_z.jpg'},
        //    {
        //        title: 'Jordan',
        //        link: 'https://cdn.newsapi.com.au/image/v1/5115ef8c03f1131ad928b5e31df9901a?width=1024'},
        //    {
        //        title: 'Lebron',
        //        link: 'https://www.nbcsports.com/bayarea/sites/csnbayarea/files/styles/article_hero_image/public/2019/02/06/lebronus.jpg?itok=lL2woRCZ'},
        //    {
        //        title: 'Rodman',
        //        link: 'http://media.al.com/news_impact/photo/Dennis%20rodman.PNG'},
        //    {
        //        title: 'Shaq',
        //        link: 'https://i.pinimg.com/originals/98/ca/74/98ca7464b573bfd44898b5cae41a7f26.jpg'}

            //]


            // Console.WriteLine("Hello World!");
            // var interfaceTest = new InterfaceTest();
            // interfaceTest.PublicProperty = 1;

            //// var dog = new AnimalTests();
            //// dog.Bark();
            // AnimalTests.Run();

            //var newCar = new Car();
            //newCar.StartEngine();
            //newCar.StopEngine();
            //newCar.MoveBackwards();
            //newCar.MoveForward();
            //newCar.UseLights();
            //newCar.UseLights(LightIntensity.Long);


            //var tankHank = new Tank();
            //tankHank.StartEngine();
            //tankHank.ShootProjectile();

            //var bicyclePegas = new ElectricBicycle();
            //bicyclePegas.StartEngine();




            //var dealerBuzesti = new CommonVehicleDealership();
            //dealerBuzesti.VehiclesStock.Add(newCar);
            ////dealerBuzesti.Vehicles.Add(tankHank);
            //dealerBuzesti.VehiclesStock.Add(bicyclePegas);


            //var chopper = new Helicopter();
            //var airTransport = new CargoPlane();
            //var airFighter = new JetFighter();

            //var dealerMilitari = new AssaultVehicleDealership();
            //dealerMilitari.VehiclesStock.Add(tankHank);
            //dealerMilitari.VehiclesStock.Add(chopper);
            //dealerMilitari.VehiclesStock.Add(airFighter);
            //dealerMilitari.VehiclesStock.Add(airTransport);


            //var countMilitariDealershipVehicles = dealerMilitari.VehiclesStock.Count;


            //var countBuzestiDealershipVehicle = dealerBuzesti.VehiclesStock.Count;


            //var dealerMilitari = new DealerShip();
            //dealerBuzesti
        }
    }
}
