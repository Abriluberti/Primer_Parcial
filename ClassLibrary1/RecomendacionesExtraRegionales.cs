using System;
using System.Collections.Generic;

namespace Entidades
{
    public class RecomendacionesExtraRegionales
    {
        private string destino;
        private string promocion;
        private string nickName;

        public string Destino { get => destino; set => destino = value; }
        public string Promocion { get => promocion; set => promocion = value; }
        public string NickName { get => nickName; set => nickName = value; }

        public RecomendacionesExtraRegionales(string Destino, string Promocion, string NickName)
        {
            this.Destino = Destino;
            this.Promocion = Promocion;
            this.NickName = NickName;     
        }
    }
}


