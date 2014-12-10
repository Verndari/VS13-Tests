using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesTalentBuilder.KlassenSkills
{
    class VallaSkills
    {
        public const string kompositpfeil = "Kompositpfeile:" + "\n" +
            "\n" +
            "Erhöht die Reichweite des Mehrfachschusses um 20%.";

        public const string arsenal = "Arsenal:" + "\n" +
            "\n" +
            "Mehrfachschuss feuert zusätzlich 3 Granaten ab," + "\n" +
            "die 35 Schaden verursachen.";

        public const string eiferdesgefechts = "Eifer des Gefechts:" + "\n" +
            "\n" +
            "Automatische Angriffe verringern die Abklingzeit" + "\n" +
            "von Fähigkeiten um 0.5 Sek.";

        public const string sperrfeuer = "Sperrfeuer:" + "\n" +
            "Abklingzeit: 60 Sek." + "\n" +
            "\n" +
            "Greift sichtbar Gegner in der Nähe schnell an und" + "\n" +
            "fügt ihnen 15 Schaden pro Treffer zu, wobei Helden" + "\n" +
            "gegenüber Dienern Priorität erhalten. Während des" + "\n" +
            "Sperrfeuers kann sich Valla bewegen und Saltos" + "\n" +
            "ausführen. Hält 4 Sek. an.";

        public const string frostschuss = "Frostschuss:" + "\n" +
            "\n" +
            "Mehrfachschuss verlangsamt Gegner zusätzlich 2" + "\n" +
            "Sek. lang um 40%.";

        public const string blutfuerblut = "Blut für Blut:" + "\n" +
            "Abklingzeit: 60 Sek." + "\n" +
            "\n" +
            "Aktivieren, um 15% der maximalen Lebenspunkte" + "\n" +
            "des Ziels zu stehlen und seine" + "\n" +
            "Bewegungsgeschwindigkeit 3 Sek. lang um 30% zu" + "\n" +
            "verringern.";

        public const string blitschlagdessturms = "Blitzschlag des Sturms:" + "\n" +
                "Abklingzeit: 40 Sek." + "\n" +
                "\n" +
                "Aktivieren, um zu einem Ort in der Nähe" + "\n" +
                "teleportiert zu werden.";


        public const string groll = "Groll (Eigenschaft):" + "\n" +
                "\n" +
                "Jeder Stapel Hass erhöht die" + "\n" +
                "Angriffsgeschwindigkeit um 1,5%.";

        public const string mantikor = "Mantikor:" + "\n" +
                "\n" +
                "Jeder 3. aufeinanderfolgende automatische Angriff" + "\n" +
                "auf dasselbe Ziel verursacht 50% zusätzlichen schaden.";

        public const string sengendeangriffe = "Sengende Angriffe:" + "\n" +
                "Abklingzeit: 25 Sek." + "\n" +
                "\n" +
                "Aktivieren, um den Schaden automatischer" + "\n" +
                "Angriffe 5 Sek. lang um 50% zu erhöhen. Kostet 15" + "\n" +
                "Mana pro Angriff.";

        public const string rachehagel = "Rachehagel:" + "\n" +
                "Abklingzeit: 90 Sek." + "\n" +
                "\n" +
                "Erzeugt 2 Wellen aus Schattenbestien, die Gegnern" + "\n" +
                "im Zielbereich 100 Schaden zufügen und sie pro" + "\n" +
                "Welle 0,5 Sek. lang betäuben.";
        
        public const string zauberschild = "Zauberschild:" + "\n" +
                "\n" +
                "Verringert nach dem Erleiden von Schaden 2 Sek." + "\n" +
                "lang jeglichen durch Fähigkeiten erlittenen Schaden" + "\n" +
                "um 50%. Kann nur einmal alle 30 Sek. ausgelöst werden.";
    }
}
