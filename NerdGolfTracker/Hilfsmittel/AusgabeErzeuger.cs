#region Copyright
//------------------------------------------------------------------------
// Copyright (C) Siemens AG 2004-2006. All Rights Reserved. Confidential.
//------------------------------------------------------------------------
// Project: Siemens.Simatic.HwConfiguration
// Module : <module>
// File   : AusgabeErzeuger.cs
// Author : Walter Benkö, Siemens AG
//------------------------------------------------------------------------
#endregion

#region Used Namespaces
using System;
using System.Text;

#endregion

namespace NerdGolfTracker.Hilfsmittel
{

    public class AusgabeErzeuger
    {
        public static string s_GesamtErgebnisPattern = "Gesamt: {0}";
        public static string s_Trennzeichen = "=";

        public static string ErzeugeTrenner(int count)
        {
            return ErzeugeTrennPattern(s_Trennzeichen, count);
        }

        public static string GesamtErgebnis(int schlaege)
        {
            return ErzeugeAusgabe(s_GesamtErgebnisPattern, Schlaege(schlaege));
        }
        public static string ErzeugeTrennPattern(string trenner, int count)
        {
            StringBuilder build = new StringBuilder(trenner);
            while (count > 1)
            {
                build.Append(trenner);
                count--;
            }
            return build.ToString();
        }

        private static string s_Schlag = "{0:##} Schlag";
        private static string s_Schlaege = "{0:#0} Schlaege";
        public static string Schlaege(int count)
        {
            string pattern = s_Schlaege;

            if (count == 1)
            {
                pattern = s_Schlag;
            }

            return string.Format(pattern, count);
        }
        public static string ErzeugeAusgabe(string pattern, object value)
        {
            return string.Format(pattern, value);
        }
    }

    
}

#region Copyright
//------------------------------------------------------------------------
// Copyright (C) Siemens AG 2004-2006. All Rights Reserved. Confidential.
//------------------------------------------------------------------------
#endregion
