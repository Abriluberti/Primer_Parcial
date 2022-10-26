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
    public partial class ViajesRegionales : Form
    {
        public ViajesRegionales()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Harcodeados.listaDeRecomendaciones;
        }

        private void ViajesRegionales_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ViajesRegionales_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((MessageBox.Show("SE VA A CERRAR ¿", "Aviso.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}


