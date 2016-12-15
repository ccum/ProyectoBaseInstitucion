using ProyectoBaseInstitucion.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBaseInstitucion.DataConfig
{
    public class AppContexto : DbContext
    {
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
       
    }
}
