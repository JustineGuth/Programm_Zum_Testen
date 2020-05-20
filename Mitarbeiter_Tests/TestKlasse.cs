using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp_Mitarbeit_Personal_Testen;

namespace Mitarbeiter_Tests
{
    [TestFixture]
    public class TestKlasse
    {
        List<MitarbeiterDaten> liste;
        Program program = new Program();
        UserLogin user = new UserLogin();

        [Test]
        public void SollMitarbeiterDatenPrüfen()
        {
            
            liste = program.ListeAllerBentuzer();
            foreach(var x in liste)
            {
                Assert.IsNotNull(x.Id);
                Assert.IsNotNull(x.name);
                Assert.IsNotNull(x.vorname);
                Assert.IsNotNull(x.wohnort);
                Assert.IsNotNull(x.gehalt);
                Assert.IsNotNull(x.alter);
                Assert.IsNotNull(x.geschlecht);
            }
        }

        [Test]
        public void TestLogin()
        {
            string useradmin = user.Login("admin", "admin");
            string user_1 = user.Login("", "");
            string user_2 = user.Login("John", "admin");

            Assert.AreEqual("Willkommen", useradmin);
            Assert.AreEqual("Name oder Passwort darf nicht leer sein", user_1);
            Assert.AreEqual("Name oder Passwort kann nicht gefunden werden", user_2);
        }

        [Test]
        public void SouldGetUserDetails()
        {
            var user = program.GetDatens(783);
            foreach(var x in user)
            {
                Assert.AreEqual(x.Id, 783);
                Assert.AreEqual(x.name, "Vogel");
                Assert.AreEqual(x.vorname, "Maurine");
                Assert.AreEqual(x.geschlecht, "weiblich");
                Assert.AreEqual(x.gehalt, 3500.50);
                Assert.AreEqual(x.wohnort, "Mühldorf");
                Assert.AreNotEqual(x.name, x.vorname);
                Assert.IsFalse();
                Assert.IsTrue();

            }
            
        }

    }
}
