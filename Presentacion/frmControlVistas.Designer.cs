namespace Presentacion
{
    partial class frmControlVistas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgVisitas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.dSalida = new System.Windows.Forms.DateTimePicker();
            this.dEntrada = new System.Windows.Forms.DateTimePicker();
            this.cboEdificio = new System.Windows.Forms.ComboBox();
            this.cboAula = new System.Windows.Forms.ComboBox();
            this.dFecha = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.cboAlumno = new System.Windows.Forms.ComboBox();
            this.edificio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVisitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgVisitas
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgVisitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgVisitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVisitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.edificio,
            this.aula,
            this.fecha,
            this.horaE,
            this.horaS});
            this.dtgVisitas.Location = new System.Drawing.Point(143, 274);
            this.dtgVisitas.Name = "dtgVisitas";
            this.dtgVisitas.RowHeadersVisible = false;
            this.dtgVisitas.RowHeadersWidth = 51;
            this.dtgVisitas.RowTemplate.Height = 24;
            this.dtgVisitas.Size = new System.Drawing.Size(690, 317);
            this.dtgVisitas.TabIndex = 0;
            this.dtgVisitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVisitas_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Crear Visitas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Edificio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Entrada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(472, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Salida";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Motivo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(484, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Aula";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(197, 191);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(606, 77);
            this.txtMotivo.TabIndex = 7;
            // 
            // dSalida
            // 
            this.dSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dSalida.Location = new System.Drawing.Point(524, 153);
            this.dSalida.Name = "dSalida";
            this.dSalida.Size = new System.Drawing.Size(162, 22);
            this.dSalida.TabIndex = 6;
            // 
            // dEntrada
            // 
            this.dEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dEntrada.Location = new System.Drawing.Point(289, 150);
            this.dEntrada.Name = "dEntrada";
            this.dEntrada.Size = new System.Drawing.Size(162, 22);
            this.dEntrada.TabIndex = 5;
            // 
            // cboEdificio
            // 
            this.cboEdificio.FormattingEnabled = true;
            this.cboEdificio.Location = new System.Drawing.Point(197, 110);
            this.cboEdificio.Name = "cboEdificio";
            this.cboEdificio.Size = new System.Drawing.Size(254, 24);
            this.cboEdificio.TabIndex = 3;
            this.cboEdificio.SelectionChangeCommitted += new System.EventHandler(this.cboEdificio_SelectionChangeCommitted);
            // 
            // cboAula
            // 
            this.cboAula.FormattingEnabled = true;
            this.cboAula.Location = new System.Drawing.Point(524, 110);
            this.cboAula.Name = "cboAula";
            this.cboAula.Size = new System.Drawing.Size(279, 24);
            this.cboAula.TabIndex = 4;
            // 
            // dFecha
            // 
            this.dFecha.Location = new System.Drawing.Point(692, 12);
            this.dFecha.Name = "dFecha";
            this.dFecha.Size = new System.Drawing.Size(278, 22);
            this.dFecha.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(640, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Fecha";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.edificio;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalir.Image = global::Presentacion.Properties.Resources.WhatsApp_Image_2022_08_18_at_12_12_40_PM__2_;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(655, 593);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 51);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelar.Image = global::Presentacion.Properties.Resources.WhatsApp_Image_2022_08_18_at_12_12_39_PM__6_;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(544, 593);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 51);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBorrar.Image = global::Presentacion.Properties.Resources.WhatsApp_Image_2022_08_18_at_12_12_39_PM__7_;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Location = new System.Drawing.Point(433, 593);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(109, 51);
            this.btnBorrar.TabIndex = 12;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditar.Image = global::Presentacion.Properties.Resources.WhatsApp_Image_2022_08_18_at_12_12_40_PM;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(322, 593);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(109, 51);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCrear.Image = global::Presentacion.Properties.Resources.visitante__3_;
            this.btnCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrear.Location = new System.Drawing.Point(211, 593);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(109, 51);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "Agregar";
            this.btnCrear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // cboAlumno
            // 
            this.cboAlumno.FormattingEnabled = true;
            this.cboAlumno.Location = new System.Drawing.Point(197, 78);
            this.cboAlumno.Name = "cboAlumno";
            this.cboAlumno.Size = new System.Drawing.Size(606, 24);
            this.cboAlumno.TabIndex = 16;
            this.cboAlumno.SelectionChangeCommitted += new System.EventHandler(this.cboAlumno_SelectionChangeCommitted);
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
            // frmControlVistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 656);
            this.Controls.Add(this.cboAlumno);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dFecha);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboAula);
            this.Controls.Add(this.cboEdificio);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dEntrada);
            this.Controls.Add(this.dSalida);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgVisitas);
            this.Name = "frmControlVistas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Visitas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmControlVistas_FormClosed);
            this.Load += new System.EventHandler(this.frmControlVistas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVisitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgVisitas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.DateTimePicker dSalida;
        private System.Windows.Forms.DateTimePicker dEntrada;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ComboBox cboEdificio;
        private System.Windows.Forms.ComboBox cboAula;
        private System.Windows.Forms.DateTimePicker dFecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn edificio;
        private System.Windows.Forms.DataGridViewTextBoxColumn aula;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaE;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaS;
    }
}