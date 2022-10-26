using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pasaporte
    {
        #region Propietates

        public int numero;
        public string nombre;
        public string sexo;
        public string apellido;
        public int nacimiento;
        public int edad;
        public int dni;
        public string domicilio;
        public string country;
        #endregion

        #region Constructor
        public Pasaporte(int numero, string nombre, string sexo, string apellido,int nacimiento, int edad, int dni, string domicilio, string country)
        {
            Random random = new Random();
            this.numero = random.Next(1000, 999999);
            this.nacimiento = nacimiento;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
            this.domicilio = domicilio;
            this.sexo = sexo;
            this.country = country;

        }
        #endregion

        #region Metodos


        #endregion



    }
}