namespace ShapeLibrary.UnitTests
{
    public class TriangleTests
    {
        [Theory(DisplayName = "Возвращает верное значение площади треугольника")]
        [InlineData(2000000000000000000000.0, 1500000000000000000000.0, 700000000000000000000.0, 4.2E+41)]
        [InlineData(3.0, 4.0, 5.0, 6.0)]
        public void TheAreaOfTriangleWithDefinedSidesIs(double a, double b, double c, double expectedArea)
        {
            //act
            var area = Triangle.Area(a, b, c);
            //assert
            Assert.Equal(expectedArea, area);
        }

        [Theory(DisplayName = "Метод IsRightangle возвращает true если треугольник прямоугольный")]
        [InlineData(3.0, 4.0, 5.0)]
        [InlineData(60.0, 80.0, 100.0)]
        public void TriangleIsRightangled(double a, double b, double c)
        {
            //act
            var isRightangle = Triangle.IsRightangle(a, b, c);
            //assert
            Assert.True(isRightangle);
        }

        [Theory(DisplayName = "Метод IsRightangle возвращает false, если треугольник не прямоугольный")]
        [InlineData(13.0, 14.0, 15.0)]
        [InlineData(64.0, 81.0, 111.0)]
        public void TriangleIsNotRightangled(double a, double b, double c)
        {
            //act
            var isRightangle = Triangle.IsRightangle(a, b, c);
            //assert
            Assert.False(isRightangle);
        }

        [Theory(DisplayName = "Возвращает true если треугольник прямоугольный, независимо от того в каком порядке были заданы величины сторон")]
        [InlineData(3.0, 4.0, 5.0)]
        [InlineData(4.0, 5.0, 3.0)]
        [InlineData(5.0, 4.0, 3.0)]
        public void SameResultIfSwapParameters(double a, double b, double c)
        {
            //act
            var isRightangle = Triangle.IsRightangle(a, b, c);
            //assert
            Assert.True(isRightangle);
        }

        [Theory(DisplayName = "Ошибка, если значение a меньше нуля")]
        [InlineData(0.0)]
        [InlineData(-1.0)]
        public void ThrowExceptionWhenSideALessOrEqual0(double a)
        {
            //act
            var error = Assert.Throws<ArgumentException>(() => Triangle.Area(a, 5, 6));
            //assert
            Assert.Equal($"a ({a}) cannot be less or equal 0", error.Message);
        }

        [Theory(DisplayName = "Ошибка, если значение b меньше нуля")]
        [InlineData(0.0)]
        [InlineData(-1.0)]
        public void ThrowExceptionWhenSideBLessOrEqual0(double b)
        {
            //act
            var error = Assert.Throws<ArgumentException>(() => Triangle.Area(5, b, 6));
            //assert
            Assert.Equal($"b ({b}) cannot be less or equal 0", error.Message);
        }

        [Theory(DisplayName = "Ошибка, если значение c меньше нуля")]
        [InlineData(0.0)]
        [InlineData(-1.0)]
        public void ThrowExceptionWhenSideCLessOrEqual0(double c)
        {
            //act
            var error = Assert.Throws<ArgumentException>(() => Triangle.Area(5, 6, c));
            //assert
            Assert.Equal($"c ({c}) cannot be less or equal 0", error.Message);
        }

        [Fact(DisplayName = "Ошибка, если значение a больше чем сумма b и c")]
        public void ThrowExceptionWhenASideMoreThenSumOfBSideAndCSide()
        {
            //arrange
            var a = 20;
            var b = 10;
            var c = 5;
            //act
            var error = Assert.Throws<ArgumentException>(() => Triangle.Area(a, b, c));
            //assert
            Assert.Equal($"a ({a}) cannot be more or equal b + c ({b + c})", error.Message);
        }

        [Fact(DisplayName = "Ошибка, если значение b больше чем сумма a и c")]
        public void ThrowExceptionWhenBSideMoreThenSumOfASideAndCSide()
        {
            //arrange
            var a = 10;
            var b = 20;
            var c = 5;
            //act
            var error = Assert.Throws<ArgumentException>(() => Triangle.Area(a, b, c));
            //assert
            Assert.Equal($"b ({b}) cannot be more or equal a + c ({a + c})", error.Message);
        }

        [Fact(DisplayName = "Ошибка, если значение c больше чем сумма b и a")]
        public void ThrowExceptionWhenCSideMoreThenSumOfASideAndBSide()
        {
            //arrange
            var a = 5;
            var b = 10;
            var c = 20;
            //act
            var error = Assert.Throws<ArgumentException>(() => Triangle.Area(a, b, c));
            //assert
            Assert.Equal($"c ({c}) cannot be more or equal b + a ({b + a})", error.Message);
        }
    }
}
