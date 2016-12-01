﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBaseInstitucion.Models
{
    class Alumno: Persona
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
                return base.NombreCompleto.ToUpper();
            }
        }
    }
}
