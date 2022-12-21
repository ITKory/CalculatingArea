using AreaLibrary;

namespace UnitTest
{
    public class UnitTest
    {
        [Fact]
        public void TriangleArea()
        {
            Triangle triangle = new(6, 8, 10);
            Assert.Equal(24, triangle.Area);
        }
        [Fact]
        public void TriangleIsRight()
        {
            Triangle triangle = new(12, 16, 20);
            Assert.True(triangle.ISRightTriangle());
        }
        [Fact]
        public void TriangleIsNotRight()
        {
            Triangle triangle = new(122, 16, 20);
            Assert.False(triangle.ISRightTriangle());
        }
        [Fact]
        public void CircleArea()
        {
            Circle circle = new (11);
            Assert.Equal(380,(int)circle.Area);
        }
        [Fact]
        public void RectangleArea()
        {
            Rectangle circle = new(12,6);
            Assert.Equal(72,circle.Area);
        }
    }
}