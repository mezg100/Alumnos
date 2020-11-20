using System;
using System.Collections;
using alumno;

namespace Comision
{
    class CAlumnos
    {
        private ArrayList lista;

        public CAlumno BuscaAlumno(ulong leg)
        {
            CAlumno Encontrado;

            foreach (CAlumno aux in lista)
            {
                if (aux.GetLegajo() == leg)
                {
                    Encontrado = aux;
                    return Encontrado;
                }
            }

            return null;
        }

        public CAlumnos()
        {
            this.lista = new ArrayList();   
        }

        public bool CrearAlumno(ulong leg, string noms, string apes, float bec)
        {   
            CAlumno alum;
            
            if (this.BuscaAlumno(leg) == null){
                alum = new CAlumno(leg, noms, apes, bec);
                this.lista.Add(alum);
                return true;
            }
            else
            {
                return false;
            }
            
        }
 

        public string DarDatos()
        {
            this.Ordenar();
            string datos = "";

            foreach (CAlumno aux in this.lista)
            {
                datos += aux.DarDatos() + "\n";
            }

            return datos;
        }

        public string DarDatos(ulong leg)
        {
           
            string datos = " ";

            foreach (CAlumno aux in this.lista)
            {
                if (aux.Legajo == leg)
                {
                    return datos += aux.DarDatos() ;
                }
            }

            return "El legajo ingresado no existe";
        }

        public bool EliminarAlumno(ulong leg)
        {

            foreach (CAlumno aux in lista)
            {
                if (aux.GetLegajo() == leg)
                {
                    lista.Remove(aux);
                    return true;
                }
            }

            return false;
        }


        public void Ordenar()
        {
            lista.Sort(new myComparer());
        }

        public class myComparer : IComparer
        {
            int IComparer.Compare(object xx, object yy)
            {
                CAlumno x = (CAlumno)xx;
                CAlumno y = (CAlumno)yy;
                return x.GetLegajo().CompareTo(y.GetLegajo());
            }
        }

        public static float GetCuota()
        {
            return CAlumno.GetCuota();
        }

        public static void SetCuota(float cuot)
        {
            CAlumno.SetCuota(cuot);
        }

        public float DarCuotaPersonal( ulong leg )
        {
            foreach (CAlumno Aux in lista)
            {
                if (Aux.GetLegajo() == leg)

                    return Aux.darCuotaPersonal();
            }

            return -1F;
        }

    }           
 }
   
    

