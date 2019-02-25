using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    /// <summary>
    /// base klasse for bil og Mc.
    /// </summary>
    public abstract class baseklasse
    {

        protected string numberplade;

        /// <summary>
        /// En property der sørger for at nummerpladen ikke er længere end 7 tegn.
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
        /// <summary>
        /// property til at indholde dato og tidspunkt for en givne transaction.
        /// </summary>
        protected DateTime dato = DateTime.Now;

        /// <summary>
        /// property der siger noget om, en givne køretøj har bro bizz eller ej.
        /// </summary>
        public Boolean broBizz;


        public abstract decimal Pris();

        public abstract string køretøj();
    }
}
