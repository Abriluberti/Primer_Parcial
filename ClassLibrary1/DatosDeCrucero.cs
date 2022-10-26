using System;
using System.Collections.Generic;
using Entidades;

namespace Entidades
{
    public class DatosDeCrucero
    {
        private string Nombre;
        private string DestinosMasFamoso;
        private int CantidadDeHoras;

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string DestinosMasFamoso1 { get => DestinosMasFamoso; set => DestinosMasFamoso = value; }
        public int CantidadDeHoras1 { get => CantidadDeHoras; set => CantidadDeHoras = value; }


      public DatosDeCrucero(String Nombre, String DestinosMasFamoso, int CantidadDeHoras)
        {
            this.CantidadDeHoras = CantidadDeHoras;
            this.Nombre = Nombre;
            this.DestinosMasFamoso = DestinosMasFamoso;
        }

    }
}


