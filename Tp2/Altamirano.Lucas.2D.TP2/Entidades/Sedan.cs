﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        public enum ETipo { CuatroPuertas, CincoPuertas }
        ETipo tipo;


        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        /// 
        
        public Sedan(EMarca marca, string chasis, ConsoleColor color,ETipo tipo)
            : base(marca, chasis, color)
        {
            tipo = ETipo.CuatroPuertas;
        }
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
           : base(marca, chasis, color)
        {

        }

        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TAMAÑO : {this.Tamanio} TIPO:{ this.tipo}\n");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
