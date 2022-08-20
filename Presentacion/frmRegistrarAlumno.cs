//using ITLA_US.Models;
using Entities;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmRegistrarAlumno : Form
    {
        //VisitaITLAEntities db;
        public frmRegistrarAlumno()
        {
            InitializeComponent();
        }

        private void RegistrarAlumno_Load(object sender, EventArgs e)
        {
            rdF.Checked = true;
            //using (db = new VisitaITLAEntities())
            //{
            //    var oMostrarCarrera = from oCarrera in db.Set<Carreras>()
            //                          select oCarrera;

            //    List<Carreras> olist = new List<Carreras>();
            //    foreach (var item in oMostrarCarrera.ToList())
            //    {
            //        olist.Add(new Carreras() {  idCarrera = item.idCarrera, descripcion = item.descripcion });
            //    }
            //    cboCarrera.DataSource = olist;
            //    cboCarrera.DisplayMember = "descripcion";
            //    cboCarrera.ValueMember = "idCarrera";
            //}

            Logica_Negocio oLogicaNegocio = new Logica_Negocio();
            DataTable oCarreras = oLogicaNegocio.MostrarCarreras(0);

            cboCarrera.DataSource = oCarreras.DefaultView;
            cboCarrera.DisplayMember = "descripcion";
            cboCarrera.ValueMember = "idCarrera";


            DataTable oAlumnos = oLogicaNegocio.ListarAlumnos(0);
            //oAlumnos.Columns.Add(
            //"NombreCompleto",
            //typeof(string),
            //"nombre+ ' ' + apellido");

            cboBuscar.DataSource = oAlumnos;
            cboBuscar.DisplayMember = "NombreCompleto";
            cboBuscar.ValueMember = "idAlumno";
            cboBuscar.SelectedItem = null;

            cmdCrearUser.Enabled = false;
            btnNuevo.Enabled = false;


        }

        private void cmdCrearUser_Click(object sender, EventArgs e)
        {
            if (txtIdAlumno.Text != "")
            {
                Logica_Negocio ologicaNegocio = new Logica_Negocio();
                DataTable oUsuario = ologicaNegocio.MostrarUsuario(Convert.ToInt32(txtIdAlumno.Text));

                if (oUsuario.Rows.Count < 1)
                {
                    frmRegister frmRegistro = new frmRegister(Convert.ToInt32(txtIdAlumno.Text));
                    frmRegistro.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Este Alumno tiene un Usuario Registrado");
                }

                
            }
            
            
        }

        private void txtIdAlumno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearAlumno_Click(object sender, EventArgs e)
        {
            string cSexo = "";
            //foreach(RadioButton rdo in gboGenero.Controls.OfType<RadioButton>())
            //{
            //    if (rdo.Checked)
            //    {
            //        cRdbCheck = rdo.Text;
            //    }
            //}
            if (rdF.Checked == true)
            {
                cSexo = "F";

            }
            if (rdM.Checked == true)
            {
                cSexo = "M";

            }

            if (txtCorreo.Text.Contains("@gmail.com") == false && txtCorreo.Text.Contains("@hotmail.com") == false )
            {
                MessageBox.Show("Correo no Valido");
                txtCorreo.Text = "";
            }

            if (txtNombre.Text != "" && txtApellido.Text != "" && txtCorreo.Text != "" && cboCarrera.Text != "" && cSexo != "" && txtDireccion.Text != "" && dtFNacimiento.Text != "")
            {
                Alumno oAlumno = new Alumno();
                oAlumno.Nombre = txtNombre.Text;
                oAlumno.Apellido = txtApellido.Text;
                oAlumno.Correo = txtCorreo.Text;
                oAlumno.Idcarrera = int.Parse(cboCarrera.SelectedValue.ToString());
                oAlumno.Genero = cSexo;
                oAlumno.Fnacimiento = dtFNacimiento.Value;
                oAlumno.Direccion = txtDireccion.Text;

                Logica_Negocio oLogicaNegocio = new Logica_Negocio();
                oLogicaNegocio.AgregarAlumno(oAlumno);
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtCorreo.Text = "";
                cboCarrera.Text = "Software";
                rdF.Checked = true;
                dtFNacimiento.Value = DateTime.Now ;
                txtDireccion.Text = "";

                btnNuevo.Enabled = true;


                MessageBox.Show("Alumno " + oAlumno.Nombre + " " + oAlumno.Apellido + ", Ha Sido Registrado");


                //using (db = new VisitaITLAEntities())
                //{
                //    db.Set<Alumnos>().Add(oAlumno);
                //    try
                //    {
                //        db.SaveChanges();
                //        txtNombre.Text = "";
                //        txtApellido.Text = "";
                //        txtCorreo.Text = "";
                //        txtDireccion.Text = "";
                //        cboCarrera.Text = "Software";

                //        MessageBox.Show("Datos Guardados de Manera Satisfactoria");
                //    }
                //    catch (Exception ex)
                //    {
                //    MessageBox.Show(ex.ToString() );
                //}


            }
            else
            {
                MessageBox.Show("Faltan Datos para ser llenados correctamente");
            }

        }

        private void cboBuscar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            /*
            ///MessageBox.Show(cboBuscar.SelectedValue.ToString());
            txtIdAlumno.Text = cboBuscar.SelectedValue.ToString();

            Logica_Negocio oLogicaNegocio = new Logica_Negocio();
            DataTable oAlumnos = oLogicaNegocio.ListarAlumnos(Convert.ToInt32(txtIdAlumno.Text));

            txtNombre.Text = oAlumnos.Rows[0].Field<string>("nombre");
            txtApellido.Text = oAlumnos.Rows[0].Field<string>("apellido");
            txtCorreo.Text = oAlumnos.Rows[0].Field<string>("correo");
            txtDireccion.Text = oAlumnos.Rows[0].Field<string>("direccion");
            dtFNacimiento.Value = oAlumnos.Rows[0].Field<DateTime>("Fnacimiento");

            DataTable oGeneroSeleccionado = oLogicaNegocio.MostrarCarreras(oAlumnos.Rows[0].Field<int>("idcarrera"));
            string cGenreo = oGeneroSeleccionado.Rows[0].Field<string>("descripcion");

            cboCarrera.Text = cGenreo;

            if (oAlumnos.Rows[0].Field<string>("genero").Equals("F"))
            {
                rdF.Checked = true;
            }
            else
            {
                rdM.Checked = true;
            }


            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtCorreo.Enabled = false;
            cboCarrera.Enabled = false;
            gboGenero.Enabled = false;
            dtFNacimiento.Enabled = false;
            txtDireccion.Enabled = false;
            cmdCrearUser.Enabled = true;
            btnNuevo.Enabled = true;
            btnCrearAlumno.Enabled = false;
            */

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtIdAlumno.Text = "0";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCorreo.Text = "";
            cboCarrera.Text = "Software";
            rdF.Checked = true;
            dtFNacimiento.Value = DateTime.Now;
            txtDireccion.Text = "";
            cboBuscar.SelectedItem = null;

            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtCorreo.Enabled = true;
            cboCarrera.Enabled = true;
            gboGenero.Enabled = true;
            dtFNacimiento.Enabled = true;
            txtDireccion.Enabled = true;

            btnCrearAlumno.Enabled = true;
            btnNuevo.Enabled = false;
            cmdCrearUser.Enabled = false;
        }
        private void BuscarAlumno(int nIdALumno)
        {
            Logica_Negocio oLogicaNegocio = new Logica_Negocio();
            DataTable oAlumnos = oLogicaNegocio.ListarAlumnos(Convert.ToInt32(txtIdAlumno.Text));

            txtNombre.Text = oAlumnos.Rows[0].Field<string>("nombre");
            txtApellido.Text = oAlumnos.Rows[0].Field<string>("apellido");
            txtCorreo.Text = oAlumnos.Rows[0].Field<string>("correo");
            txtDireccion.Text = oAlumnos.Rows[0].Field<string>("direccion");
            dtFNacimiento.Value = oAlumnos.Rows[0].Field<DateTime>("Fnacimiento");

            DataTable oGeneroSeleccionado = oLogicaNegocio.MostrarCarreras(oAlumnos.Rows[0].Field<int>("idcarrera"));
            string cGenreo = oGeneroSeleccionado.Rows[0].Field<string>("descripcion");

            cboCarrera.Text = cGenreo;

            if (oAlumnos.Rows[0].Field<string>("genero").Equals("F"))
            {
                rdF.Checked = true;
                rdM.Checked = false;
            }
            else
            {
                rdM.Checked = true;
                rdF.Checked = false;
            }


            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtCorreo.Enabled = false;
            cboCarrera.Enabled = false;
            gboGenero.Enabled = false;
            dtFNacimiento.Enabled = false;
            txtDireccion.Enabled = false;
            cmdCrearUser.Enabled = true;
            btnNuevo.Enabled = true;
            btnCrearAlumno.Enabled = false;

        }

        private void txtIdAlumno_Validated(object sender, EventArgs e)
        {
            if (txtIdAlumno.Text != "")
            {
                BuscarAlumno(Convert.ToInt32(txtIdAlumno.Text));
            }
        }

        private void frmRegistrarAlumno_FormClosed(object sender, FormClosedEventArgs e)
        {
            //frmLogin ofrmLogin = new frmLogin();    
            //ofrmLogin.Show(); 
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmLogin ofrmLogin = new frmLogin();
            ofrmLogin.Show();
            this.Close();
        }
    }
}
