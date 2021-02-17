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
        public static List<string> Abilites { get; private set; } = new List<string>();
        public static List<string> Skills { get; private set; } = new List<string>();
        public static List<string> EQ { get; private set; } = new List<string>();
        public static List<string> NextProf{ get; private set; } = new List<string>();

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
        public static void SetAbilites (string[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                Abilites.Add(s[i]);
            }
        }
        public static void SetSkills(string[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                Skills.Add(s[i]);
            }
        }
        public static void SetEQ(string[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                EQ.Add(s[i]);
            }
        }
        public static void SetNextProf(string[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                NextProf.Add(s[i]);
            }
        }
    }




}
