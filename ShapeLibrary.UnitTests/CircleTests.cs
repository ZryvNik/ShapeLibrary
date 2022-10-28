namespace ShapeLibrary.UnitTests
{
    public class CircleTests
    {
        [Fact(DisplayName = "����� Area ������ ������� ������� ����� � �������� 10 ������ PI * 100")]
        public void TheAreaOfCircleWithRadius10IsPImultipleBy100()
        {
            //arrange
            var expectedArea = Math.PI * 10 * 10; 
            //act
            var area = Circle.Area(10);
            //assert
            Assert.Equal(expectedArea, area);
        }

        [Fact(DisplayName = "��� ����� � �������� 0 ������� ����� 0")]
        public void TheAreaOfCircleWithRadius0Is0()
        {
            //act
            var area = Circle.Area(0);
            //assert
            Assert.Equal(0, area);
        }

        [Fact(DisplayName = "���������� ������, ���� ������ ������ 0")]
        public void ThrowExceptionWhenRadiusLessThen0()
        {
            //act
            var error = Assert.Throws<ArgumentException>(() => Circle.Area(-10));
            //assert
            Assert.Equal($"radius (-10) cannot be less then 0", error.Message);
        }
    }
}