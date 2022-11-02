using mindboxTest;

namespace Tests
{
    public class CircleTest
    {
        [Fact]
        public void ZeroRadius()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
        }
        [Fact]
        public void NegativeRadius()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }
        [Fact]
        public void Area()
        {
            var r = 4;
            var expectedArea = Math.Pow(r, 2) * Math.PI;
            var circle = new Circle(r);

            var area = circle.GetArea();

            Assert.Equal(expectedArea, area);
        }
    }
}