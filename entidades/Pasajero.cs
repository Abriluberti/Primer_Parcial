using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Pasajero
    {
        #region Propiedades    
        public string apellido;
        public string nickName;
        public int edad;
        public EClases clases;
        public List<Equipajes> Equipajes = new List<Equipajes>();

        #endregion

        #region Constructor
        public Pasajero(string nickName, string apellido, int edad, EClases clases)
        {
            this.nickName = nickName;
            this.apellido = apellido;
            this.edad = edad;
            this.clases = clases;
        }
        #endregion

        #region Metodos
        public bool AgregarEquipaje(Equipajes equipajes)
        {
            var contadorValijas = 0;
            var contadorBolsas = 0;
            foreach (var item in Equipajes)
            {
                if (item.tipoDeEquipaje == ETiposEquipajes.Valija)
                {
                    contadorValijas++;
                }
                else if (item.tipoDeEquipaje == ETiposEquipajes.BolsoDeMano)
                {
                    contadorBolsas++;
                }
            }

            if (equipajes.tipoDeEquipaje == ETiposEquipajes.BolsoDeMano)
            {
                if (contadorBolsas == 0)
                {
                    Equipajes.Add(equipajes);
                    return true;
                }
            }
            else if (equipajes.tipoDeEquipaje == ETiposEquipajes.Valija)
            {
                if (equipajes.peso <= 25)
                {
                    if (this.clases == EClases.Premium && contadorValijas < 2)
                    {
                        Equipajes.Add(equipajes);
                        return true;
                    }
                    if (this.clases == EClases.Turista && contadorValijas == 0)
                    {
                        Equipajes.Add(equipajes);
                        return true;
                    }
                }
            }

            return false;
        }
        #endregion

    }

 

    public class Equipajes
    {
        public ETiposEquipajes tipoDeEquipaje;
        public int peso;

        public Equipajes(ETiposEquipajes tipoDeEquipaje, int peso)
        {
            this.tipoDeEquipaje = tipoDeEquipaje;
            this.peso = peso;
        }
    }
}
