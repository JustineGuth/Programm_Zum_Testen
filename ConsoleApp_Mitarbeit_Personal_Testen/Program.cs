using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Mitarbeit_Personal_Testen
{
    public class Program
    {


        public List<MitarbeiterDaten> ListeAllerBentuzer()
        {
            List<MitarbeiterDaten> mitarbeiterListe = new List<MitarbeiterDaten>();
            mitarbeiterListe.Add(new MitarbeiterDaten { Id = 123, vorname = "John", name = "Mühler", wohnort = "München", alter = "25", gehalt = 4000, geschlecht = "männlich" });
            mitarbeiterListe.Add(new MitarbeiterDaten { Id = 354, vorname = "Justine", name = "Kirchner", wohnort = "Franfurt", alter = "30", gehalt = 4000, geschlecht = "weiblich" });
            mitarbeiterListe.Add(new MitarbeiterDaten { Id = 253, vorname = "Markus", name = "Liebig", wohnort = "München", alter = "35", gehalt = 3500, geschlecht = "männlich" });
            mitarbeiterListe.Add(new MitarbeiterDaten { Id = 783, vorname = "Maurine", name = "Vogel", wohnort = "Mühldorf", alter = "27", gehalt = 3500.50, geschlecht = "weiblich" });
            mitarbeiterListe.Add(new MitarbeiterDaten { Id = 125, vorname = "Martin", name = "Funk", wohnort = "Hamburg", alter = "45", gehalt = 5000, geschlecht = "männlich" });
            mitarbeiterListe.Add(new MitarbeiterDaten { Id = 789, vorname = "Mathias", name = "Bauer", wohnort = "Bremen", alter = "32", gehalt = 6000, geschlecht = "männlich" });
            return mitarbeiterListe;
        }

        public List<MitarbeiterDaten> GetDatens(int id)
        {   
            List<MitarbeiterDaten> daten = new List<MitarbeiterDaten>();
            Program program = new Program();
            var liste = program.ListeAllerBentuzer();
       
            foreach (var x in liste)
            {
                if (x.Id == id)
                {
                    daten.Add(x);
                }
            }
            return daten;
        }

        static void Main(string[] args)
        {
        }
    }
}
