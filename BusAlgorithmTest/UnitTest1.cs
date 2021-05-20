using algoritmiek_busplantproject2._0;
using System;
using System.Collections.Generic;
using Xunit;

namespace BusAlgorithmTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        [Theory]
        [InlineData(1)]
        [InlineData(4)]
        [InlineData(7)]
        [InlineData(10)]
        public void ReturnBusList(int Id)
        {
            //List<Bus> bussen = new List<Bus>()
            //{
            //    new Bus(1),
            //    new Bus(2),
            //    new Bus(3),
            //    new Bus(4),
            //    new Bus(5),
            //    new Bus(6),
            //    new Bus(7),
            //    new Bus(8),
            //    new Bus(9),
            //    new Bus(10),
            //    new Bus(11),
            //    new Bus(12),
            //    new Bus(13),
            //    new Bus(14),
            //};
            Bus bus = new Bus(Id);
            using (AlgorithmCleaning Algoritme = new AlgorithmCleaning())
                Algoritme.renstester(bus);
            Assert.Equal(MaintenanceType.LongCleaning, bus.Tasks[0].type);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(8)]
        public void ShortCleaningTask(int Id)
        {
            //List<Bus> bussen = new List<Bus>()
            //{
            //    new Bus(1),
            //    new Bus(2),
            //    new Bus(3),
            //    new Bus(4),
            //    new Bus(5),
            //    new Bus(6),
            //    new Bus(7),
            //    new Bus(8),
            //    new Bus(9),
            //    new Bus(10),
            //    new Bus(11),
            //    new Bus(12),
            //    new Bus(13),
            //    new Bus(14),
            //};
            Bus bus = new Bus(Id);
            using (AlgorithmCleaning Algoritme = new AlgorithmCleaning())
                Algoritme.renstester(bus);
            Assert.Equal(MaintenanceType.ShortCleaning, bus.Tasks[0].type);
        }
    }
}
