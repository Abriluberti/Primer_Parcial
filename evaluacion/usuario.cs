using System;


namespace evaluacion
{
    public class usuarios
    {
        private string usuario;
        private string password;
        
        public usuarios (string nickName, string contraseña)
        {
            this.usuario = nickName;
            this.password = contraseña;

        }

        public static bool operator == (usuarios primerUsuario, usuarios segundoUsuario)
        {
            bool validacion = false;

            if(primerUsuario is not null && segundoUsuario is not null)
            {
                validacion = primerUsuario.usuario == segundoUsuario.usuario;

            }

            return validacion;
        }
        public static bool operator !=(usuarios primerUsuario, usuarios segundoUsuario)
        {
            return ! (primerUsuario == segundoUsuario);
        }
        internal class Add
        {
        }
    }
}
