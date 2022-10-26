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
    public partial class Estadisticass : Form
    {
        public Estadisticass()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            menu menu = new menu();

            menu.Show();
            this.Hide();
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            menu menu = new menu();

            menu.Show();
            this.Hide();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CrearViaje viajes = new CrearViaje();

            viajes.Show();
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
            Info informacion = new Info();

            informacion.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aca vas a ver");
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Estadisticass_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Harcodeados.listaDeDatosDeCrucero;
            this.dataGridView2.DataSource = Harcodeados.listaDedestinosMasVisitados;
            this.dataGridView3.DataSource = Harcodeados.listaDePasajerosFrecuentes;
        }
    }
}
