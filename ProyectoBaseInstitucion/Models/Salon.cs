using ProyectoBaseInstitucion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBaseInstitucion.Models
{
    class Salon : IEntidad
    {
        public string CodigoInterno
        {
            get;
            set;

        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public string GenerarLlaveSecreta(string nombreEntidad)
        {
            return "SAL ON";
        }
    }
}
