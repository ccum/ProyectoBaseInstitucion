using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBaseInstitucion.Interfaces
{
    interface IEntidad
    {
        string CodigoInterno { get; set; }
        string GenerarLlaveSecreta(string nombreEntidad);
    }
}
