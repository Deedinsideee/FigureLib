using NUnit.Framework;
using FigureLibrary.Figures;

namespace TEST2222
{
    public class Tests
    {
        //тест вычисления площади круга
        [Test]
        public void CircleSqr()
        {
            var s = new Circle(6);
            var sqr = s.Square();
            Assert.AreEqual(113.09733552923255, sqr);
        }

        //тест вычисления площади треугольника

        [Test]
        public void TryangleSqr()
        {
            var s = new Triangle(3,4,5);
            var sqr = s.Square();
            Assert.AreEqual(6, sqr);
        }
        //тест на прямоугольный треугольник
        [Test]
        public void PtyamTyangle()
        {
            var s = new Triangle(3, 4, 5);
            var istrue = s.pruamougol;
            Assert.AreEqual(true, istrue);
        }


        // тест на непрямоугольный треугольник
        [Test]
        public void NotPtyamTyangle()
        {
            var s = new Triangle(5, 2, 13);
            var istrue = s.pruamougol;
            Assert.AreEqual(false, istrue);
        }
    }
}