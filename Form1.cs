using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRINCIPAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        AgregarConcreto obj_agregar = new AgregarConcreto();
        int c = 0;

        public void ingresar()
        {
            obj_agregar[c] = txt_elemento.Text;

        }
        public void mostrar()
        {
            interador_conceto obj_iterador = new interador_conceto(obj_agregar);
            object Lista = obj_iterador.primero();
            dgv_elemento.Rows.Clear();
            while (Lista != null)
            {
                dgv_elemento.Rows.Add(Lista);
                Lista = obj_iterador.siguiente();

            }



        }

        public void Limpiar() {

            txt_elemento.Clear();

        
        }


        


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ingresar();
            c++;
            Limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mostrar();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
