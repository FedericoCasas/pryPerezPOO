using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPerezPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            ClassPersonaje objeto = new ClassPersonaje();


            objeto.nombre = Convert.ToString(txtNombre.Text);
            objeto.Fuerza = Convert.ToInt32(txtFuerza.Text);
            objeto.Destreza = Convert.ToInt32(txtDestreza.Text);

            lblDatos.Text += objeto.nombre + "-" + objeto.Fuerza + "-" + objeto.Destreza + "\n";
        }
    }
}
