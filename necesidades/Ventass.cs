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
    public partial class Ventass : Form
    {

    
        public Ventass()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            menu menu = new menu();

            menu.Show();
            this.Hide();

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
            Info informacion = new Info();

            informacion.Show();
            this.Hide();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Estadisticass estadisticas = new Estadisticass();

            estadisticas.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViajesCreados viajesDisponible = new ViajesCreados();


            viajesDisponible.name = this.textBox2.Text;
            viajesDisponible.pasaporte = this.textBox4.Text;
            viajesDisponible.edad = this.textBox3.Text;
            viajesDisponible.Apellido = this.textBox5.Text;
          

            if (comboBox1.SelectedItem != null)
            {
                viajesDisponible.tipoDeMiembro = comboBox1.SelectedItem.ToString();
               
                viajesDisponible.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error, eliga alguna opcion de miembros");
            }
            
                  
        }

       
        private void Ventass_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("NO, SOLO USAR LETRAS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("NO, SOLO NUMEROS!!!!!!!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("NO, SOLO NUMEROS!!!!!!!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Ventass_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Ventass_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((MessageBox.Show("SE VA A CERRAR", "Aviso.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
