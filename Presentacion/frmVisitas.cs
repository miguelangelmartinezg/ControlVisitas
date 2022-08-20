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
    public partial class frmVisitas : Form
    {
        public frmVisitas()
        {
            InitializeComponent();
        }

        private void frmVisitas_Load(object sender, EventArgs e)
        {
            LlenarGrid(0);
        }
        private void LlenarGrid(int nId)
        {

            try
            {
                Logica_Negocio oLogica = new Logica_Negocio();

                DataTable dtDatos = oLogica.ListarVisitas(nId);
                dtgVisitas.Rows.Clear();
                foreach (DataRow contacto in dtDatos.Rows)
                {

                    dtgVisitas.Rows.Add(Convert.ToString(contacto["NombreCompleto"]), Convert.ToString(contacto["Edificio"]), Convert.ToString(contacto["Aula"]),
                        Convert.ToString(contacto["Fecha"]), Convert.ToString(contacto["H_Entrada"]), Convert.ToString(contacto["H_Salida"]));
                }
            }
            catch (Exception ex)
            {

                string cMensajeError = ex.Message + ", " + ((ex.InnerException != null) ? ex.InnerException.Message.Trim() : "").ToString();
                MessageBox.Show("Error Llenando Grid: " + cMensajeError, "", MessageBoxButtons.OK,
                      MessageBoxIcon.Information);

            }

        }

        private void btnAddVisitas_Click(object sender, EventArgs e)
        {
            this.Close();
            frmControlVistas frmControlVistas = new frmControlVistas();
            frmControlVistas.Show();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }
    }
}
