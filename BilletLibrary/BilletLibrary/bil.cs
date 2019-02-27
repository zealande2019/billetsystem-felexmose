using System;

namespace BilletLibrary
{
    /// <summary>
    /// bil klassen med nedarvning fra baseklassen.
    /// </summary>
    public class bil : baseklasse
    {
            /// <summary>
            /// opretter en bil objekt med info om hvorvidt brobizz haves.
            /// </summary>
            /// <param name="broBizz"></param>
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
            decimal prisen = 240;

            //DayOfWeek day = dato.DayOfWeek;
            //string dayToday = day.ToString();
            if ((dato.DayOfWeek.ToString() == "Saturday") || (dato.DayOfWeek.ToString() == "Sunday"))
            {
                prisen = Convert.ToDecimal(0.80) * 240;
            }   
            if (broBizz == true)
            {
                decimal rabat = Convert.ToDecimal(0.95) * prisen;
                return rabat;
            }
            else

                return prisen;
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
