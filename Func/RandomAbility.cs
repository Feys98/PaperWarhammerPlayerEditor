using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHeditor
{
    public static class RandomAbility
    {
        public static string Run(int ID)
        {
            string str = "NULL";

            int roll = DiceRoll.K_OneHundred();
            do
            {
                if (ID == 1)
                {
                    switch (roll)
                    {
                        case 4:
                            str = "bardzo silny";
                            break;
                        case 9:
                            str = "bardzo szybki";
                            break;
                        case 13:
                            str = "blyskotliwy";
                            break;
                        case 18:
                            str = "bystry wzrok";
                            break;
                        case 22:
                            str = "charyzmatyczny";
                            break;
                        case 27:
                            str = "czuły sluch";
                            break;
                        case 31:
                            str = "geniusz arytmetyczny";
                            break;
                        case 35:
                            str = "krzepki";
                            break;
                        case 40:
                            str = "naśladowca";
                            break;
                        case 44:
                            str = "niezwykle odporny";
                            break;
                        case 49:
                            str = "obureczny";
                            break;
                        case 53:
                            str = "odpornosc na choroby";
                            break;
                        case 57:
                            str = "odpornosc na magie";
                            break;
                        case 61:
                            str = "odpornosc na trucizny";
                            break;
                        case 66:
                            str = "odpornosc psychiczna";
                            break;
                        case 71:
                            str = "opanowanie";
                            break;
                        case 75:
                            str = "strzelec wyborowy";
                            break;
                        case 79:
                            str = "szczescie";
                            break;
                        case 83:
                            str = "szosty zmysl";
                            break;
                        case 87:
                            str = "szybki refleks";
                            break;
                        case 91:
                            str = "twardziel";
                            break;
                        case 95:
                            str = "urodzony wojownik";
                            break;
                        case 100:
                            str = "widzenie w ciemnosci";
                            break;
                        default:
                            roll++;
                            break;
                    }
                }
                else if (ID == 4)
                {
                    switch (roll)
                    {
                        case 4:
                            str = "bardzo silny";
                            break;
                        case 9:
                            str = "bardzo szybki";
                            break;
                        case 13:
                            str = "blyskotliwy";
                            break;
                        case 18:
                            str = "bystryy wzrok";
                            break;
                        case 23:
                            str = "charyzmatyczny";
                            break;
                        case 28:
                            str = "czuły sluch";
                            break;
                        case 34:
                            str = "geniusz arytmetyczny";
                            break;
                        case 39:
                            str = "krzepki";
                            break;
                        case 44:
                            str = "naśladowca";
                            break;
                        case 49:
                            str = "niezwykle odporny";
                            break;
                        case 53:
                            str = "obureczny";
                            break;
                        case 58:
                            str = "odpornosc na choroby";
                            break;
                        case 62:
                            str = "odpornosc na magie";
                            break;
                        case 64:
                            str = "odpornosc na trucizny";
                            break;
                        case 68:
                            str = "odpornosc psychiczna";
                            break;
                        case 73:
                            str = "opanowanie";
                            break;
                        case 78:
                            str = "strzelec wyborowy";
                            break;
                        case 82:
                            str = "szczescie";
                            break;
                        case 87:
                            str = "szosty zmysl";
                            break;
                        case 92:
                            str = "szybki refleks";
                            break;
                        case 96:
                            str = "twardziel";
                            break;
                        case 100:
                            str = "urodzony wojownik";
                            break;
                        default:
                            roll++;
                            break;
                    }
                }
                else
                {
                    str = "";
                }
            } while (str == "NULL");
            return str;
        }
    }
}
