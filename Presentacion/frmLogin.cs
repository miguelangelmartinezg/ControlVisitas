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
    public partial class frmLogin : Form
    {
       // int nIdAlumno = 0;
        public frmLogin()
        {
            InitializeComponent();
        }
        //public frmLogin(int _idAlumno)
        //{
        //    InitializeComponent();
        //    nIdAlumno = _idAlumno;
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistrarAlumno formAlumno = new frmRegistrarAlumno();
            formAlumno.Show();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ValidarUsuario(txtUser.Text, txtPass.Text);
        }
        private bool ValidarUsuario(string cUserName, string cPassword)
        {
            bool lResultado = false ;
            Logica_Negocio oLogicaNegocio = new Logica_Negocio();
            if (txtUser.Text != "" && txtPass.Text != "")
            {
                if (oLogicaNegocio.ValidarUsuario(txtUser.Text.Trim(),txtPass.Text.Trim()))
                {
                    //TODO: Codificar => Llamar al Form Principal, mandando como parametro su ID
                    
                    
                    frmVisitas ofrmVisitas = new frmVisitas();
                    ofrmVisitas.Show();
                    this.Hide();
                    // break;
                }
                else
                {
                    MessageBox.Show("Usuario o Password Incorrecto.");
                }

            }
            else
            {
                MessageBox.Show("Hay campos en Blancos");
            }


            return lResultado;
        }
    }
}
