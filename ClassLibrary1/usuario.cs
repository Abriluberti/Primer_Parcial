using System;
using System.Collections.Generic;
using Entidades;
namespace Entidades
{
    public class usuario
    {
        public string usuarios;
        public string contraseña;

        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Usuarios { get => usuarios; set => usuarios = value; }

        public usuario(string usuarios, string contraseña)
        {
            this.usuarios = usuarios;
            this.contraseña = contraseña;
        }

       
    }
}


