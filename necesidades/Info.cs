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
    public partial class Info : Form
    {
       
        public Info()
        {
            InitializeComponent();
        }


        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            menu menu = new menu();

            menu.Show();
            this.Hide();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Harcodeados.listaPasajeros;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            menu menu = new menu();

            menu.Show();
            this.Hide();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CrearViaje viaje = new CrearViaje();

            viaje.Show();
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
            Estadisticass estadisticass = new Estadisticass();

            estadisticass.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Aca vas a poder ver la informacion de los pasajeros");
        }

        private void Info_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Info_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
