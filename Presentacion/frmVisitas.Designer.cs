
namespace Presentacion
{
    partial class frmVisitas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgVisitas = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAddVisitas = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edificio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVisitas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgVisitas
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgVisitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgVisitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVisitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.edificio,
            this.aula,
            this.fecha,
            this.horaE,
            this.horaS});
            this.dtgVisitas.Location = new System.Drawing.Point(12, 83);
            this.dtgVisitas.Name = "dtgVisitas";
            this.dtgVisitas.RowHeadersVisible = false;
            this.dtgVisitas.RowHeadersWidth = 51;
            this.dtgVisitas.RowTemplate.Height = 24;
            this.dtgVisitas.Size = new System.Drawing.Size(989, 321);
            this.dtgVisitas.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalir.Image = global::Presentacion.Properties.Resources.WhatsApp_Image_2022_08_18_at_12_12_40_PM__2_;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(505, 493);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 51);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAddVisitas
            // 
            this.btnAddVisitas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddVisitas.Image = global::Presentacion.Properties.Resources.visitante__3_;
            this.btnAddVisitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddVisitas.Location = new System.Drawing.Point(332, 493);
            this.btnAddVisitas.Name = "btnAddVisitas";
            this.btnAddVisitas.Size = new System.Drawing.Size(167, 51);
            this.btnAddVisitas.TabIndex = 15;
            this.btnAddVisitas.Text = "Agregar Visita";
            this.btnAddVisitas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddVisitas.UseVisualStyleBackColor = false;
            this.btnAddVisitas.Click += new System.EventHandler(this.btnAddVisitas_Click);
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Alumno";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.Width = 200;
            // 
            // edificio
            // 
            this.edificio.HeaderText = "Edificio";
            this.edificio.MinimumWidth = 6;
            this.edificio.Name = "edificio";
            this.edificio.Width = 150;
            // 
            // aula
            // 
            this.aula.HeaderText = "Aula";
            this.aula.MinimumWidth = 6;
            this.aula.Name = "aula";
            this.aula.Width = 120;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fec. Vista";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.Width = 75;
            // 
            // horaE
            // 
            this.horaE.HeaderText = "Hora Ent.";
            this.horaE.MinimumWidth = 6;
            this.horaE.Name = "horaE";
            this.horaE.Width = 90;
            // 
            // horaS
            // 
            this.horaS.HeaderText = "Hora Sal.";
            this.horaS.MinimumWidth = 6;
            this.horaS.Name = "horaS";
            this.horaS.Width = 90;
            // 
            // frmVisitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1013, 556);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAddVisitas);
            this.Controls.Add(this.dtgVisitas);
            this.Name = "frmVisitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVisitas";
            this.Load += new System.EventHandler(this.frmVisitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVisitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgVisitas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAddVisitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn edificio;
        private System.Windows.Forms.DataGridViewTextBoxColumn aula;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaE;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaS;
    }
}