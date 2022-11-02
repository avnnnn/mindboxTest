using mindboxTest;

namespace Tests
{
    public class TriangleTest
    {
        [Theory]
        [InlineData(-1,2,3)]
        [InlineData(1,-2,3)]
        [InlineData(1,2,-3)]
        [InlineData(1,2,0)]
        public void ZeroOrNegativeEdge(double var1,double var2, double var3)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(var1, var2, var3));
        }
        [Theory]
        [InlineData(3, 4, 10)]
        [InlineData(6, 8, 20)]
        public void IsTriangle(double var1, double var2, double var3)
        {

            Assert.Throws<ArgumentException>(() => new Triangle(var1, var2, var3));
        }
        [Theory]
        [InlineData(3,4,5,6)]
        [InlineData(6,8,10,24)]
        public void Area(double var1, double var2, double var3, double var4)
        {
            var triangle = new Triangle(var1, var2, var3);
            var area = triangle.GetArea();
            var expectedArea = var4;
            Assert.Equal(area, expectedArea);  
        }
        [Theory]
        [InlineData(3, 4, 5, true)]
        [InlineData(6, 8, 10, true)]
        [InlineData(3, 4, 6, false)]
        [InlineData(6, 8, 12, false)]
        public void IsRightTriangle(double var1, double var2, double var3, bool expectedResult)
        {
            var triangle = new Triangle(var1, var2, var3);
            var isRight = triangle.isRightTriangle();
            Assert.Equal(isRight, expectedResult);
        }

        
    }
}