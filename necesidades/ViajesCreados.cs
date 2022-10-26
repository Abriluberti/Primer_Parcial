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

    public partial class ViajesCreados : Form
    {
        private int n = 0;
        public string name;
        public string edad;
        public string dni;
        public string Apellido;
        public string pasaporte;
        public string tipoDeMiembro;
        private Pasajero addPasajero;
        private Crucero listCruceros;

        public ViajesCreados()
        {
            InitializeComponent();
         
            this.listCruceros = new Crucero();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = dataGridViajes.Rows.Count;  i < Harcodeados.listaDeViajes.Count; i ++ )
            {
                this.dataGridViajes.Rows.Add(Harcodeados.listaDeViajes[i]);
            }
          
        }
    
        private void Form7_Load(object sender, EventArgs e)
        {
            this.dataGridViajes.DataSource = Harcodeados.listaDeViajes;
         
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Ventass ventas = new Ventass();
            this.addPasajero = new Pasajero(name.ToString(), int.Parse(edad), pasaporte.ToString(), tipoDeMiembro.ToString(), Apellido.ToString());
            Harcodeados.Add_Passenger(this.addPasajero);
            if (Crucero.AddPasajeroCrucero(addPasajero))
            {
                MessageBox.Show("EL VIAJE ESTA AGREGADO");

            }
            this.DialogResult = DialogResult.OK;
        }

       

        private void dataGridViajes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            menu menu = new menu();

            menu.Show();
            this.Hide();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CrearViaje crearViajes = new CrearViaje();

            crearViajes.Show();
            this.Hide();

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Ventass ventas = new Ventass();

            ventas.Show();
            this.Hide();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Estadisticass estadisticas = new Estadisticass();

            estadisticas.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Aca vamos a observar la lista de viajes creados, ademas te habilitara un boton para que selecciones el viaje cuando estes vendiendo, NO USAR AHORA");
            this.button2.Visible = true;

        }

    }
}
