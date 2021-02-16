using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHeditor
{
    
    public static class Player
    {

        public static int RaseID { get; private set; }
        public static int ProffesionID { get; private set; }

        public static int[] Attributes { get; set; } = new int[16];

        public static void SetRaceID(int value)
        {
            RaseID = value;
        }
        public static void SetProffesionID(int value)
        {
            ProffesionID = value;
        }

        public static void SetAttributes(int[]at)
        {
            for (int i = 0; i < 16; i++)
            {
                Attributes[i] = at[i];
            }
        }
        public static void SetOneAttribute(int at, int value)
        {
            Attributes[at] = value;
        }

    }




}
