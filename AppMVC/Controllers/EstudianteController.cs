using AppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppMVC.Controllers
{
    public class EstudianteController : Controller
    {
        // GET: Estudiante
        public ActionResult Index()
        {

            Estudiante estu = new Estudiante();
            estu.Nombre = "Juan";
            estu.Apellidos = "Perez";

            return View(estu);
        }

        public ActionResult ListaEstudiantes()
        {
            List<Estudiante> listaEst = new List<Estudiante>();
            Estudiante estu1 = new Estudiante(){Nombre = "Eduardo", Apellidos = "APpellidos" } ;
            Estudiante estu2 = new Estudiante() { Nombre = "Karla",  Apellidos ="Pacheco"};
            listaEst.Add(estu1);
            listaEst.Add(estu2);
            return View(listaEst);
        }


    }
}