
using ProyectoBaseInstitucion.DataConfig;
using ProyectoBaseInstitucion.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBaseInstitucion
{
    class Program
    {
        private static object a1;

        static void Main(string[] args)
        {
            Console.WriteLine("Clase 5");
            //ConsultaArchivoYLinq();

            AppContexto db = new AppContexto();

            List<Profesor> listarProfesores = new List<Profesor>();
            string[] lineasArchivo = File.ReadAllLines("./Files/listasProfesores.txt");
            foreach (string item in lineasArchivo)
            {
                Profesor profe = new Profesor();
                string[] arrayNombres = item.Split(' ');
                profe.Apellido = $"{arrayNombres[1]} {arrayNombres[2]} ";
                profe.CodigoInterno = arrayNombres[0];
                switch (arrayNombres.Length)
                {
                    case 4:
                        profe.Nombre = arrayNombres[3];
                        break;
                    case 5:
                        profe.Nombre = $"{arrayNombres[3]} {arrayNombres[4]} ";
                        break;
                    default:
                        break;
                }
   
                listarProfesores.Add(profe);

            }

            db.Profesores.AddRange(listarProfesores);
            db.SaveChanges();
            Console.WriteLine("Termino");
            Console.ReadKey();

        }

        



        //private List<Profesor>  listarrPorfesoresDesrFile()
        //{
        //    string[] lineasText = File.ReadAllLines("./Files/listasProfesores.txt");

        //    List<Profesor> ListaProfesores = new List<Profesor>();

        //    foreach (string item in lineasText)
        //    {
        //        Profesor profe = new Profesor();
        //        string[] arrayNombres = item.Split(' ');
        //        profe.Apellido = $"{arrayNombres[1]} {arrayNombres[2]} ";
        //        profe.CodigoInterno = arrayNombres[0];
        //        switch (arrayNombres.Length)
        //        {
        //            case 4:
        //                profe.Nombre = arrayNombres[3];
        //                break;
        //            case 5:
        //                profe.Nombre = $"{arrayNombres[3]} {arrayNombres[4]} ";
        //                break;
        //            default:
        //                break;
        //        }
        //        ListaProfesores.Add(profe);

        //    }



        //    //var archivo = File.Open("nuevoArchivo.bin", FileMode.OpenOrCreate);
        //    //var wrapper = new BinaryWriter(archivo);

        //    //foreach (var item in ListaProfesores)
        //    //{
        //    //    //var dataNombre = Encoding.UTF8.GetBytes(item.NombreCompleto);
        //    //    //archivo.Write(dataNombre,0 , dataNombre.Length)
        //    //    wrapper.Write(item.NombreCompleto);
        //    //    Console.WriteLine($"CODIGO {item.CodigoInterno} NOMBRE: {item.NombreCompleto}");
        //    //}



        //    var consulta = from prof in ListaProfesores
        //                   where prof.Nombre.Contains("J")
        //                   select prof.Nombre;

        //    var consulta2 = ListaProfesores.Where(e => e.Nombre.StartsWith("J"));

        //    foreach (var item in consulta2)
        //    {
        //        Console.WriteLine(item.Nombre);
        //    }
        //}
    }
}
