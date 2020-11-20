using System;
using Comision;
using interfaz;

namespace controladora
{
    class Ccontroladora
    {
        static void Main()
        {

            CAlumnos nuevo;
            nuevo = new CAlumnos();
            ulong legajo;
            string nombre;
            string apellido;
            float beca;
            float cuotageneral;

         
              string opc = CInterfaz.darOpcion().ToUpper();

               while (opc != "S")
               {
                   if (opc == "C")
                   {
                       Console.WriteLine("***********************************************");
                       Console.WriteLine("*               Cuota General                 *");
                       Console.WriteLine("***********************************************");
                       Console.Write("Ingrese el valor de la cuota general: ");
                       cuotageneral = float.Parse(Console.ReadLine());
                       CAlumnos.SetCuota(cuotageneral);
                       CInterfaz.mostrarInfo("Cuota general establecida exitosamente.");

                   }

                   if (opc == "G")
                   {
                       Console.WriteLine("***********************************************");
                       Console.WriteLine("*               Cuota General                 *");
                       Console.WriteLine("***********************************************");
                       CInterfaz.mostrarInfo("La cuota General es: " + CAlumnos.GetCuota().ToString());
                   }

                   if (opc == "A")
                   {  
                       Console.WriteLine("***********************************************");
                       Console.WriteLine("*               Agregar Alumno                *");
                       Console.WriteLine("***********************************************");
                       Console.Write("Ingrese Legajo: ");
                       legajo = ulong.Parse(Console.ReadLine());
                       Console.Write("Ingrese Nombre: ");
                       nombre = Console.ReadLine();
                       Console.Write("Ingrese Apellido: ");
                       apellido = Console.ReadLine();
                       Console.Write("Ingrese el porcentaje de la Beca: ");
                       beca = float.Parse(Console.ReadLine());

                      if( nuevo.CrearAlumno(legajo, nombre, apellido, beca) == true )
                      {
                         CInterfaz.mostrarInfo("Alumno creado exitosamente.");
                      }
                      else
                      {
                          CInterfaz.mostrarInfo("Ya existe un alumno con el legajo ingresado.");
                      }

                   }

                   if (opc == "M")
                   {
                       Console.WriteLine("***********************************************");
                       Console.WriteLine("*          Buscar Alumno por Legajo           *");
                       Console.WriteLine("***********************************************");
                       Console.Write("Ingrese numero de legajo: ");
                      legajo = ulong.Parse(Console.ReadLine());

                       CInterfaz.mostrarInfo(nuevo.DarDatos(legajo));
                   }

                   if (opc == "L")
                   {
                       Console.WriteLine("***********************************************");
                       Console.WriteLine("*          Listado de Alumnos Ordenados       *");
                       Console.WriteLine("***********************************************");
                       CInterfaz.mostrarInfo(nuevo.DarDatos());
                   }

                   if (opc == "R")
                   {
                       Console.WriteLine("***********************************************");
                       Console.WriteLine("*          Eliminar Alumno por Legajo         *");
                       Console.WriteLine("***********************************************");
                       Console.Write("Ingrese numero de legajo: ");
                       legajo = ulong.Parse(Console.ReadLine());
                      if (nuevo.EliminarAlumno(legajo) == true)
                      {
                          CInterfaz.mostrarInfo("El Alumno Con Legajo" + " " + legajo.ToString() + " Se Eliminó Exitosamente");
                      }
                      else
                      {
                          CInterfaz.mostrarInfo("No Existe Alumno con Numero de Legajo " + legajo.ToString());
                      }
                   }

                  opc = CInterfaz.darOpcion().ToUpper();

               } 

        }

    }
}
