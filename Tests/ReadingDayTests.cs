using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Book_Reader_Manager;
using Book_Reader_Manager.Model;
namespace Tests
{
    [TestClass]
    public class ReadingDayTests
    {
        [TestMethod]
        public void testAddOperator()
        {
            Book symfonia1 = new Book("Symfonia C++ tom 1", 450);
            Book symfonia2 = new Book("Symfonia C++ tom 2", 500);

            ReadingDay day = ReadingDay.Get(2014, 10, 5);
            for (int i = 0; i < 10; ++i)
            {
                symfonia1.addReading(5);
                symfonia1.addReading(2);
            }
            //day = day + symfonia1;// +symfonia2;
            Console.WriteLine("Test");
        }
    }
}
