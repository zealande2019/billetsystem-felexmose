using System;

namespace BilletLibrary
{
    public class Bil
    {
        public string Nummerplade;
        public DateTime Dato;
            
        /// <summary>
        /// returns a fixed price 240.
        /// </summary>
        /// <returns></returns>
        public static decimal Pris()
        {
            return 240;
        }

        /// <summary>
        /// return a string Bil.
        /// </summary>
        /// <returns></returns>
        public static string køretøj()
        {
            return "Bil";
        }
    }
}
