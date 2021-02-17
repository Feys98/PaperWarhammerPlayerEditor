using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHeditor
{
    public static class Debugs
    {
        public static void OutOfRollRange(int roll)
        {
            Debug.Assert(roll > 100, "OutOfRollRange!");
        }
        public static void OutOfRaseIDRange(int RaseID)
        {
            Debug.Assert(RaseID > 4, "OutOfRaseIDRange");
        }
        public static void OutOfProfessionRoll(int profID)
        {
            Debug.Assert(profID == 0, "WrongProfesionID!");
        }
    }
}

}
