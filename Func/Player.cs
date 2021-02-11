using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHeditor
{
    
    public static class Player
    {
        private static int raseID = 0;
        public static int RaseID { get; private set; }
        public static int ProffesionID { get; private set; }




        public static void SetRaceID(int value)
        {
            raseID = value;
        }
        public static void SetProffesionID(int value)
        {
            ProffesionID = value;
        }

    }
}
