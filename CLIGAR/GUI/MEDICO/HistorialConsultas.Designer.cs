
namespace CLIGAR.GUI.MEDICO
{
    partial class HistorialConsultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialConsultas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.btnSeleccionarPaciente = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalles = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 84);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 366);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.83511F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.16489F));
            this.tableLayoutPanel1.Controls.Add(this.lblPaciente, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSeleccionarPaciente, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 36);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 48);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.Location = new System.Drawing.Point(3, 0);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(198, 22);
            this.lblPaciente.TabIndex = 15;
            this.lblPaciente.Text = "NOMBRE PACIENTE : ";
            // 
            // btnSeleccionarPaciente
            // 
            this.btnSeleccionarPaciente.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSeleccionarPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeleccionarPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSeleccionarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarPaciente.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSeleccionarPaciente.Location = new System.Drawing.Point(585, 3);
            this.btnSeleccionarPaciente.Name = "btnSeleccionarPaciente";
            this.btnSeleccionarPaciente.Size = new System.Drawing.Size(212, 42);
            this.btnSeleccionarPaciente.TabIndex = 13;
            this.btnSeleccionarPaciente.Text = "SELECCIONAR PACIENTE";
            this.btnSeleccionarPaciente.UseVisualStyleBackColor = false;
            this.btnSeleccionarPaciente.Click += new System.EventHandler(this.btnSeleccionarPaciente_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnCerrar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 36);
            this.panel4.TabIndex = 3;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrar.Location = new System.Drawing.Point(0, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(44, 32);
            this.btnCerrar.TabIndex = 1;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Observacion,
            this.Detalles});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(800, 366);
            this.dgv.TabIndex = 4;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Fecha";
            this.Nombre.HeaderText = "Fecha";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 457;
            // 
            // Observacion
            // 
            this.Observacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Observacion.DataPropertyName = "Observacion";
            this.Observacion.HeaderText = "Observacion";
            this.Observacion.Name = "Observacion";
            // 
            // Detalles
            // 
            this.Detalles.HeaderText = "Detalles";
            this.Detalles.Image = ((System.Drawing.Image)(resources.GetObject("Detalles.Image")));
            this.Detalles.Name = "Detalles";
            this.Detalles.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // HistorialConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistorialConsultas";
            this.Text = "HistorialConsultas";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPaciente;
        public System.Windows.Forms.Button btnSeleccionarPaciente;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel btnCerrar;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
        private System.Windows.Forms.DataGridViewImageColumn Detalles;
    }
}