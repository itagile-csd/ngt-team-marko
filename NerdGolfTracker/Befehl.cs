using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NerdGolfTracker
{
    public abstract class Befehl
    {
        protected abstract string Kommando { get; }
        protected virtual string Kuerzel { get { return string.Empty; }}
        public abstract IOperation Operation { get; }
        protected abstract string Erklaerung { get; }

        public virtual string HilfeText
        {
            get
            {
                string result;
                if (string.IsNullOrWhiteSpace(Kuerzel))
                {
                    result = string.Format(" * \"{0}\" {1}", Kommando, Erklaerung);
                }
                else
                {
                    result = string.Format(" * \"{0} ({2})\" {1}", Kommando, Erklaerung, Kuerzel);
                }
                return result;
            }
        }

        public bool IstZustaendigFuer(string kommando)
        {
            bool result = Kommando == kommando;

            if (!result && ! string.IsNullOrWhiteSpace(Kuerzel))
            {
                result = Kuerzel == kommando;
            }

            return result;
        }
    }
}
