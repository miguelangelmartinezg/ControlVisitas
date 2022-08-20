using Entities;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmRegister : Form
    {
        int nIdAlumno = 0;
        public frmRegister()
        {
            InitializeComponent();
        }
        public frmRegister(int _idAlumno)
        {
            InitializeComponent();
            if (_idAlumno > 0)
            {
                nIdAlumno = _idAlumno;
            }
              
        }

        private void FormRegistrar_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            if(txtUser.Text != "" && txtPass.Text != "" && nIdAlumno > 0)
            {
                Logica_Negocio oLogicaNegocio = new Logica_Negocio();
                Usuarios oUsuario = new Usuarios();

                DataTable oResultUserExistente = oLogicaNegocio.MostrarUsuario(0);
                for (int i = 0; i < oResultUserExistente.Rows.Count; i++)
                {

                    var cUser = oResultUserExistente.Rows[i].Field<string>("Usuario");
                    if (txtUser.Text == cUser)
                    {
                        MessageBox.Show("Este Usuario esta registrado, Introduzca otro");
                    }
                    else
                    {
                        var nTotal = Convert.ToInt32(oResultUserExistente.Rows.Count)-1;
                        if ( i == nTotal)
                        {
                            oUsuario.IdUser = nIdAlumno;
                            oUsuario.Usuario = txtUser.Text;
                            oUsuario.Password = txtPass.Text;
                            oUsuario.Roles = "General";

                            oLogicaNegocio.AgregarUsuario(oUsuario);
                            MessageBox.Show("Usuario Registrado");
                            this.Hide();

                            break;
                        }
                    }
                }

                
            }
            else
            {
                MessageBox.Show("Hay campos Vacios, Favor Completarlos");
            }
        }
    }
}
