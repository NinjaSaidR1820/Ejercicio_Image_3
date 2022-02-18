using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Image_3.Clases
{
    class Estudiante
    {
        int idEstudiante;
        string nonbre;
        string apellido;
        string direccion;
        string telefono;

        public Estudiante()
        {
            IdEstudiante = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            Direccion = string.Empty;
            Telefono= string.Empty;

        }

        public Estudiante(int idestudiante, string nombre,string apellido, string direccion, string telefono)
        {
            this.IdEstudiante = idestudiante;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.Telefono = telefono;



        }



        public string Nombre { get => nonbre; set => nonbre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int IdEstudiante { get => idEstudiante; set => idEstudiante = value; }

        public string getDatosEstudiante()
        {
            return Nombre + " " + Apellido + " Con ID de Estudiante " + IdEstudiante + "\r\n"; 
        }


        public string getEstudiantesRegistrados()
        {
            return Nombre + " " + Apellido + "\r\n";
        }

    }
}
