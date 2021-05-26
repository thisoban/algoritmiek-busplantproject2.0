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
            Bus bus = new Bus(Id);
            using (AlgorithmCleaning Algoritme = new AlgorithmCleaning())
                Algoritme.renstester(bus);
            Assert.Equal(MaintenanceType.ShortCleaning, bus.Tasks[0].type);
        }
    }
}
