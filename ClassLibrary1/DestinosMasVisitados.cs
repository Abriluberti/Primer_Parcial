using System;
using System.Collections.Generic;
using Entidades;

namespace Entidades
{
    public class DestinosMasVisitaodos
    {
        private string destino;
        private int pasajerosTuristas;
        private int pasajerosPremium;

        public string Destino { get => destino; set => destino = value; }
        public int PasajerosTuristas { get => pasajerosTuristas; set => pasajerosTuristas = value; }
        public int PasajerosPremium { get => pasajerosPremium; set => pasajerosPremium = value; }

        public DestinosMasVisitaodos(String destino,int pasajerosTuristas, int pasajerosPremium)
        {
            this.destino = destino;
            this.pasajerosPremium = pasajerosPremium;
            this.PasajerosTuristas = pasajerosTuristas;
        }

    }
}


