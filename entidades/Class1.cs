using System.Collections.Generic;

namespace Entidades
{

    public class Crucero
    {
        #region Propiedades        

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
        public int Camarotes
        {
            get
            {
                return this._cantCamarotes;
            }
            set
            {
                this._cantCamarotes = value;
            }
        }


        private string _matricula;
        private string _nickName;
        public int _cantCamarotes;
        private int _bodegaKG;
        private List<ESalones> _listaSalones = new List<ESalones>();
        #endregion

        #region Constructor
        public Crucero(string matricula, string nombre, int cantidadCamarotes, int bodega)
        {
            this._matricula = matricula;
            this._nickName = nombre;
            this._cantCamarotes = cantidadCamarotes;
            this._bodegaKG = bodega;
            _listaSalones.Add(ESalones.Comedor);
        }
        #endregion

        #region Metodos
        public void AñadirSalones(ESalones salon)
        {
            _listaSalones.Add(salon);
        }

        public int CantidadCasinos()
        {
            var contador = 0;
            foreach (var item in _listaSalones)
            {
                if (item == ESalones.Casino)
                {
                    contador++;
                }
            }
            return contador;
        }
        #endregion

    }
}