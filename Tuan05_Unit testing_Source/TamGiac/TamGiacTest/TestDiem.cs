using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamGiac;
using NUnit.Framework;

namespace TamGiacTest
{
    [TestFixture]
    public class TestDiem
    {
        [Test]
        public void testHamKhoiTaoMacDinh()
        {
            Diem a = new Diem();
            Assert.AreEqual(0, a.X, "Loi o X");
            Assert.AreEqual(0, a.Y, "Loi o Y");
        }
        [Test]
        public void testHamKhoiTaoCoThamSo()
        {
            Diem a = new Diem(4, 10);
            Assert.AreEqual(4, a.X, "Loi o X");
            Assert.AreEqual(10, a.Y, "Loi o Y");
        }
        [Test]
        public void testHamKhoiTaoBangChuoi()
        {
            Diem a = new Diem("5,8");
            Assert.AreEqual(5, a.X, "Loi o X");
            Assert.AreEqual(8, a.Y, "Loi o Y");
        }
        [Test]
        public void testHamKhoangCach()
        {
            Diem a = new Diem(1,10);
            Diem b = new Diem(8, 6);
            double _kc = a.KhoangCach(b);
            Assert.AreEqual(Math.Sqrt(65), _kc, "Loi Khoang Cach");
        }
        [Test]
        public void testHamToString()
        {
            Diem a = new Diem(2, 6);
            Assert.AreEqual("2,6", a.ToString(), "Loi o ToString");
        }
    }
}
