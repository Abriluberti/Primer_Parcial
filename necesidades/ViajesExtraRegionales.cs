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
    public partial class ViajesExtraRegionales : Form
    {
        public ViajesExtraRegionales()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void ViajesExtraRegionales_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Harcodeados.listaDeRecomendacionesExtraRegionales;
        }

        private void ViajesExtraRegionales_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ViajesExtraRegionales_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((MessageBox.Show("SE VA A CERRAR ", "Aviso.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
