namespace ShapeLibrary.UnitTests
{
    public class CircleTests
    {
        [Fact]
        public void TheAreaOfCircleWithRadius10IsPImultipleBy50()
        {
            //arrange
            var expectedArea = Math.PI * 10 * 10 / 2; 
            //act
            var area = Circle.Area(10);
            //assert
            Assert.Equal(expectedArea, area);
        }

        [Fact]
        public void TheAreaOfCircleWithRadius0IsPImultipleBy50()
        {
            //act
            var area = Circle.Area(0);
            //assert
            Assert.Equal(0, area);
        }

        [Fact]
        public void ThrowExceptionWhenRadiusLessThen0()
        {
            //act
            var error = Assert.Throws<ArgumentException>(() => Circle.Area(-10));
            //assert
            Assert.Equal($"radius (-10) cannot be less then 0", error.Message);
        }
    }
}