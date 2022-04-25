using NUnit.Framework;
using FigureLibrary.Figures;

namespace TEST2222
{
    public class Tests
    {
        //���� ���������� ������� �����
        [Test]
        public void CircleSqr()
        {
            var s = new Circle(6);
            var sqr = s.Square();
            Assert.AreEqual(113.09733552923255, sqr);
        }

        //���� ���������� ������� ������������

        [Test]
        public void TryangleSqr()
        {
            var s = new Triangle(3,4,5);
            var sqr = s.Square();
            Assert.AreEqual(6, sqr);
        }
        //���� �� ������������� �����������
        [Test]
        public void PtyamTyangle()
        {
            var s = new Triangle(3, 4, 5);
            var istrue = s.pruamougol;
            Assert.AreEqual(true, istrue);
        }


        // ���� �� ��������������� �����������
        [Test]
        public void NotPtyamTyangle()
        {
            var s = new Triangle(5, 2, 13);
            var istrue = s.pruamougol;
            Assert.AreEqual(false, istrue);
        }
    }
}