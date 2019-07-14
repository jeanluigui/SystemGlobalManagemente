﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xAPI.Entity.Environment
{
    public class Ambiente
    {
        public int Id_Ambiente { get; set; }
        public string Nombre_Ambiente { get; set; }
        public int Piso_Ambiente { get; set; }
        public string Descripcion_Ambiente { get; set; }
        public byte Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public int CreadoPor { get; set; }
        public int ActualizadoPor { get; set; }
    }
}
