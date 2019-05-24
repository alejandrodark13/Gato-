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
    public partial class Form1 : Form
    {
        //verdadero = x  y falso = o
        bool turno = true;
        bool computadora = false;
        int contTurno = 0;
        
        //static String Jugador1, Jugador2;

        public Form1()
        {
            InitializeComponent();
        }

        /*
        //Cuando se obtienen los nombres de los jugadores en la primer ventana 
        //se igualan a unas variables para poderlas utilizar 
        public static void NombresJugadores(String nombre1, String nombre2)
        {
            Jugador1 = nombre1;
            Jugador2 = nombre2;

        } */

        //cierra la aplicacion
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClicBoton(object sender, EventArgs e)
        {
            //Para jugar con la computadora el nombre del jugador tiene que estar especificados 
            if((tbJugador1.Text == "Jugador 1") || (tbJugador2.Text == "Jugador 2"))
            {
                MessageBox.Show("Debes especificar el nombre de los jugadores para que puedas jugar \n computadora como jugador 2");
            }
            else { 

            //Cuando se le da clic en el boton coloca una X o O y no deja que le 
            //vuelvan a dar clic para cambiar la figura 
            Button b = (Button)sender;
            if (turno)
            {
                b.Text = "X";
            }
            else
                b.Text = "O";

            turno = !turno;
            b.Enabled = false;
            contTurno++;

                //checamos el ganador
                label2.Focus();
                Gandador();
        }
            if((!turno) && (computadora))
            {
                Computadora_mueve();   
            }
     }

        private void Computadora_mueve()
        {
           
            //prioridad 1:  bloquear X
            //prioridad 2:  ir a las esquinas
            //prioridad 3:  seleccionar casillas libres

            Button move = null;

            //Viendo oportunidades
            move = GanarOBloquear("O"); //Observando para ganar
            if (move == null)
            {
                move = GanarOBloquear("X"); //Observando para bloquear
                if (move == null)
                {
                    move = ObservandoEsquinas();
                    if (move == null)
                    {
                        move = EspaciosLibres();
                    }
                }
            }

            move.PerformClick();
        }

        private Button EspaciosLibres()
        {
            Console.WriteLine("Viendo para obtener una casilla");

            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                        return b;
                }
            }

            return null;
        }

        //observa las esquinas libres 
        private Button ObservandoEsquinas()
        {
            Console.WriteLine("Observando las esquinas");
            if (btnA1.Text == "O")
            {
                if (btnA3.Text == "")
                    return btnA3;
                if (btnC3.Text == "")
                    return btnC3;
                if (btnC1.Text == "")
                    return btnC1;
            }

            if (btnA3.Text == "O")
            {
                if (btnA1.Text == "")
                    return btnA1;
                if (btnC3.Text == "")
                    return btnC3;
                if (btnC1.Text == "")
                    return btnC1;
            }

            if (btnC3.Text == "O")
            {
                if (btnA1.Text == "")
                    return btnA3;
                if (btnA3.Text == "")
                    return btnA3;
                if (btnC1.Text == "")
                    return btnC1;
            }

            if (btnC1.Text == "O")
            {
                if (btnA1.Text == "")
                    return btnA3;
                if (btnA3.Text == "")
                    return btnA3;
                if (btnC3.Text == "")
                    return btnC3;
            }

            if (btnA1.Text == "")
                return btnA1;
            if (btnA3.Text == "")
                return btnA3;
            if (btnC1.Text == "")
                return btnC1;
            if (btnC3.Text == "")
                return btnC3;

            return null;
        }


        //marca las casillas con ciertas reglas para que marque en el tablero
        private Button GanarOBloquear(string mark)
        {
            Console.WriteLine("observando ganar o bloquear:  " + mark);
            
            //HORIZONTAL 
            if ((btnA1.Text == mark) && (btnA2.Text == mark) && (btnA3.Text == ""))
                return btnA3;
            if ((btnA2.Text == mark) && (btnA3.Text == mark) && (btnA1.Text == ""))
                return btnA1;
            if ((btnA1.Text == mark) && (btnA3.Text == mark) && (btnA2.Text == ""))
                return btnA2;


            if ((btnB1.Text == mark) && (btnB2.Text == mark) && (btnB3.Text == ""))
                return btnB3;
            if ((btnB2.Text == mark) && (btnB3.Text == mark) && (btnB1.Text == ""))
                return btnB1;
            if ((btnB1.Text == mark) && (btnB3.Text == mark) && (btnB2.Text == ""))
                return btnB2;

            if ((btnC1.Text == mark) && (btnC2.Text == mark) && (btnC3.Text == ""))
                return btnC3;
            if ((btnC2.Text == mark) && (btnC3.Text == mark) && (btnC1.Text == ""))
                return btnC1;
            if ((btnC1.Text == mark) && (btnC3.Text == mark) && (btnC2.Text == ""))
                return btnC2;

            //VERTICAL 
            if ((btnA1.Text == mark) && (btnB1.Text == mark) && (btnC1.Text == ""))
                return btnC1;
            if ((btnB1.Text == mark) && (btnC1.Text == mark) && (btnA1.Text == ""))
                return btnA1;
            if ((btnA1.Text == mark) && (btnC1.Text == mark) && (btnB1.Text == ""))
                return btnB1;

            if ((btnA2.Text == mark) && (btnB2.Text == mark) && (btnC2.Text == ""))
                return btnC2;
            if ((btnB2.Text == mark) && (btnC2.Text == mark) && (btnA2.Text == ""))
                return btnA2;
            if ((btnA2.Text == mark) && (btnC2.Text == mark) && (btnB2.Text == ""))
                return btnB2;

            if ((btnA3.Text == mark) && (btnB3.Text == mark) && (btnC3.Text == ""))
                return btnC3;
            if ((btnB3.Text == mark) && (btnC3.Text == mark) && (btnA3.Text == ""))
                return btnA3;
            if ((btnA3.Text == mark) && (btnC3.Text == mark) && (btnB3.Text == ""))
                return btnB3;

            //DIAGONAL 
            if ((btnA1.Text == mark) && (btnB2.Text == mark) && (btnC3.Text == ""))
                return btnC3;
            if ((btnB2.Text == mark) && (btnC3.Text == mark) && (btnA1.Text == ""))
                return btnA1;
            if ((btnA1.Text == mark) && (btnC3.Text == mark) && (btnB2.Text == ""))
                return btnB2;

            if ((btnA3.Text == mark) && (btnB2.Text == mark) && (btnC1.Text == ""))
                return btnC1;
            if ((btnB2.Text == mark) && (btnC1.Text == mark) && (btnA3.Text == ""))
                return btnA3;
            if ((btnA3.Text == mark) && (btnC1.Text == mark) && (btnB2.Text == ""))
                return btnB2;

            return null;
        }
        private void Gandador()
        {
            bool Tenemos_Un_Ganador = false;

            //Ganador en horizontal
            if ((btnA1.Text == btnA2.Text) && (btnA2.Text == btnA3.Text) && (!btnA1.Enabled))
                Tenemos_Un_Ganador = true;
            else if ((btnB1.Text == btnB2.Text) && (btnB2.Text == btnB3.Text) && (!btnB1.Enabled))
                Tenemos_Un_Ganador = true;
            else if ((btnC1.Text == btnC2.Text) && (btnC2.Text == btnC3.Text) && (!btnC1.Enabled))
                Tenemos_Un_Ganador = true;

            //Ganador en vertical
            else if ((btnA1.Text == btnB1.Text) && (btnB1.Text == btnC1.Text) && (!btnA1.Enabled))
                Tenemos_Un_Ganador = true;
            else if ((btnA2.Text == btnB2.Text) && (btnB2.Text == btnC2.Text) && (!btnA2.Enabled))
                Tenemos_Un_Ganador = true;
            else if ((btnA3.Text == btnB3.Text) && (btnB3.Text == btnC3.Text) && (!btnA3.Enabled))
                Tenemos_Un_Ganador = true;
            
            //Ganador en diagonal
            else if ((btnA1.Text == btnB2.Text) && (btnB2.Text == btnC3.Text) && (!btnA1.Enabled))
                Tenemos_Un_Ganador = true;
            else if ((btnA3.Text == btnB2.Text) && (btnB2.Text == btnC1.Text) && (!btnC1.Enabled))
                Tenemos_Un_Ganador = true;
            

            if (Tenemos_Un_Ganador)
            {

                desactivarBotones();
                String ganador = "";
                if (turno)
                {
                    ganador = tbJugador2.Text;
                    //Suma un 1 cada vez que gana 0
                    GanadoO.Text = (Int32.Parse(GanadoO.Text) + 1).ToString();

                }
                else
                {
                    //Suma un 1 cada vez que gana X
                    ganador = tbJugador1.Text;
                    GanadosX.Text = (Int32.Parse(GanadosX.Text) + 1).ToString();
                }
                  MessageBox.Show(ganador + " " + "Ganaste");
            }
            else
            
                if (contTurno == 9)
                {
                    //Suma un 1 cada vez que hay un empate
                    empates.Text = (Int32.Parse(empates.Text) + 1).ToString();
                    MessageBox.Show("Empate!!!");
                }
            

        }


        //Desactiva los botones una vez que se envia el mensaje del ganador
        private void desactivarBotones()
        {
            
                foreach (Control c in Controls)
                {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = false;

                }
                catch { }
            }
            
        }

        private void NuevoJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Restart();
            //Coloca todos los botones en blanco, practicamente un reset del juego 
            turno = true;
            contTurno = 0;
            
                foreach (Control c in Controls)
                {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }

            }

        }

        //Nombres nada mas 
        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Miguel Alejandro Vazquez Alberto" 
                             +" "+ "y" +" "+"Efrain Jared Ramirez Diaz ");
        }


        //Cuando pase el raton por encima del boton marca  X o O dependiendo del 
        //turno al que le toque y ya no deja seleccionar un boton previamente 
        //seleccionado
        private void BtnRozon(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if (B.Enabled) {
                if (turno)
                    B.Text = "X";
                else
                    B.Text = "O";
            }
        }

        //Cuando el raton sale del area del boton lo vuelve a dejar en blanco 
        private void BtnSalir(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if (B.Enabled)
            {
                B.Text = "";
            }
        }


        //Nada mas coloca las etiquetas con los resultados en 0
        private void resetAlMarcadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GanadosX.Text = "0";
            GanadoO.Text = "0";
            empates.Text = "0";
        }


        //Lanza los nombres por default 
        private void Form1_Load(object sender, EventArgs e)
        {
            jugadoresDefaultToolStripMenuItem.PerformClick();
            /*
            Nombres nom = new Nombres();
            nom.ShowDialog();

            //coloca los nombres en los label del tablero
            label1.Text = Jugador1;
            label3.Text = Jugador2;*/
        }

        private void tbJugador2_TextChanged(object sender, EventArgs e)
        {
            if (tbJugador2.Text.ToUpper() == "COMPUTADORA")
                computadora = true;
            else
                computadora = false;
        }

        //Coloca por default los nombres en los textbox
        private void jugadoresDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbJugador1.Text = "Miguel";
            tbJugador2.Text = "Computadora";
        }
    }
}
