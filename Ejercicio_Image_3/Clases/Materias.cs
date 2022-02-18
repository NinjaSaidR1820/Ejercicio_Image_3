using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Image_3.Clases
{
    class Materias
    {
      
        string materia;
        int idMateria;
        
        

        public Materias()
        {
             IdMateria = 0;
            Materia = string.Empty;
           
        }

        public Materias(int idmateria, string materia)
        {
            this.IdMateria = idmateria;
            this.Materia = materia;

        }

        public string getMateriasRegistrados()
        {
            return "La materia Es "+Materia+ " Con ID: "+IdMateria +"\r\n";
        }


        public string Materia { get => materia; set => materia = value; }
        public int IdMateria { get => idMateria; set => idMateria = value; }
    }
}
