using necesidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingreso

{
    public partial class menu : Form
    {
        public string nickName;

        public menu()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lb_mensaje.Text = "Bienvenida a Sea Experience " + nickName;
            Fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            CrearViaje viajes = new CrearViaje();

            MessageBox.Show("Aca vas a poder crear los viajes o ver los viajes disponibles");
            viajes.Show();
            this.Hide();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            Ventass ventas = new Ventass();

            MessageBox.Show("Aca vas a poder vender");
            ventas.Show();
            this.Hide();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            
                Info informacion = new Info();

            MessageBox.Show("Vas a poder ver la informacion de los pasajeros ");
            informacion.Show();
                this.Hide();
            
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Estadisticass estadisticas = new Estadisticass();

            MessageBox.Show("Vas a ver las estadisticas historicas ");
            estadisticas.Show();
            this.Hide();

        }

   
        private void button5_Click(object sender, EventArgs e)
        {
            FormEntrada registro = new FormEntrada();
            MessageBox.Show("Vas al volver al Registro ");
            registro.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Recomendaciones recomendaciones = new Recomendaciones();
            MessageBox.Show("Vas a ver ciertas promos y recomedaciones, exitos! ");

            recomendaciones.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al Menu, aca tenes distintas opciones ");
        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmMenu_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if ((MessageBox.Show("¿Seguro que desea cerrar el programa?", "Aviso.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
