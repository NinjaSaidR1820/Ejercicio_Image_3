using Ejercicio_Image_3.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Image_3
{
    public partial class Form1 : Form
    {
        List<Materias> listaMaterias = new List<Materias>();
        List<Estudiante> listaEstudiante = new List<Estudiante>();
        List<Notas> listanota = new List<Notas>();


        Notas nota;
        Materias mat;
        Estudiante stu;

       

        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        #region guardar
        public void guardaNota()
        {
          
            nota = new Notas(int.Parse(txtIdStu.Text), int.Parse(txtIdMat.Text), int.Parse(txtNota.Text));

            listanota.Add(nota);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listanota;
        }

        public void guardarMateria()
        {
            mat = new Materias(int.Parse(txtIDMateria.Text),txtNombreMateria.Text);

            listaMaterias.Add(mat);

            dgvMateria.DataSource = null;
            dgvMateria.DataSource = listaMaterias;
        }

        public void guardarEstudiante()
        {


            stu = new Estudiante(Convert.ToInt32(txtIDEstudiante.Text), txtNombreEstudiante.Text, txtApellido.Text,
                txtDireccion.Text, txtTelefono.Text);

            listaEstudiante.Add(stu);

            dgvEstudiante.DataSource = null;
            dgvEstudiante.DataSource = listaEstudiante;
        }

        #endregion

        private void btnIngresarEmpresa_Click(object sender, EventArgs e)
        {
            guardarMateria();
        }

        private void btnIngresarEmpleado_Click(object sender, EventArgs e)
        {
            guardarEstudiante();
        }

        private void btnAgregarNota_Click(object sender, EventArgs e)
        {
            guardaNota();
        }

        #region Linq
        public void getAlumnosOredenado()
        {
            IEnumerable<Estudiante> nomalum = from d in listaEstudiante orderby d.Nombre descending select d;

            foreach (Estudiante st in nomalum)
            {
                txtCONSULTA.AppendText(st.getDatosEstudiante());
            }
        }

        public void getEstudiante()
        {
            IEnumerable<Estudiante> nomEmp = from nEmp in listaEstudiante select nEmp;

            foreach (Estudiante em in nomEmp)
            {
                txtCONSULTA.AppendText(em.getEstudiantesRegistrados());
            }
        }

        public void getMateria()
        {
            IEnumerable<Materias> nomEmp = from nEmp in listaMaterias select nEmp;

            foreach (Materias em in nomEmp)
            {
                txtCONSULTA.AppendText(em.getMateriasRegistrados());
            }
        }



        #endregion



        #region Consultas

        private void rbAlumnosOrdenados_CheckedChanged(object sender, EventArgs e)
        {
            txtCONSULTA.Clear();
            getAlumnosOredenado();
        }
        private void rbAlumnosRegistrados_CheckedChanged(object sender, EventArgs e)
        {
            txtCONSULTA.Clear();
            getEstudiante();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txtCONSULTA.Clear();
            getMateria();
        }


        #endregion

        
    }
}
