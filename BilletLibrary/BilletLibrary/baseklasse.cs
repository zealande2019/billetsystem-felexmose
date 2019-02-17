using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public abstract class baseklasse
    {
        protected string numberplade;

        /// <summary>
        /// nummerplade, skal ikke være længere end 7 tegn.
        /// </summary>
        public string Nummerplade
        {
            get { return numberplade; }
            set
            {
                if (value.Length <= 7)
                    numberplade = value;
                else
                    throw new ArgumentException($"Nummerplade må ikke være længer end 7 tegn, du skrev {value.Length} tegn");
            }
        }

        protected DateTime dato;

        public abstract decimal Pris();

        public abstract string køretøj();
    }
}
