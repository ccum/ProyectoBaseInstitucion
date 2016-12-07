using ProyectoBaseInstitucion.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBaseInstitucion.Models
{
    public abstract class Persona : IEntidad
    {
        public static int ContadorPersona = 0;
        [Key]
        public int PersonaId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }


        public virtual string NombreCompleto
        {
            get { return $"{Nombre} {Apellido}"; }
        }
        public string CodigoInterno { get; set; }
        static Persona()
        {
            ContadorPersona++;
        }
        public abstract string ConstruirResumen();
        public string GenerarLlaveSecreta(string nombreEntidad)
        {
            return new Guid().ToString();
        }
       
    }
}
