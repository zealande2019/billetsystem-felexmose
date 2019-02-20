using System;

namespace BilletLibrary
{
    public class bil : baseklasse
    {
        //public string Nummerplade;
        //public DateTime Dato;
        
        public bil(Boolean broBizz)
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
                decimal rabat = Convert.ToDecimal(0.95) * 240;
                return rabat;
            }
            else

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
