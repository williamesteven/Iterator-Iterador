using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRINCIPAL
{
    public  class interador_conceto:Iterator
    {
        private AgregarConcreto agregar;
        private int actual = 0;

        public interador_conceto(AgregarConcreto agregar)
        {

       
            this.agregar = agregar;

        }
        public override object primero()
        {
            return agregar[0];
        }
        public override object siguiente()
        {
            object ret = null;

            if (actual < agregar.Count - 1)
            {
                ret = agregar[++actual];
            }
            return ret;
        }
        public override object ElementoActual()
        {
            return agregar[actual];

        }
        public override bool EstaHecho()
        {
            return actual >= agregar.Count ? true : false;
        }

    }
}
