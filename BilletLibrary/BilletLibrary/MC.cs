using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class MC : baseklasse
    {
        //public string Nummerplade;
        //public DateTime dato;

            /// <summary>
            /// opretter et MC objekt med info om hvorvidt brobizz haves.
            /// </summary>
            /// <param name="broBizz"></param>
            public MC(Boolean broBizz)
        {
            this.broBizz = broBizz;
        }
            /// <summary>
            /// returns the amount to pay.
            /// </summary>
            /// <returns></returns>
        public override decimal Pris()
        {
            if (broBizz == true)
            {
                decimal rabat = Convert.ToDecimal(0.95) * 125;
                return rabat ;
            }else

            return 125;
        }

        /// <summary>
        /// returns the type of vehichle.
        /// </summary>
        /// <returns></returns>
        public override string køretøj()
        {
            return "MC";
        }
    }
}
