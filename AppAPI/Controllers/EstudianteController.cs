using AppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppAPI.Controllers
{
    public class EstudianteController : ApiController
    {

        public Estudiante[] Get()
        {
            List<Estudiante> ListaEstudiante = new List<Estudiante>();
            ListaEstudiante.Add(new Estudiante() { Apellido = "Perez", Nombre = "Juan" });
            ListaEstudiante.Add(new Estudiante() { Apellido = "Pacheco", Nombre = "Nely" });
            ListaEstudiante.Add(new Estudiante() { Apellido = "App", Nombre = "Carlos" });
            ListaEstudiante.Add(new Estudiante() { Apellido = "App2", Nombre = "Fernando" });
            ListaEstudiante.Add(new Estudiante() { Apellido = "App4", Nombre = "Andres" });
            
            return ListaEstudiante.ToArray();
        }
    }
}
