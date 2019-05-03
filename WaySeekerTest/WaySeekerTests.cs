using NUnit.Framework;
using SeekWayLib;

namespace SeekWayLibTest
{
    [TestFixture]
    public class WaySeekerTests
    {
        [Test]
        public void Test1()
        {
            var values = new[] 
            {
                "1 2 3",
                "4 5 6",
                "7 8 9"
            };
            var way = WaySeeker.Main(values);

         Assert.AreEqual(way, 987456321);
        }

        [Test]
        public void Test2()
        {
            var values = new[] 
            {
                "7 8 9",
                "1 2 3",
                "4 5 6"
            };
            var way = WaySeeker.Main(values);
            Assert.AreEqual(way, 987145632);
        }

        [Test]
        public void Test3()
        {
            var values = new[] 
            {
                "7 8 9",
                "1 2 3",
                "4 5 6"
            };
            var way = WaySeeker.Main(values);
            Assert.AreEqual(way, 987145632);
        }

        [Test]
        public void Test4()
        {
            var values = new[]
            {
                "1 2 3",
                "9 6 8",
                "4 5 7"
            };
            var way = WaySeeker.Main(values);
            Assert.AreEqual(way, 786549123);
        }

        [Test]
        public void Test5()
        {
            var values = new[]
            {
                "1 2 4",
                "9 6 5",
                "8 3 7"
            };
            var way = WaySeeker.Main(values);
            Assert.AreEqual(way, 896375421);
        }

        [Test]
        public void Test6()
        {
            var values = new[]
            {
                "6 7 8",
                "4 9 3",
                "2 1 5"
            };
            var way = WaySeeker.Main(values);
            Assert.AreEqual(way, 978351246);

        }

        [Test]
        public void Test7()
        {

            var values = new[]
            {
                "9 4 8",
                "7 5 3",
                "2 1 6"
            };
            var way = WaySeeker.Main(values);
            Assert.AreEqual(way, 975483612);

        }




    }
}
