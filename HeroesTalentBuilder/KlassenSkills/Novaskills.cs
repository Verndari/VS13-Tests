using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesTalentBuilder.KlassenSkills
{
    class Novaskills
    {

        public const string heckenschuetze = "Heckenschütze:" + "\n" +
            "\n" +
            "Scharfschütze verursacht 20% mehr Schaden," + "\n" +
            "wenn die Fähigkeit im getarnten Zustand oder" + "\n" +
            "innerhalb einer Sek. nach der Enttarnung eingestzt wird.";

        public const string energiesammeln = "Energie sammeln:" + "\n" +
                    "\n" +
                    "Gewährt passiv 8% Fähigkeitsstärke. Jeder getötete" + "\n" +
                    "gegnerische Held erhöht die Fähigkeitsstärke um" + "\n" +
                    "2%, bis zu 12%. Diese zusätzliche Fähigkeitsstärke" + "\n" +
                    "geht beim Tod verloren.";

        public const string panzerbrechendemunition = "Panzerbrechende Munition:" + "\n" +
                "\n" +
                "Automatische Angriffe erfolgen dreimal langsamer," + "\n" +
                "verursachen aber 300% Schaden.";
    
        public const string praezisionsschlag = "Präzisionsschlag:" + "\n" +
                "Abklingzeit: 60 Sek." + "\n" +
                "\n" +
                "Verursacht nach einer Verzögerung von 3 Sek. 335" + "\n" +
                "Schaden im Wirkungsbereich. Unbegrenzte Reichweite.";

        public const string verbessertetarnung = "Verbesserte Tarnung (Eigenschaft):" + "\n" +
                "\n" +
                "Im getarnten Zustand ist die" + "\n" +
                "Bewegungsgeschwindigkeit um 25% erhöht und die" + "\n" +
                "Abklingzeit von Grundfähigkeiten sind 25% schneller.";

        public const string verkrueppelnderschuss = "Verkrüppelnder Schuss:" + "\n" +
                "\n" +
                "Gegner, die vom Beeinträchtigenden Schuss" + "\n" +
                "getroffen werden, erleiden für die Dauer der" + "\n" +
                "Verlangsamung 25% mehr Schaden.";

        public const string blitzschlagdessturms = "Blitzschlag des Sturms:" + "\n" +
               "Abklingzeit: 40 Sek." + "\n" +
               "\n" +
               "Aktivieren, um zu einem Ort in der Nähe" + "\n" +
               "teleportiert zu werden.";
    }    
}
