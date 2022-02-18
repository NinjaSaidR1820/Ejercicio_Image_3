using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Image_3.Clases
{
    class Notas
    {

        int idMateria;
         int idEstudiante;
        int nota;

        public Notas()
        {
            IdEstudiante = 0;
            idMateria = 0;
            Nota = 0;

        }


        public Notas (int idstu, int idmat, int nota)
        {
            this.IdEstudiante = idstu;
            this.IdMateria = idmat;
            this.Nota = nota;

        }
      

        public int IdMateria { get => idMateria; set => idMateria = value; }
        public int IdEstudiante { get => idEstudiante; set => idEstudiante = value; }
        public int Nota { get => nota; set => nota = value; }
    }
}
