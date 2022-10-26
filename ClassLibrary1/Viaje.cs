using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Viaje
    {
        #region  propietates


        private string ciudadDePartida;
        private string ciudadDeDestino;
        // public string matriculaDeCrucero;// dentro de crucero
        private DateTime fechaDeInicio;
        private int cantidadDeHabitacionesPremium;
        private int cantidadDeHabitacionesTurista;
        private double costoDePremium;
        private double costoDeTurista;
        private int duracionDeViaje;
        public bool EsRegional;
      
        private int pesoDeBodega;
        private List<Pasajero> _listaPasajero;
        private Crucero crucero;
        private string text;
        private string nickName;
        private DateTime date;
        private Crucero crucero1;
        private EviajesRegionales selectedIndex;

        public string CiudadDePartida { get => ciudadDePartida; set => ciudadDePartida = value; }
        public string CiudadDeDestino { get => ciudadDeDestino; set => ciudadDeDestino = value; }
        public DateTime FechaDeInicio { get => fechaDeInicio; set => fechaDeInicio = value; }
        public int CantidadDeHabitacionesPremium { get => cantidadDeHabitacionesPremium; set => cantidadDeHabitacionesPremium = value; }
        public int CantidadDeHabitacionesTurista { get => cantidadDeHabitacionesTurista; set => cantidadDeHabitacionesTurista = value; }
        public double CostoDePremium { get => costoDePremium; set => costoDePremium = value; }
        public double CostoDeTurista { get => costoDeTurista; set => costoDeTurista = value; }
        public int DuracionDeViaje { get => duracionDeViaje; set => duracionDeViaje = value; }
        public int PesoDeBodega { get => pesoDeBodega; set => pesoDeBodega = value; }
        public string NickName { get => nickName; set => nickName = value; }
        public List<Pasajero> ListaPasajero { get => _listaPasajero; set => _listaPasajero = value; }


        #endregion

        #region  Constructor
        public Viaje(string ciudadDePartida, string ciudadDeDestino, DateTime fechaDeInicio, Crucero crucero)
        {
           

            this.ciudadDeDestino = ciudadDeDestino;
            this.fechaDeInicio = fechaDeInicio;
            this.ciudadDePartida = ciudadDePartida;
            this.nickName = crucero.NickName;
            this.pesoDeBodega = crucero._bodegaKilos;
            this.cantidadDeHabitacionesTurista = (int)(crucero._cantidadDeHabitaciones * 0.65);
            this.cantidadDeHabitacionesPremium = crucero._cantidadDeHabitaciones - this.cantidadDeHabitacionesTurista;
            _listaPasajero = new List<Pasajero>();
            this.crucero = crucero;


            Random random = new Random();
            if (EsRegional)
            {
                this.duracionDeViaje = random.Next(72, 360);
                this.costoDeTurista = duracionDeViaje * 57;
            }
            else
            {
                this.duracionDeViaje = random.Next(480, 720);
                this.costoDeTurista = duracionDeViaje * 120;
            }
            this.costoDePremium = this.costoDeTurista * 1.20;
        }

        public Viaje(string text, DateTime date, Crucero crucero1, EviajesRegionales selectedIndex)
        {
            this.text = text;
            this.date = date;
            this.crucero1 = crucero1;
            this.selectedIndex = selectedIndex;
        }

        private void CalcularPesoDeBodega()
        {
            this.crucero._bodegaKilos = (this.cantidadDeHabitacionesTurista * 25) + (this.cantidadDeHabitacionesPremium * 50);
        }

        #endregion

        #region  Metodos
        public bool AgregarGrupoPasajeros(GrupoDePasajeros grupo)
        {
            var contadorPesos = 0;

            foreach (var pasajero in _listaPasajero)
            {
                contadorPesos += pasajero.Peso();
            }

            var pesoPermitido = false;
            if (contadorPesos + grupo.Peso() <= this.pesoDeBodega)
            {
                pesoPermitido = true;
            }

            var hayLugarPremium = false;
            if (this.cantidadDeHabitacionesPremium > grupo.CantidadDePremium())
            {
                hayLugarPremium = true;
            }

            var hayLugarTurista = false;
            if (this.cantidadDeHabitacionesTurista > grupo.CantidadDeTurista())
            {
                hayLugarTurista = true;
            }



            foreach (var pasajero in grupo.Pasajeros)
            {
                foreach (var item in pasajero.SalonesApetecidos)
                {
                    if (!crucero._EAñadirPasajeros.Contains(item))
                    {
                        return false;
                    }
                }
            }


            if (pesoPermitido && hayLugarPremium && hayLugarTurista)
            {
                foreach (var pasajero in grupo.Pasajeros)
                {
                    _listaPasajero.Add(pasajero);
                }
                return true;
            }

            return false;
        }
        #endregion




    }
}
