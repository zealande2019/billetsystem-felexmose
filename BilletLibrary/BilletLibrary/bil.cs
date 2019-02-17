using System;

namespace BilletLibrary
{
    public class bil : baseklasse
    {
        //public string Nummerplade;
        //public DateTime Dato;
            
        /// <summary>
        /// returns the amount to pay.
        /// </summary>
        /// <returns></returns>
        public override decimal Pris()
        {
            return 240;
        }

        /// <summary>
        /// returns the type of vehichle.
        /// </summary>
        /// <returns></returns>
        public override string køretøj()
        {
            return "Bil";
        }
    }
}
