using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroesTalentBuilder.KlassenSkills
{
    class JainaSkills
    {
        public const string eiseskaelte = "Eiseskälte (Eigenschaft):" + "\n" +
                "\n" +
                "Erhöht die Verlangsamung durch Unterkühlungen" + "\n" +
                "von 25% auf 35%.";

        public const string frostsplitter = "Frostsplitter:" + "\n" +
                "\n" +
                "Frostblitz durchschlägt das erste Ziel und kann" + "\n" +
                "danach ein zweites treffen.";

        public const string eislanze = "Eislanze:" + "\n" +
                "\n" +
                "Die Abklingzeit von Frostblitz wird um 2 Sek." + "\n" +
                "verringert, wenn ein unterkühltes Ziel getroffen wird.";

        public const string wasserelementar = "Wasserelementar:" + "\n" +
                "Abklingzeit 80 Sek." + "\n" +
                "\n" +
                "Ruft ein Wasserelementar am Zielort herbei, verursacht" + "\n" +
                "50 Schaden und unterkühlt Gegner in der Nähe. Die" + "\n" +
                "automatischen Angriffe des Wasserelementars verursachen" + "\n" +
                "25% Flächenschaden und unterkühlen Gegner im Umkreis.";

        public const string eisigeadern = "Eisige Adern:" + "\n" +
                "\n" +
                "Aktivieren, um die Abklingzeit von" + "\n" +
                "Grundfähigkeiten um das Dreifache zu" + "\n" +
                "beschleunigen und ihre Manakosten 5 Sek. lang um" + "\n" +
                "50% zu verringern.";

        public const string schneidenderwind = "Schneidender Wind:" + "\n" +
                "\n" +
                "Macht getroffene Gegner besonders verwundbar," + "\n" +
                "was ihren erlittenen Schaden 2 Sek. lang um 25% erhöht.";

        public const string altvatarwinder = "Altvater Winter:" + "\n" +
                "\n" +
                "Der Wasserelementar imitiert jetzt die Fähigkeiten" + "\n" +
                "Fristblitz, Blizzard und Kältekegel, wobei er 50%" + "\n" +
                "des ursprünglichen Schadens verursacht. Die" + "\n" +
                "Einsatzreichweite erhöht sich um 50%.";


        public const string griffdeswinters = "Griff des Winters:" + "\n" +
                "\n" +
                "Erhöht die Reichweite von Frostblitz um 30%.";

        public const string vergiften = "Vergiften:" + "\n" +
                "Abklingzeit: 60 Sek." + "\n" +
                "\n" +
                "Aktivieren, um einen gegnerischen Held zu" + "\n" +
                "vergiften und ihm im Verlauf von 6 Sek. 120" + "\n" +
                "Schaden zuzufügen.";

        public const string ringdesfrosts = "Ring des Frosts:" + "\n" +
                "Abklingzeit: 100 Sek." + "\n" +
                "\n" +
                "Erzeugt nach einer kurzen Verzögerung einen Ring" + "\n" +
                "des Frosts am Zielort, der 200 Schaden verursacht" + "\n" +
                "und Gegner 3 Sek. lang bewegungsunfähig macht." + "\n" +
                "Der Ring bleibt danach 3 Sek. lang bestehen und" + "\n" +
                "unterkühlt Gegner, die mit ihm in Berührung kommen.";

        public const string verbessertereisblock = "Verbesserter Eisblock:" + "\n" +
                "Abklingzeit: 80 Sek." + "\n" +
                "\n" +
                "Aktivieren, um den Helden in einem Eisblock" + "\n" +
                "einzuschließen, der ihn 3 Sek. lang unverwundbar" + "\n" +
                "macht. Nach Ablauf werden alle Gegner in der" + "\n" +
                "Nähe unterkühlt.";

        public const string kaltefuesse = "Kalte Füße:" + "\n" +
                "\n" +
                "Kältekegel betäubt unterkühlte Gegner 1 Sek. lang.";

        public const string blitschlagdessturms = "Blitzschlag des Sturms:" + "\n" +
                "Abklingzeit: 40 Sek." + "\n" +
                "\n" +
                "Aktivieren, um zu einem Ort in der Nähe" + "\n" +
                "teleportiert zu werden.";
    }
}
