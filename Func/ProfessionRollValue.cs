using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHeditor
{
    public static class ProfessionRollValue
    {
     
        public static int RollProfessionAndGetID()
        {
            int ID=0;

            int roll = DiceRoll.K_OneHundred();

            do
            {
                if (Player.RaseID ==1 )
                {
                    switch (roll)
                    {
                        case 2:
                            ID = 1;
                            break;
                        case 4:
                            ID = 2;
                            break;
                        case 5:
                            ID = 3;
                            break;
                        case 7:
                            ID = 4;
                            break;
                        case 9:
                            ID = 5;
                            break;
                        case 11:
                            ID = 6;
                            break;
                        case 12:
                            ID = 7;
                            break;
                        case 14:
                            ID = 8;
                            break;
                        case 16:
                            ID = 9;
                            break;
                        case 18:
                            ID = 10;
                            break;
                        case 20:
                            ID = 11;
                            break;
                        case 22:
                            ID = 13;
                            break;
                        case 23:
                            ID = 14;
                            break;
                        case 25:
                            ID = 15;
                            break;
                        case 27:
                            ID = 16;
                            break;
                        case 28:
                            ID = 17;
                            break;
                        case 30:
                            ID = 18;
                            break;
                        case 32:
                            ID = 19;
                            break;
                        case 34:
                            ID = 20;
                            break;
                        case 36:
                            ID = 21;
                            break;
                        case 38:
                            ID = 22;
                            break;
                        case 40:
                            ID = 23;
                            break;
                        case 42:
                            ID = 24;
                            break;
                        case 44:
                            ID = 25;
                            break;
                        case 46:
                            ID = 26;
                            break;
                        case 48:
                            ID = 27;
                            break;
                        case 50:
                            ID = 28;
                            break;
                        case 52:
                            ID = 29;
                            break;
                        case 54:
                            ID = 30;
                            break;
                        case 56:
                            ID = 21;
                            break;
                        case 58:
                            ID = 32;
                            break;
                        case 59:
                            ID = 33;
                            break;
                        case 61:
                            ID = 34;
                            break;
                        case 63:
                            ID = 36;
                            break;
                        case 65:
                            ID = 37;
                            break;
                        case 67:
                            ID = 38;
                            break;
                        case 69:
                            ID = 39;
                            break;
                        case 71:
                            ID = 40;
                            break;
                        case 73:
                            ID = 41;
                            break;
                        case 74:
                            ID = 43;
                            break;
                        case 76:
                            ID = 44;
                            break;
                        case 77:
                            ID = 45;
                            break;
                        case 79:
                            ID = 46;
                            break;
                        case 81:
                            ID = 47;
                            break;
                        case 83:
                            ID = 49;
                            break;
                        case 85:
                            ID = 50;
                            break;
                        case 87:
                            ID = 51;
                            break;
                        case 89:
                            ID = 53;
                            break;
                        case 90:
                            ID = 55;
                            break;
                        case 92:
                            ID = 56;
                            break;
                        case 94:
                            ID = 57;
                            break;
                        case 96:
                            ID = 58;
                            break;
                        case 98:
                            ID = 59;
                            break;
                        case 100:
                            ID = 60;
                            break;
                        default:
                            roll++;
                            break;                              
                    }
                }

                if (Player.RaseID == 2)
                {
                    switch (roll)
                    {
                        case 5:
                            ID = 2;
                            break;
                        case 10:
                            ID = 6;
                            break;
                        case 16:
                            ID = 46;
                            break;
                        case 24:
                            ID = 19;
                            break;
                        case 29:
                            ID = 23;
                            break;
                        case 31:
                            ID = 27;
                            break;
                        case 37:
                            ID = 30;
                            break;
                        case 43:
                            ID = 32;
                            break;
                        case 50:
                            ID = 35;
                            break;
                        case 57:
                            ID = 36;
                            break;
                        case 63:
                            ID = 38;
                            break;
                        case 70:
                            ID = 49;
                            break;
                        case 77:
                            ID = 51;
                            break;
                        case 84:
                            ID = 52;
                            break;
                        case 90:
                            ID = 56;
                            break;
                        case 95:
                            ID = 57;
                            break;
                        case 100:
                            ID = 58;
                            break;
                        default:
                            roll++;
                            break;
                    }
                }

                if (Player.RaseID == 3)
                    {
                        switch (roll)
                        {

                            case 3:
                                ID = 2;
                                break;
                            case 6:
                                ID = 6;
                                break;
                            case 11:
                                ID = 11;
                                break;
                            case 16:
                                ID = 12;
                                break;
                            case 22:
                                ID = 13;
                                break;
                            case 25:
                                ID = 15;
                                break;
                            case 29:
                                ID = 19;
                                break;
                            case 33:
                                ID = 21;
                                break;
                            case 36:
                                ID = 22;
                                break;
                            case 42:
                                ID = 23;
                                break;
                            case 46:
                                ID = 24;
                                break;
                            case 50:
                                ID = 25;
                                break;
                            case 52:
                                ID = 28;
                                break;
                            case 55:
                                ID = 31;
                                break;
                            case 59:
                                ID = 36;
                                break;
                            case 63:
                                ID = 37;
                                break;
                            case 65:
                                ID = 38;
                                break;
                            case 67:
                                ID = 39;
                                break;
                            case 69:
                                ID = 40;
                                break;
                            case 73:
                                ID = 43;
                                break;
                            case 77:
                                ID = 44;
                                break;
                            case 79:
                                ID = 46;
                                break;
                            case 83:
                                ID = 48;
                                break;
                            case 85:
                                ID = 53;
                                break;
                            case 89:
                                ID = 54;
                                break;
                            case 92:
                                ID = 56;
                                break;
                            case 94:
                                ID = 57;
                                break;
                            case 95:
                                ID = 58;
                                break;
                            case 99:
                                ID = 59;
                                break;
                            case 100:
                                ID = 60;
                                break;
                            default:
                                roll++;
                                break;
                        }
                    }

                if (Player.RaseID == 4)
                {
                    switch (roll)
                    {
                        case 3:
                            ID = 2;
                            break;
                        case 5:
                            ID = 5;
                            break;
                        case 8:
                            ID = 6;
                            break;
                        case 9:
                            ID = 7;
                            break;
                        case 14:
                            ID = 15;
                            break;
                        case 20:
                            ID = 16;
                            break;
                        case 25:
                            ID = 19;
                            break;
                        case 27:
                            ID = 20;
                            break;
                        case 29:
                            ID = 21;
                            break;
                        case 31:
                            ID = 22;
                            break;
                        case 35:
                            ID = 23;
                            break;
                        case 40:
                            ID = 24;
                            break;
                        case 42:
                            ID = 27;
                            break;
                        case 45:
                            ID = 28;
                            break;
                        case 48:
                            ID = 29;
                            break;
                        case 53:
                            ID = 30;
                            break;
                        case 56:
                            ID = 31;
                            break;
                        case 57:
                            ID = 33;
                            break;
                        case 58:
                            ID = 34;
                            break;
                        case 63:
                            ID = 36;
                            break;
                        case 68:
                            ID = 39;
                            break;
                        case 72:
                            ID = 40;
                            break;
                        case 74:
                            ID = 41;
                            break;
                        case 78:
                            ID = 42;
                            break;
                        case 82:
                            ID = 44;
                            break;
                        case 83:
                            ID = 47;
                            break;
                        case 86:
                            ID = 50;
                            break;
                        case 90:
                            ID = 51;
                            break;
                        case 96:
                            ID = 56;
                            break;
                        case 98:
                            ID = 57;
                            break;
                        case 100:
                            ID = 59;
                            break;
                            default:
                            roll++;
                            break;
                    }
                }

                if (roll > 101)
                {
                    throw new ArgumentOutOfRangeException();
                }

            } while (ID == 0);

                return ID;
        }
    }
}
