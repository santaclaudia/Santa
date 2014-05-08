using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculatorv1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTambah()
        {
            MainWindow satu=new MainWindow();
            double a1=3;
            double a2=3;
            double result=satu.tambah(a1,a2);
            double hasil=6;

            Assert.AreEqual(hasil,result,"salah");


        }

        [TestMethod]
        public void TestKurang()
        {
            MainWindow satu=new MainWindow();
            double b3=6;
            double b4=3;
            double result=satu.kurang(b3,b4);
            double hasil=3;

            Assert.AreEqual(hasil,result,"salah");


        }

        [TestMethod]
        public void TestKali()
        {
            MainWindow satu=new MainWindow();
            double a1=6;
            double a2=3;
            double result = satu.kali(a1, a2);
            double hasil=18;

            Assert.AreEqual(hasil,result,"salah");


        }

        [TestMethod]
        public void TestBagi()
        {
            MainWindow satu=new MainWindow();
            double a1=3;
            double a2=3;
            double result = satu.bagi(a1, a2);
            double hasil=1;

            Assert.AreEqual(hasil,result,"salah");


        }
    }
}
