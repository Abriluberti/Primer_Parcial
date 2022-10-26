using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class GrupoDePasajeros
    {
        #region Propietates

        public List<Pasajero> Pasajeros = new List<Pasajero>();

        #endregion

        #region Constructor
        public GrupoDePasajeros(List<Pasajero> lista)
        {
            this.Pasajeros = lista;
        }

        public int CantidadDePremium()
        {
            var cantidad = 0;
            foreach (var pasajero in Pasajeros)
            {
                if (pasajero.clase == EClase.Premium)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
        public int Peso()
        {
            var peso = 0;
            foreach (var pasajero in Pasajeros)
            {
                peso += pasajero.Peso();
            }
            return peso;
        }

     
        public int CantidadDeTurista()
        {
            var cantidad = 0;
            foreach (var pasajero in Pasajeros)
            {
                if (pasajero.clase == EClase.Turista)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }


        #endregion

    }
}