using Ingreso;
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

namespace necesidades
{
    public partial class FormEntrada : Form
    {
       
        public FormEntrada()
        {

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var user in Harcodeados.listaDeUsuarios)
            {
                if (tb_user.Text.ToString() == user.usuarios && tb_pass.Text.ToString() == user.Contraseña)
                {
                    menu Inicio = new menu();
                    this.Hide();
                    Inicio.Show();
                    
                }
            }
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Inicie su usuario y su contraseña, las opciones de usuario son Abril, Nahuel, Gemma y Facundo");
        }
    }
}
