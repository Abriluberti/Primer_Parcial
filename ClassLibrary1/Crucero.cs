using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public class Crucero
    {
        #region  propiedades

        public int Habitaciones
        {
            get
            {
                return this._cantidadDeHabitaciones;
            }
            set
            {
                this._cantidadDeHabitaciones = value;
            }
        }

        public string Matricula
        {
            get
            {
                return this._matricula;
            }
            set
            {
                this._matricula = value;
            }
        }

        public int _bodegaKG { get; internal set; }
        public string NickName { get => _nickName; set => _nickName = value; }
        public static object cruceros { get; set; }

        private string _matricula;
        private string _nickName;   
        public int _cantidadDeHabitaciones;
        public int _bodegaKilos;
        public EEstadosDeViaje estados;
        public List<ESalones> _EAñadirPasajeros = new List<ESalones>();
       
        #endregion

        #region constructor
        public Crucero(string matricula, string nickName, int cantidadDeHabitaciones, int __bodegaKilos)
        {
            this._matricula = matricula;
            this._cantidadDeHabitaciones = cantidadDeHabitaciones;
            this._nickName = nickName;
            this._bodegaKilos = __bodegaKilos;
            _EAñadirPasajeros.Add(ESalones.Comedor);
            this.estados = EEstadosDeViaje.Disponible;
        }



        #endregion
        public void AñadirSalones(ESalones salon)
        {
            _EAñadirPasajeros.Add(salon);
        }
        #region  Metodos
        public int CantidadDeCasinos()
        {
            var contador = 0;
            foreach (var item in _EAñadirPasajeros)
            {
                if (item == ESalones.Casino)
                {
                    contador++;
                }
            }
            return contador;
        }

        public static List<Pasajero> pasajeCruceros;

        public Crucero()
        {
            pasajeCruceros = new List<Pasajero>();
        }

        public static bool AddPasajeroCrucero(Pasajero newPasajeros)
        {
            bool r = true;

            pasajeCruceros.Add(newPasajeros);

            return r;
        }

        #endregion
    }
}


