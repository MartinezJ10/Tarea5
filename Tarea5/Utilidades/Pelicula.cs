using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5.Utilidades
{
    internal class Pelicula
    {
        private string nombre;
        private string director;
        private string genero;
        private string pais;
        private DateTime lanzamiento;
        
        public Pelicula(string nombre, string director, string genero, string pais, DateTime lanzamiento)
        {
            this.nombre = nombre;
            this.director = director;
            this.genero = genero;   
            this.pais = pais;   
            this.lanzamiento = lanzamiento;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        public DateTime Lanzamiento
        {
            get { return lanzamiento; }
            set { lanzamiento = value;}
        }

        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }
    }
}
