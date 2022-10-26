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
    public partial class Recomendaciones : Form
    {
        public Recomendaciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            ViajesRegionales viajesregionales = new ViajesRegionales();

            viajesregionales.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViajesExtraRegionales viajesExtraRegionales = new ViajesExtraRegionales();

            viajesExtraRegionales.Show();

            this.Hide();
        }

        private void Recomendaciones_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aca vas a tener que elegir que promos te gustaria dependiendo a regionales o extra");
        }

        private void Recomendaciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Recomendaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((MessageBox.Show("SE VA A CERRAR ", "Aviso.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
