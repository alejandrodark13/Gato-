using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gato
{
    public partial class Nombres : Form
    {
        public Nombres()
        {
            InitializeComponent();
        }

        //Se obtiene los nombres ingresados en los texbox y cierra la ventana
        private void btnPlay_Click(object sender, EventArgs e)
        {
            //Form1.NombresJugadores(tbJugador1.Text, tbJugador2.Text);
            this.Close();
        }
    }
}
