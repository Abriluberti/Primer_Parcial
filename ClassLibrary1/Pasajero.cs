
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public class Pasajero
    {
        #region Propiedades


        private string apellido;
        public EClase clase;
        private string name;
        private int age;
        public string passport;
        private string tipoDeGrupo;

        public List<ESalones> SalonesApetecidos = new List<ESalones>();
        public List<Equipaje> Equipajes = new List<Equipaje>();
        public List<EAñadirPasajeros> pasajeros = new List<EAñadirPasajeros>();

        public string Apellido { get => apellido; set => apellido = value; }
        public string Name { get => name; set => name = value; }

        public string TipoDeGrupo { get => tipoDeGrupo; set => tipoDeGrupo = value; }
        public int Age { get => age; set => age = value; }


        #endregion



        public Pasajero(string name, int age, string passport, string tipoDeGrupo, string Apellido)
        {
            this.name = name;
            this.Apellido = Apellido;
            this.age = age;
            this.passport = passport;
            this.tipoDeGrupo = tipoDeGrupo;


        }

        #region Constructor
     

        public int Peso()
        {
            var peso = 0;
            foreach (var item in Equipajes)
            {
                peso += item.peso;
            }
            return peso;
        }
        public bool AñadirEquipaje(Equipaje equipaje)
        {
            var contadorDeBolsaMano = 0;
            var contadorDeValijas = 0;
            foreach (var item in Equipajes)
            {
                if (item.tipoDeEquipaje == ETipoDeEquipaje.BolsoDeMano)
                {
                    contadorDeBolsaMano++;
                }
                 
                else if (item.tipoDeEquipaje == ETipoDeEquipaje.Valija)
                {
                    contadorDeValijas++;
                }
            }

            if (equipaje.tipoDeEquipaje == ETipoDeEquipaje.BolsoDeMano)
            {
                if (contadorDeBolsaMano == 0)
                {
                    Equipajes.Add(equipaje);
                    return true;
                }
            }
            else if (equipaje.tipoDeEquipaje == ETipoDeEquipaje.Valija)
            {
                if (equipaje.peso <= 25)
                {
                    if (this.clase == EClase.Premium && contadorDeValijas < 2)
                    {
                        Equipajes.Add(equipaje);
                        return true;
                    }
                    if (this.clase == EClase.Turista && contadorDeValijas == 0)
                    {
                        Equipajes.Add(equipaje);
                        return true;
                    }
                }
            }
            return false;
        }

       

        #endregion



    }

  
}
