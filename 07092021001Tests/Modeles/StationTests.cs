using Microsoft.VisualStudio.TestTools.UnitTesting;
using _07092021001.Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07092021001.Modeles.Tests
{
    [TestClass()]
    public class StationTests
    {
        [TestMethod()]
        public void getIdTest()
        {
            ///Jeu d'essai
            Station S1 = new Station(1, "emplacement1");
            ///Methode
            int resultat = S1.getId();
            ///Assert
            Assert.AreEqual(1, resultat);
        }
    }
}