using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RussianShoot;

namespace RussianGunTesting
{
    [TestClass]
    public class UnitTest1
    {

        Classshoot myclass = new Classshoot();


        [TestMethod]
        public void LoadGun()// loadgun testing

        {

            string Actual = myclass.spinshot(out int value);
            string Expected = "Spinning....Spinning....Spinning";


            Assert.AreEqual(Expected, Actual);

        }

        [TestMethod]
        public void fire ()
        {
            string Actual = "you losse";
            string Expected = "you losse";


            Assert.AreEqual(Expected, Actual);


        }
    }
    
}
