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
            /// returns the amount to pay.
            /// </summary>
            /// <returns></returns>
        public override decimal Pris()
        {
            return 125;
        }

        /// <summary>
        /// returns the type of vehichel
        /// </summary>
        /// <returns></returns>
        public override string køretøj()
        {
            return "MC";
        }
    }
}
