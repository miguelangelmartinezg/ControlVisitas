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
using Entities;

namespace Presentacion
{
    public partial class frmControlVistas : Form
    {
        string cUsuario = "";
        string cPassword = "";
        Logica_Negocio oLogicaNegocio = new Logica_Negocio();

        public frmControlVistas()
        {
            InitializeComponent();
        }
        public frmControlVistas(string _usuario, string _password)
        {
            InitializeComponent();
            cUsuario = _usuario;    
            cPassword = _password;
        }

        private void frmControlVistas_Load(object sender, EventArgs e)
        {
            DataTable oEdificios = oLogicaNegocio.ListarEdificios(0);
            cboEdificio.DataSource = oEdificios.DefaultView;
            cboEdificio.DisplayMember = "Descripcion";
            cboEdificio.ValueMember = "IdEdificio";
            cboEdificio.SelectedIndex = -1;

            DataTable dtAlumno = oLogicaNegocio.ListarAlumnos(0);
            cboAlumno.DataSource = dtAlumno.DefaultView;
            cboAlumno.DisplayMember = "NombreCompleto";
            cboAlumno.ValueMember = "IdAlumno";
            cboAlumno.SelectedIndex = -1;
        }

        private void cboEdificio_SelectionChangeCommitted(object sender, EventArgs e)
        {

            DataTable oAulas = oLogicaNegocio.ListarAulasPorEdificio(Convert.ToInt32(cboEdificio.SelectedValue));
            
            cboAula.DataSource = oAulas.DefaultView;
            cboAula.DisplayMember = "Codigo";
            cboAula.ValueMember = "IdAula";
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                Logica_Negocio oLogica = new Logica_Negocio();

                Visita oVisita = new Visita
                {
                    IdAlumno = Convert.ToInt32(cboAlumno.SelectedValue),
                    IdEdificio = Convert.ToInt32(cboEdificio.SelectedValue),
                    IdAula = Convert.ToInt32(cboAula.SelectedValue),
                    Motivo = txtMotivo.Text,
                    Fecha = dFecha.Value,
                    H_Entrada = dEntrada.Value.TimeOfDay,
                    H_Salida = dSalida.Value.TimeOfDay


                };
                oLogica.AgregarVisita(oVisita);

                MessageBox.Show("Visita Insertada Correctamente!!!");
                LlenarGrid(Convert.ToInt32(cboAlumno.SelectedValue));
              

            }
            catch (Exception ex)
            {
                string cMensajeError = ex.Message + ", " + ((ex.InnerException != null) ? ex.InnerException.Message.Trim() : "").ToString();
                MessageBox.Show("Error Llenando Grid: " + cMensajeError, "", MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
            }

        }

        private void pruebaExtraccionFecha()
        {
            TimeSpan prueba = dEntrada.Value.TimeOfDay;
            TimeSpan prueba2 = dSalida.Value.TimeOfDay;

            if (prueba > prueba2)
            {
                TimeSpan nResultado = prueba.Subtract(prueba2);
                //TimeSpan nResultado = prueba - prueba2;
                var nNewResultado = nResultado.Hours + ":" + nResultado.Minutes;
                MessageBox.Show(nNewResultado);
            }
        }

        private void frmControlVistas_FormClosed(object sender, FormClosedEventArgs e)
        {
            //frmVisitas frmVistas = new frmVisitas();
            //frmVistas.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmVisitas frmVistas = new frmVisitas();
            frmVistas.Show();
            this.Close();
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

                    dtgVisitas.Rows.Add(Convert.ToString(contacto["Edificio"]), Convert.ToString(contacto["Aula"]),
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
        private void dtgVisitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboAlumno_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LlenarGrid(Convert.ToInt32(cboAlumno.SelectedValue));
        }
    }
}
