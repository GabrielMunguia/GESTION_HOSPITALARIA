namespace CLIGAR.GUI.Recepcion
{
    partial class VerCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerCitas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.btnSeleccionarDoctor = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Urgencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewImageColumn();
            this.Cancelar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 35);
            this.panel1.TabIndex = 3;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrar.Location = new System.Drawing.Point(0, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(44, 31);
            this.btnCerrar.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(962, 43);
            this.panel2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.83511F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.16489F));
            this.tableLayoutPanel1.Controls.Add(this.lblDoctor, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSeleccionarDoctor, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(962, 43);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctor.Location = new System.Drawing.Point(3, 0);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(177, 22);
            this.lblDoctor.TabIndex = 15;
            this.lblDoctor.Text = "NOMBRE DOCTOR:";
            // 
            // btnSeleccionarDoctor
            // 
            this.btnSeleccionarDoctor.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSeleccionarDoctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeleccionarDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSeleccionarDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarDoctor.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSeleccionarDoctor.Location = new System.Drawing.Point(703, 3);
            this.btnSeleccionarDoctor.MaximumSize = new System.Drawing.Size(291, 44);
            this.btnSeleccionarDoctor.MinimumSize = new System.Drawing.Size(291, 44);
            this.btnSeleccionarDoctor.Name = "btnSeleccionarDoctor";
            this.btnSeleccionarDoctor.Size = new System.Drawing.Size(291, 44);
            this.btnSeleccionarDoctor.TabIndex = 13;
            this.btnSeleccionarDoctor.Text = "SELECCIONAR DOCTOR";
            this.btnSeleccionarDoctor.UseVisualStyleBackColor = false;
            this.btnSeleccionarDoctor.Click += new System.EventHandler(this.btnSeleccionarDoctor_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvCitas);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(962, 385);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(962, 47);
            this.panel4.TabIndex = 0;
            // 
            // dgvCitas
            // 
            this.dgvCitas.AllowUserToAddRows = false;
            this.dgvCitas.AllowUserToDeleteRows = false;
            this.dgvCitas.AllowUserToResizeColumns = false;
            this.dgvCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.nombrePaciente,
            this.CodigoPaciente,
            this.Urgencia,
            this.Hora,
            this.Detalle,
            this.Cancelar});
            this.dgvCitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCitas.Location = new System.Drawing.Point(0, 47);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCitas.Size = new System.Drawing.Size(962, 338);
            this.dgvCitas.TabIndex = 5;
            this.dgvCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCitas_CellContentClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.06445F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.93555F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(962, 47);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.dtpFechaCita, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(466, 41);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "FECHA CITA : ";
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.CustomFormat = "yyyy-MM-dd H:mm:ss";
            this.dtpFechaCita.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpFechaCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCita.Location = new System.Drawing.Point(164, 3);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(299, 27);
            this.dtpFechaCita.TabIndex = 17;
            this.dtpFechaCita.ValueChanged += new System.EventHandler(this.dtpFechaCita_ValueChanged);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // nombrePaciente
            // 
            this.nombrePaciente.DataPropertyName = "nombrePaciente";
            this.nombrePaciente.HeaderText = "Nombre Paciente";
            this.nombrePaciente.Name = "nombrePaciente";
            // 
            // CodigoPaciente
            // 
            this.CodigoPaciente.DataPropertyName = "CodigoPaciente";
            this.CodigoPaciente.HeaderText = "CodigoPaciente";
            this.CodigoPaciente.Name = "CodigoPaciente";
            // 
            // Urgencia
            // 
            this.Urgencia.DataPropertyName = "Urgencia";
            this.Urgencia.HeaderText = "Urgencia";
            this.Urgencia.Name = "Urgencia";
            // 
            // Hora
            // 
            this.Hora.DataPropertyName = "Hora";
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle Paciente";
            this.Detalle.Image = ((System.Drawing.Image)(resources.GetObject("Detalle.Image")));
            this.Detalle.Name = "Detalle";
            // 
            // Cancelar
            // 
            this.Cancelar.HeaderText = "Cancelar cita";
            this.Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Cancelar.Image")));
            this.Cancelar.Name = "Cancelar";
            // 
            // VerCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 463);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerCitas";
            this.Text = "VerCitas";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel btnCerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDoctor;
        public System.Windows.Forms.Button btnSeleccionarDoctor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urgencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewImageColumn Detalle;
        private System.Windows.Forms.DataGridViewImageColumn Cancelar;
    }
}