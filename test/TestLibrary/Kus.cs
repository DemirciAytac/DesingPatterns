using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class Kus
    {
        public virtual int Fly(int distinc)
        {
            return distinc;
        }
    }
    public class DeveKusu : Kus
    {
    }
}
