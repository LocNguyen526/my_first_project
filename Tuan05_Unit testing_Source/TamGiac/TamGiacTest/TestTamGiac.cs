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
    public class TestTamGiac
    {
        [Test]
        public void testHamKhoiTaoMacDinh()
        {
            TamGiac.TamGiac a = new TamGiac.TamGiac();
            Assert.AreEqual(0, a.A.X, "Hoanh Do x Diem A sai");
            Assert.AreEqual(0, a.A.Y, "Tung Do Y Diem A sai");
            Assert.AreEqual(0, a.B.X, "Hoanh Do x Diem B sai");
            Assert.AreEqual(0, a.B.Y, "Tung Do Y Diem B sai");
            Assert.AreEqual(0, a.C.X, "Hoanh Do x Diem C sai");
            Assert.AreEqual(0, a.C.Y, "Tung Do Y Diem C sai");
        }
        [Test]
        public void testHamKhoiTaoCoThamSo()
        {
            Diem a = new Diem(-2, 3);
            Diem b = new Diem(4, 1);
            Diem c = new Diem(1, 4);
            TamGiac.TamGiac tg = new TamGiac.TamGiac(a,b,c);
            Assert.AreEqual(-2, tg.A.X, "Hoanh Do x Diem A sai");
            Assert.AreEqual(3, tg.A.Y, "Tung Do Y Diem A sai");
            Assert.AreEqual(4, tg.B.X, "Hoanh Do x Diem B sai");
            Assert.AreEqual(1, tg.B.Y, "Tung Do Y Diem B sai");
            Assert.AreEqual(1, tg.C.X, "Hoanh Do x Diem C sai");
            Assert.AreEqual(4, tg.C.Y, "Tung Do Y Diem C sai");
        }
        [Test]
        public void testHamChuVi()
        {
            Diem a = new Diem(-2, 3);
            Diem b = new Diem(4, 1);
            Diem c = new Diem(1, 4);
            TamGiac.TamGiac tg = new TamGiac.TamGiac(a, b, c);
            double ab = a.KhoangCach(b);
            double ac = a.KhoangCach(c);
            double bc = b.KhoangCach(c);
            double _chuvi = ab + ac + bc;
            Assert.AreEqual(_chuvi, tg.ChuVi(),"Loi chu vi");
        }
        [Test]
        public void testHamLoaiTamGiac()
        {
            Diem a = new Diem(-2, 3);
            Diem b = new Diem(4, 1);
            Diem c = new Diem(1, 4);
            TamGiac.TamGiac tg = new TamGiac.TamGiac(a, b, c);
            Assert.AreEqual(-1, tg.LoaiTamGiac(), "Khong phai tam giac");
            Assert.AreEqual(0, tg.LoaiTamGiac(), "Tam giac Thuong");
            Assert.AreEqual(1, tg.LoaiTamGiac(), "Tam giac deu");
            Assert.AreEqual(2, tg.LoaiTamGiac(), "Tam giac can");
        }
    }
}
