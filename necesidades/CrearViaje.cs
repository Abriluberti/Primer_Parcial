using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Ingreso
{
   
    
    public partial class CrearViaje : Form
    {
        
        List <string> formulario = new List<string>();

   

        public CrearViaje()
        {
            InitializeComponent();
            this.CargaComBoxCruceros();
            this.CargaComBoxRegional();
            this.CargaComBoxExtraRegional();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime inicio = dateTimePicker1.MinDate;
           

        }

        
   
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            menu menu = new menu();

            menu.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int duracion;
            Random aleatorio = new Random();            
            string salida;
            string destino;
            string crucero;
          

            salida = comboBoxRegional.Text;
            destino = comboBoxExtraRegional.Text;
           
           
            
          
            crucero = comboBoxCruceros.Text;
         

            formulario.Add(" Salida: " + salida);
            formulario.Add(" Destino: " + destino);
           
            formulario.Add(" crucero " + crucero);
            
           

            if (this.comboBoxRegional.SelectedItem.ToString() == "REGIONAL" )
            {
                duracion = aleatorio.Next(72, 360);
                formulario.Add("Duracion del viaje: " + duracion);
            }
            else
            {
                if (this.comboBoxExtraRegional.SelectedItem.ToString() == "EXTRA-REGIONAL")
                {
                    duracion = aleatorio.Next(480, 720);
                    formulario.Add("Duracion del viaje: " + duracion + "hrs");
                }

            }
        }

        

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Ventass Ventas = new Ventass();

           Ventas.Show();
            this.Hide();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Info Informacion = new Info();

            Informacion.Show();
            this.Hide();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Estadisticass Estadisticas = new Estadisticass();

            Estadisticas.Show();
            this.Hide();
        }

    

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ViajesCreados viajesDisponibles  = new ViajesCreados();

            viajesDisponibles.Show();
            this.Hide();
        }

      

     

        private void CargaComBoxRegional()
        {
            foreach (EviajesRegionales viajesRegionales in Enum.GetValues(typeof(EviajesRegionales)))//para cada crucero en lista de crucero
            {
                this.comboBoxRegional.Items.Add(viajesRegionales);
                
            }
        }

        

        private void CargaComBoxExtraRegional()
        {
            foreach (EviajesExtraRegionales viajesExtraRegionales in Enum.GetValues(typeof(EviajesExtraRegionales)))//para cada crucero en lista de crucero
            {
                this.comboBoxExtraRegional.Items.Add(viajesExtraRegionales);
            }
        }
        private void CargaComBoxCruceros()
        {
            foreach ( Crucero crucero in Harcodeados.listaDeCruceros)//para cada crucero en lista de crucero
            {
                this.comboBoxCruceros.Items.Add(crucero.NickName);
            }
        }

       

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            ViajesCreados viajescreados = new ViajesCreados();

            viajescreados.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if ((comboBoxRegional.SelectedItem is not null || comboBoxExtraRegional.SelectedItem is not null) && comboBoxCruceros.SelectedItem is not null)

            {
                Viaje nuevoViajeDisponible;
                Crucero SeleccionadoCrucero = null;

                foreach (Crucero cruceroAux in Harcodeados.listaDeCruceros)
                {
                    if(comboBoxCruceros.Text == cruceroAux.NickName)
                    {
                        SeleccionadoCrucero = cruceroAux;
                    }
                }


                if (comboBoxRegional.SelectedItem is not null)
                {
                    nuevoViajeDisponible = new Viaje("Buenos Aires", comboBoxRegional.Text, dateTimePicker1.Value, SeleccionadoCrucero);
                }
                else
                {
                    nuevoViajeDisponible = new Viaje("Buenos Aires", comboBoxExtraRegional.Text, dateTimePicker1.Value, SeleccionadoCrucero);
                }

                Harcodeados.listaDeViajes.Add(nuevoViajeDisponible);
                // Creado.Visible = true;
                // Error.Visible = false;
                MessageBox.Show("Enviado!!");
            }

            else
            {
                MessageBox.Show("NO FUE ENVIADO");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Elige tu tipo de viaje si es regional o extra regional, despues tenes la opcion de cruceros con todos sus nombres disponibles y por ultimo la fecha en la que decida viajar, una vez elegido todo apretas el boton enviar datos y ahi va ser enviado, para poder observado apreta la opcion de arriba que dice viaje disponibles");
        }
    }
}
