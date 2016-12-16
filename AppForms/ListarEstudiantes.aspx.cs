using AppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppForms
{
    public partial class ListarEstudiantes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Estudiante> ListaEstudiante = new List<Estudiante>();
            ListaEstudiante.Add(new Estudiante() { Apellidos = "Perez", Nombre = "Juan" });
            ListaEstudiante.Add(new Estudiante() { Apellidos = "Pacheco", Nombre = "Nely" });
            ListaEstudiante.Add(new Estudiante() { Apellidos = "App", Nombre = "Carlos" });
            ListaEstudiante.Add(new Estudiante() { Apellidos = "App2", Nombre = "Fernando" });
            ListaEstudiante.Add(new Estudiante() { Apellidos = "App4", Nombre = "Andres" });

            foreach (var item in ListaEstudiante)
            {
                TableRow fila = new TableRow();
                TableCell CellNombre = new TableCell();
                CellNombre.Text = item.Nombre;
                TableCell CellApellido = new TableCell();
                CellApellido.Text = item.Apellidos;
                fila.Cells.Add(CellApellido);
                fila.Cells.Add(CellNombre);
                tb_listaEstudiantes.Rows.Add(fila);

            }


        }
    }
}