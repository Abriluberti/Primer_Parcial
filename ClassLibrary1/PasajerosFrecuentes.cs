using System;
using System.Collections.Generic;
using Entidades;

namespace Entidades
{
    public class PasajerosFrecuentes
    {
        private string nombre;
        private int dni;
        private int cantidadDeViajes;
        private string nacionalidad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Dni { get => dni; set => dni = value; }
        public int CantidadDeViajes { get => cantidadDeViajes; set => cantidadDeViajes = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }

        public PasajerosFrecuentes(string nombre, string nacionalidad, int dni, int cantidadDeViajes)
        {
            this.nombre = nombre;
            this.nacionalidad = nacionalidad;
            this.dni = dni;
            this.cantidadDeViajes = cantidadDeViajes;
        }
    }
}



