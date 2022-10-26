using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipaje
    {

        public int peso;
        public ETipoDeEquipaje tipoDeEquipaje;
      

        public Equipaje(ETipoDeEquipaje tipoDeEquipaje, int peso)
        {
            this.peso = peso;
            this.tipoDeEquipaje = tipoDeEquipaje;
        }


    }
}
