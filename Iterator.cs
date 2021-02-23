using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRINCIPAL
{
    public abstract class Iterator
    {
        public abstract object primero();
        public abstract object siguiente();
        public abstract bool EstaHecho();
        public abstract object ElementoActual();
    }
}
