using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c
{

    class Estudiantes
    {
        private int id;
        private String código;
        private String nombre;
        private string facultad;
        private double nota;
        private double nota2;
        private double notaf;
        private string carrera;
        private string asignatura;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public String Código
        {
            get { return código; }
            set { código = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Facultad
        {
            get { return Facultad; }
            set { Facultad = value; }
        }
        public double Nota {
            get { return nota; }
            set { nota = value; }

        }
        public double Nota2
        {
            get { return nota2; }
            set { nota2 = value; }

        }
        public double Notaf
        {
            get { return notaf; }
            set { notaf = value; }

        }
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }

        }
        public string Asignatura
        {
            get { return asignatura; }
            set { asignatura = value; }

        }




        public Estudiantes(int id, String código, string nombre, string Facultad, double Notas, double Notas2,double Notaf, string Asignatuta, string Carrera)
        {
            this.id = id;
            this.código = código;
            this.nombre = nombre;
            this.facultad = Facultad;
            this.nota = Nota;
            this.nota2 = Nota2;
            this.notaf = Notaf;
            this.carrera = Carrera;
            this.asignatura = Asignatuta;

        }
        public string mostrar()
        {
            return id + " " + código + " " + nombre + " " + facultad + nota+" "+nota2+" "+notaf+" "+asignatura +" "+carrera+" ";
        }

    }

}