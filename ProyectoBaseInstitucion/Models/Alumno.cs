﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBaseInstitucion.Models
{
    public class Alumno: Persona
    {
        public EstadosAlumno Estado { get; set; }
        public string Email { get; set; }
        public string NickName { get; set; }

        public override string ConstruirResumen()
        {
            return $"{NombreCompleto}, {NickName}, {Telefono}";
        }
        public override string NombreCompleto
        {
            get
            {
                return $"{Nombre } {Apellido}";

            }
        }
        //public string ColumnaTest { get; set; }

    }
}
