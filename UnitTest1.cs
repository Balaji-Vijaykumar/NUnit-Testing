using MyCalculator;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        

        [Test]
        public void Add()
        {
            Mathematics math = new Mathematics();
            Assert.AreEqual(10, math.Add(5, 5));
        }

        [Test]
        public void Sub()
        {
            Mathematics math = new Mathematics();
            Assert.AreEqual(10, math.Sub(30, 20));

        }

        [Test]
        public void Mul()
        {
            Mathematics math = new Mathematics();
            Assert.AreEqual(6, math.Mul(3, 2));
        }

        [Test]
        public void Div()
        {
            Mathematics math = new Mathematics();
            Assert.AreEqual(4, math.Div(16, 4));
        }

        [Test]
        public void Mod()
        {
            Mathematics math = new Mathematics();
            Assert.AreEqual(1, math.Mod(7, 3));
        }
    }
}