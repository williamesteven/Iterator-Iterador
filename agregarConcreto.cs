using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PRINCIPAL
{
    public class AgregarConcreto:agregar
    {
        private ArrayList elemento = new ArrayList();
        public override Iterator crearIterador()
        {
            return new interador_conceto(this);
        }
        public int Count
        {
            get { return elemento.Count; }
        }
        public object this[int tamaño]
        {
            get { return elemento[tamaño]; }
            set { elemento.Insert(tamaño, value); }
        }
    }
}
