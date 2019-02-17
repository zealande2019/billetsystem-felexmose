using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public abstract class baseklasse
    {
        protected string Nummerplade;
        protected DateTime dato;

        public abstract decimal Pris();

        public abstract string køretøj();
    }
}
