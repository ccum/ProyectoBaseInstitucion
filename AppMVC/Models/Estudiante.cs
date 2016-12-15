using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppMVC.Models
{
    public class Estudiante
    {
        public int EstudianteId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public virtual string NombreCompleto
        {
            get { return $"{Nombre} {Apellidos}"; }
        }

    }
}