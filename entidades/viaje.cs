using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Viaje
    {
        #region Propiedades

        public string ciudadPartida;
        public string ciudadDestino;
        public DateTime fechaInicio;
        public string matriculaCrucero;
        public int cantCamarotesPremium;
        public int cantCamarotesTurista;
        public double costoDePremium;
        public double costoDeTurista;
        public int duracionDeViaje;
        public bool EsRegional;


        public List<string> ListaDeViajesRegionales = new List<string>()
        {
            "Montevideo (Uruguay)",
            "Ushuaia (Argentina)",
            "Recife (Brasil)",
            "Santiago (Chile)",
            "Lima (Perú)",
            "Isla de Pascua (Chile)",
            "Isla Galápagos (Ecuador)",
            "Puerto Madryn (Argentina)",
            "Río de Janeiro (Brasil)",
            "Cartagena (Colombia)"
        };

        public List<string> ListaDeViajesExtraRegionales = new List<string>()
        {
            "La Habana (Cuba)",
            "Venecia (Italia)",
            "Acapulco (México)",
            "Miami (EE.UU.)",
            "Nueva York (EE.UU.)",
            "Bangkok (Tailandia)",
            "Taipei (Taiwán)",
            "Atenas (Grecia)"
        };



        #endregion

        #region Constructor
        public Viaje(string ciudadPartida, string ciudadDestino, DateTime fechaInicio, string matriculaCrucero,
            int cantidadCamarotes)
        {
            this.EsRegional = ListaDeViajesRegionales.Contains(ciudadDestino);

            this.ciudadDestino = ciudadDestino;
            this.fechaInicio = fechaInicio;
            this.matriculaCrucero = matriculaCrucero;
            this.cantCamarotesTurista = (int)(cantidadCamarotes * 0.65);
            this.cantCamarotesPremium = cantidadCamarotes - this.cantCamarotesTurista;


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


        public List<Equipajes> Equipajes = new List<Equipajes>();

      

        #endregion

        #region Metodos

        #endregion
    }
}
