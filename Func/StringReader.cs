using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHeditor
{
    class StringReader
    {
        public static string[] Convert(string s)
        {
            string[] ss;
            ss = s.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries) ;
            return ss;
        }
        public static List<string> orOr(string[] s, out int howMany)
        {
            howMany = 0;
            List<string> oror = new List<string>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Contains("albo "))
                {
                    string[] sshelp;
                    sshelp = s[i].Split(new string[] { "albo " }, StringSplitOptions.RemoveEmptyEntries);
                    oror.Add(sshelp[0]);
                    oror.Add(sshelp[1]);
                    howMany++;
                }
            }         
            return oror;
        }
    }
}
