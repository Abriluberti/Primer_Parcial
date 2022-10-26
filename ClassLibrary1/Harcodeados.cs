using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{

    public static class Harcodeados
    {
        public static List<Viaje> listaDeViajes;
        public static List<Crucero> listaDeCruceros;
        public static List<usuario> listaDeUsuarios;
        public static List<Pasajero> listaPasajeros;
        public static List<Recomendaciones> listaDeRecomendaciones;
        public static List<RecomendacionesExtraRegionales> listaDeRecomendacionesExtraRegionales;
        public static List<DatosDeCrucero> listaDeDatosDeCrucero;
        public static List<DestinosMasVisitaodos> listaDedestinosMasVisitados;
        public static List<PasajerosFrecuentes> listaDePasajerosFrecuentes;

       
        static Harcodeados()
        {
            Harcodeados.listaDeUsuarios = new List<usuario>();
            Harcodeados.listaDeCruceros = new List<Crucero>();
            Harcodeados.listaDeViajes = new List<Viaje>();
            Harcodeados.listaPasajeros= new List<Pasajero>();     
            Harcodeados.listaDeDatosDeCrucero = new List<DatosDeCrucero>();
            Harcodeados.listaDedestinosMasVisitados = new List<DestinosMasVisitaodos>();
            Harcodeados.listaDePasajerosFrecuentes = new List<PasajerosFrecuentes>();
            Harcodeados.listaDeRecomendaciones = new List<Recomendaciones>();
            Harcodeados.listaDeRecomendacionesExtraRegionales = new List<RecomendacionesExtraRegionales>();

             

            listaDeUsuarios.Add(new usuario("Abril", "uberti07"));
          listaDeUsuarios.Add(new usuario("Nahuel", "marambio"));
            listaDeUsuarios.Add(new usuario("Gemma", "caraballo01"));
            listaDeUsuarios.Add(new usuario("Facundo", "Garcia16"));

            listaDeCruceros.Add(new Crucero ("PNA-0", "Manilla", 40, 1) );
            listaDeCruceros.Add(new Crucero("BRILA-007", "Memioa", 54, 49937));
            listaDeCruceros.Add(new Crucero("PEP3-03", "Marambio", 39, 87659));
            listaDeCruceros.Add(new Crucero("42-GGFJBJ", "Remoño", 56, 483920));
            listaDeCruceros.Add(new Crucero("Ci-23", "Base", 44, 27389));
            listaDeCruceros.Add(new Crucero("DANYO-65", "Damico", 60, 37892));
            listaDeCruceros.Add(new Crucero("AMSM-450", "Genova", 53, 748392));

            listaDeViajes.Add(new Viaje("Buenos Aires", "La Habana (Cuba)", new DateTime(2022, 09, 05), listaDeCruceros[0]));
            listaDeViajes.Add(new Viaje("Buenos Aires", "Montevideo (Uruguay)", new DateTime(2023, 01, 02), listaDeCruceros[1]));
            listaDeViajes.Add(new Viaje("Buenos Aires", "Nueva York (EE.UU.)", new DateTime(2023, 05, 07), listaDeCruceros[2]));
            listaDeViajes.Add(new Viaje("Buenos Aires", "Santiago (Chile)", new DateTime(2022, 12, 17), listaDeCruceros[3]));
            listaDeViajes.Add(new Viaje("Buenos Aires",  "Atenas(Grecia)", new DateTime(2022, 11, 27), listaDeCruceros[4]));
            listaDeViajes.Add(new Viaje("Buenos Aires", "Puerto Madryn (Argentina)", new DateTime(2022, 12, 07), listaDeCruceros[5]));
            listaDeViajes.Add(new Viaje("Buenos Aires", "Montevideo (Uruguay)", new DateTime(2023, 02, 02), listaDeCruceros[6]));
          
            listaDeViajes[0].ListaPasajero.Add(new Pasajero("Juan", 12, "4232-A72", "Individual", "Botaro"));
            listaDeViajes[1].ListaPasajero.Add(new Pasajero("Nahuel", 19, "3245-A234", "Individual", "Marambio"));
            listaDeViajes[2].ListaPasajero.Add(new Pasajero("Guadalupe", 60, "8945-A234", "Familiar", "Salviati"));
            listaDeViajes[3].ListaPasajero.Add(new Pasajero("Joaquin", 18, "896-A234", "Familiar", "Vianello"));
            listaDeViajes[4].ListaPasajero.Add(new Pasajero("Belen", 19, "769-13456D", "Individual", "Pautazzo"));
            listaDeViajes[5].ListaPasajero.Add(new Pasajero("Rocio", 17, "769-133DE", "Individual", "Bugliavaz"));
            listaDeViajes[6].ListaPasajero.Add(new Pasajero("Micaela", 16, "769-2345KM", "Individual", "Uberti"));

            

            listaDeDatosDeCrucero.Add(new DatosDeCrucero("Manilla", "La Habana (Cuba)", 244566));
            listaDeDatosDeCrucero.Add(new DatosDeCrucero("Remoño", "Santiago (Chile)", 123443));
            listaDeDatosDeCrucero.Add(new DatosDeCrucero("Memioa", "Nueva York (EE.UU.))", 22123));
            listaDeDatosDeCrucero.Add(new DatosDeCrucero("Genova", "Recife (Brasil)", 23456));
            listaDeDatosDeCrucero.Add(new DatosDeCrucero("Base", "Venecia (Italia)", 12345));
            listaDeDatosDeCrucero.Add(new DatosDeCrucero("Damico", "Lima (Perú)", 234));
            listaDeDatosDeCrucero.Add(new DatosDeCrucero("Marambio", "Acapulco (México)", 112));

            listaDedestinosMasVisitados.Add(new DestinosMasVisitaodos("Acapulco (México)", 11223, 245345));
            listaDedestinosMasVisitados.Add(new DestinosMasVisitaodos("Santiago (Chile))", 2345, 23578));
            listaDedestinosMasVisitados.Add(new DestinosMasVisitaodos("Recife (Brasil)", 1345, 21271));
            listaDedestinosMasVisitados.Add(new DestinosMasVisitaodos("Lima (Perú))", 345, 13071));
            listaDedestinosMasVisitados.Add(new DestinosMasVisitaodos("Venecia (Italia)", 45, 11111));

            listaDePasajerosFrecuentes.Add(new PasajerosFrecuentes("Ana", "Mexico", 43223657, 2334));
            listaDePasajerosFrecuentes.Add(new PasajerosFrecuentes("Maria", "Chile", 49223657, 334));
            listaDePasajerosFrecuentes.Add(new PasajerosFrecuentes("Julian", "Brasil", 12723657, 84));
            listaDePasajerosFrecuentes.Add(new PasajerosFrecuentes("Juan", "Italia", 19223657, 32));



            listaDeRecomendaciones.Add(new Recomendaciones("Colonia (Uruguay)", "2x1", "Manilla"));
            listaDeRecomendaciones.Add(new Recomendaciones("Maipu (Chile)", "ALMUERZO GRATUITO", "Remoño"));
            listaDeRecomendaciones.Add(new Recomendaciones("Buenos Aires (Argentina)", "25% EN INSTALACIONES", "Damico"));
            listaDeRecomendaciones.Add(new Recomendaciones("Bahia (Brasil)", "50% EN COMIDAS", "Damico"));
            listaDeRecomendaciones.Add(new Recomendaciones("Botoga (Colombia)", "PACK FAMILIAR", "Remoño"));
            listaDeRecomendaciones.Add(new Recomendaciones("Cuzco (Peru)", "3x2", "Remoño"));
            listaDeRecomendaciones.Add(new Recomendaciones("Galapagos (Ecuador)", "CENA GRATUITA", "Remoño"));


            listaDeRecomendacionesExtraRegionales.Add(new RecomendacionesExtraRegionales(" Villa clara (Cuba)", "2x1", "Manilla"));
            listaDeRecomendacionesExtraRegionales.Add(new RecomendacionesExtraRegionales("Orlando (EE.UU)", "ALMUERZO GRATUITO", "Remoño"));
            listaDeRecomendacionesExtraRegionales.Add(new RecomendacionesExtraRegionales("Islas Jonicas (Grecia)", "25% EN INSTALACIONES", "Damico"));
            listaDeRecomendacionesExtraRegionales.Add(new RecomendacionesExtraRegionales(" Roma (Italia)", "50% EN COMIDAS", "Damico"));
            listaDeRecomendacionesExtraRegionales.Add(new RecomendacionesExtraRegionales("Fujian (Taiwan)", "PACK FAMILIAR", "Remoño"));
            listaDeRecomendacionesExtraRegionales.Add(new RecomendacionesExtraRegionales("  Samut (Tailandia)", "3x2", "Remoño"));
            listaDeRecomendacionesExtraRegionales.Add(new RecomendacionesExtraRegionales(" Cancun (Mexico)", "CENA GRATUITA", "Remoño"));
        }

        

        public static bool Add_Passenger(Pasajero newpassenger)
        {
            bool add = true;

            listaPasajeros.Add(newpassenger);

            return add;
        }
    }

  

}


