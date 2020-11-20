using System;

namespace alumno
{
    class CAlumno
    {

        private ulong legajo;
        private string nombres;
        private string apellidos;
        private float beca;

        private static float cuota;

        public CAlumno()
        {
            this.legajo = 0;
            this.nombres = "sin asignar";
            this.apellidos = "sin asignar";
            this.beca = 0.0F;
        }

        public CAlumno(ulong leg)
        {
            this.legajo = leg;
        }
        public CAlumno(ulong leg, string noms, string apes, float bec)
        {
            this.legajo = leg;
            this.nombres = noms;
            this.apellidos = apes;
            this.beca = bec;
        }

        public void SetLegajo(ulong leg)
        { this.legajo = leg; }
        public void SetNombres(string noms)
        { this.nombres = noms; }
        public void SetApellidos(string apes)
        { this.apellidos = apes; }
        public void SetBeca(float bec)
        { this.beca = bec; }

        public ulong GetLegajo()
        { return this.legajo; }
        public string GetNombres()
        { return this.nombres; }
        public string GetApellidos()
        { return this.apellidos; }
        public float GetBeca()
        { return this.beca; }

        public ulong Legajo
        {
            set { this.legajo = value; }
            get { return this.legajo; }
        }

        public float Beca
        {
            set { this.beca = value; }
        }

        public string Nombres
        {
            get { return this.nombres; }
        }

        public string DarDatos()
        {
            string ret = " - " + "Legajo: " + this.legajo.ToString() + "\n";
            ret += " - " + "Apellido: " + this.apellidos + "\n" + " - " + "Nombre: " + this.nombres + "\n"; ;
            ret += " - Beca: " + this.beca.ToString() + "%" + "\n"; ;
            ret += " - Cuota General: $" + CAlumno.cuota.ToString() + "\n"; ;
            ret += " - Cuota Personal: $ " + this.darCuotaPersonal().ToString() + "\n"; ;
            return ret;
        }

        public float darCuotaPersonal()
        {
            return CAlumno.cuota * (1 - this.beca / 100);
        }

        ~CAlumno()
        {

        }

        public void Dispose()
        {
            System.GC.SuppressFinalize(this);
        }

        public static void SetCuota(float cuot)
        { CAlumno.cuota = cuot; }

        public static float GetCuota()
        { return CAlumno.cuota; }

        public static float Cuota
        {
            set { CAlumno.cuota = value; }
            get { return CAlumno.cuota; }
        }
    } 
} 

