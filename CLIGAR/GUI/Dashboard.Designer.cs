namespace CLIGAR.GUI
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.opcConsultaMedica = new System.Windows.Forms.Button();
            this.panelOpcConsultaMedica = new System.Windows.Forms.Panel();
            this.btnHistorialConsultas = new System.Windows.Forms.Button();
            this.btnRegistrarConsulta = new System.Windows.Forms.Button();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.panelReportes = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnReporteConsultasDoctor = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panelReport = new System.Windows.Forms.Panel();
            this.opcReportes = new System.Windows.Forms.Button();
            this.panelGestionCitas = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnVerCita = new System.Windows.Forms.Button();
            this.btnRegistrarCitaView = new System.Windows.Forms.Button();
            this.opcCitas = new System.Windows.Forms.Button();
            this.panelOpcGestionDeEmpleados = new System.Windows.Forms.Panel();
            this.AgregarEspecialidad = new System.Windows.Forms.Button();
            this.btnAgregarEspecialidadMedico = new System.Windows.Forms.Button();
            this.btnVerEmpleadosView = new System.Windows.Forms.Button();
            this.btnNuevaAgregarEmpleadoView = new System.Windows.Forms.Button();
            this.opcGestionDeEmpleados = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelOpcGestionDeUsuarios = new System.Windows.Forms.Panel();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.opcGestionDeUsuarios = new System.Windows.Forms.Button();
            this.panelOpcGestionPacientes = new System.Windows.Forms.Panel();
            this.btnVerPacientes = new System.Windows.Forms.Button();
            this.btnAggPaciente = new System.Windows.Forms.Button();
            this.opcGestionPaciente = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contenedor = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsuarioOnline = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panelOpcConsultaMedica.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.panelReportes.SuspendLayout();
            this.panelGestionCitas.SuspendLayout();
            this.panelOpcGestionDeEmpleados.SuspendLayout();
            this.panelOpcGestionDeUsuarios.SuspendLayout();
            this.panelOpcGestionPacientes.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.contenedor.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // opcConsultaMedica
            // 
            this.opcConsultaMedica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.opcConsultaMedica.Dock = System.Windows.Forms.DockStyle.Top;
            this.opcConsultaMedica.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(64)))));
            this.opcConsultaMedica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opcConsultaMedica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcConsultaMedica.ForeColor = System.Drawing.Color.AliceBlue;
            this.opcConsultaMedica.Image = ((System.Drawing.Image)(resources.GetObject("opcConsultaMedica.Image")));
            this.opcConsultaMedica.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.opcConsultaMedica.Location = new System.Drawing.Point(0, 189);
            this.opcConsultaMedica.Name = "opcConsultaMedica";
            this.opcConsultaMedica.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.opcConsultaMedica.Size = new System.Drawing.Size(210, 45);
            this.opcConsultaMedica.TabIndex = 1;
            this.opcConsultaMedica.Text = "CONSULTA MEDICA";
            this.opcConsultaMedica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.opcConsultaMedica.UseVisualStyleBackColor = false;
            this.opcConsultaMedica.Click += new System.EventHandler(this.opcConsultaMedica_Click);
            this.opcConsultaMedica.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.opcConsultaMedica.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // panelOpcConsultaMedica
            // 
            this.panelOpcConsultaMedica.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panelOpcConsultaMedica.Controls.Add(this.btnHistorialConsultas);
            this.panelOpcConsultaMedica.Controls.Add(this.btnRegistrarConsulta);
            this.panelOpcConsultaMedica.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOpcConsultaMedica.Location = new System.Drawing.Point(0, 234);
            this.panelOpcConsultaMedica.Name = "panelOpcConsultaMedica";
            this.panelOpcConsultaMedica.Size = new System.Drawing.Size(210, 83);
            this.panelOpcConsultaMedica.TabIndex = 2;
            // 
            // btnHistorialConsultas
            // 
            this.btnHistorialConsultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorialConsultas.FlatAppearance.BorderSize = 0;
            this.btnHistorialConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialConsultas.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnHistorialConsultas.Location = new System.Drawing.Point(0, 40);
            this.btnHistorialConsultas.Name = "btnHistorialConsultas";
            this.btnHistorialConsultas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnHistorialConsultas.Size = new System.Drawing.Size(210, 40);
            this.btnHistorialConsultas.TabIndex = 1;
            this.btnHistorialConsultas.Text = "HISTORIAL MEDICO";
            this.btnHistorialConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorialConsultas.UseVisualStyleBackColor = true;
            this.btnHistorialConsultas.Click += new System.EventHandler(this.btnHistorialConsultas_Click);
            // 
            // btnRegistrarConsulta
            // 
            this.btnRegistrarConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarConsulta.FlatAppearance.BorderSize = 0;
            this.btnRegistrarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarConsulta.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRegistrarConsulta.Location = new System.Drawing.Point(0, 0);
            this.btnRegistrarConsulta.Name = "btnRegistrarConsulta";
            this.btnRegistrarConsulta.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnRegistrarConsulta.Size = new System.Drawing.Size(210, 40);
            this.btnRegistrarConsulta.TabIndex = 0;
            this.btnRegistrarConsulta.Text = "REGISTRAR CONSULTA";
            this.btnRegistrarConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarConsulta.UseVisualStyleBackColor = true;
            this.btnRegistrarConsulta.Click += new System.EventHandler(this.btnNuevaConsultaView_Click);
            // 
            // panelDashboard
            // 
            this.panelDashboard.AutoScroll = true;
            this.panelDashboard.AutoScrollMargin = new System.Drawing.Size(20, 0);
            this.panelDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.panelDashboard.Controls.Add(this.panelReportes);
            this.panelDashboard.Controls.Add(this.panelReport);
            this.panelDashboard.Controls.Add(this.opcReportes);
            this.panelDashboard.Controls.Add(this.panelGestionCitas);
            this.panelDashboard.Controls.Add(this.opcCitas);
            this.panelDashboard.Controls.Add(this.panelOpcGestionDeEmpleados);
            this.panelDashboard.Controls.Add(this.opcGestionDeEmpleados);
            this.panelDashboard.Controls.Add(this.btnSalir);
            this.panelDashboard.Controls.Add(this.panelOpcGestionDeUsuarios);
            this.panelDashboard.Controls.Add(this.opcGestionDeUsuarios);
            this.panelDashboard.Controls.Add(this.panelOpcGestionPacientes);
            this.panelDashboard.Controls.Add(this.opcGestionPaciente);
            this.panelDashboard.Controls.Add(this.panelOpcConsultaMedica);
            this.panelDashboard.Controls.Add(this.opcConsultaMedica);
            this.panelDashboard.Controls.Add(this.panelLogo);
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDashboard.Location = new System.Drawing.Point(0, 0);
            this.panelDashboard.MinimumSize = new System.Drawing.Size(0, 563);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(227, 563);
            this.panelDashboard.TabIndex = 0;
            // 
            // panelReportes
            // 
            this.panelReportes.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panelReportes.Controls.Add(this.button1);
            this.panelReportes.Controls.Add(this.button10);
            this.panelReportes.Controls.Add(this.btnReporteConsultasDoctor);
            this.panelReportes.Controls.Add(this.button8);
            this.panelReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReportes.Location = new System.Drawing.Point(0, 1071);
            this.panelReportes.Name = "panelReportes";
            this.panelReportes.Size = new System.Drawing.Size(210, 153);
            this.panelReportes.TabIndex = 15;
            this.panelReportes.Paint += new System.Windows.Forms.PaintEventHandler(this.panelReportes_Paint);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(0, 80);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(210, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "REPORTE CONSULTAS ANUALES";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button10.Location = new System.Drawing.Point(0, 40);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(210, 40);
            this.button10.TabIndex = 3;
            this.button10.Text = "REPORTE DOCTORES POR ESPECIALIDAD";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // btnReporteConsultasDoctor
            // 
            this.btnReporteConsultasDoctor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporteConsultasDoctor.FlatAppearance.BorderSize = 0;
            this.btnReporteConsultasDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteConsultasDoctor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnReporteConsultasDoctor.Location = new System.Drawing.Point(0, 0);
            this.btnReporteConsultasDoctor.Name = "btnReporteConsultasDoctor";
            this.btnReporteConsultasDoctor.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnReporteConsultasDoctor.Size = new System.Drawing.Size(210, 40);
            this.btnReporteConsultasDoctor.TabIndex = 2;
            this.btnReporteConsultasDoctor.Text = "REPORTE CONSULTAS POR DOCTOR";
            this.btnReporteConsultasDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteConsultasDoctor.UseVisualStyleBackColor = true;
            this.btnReporteConsultasDoctor.Click += new System.EventHandler(this.btnReporteConsultasDoctor_Click_1);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(0, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 5;
            // 
            // panelReport
            // 
            this.panelReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReport.Location = new System.Drawing.Point(0, 1071);
            this.panelReport.MinimumSize = new System.Drawing.Size(110, 0);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(210, 153);
            this.panelReport.TabIndex = 14;
            // 
            // opcReportes
            // 
            this.opcReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.opcReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.opcReportes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(64)))));
            this.opcReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opcReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcReportes.ForeColor = System.Drawing.Color.AliceBlue;
            this.opcReportes.Image = ((System.Drawing.Image)(resources.GetObject("opcReportes.Image")));
            this.opcReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.opcReportes.Location = new System.Drawing.Point(0, 1016);
            this.opcReportes.Name = "opcReportes";
            this.opcReportes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.opcReportes.Size = new System.Drawing.Size(210, 55);
            this.opcReportes.TabIndex = 13;
            this.opcReportes.Text = "REPORTES";
            this.opcReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.opcReportes.UseVisualStyleBackColor = false;
            this.opcReportes.Visible = false;
            this.opcReportes.Click += new System.EventHandler(this.opcReportes_Click);
            // 
            // panelGestionCitas
            // 
            this.panelGestionCitas.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panelGestionCitas.Controls.Add(this.button2);
            this.panelGestionCitas.Controls.Add(this.button3);
            this.panelGestionCitas.Controls.Add(this.btnVerCita);
            this.panelGestionCitas.Controls.Add(this.btnRegistrarCitaView);
            this.panelGestionCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGestionCitas.Location = new System.Drawing.Point(0, 861);
            this.panelGestionCitas.Name = "panelGestionCitas";
            this.panelGestionCitas.Size = new System.Drawing.Size(210, 155);
            this.panelGestionCitas.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(0, 120);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(210, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "DOCTORES SEGUN ESPECIALIDAD";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(0, 80);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(210, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "HORARIOS MEDICOS";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnVerCita
            // 
            this.btnVerCita.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerCita.FlatAppearance.BorderSize = 0;
            this.btnVerCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCita.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnVerCita.Location = new System.Drawing.Point(0, 40);
            this.btnVerCita.MinimumSize = new System.Drawing.Size(10, 0);
            this.btnVerCita.Name = "btnVerCita";
            this.btnVerCita.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnVerCita.Size = new System.Drawing.Size(210, 40);
            this.btnVerCita.TabIndex = 1;
            this.btnVerCita.Text = "VER CITAS";
            this.btnVerCita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerCita.UseVisualStyleBackColor = true;
            this.btnVerCita.Click += new System.EventHandler(this.btnVerCita_Click);
            // 
            // btnRegistrarCitaView
            // 
            this.btnRegistrarCitaView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarCitaView.FlatAppearance.BorderSize = 0;
            this.btnRegistrarCitaView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCitaView.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRegistrarCitaView.Location = new System.Drawing.Point(0, 0);
            this.btnRegistrarCitaView.Name = "btnRegistrarCitaView";
            this.btnRegistrarCitaView.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnRegistrarCitaView.Size = new System.Drawing.Size(210, 40);
            this.btnRegistrarCitaView.TabIndex = 0;
            this.btnRegistrarCitaView.Text = "REGISTRAR CITA";
            this.btnRegistrarCitaView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarCitaView.UseVisualStyleBackColor = true;
            this.btnRegistrarCitaView.Click += new System.EventHandler(this.btnRegistrarCitaView_Click);
            // 
            // opcCitas
            // 
            this.opcCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.opcCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.opcCitas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(64)))));
            this.opcCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opcCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcCitas.ForeColor = System.Drawing.Color.AliceBlue;
            this.opcCitas.Image = ((System.Drawing.Image)(resources.GetObject("opcCitas.Image")));
            this.opcCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.opcCitas.Location = new System.Drawing.Point(0, 816);
            this.opcCitas.Name = "opcCitas";
            this.opcCitas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.opcCitas.Size = new System.Drawing.Size(210, 45);
            this.opcCitas.TabIndex = 11;
            this.opcCitas.Text = "GESTION DE CITAS ";
            this.opcCitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.opcCitas.UseVisualStyleBackColor = false;
            this.opcCitas.Click += new System.EventHandler(this.opcCitas_Click);
            // 
            // panelOpcGestionDeEmpleados
            // 
            this.panelOpcGestionDeEmpleados.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panelOpcGestionDeEmpleados.Controls.Add(this.button4);
            this.panelOpcGestionDeEmpleados.Controls.Add(this.AgregarEspecialidad);
            this.panelOpcGestionDeEmpleados.Controls.Add(this.btnAgregarEspecialidadMedico);
            this.panelOpcGestionDeEmpleados.Controls.Add(this.btnVerEmpleadosView);
            this.panelOpcGestionDeEmpleados.Controls.Add(this.btnNuevaAgregarEmpleadoView);
            this.panelOpcGestionDeEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOpcGestionDeEmpleados.Location = new System.Drawing.Point(0, 612);
            this.panelOpcGestionDeEmpleados.Name = "panelOpcGestionDeEmpleados";
            this.panelOpcGestionDeEmpleados.Size = new System.Drawing.Size(210, 204);
            this.panelOpcGestionDeEmpleados.TabIndex = 10;
            // 
            // AgregarEspecialidad
            // 
            this.AgregarEspecialidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.AgregarEspecialidad.FlatAppearance.BorderSize = 0;
            this.AgregarEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarEspecialidad.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.AgregarEspecialidad.Location = new System.Drawing.Point(0, 120);
            this.AgregarEspecialidad.Name = "AgregarEspecialidad";
            this.AgregarEspecialidad.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.AgregarEspecialidad.Size = new System.Drawing.Size(210, 40);
            this.AgregarEspecialidad.TabIndex = 3;
            this.AgregarEspecialidad.Text = "AGREGAR ESPECIALIDAD";
            this.AgregarEspecialidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarEspecialidad.UseVisualStyleBackColor = true;
            this.AgregarEspecialidad.Click += new System.EventHandler(this.AgregarEspecialidad_Click);
            // 
            // btnAgregarEspecialidadMedico
            // 
            this.btnAgregarEspecialidadMedico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarEspecialidadMedico.FlatAppearance.BorderSize = 0;
            this.btnAgregarEspecialidadMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEspecialidadMedico.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgregarEspecialidadMedico.Location = new System.Drawing.Point(0, 80);
            this.btnAgregarEspecialidadMedico.Name = "btnAgregarEspecialidadMedico";
            this.btnAgregarEspecialidadMedico.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAgregarEspecialidadMedico.Size = new System.Drawing.Size(210, 40);
            this.btnAgregarEspecialidadMedico.TabIndex = 2;
            this.btnAgregarEspecialidadMedico.Text = "VER ESPECIALIDADES MEDICO";
            this.btnAgregarEspecialidadMedico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarEspecialidadMedico.UseVisualStyleBackColor = true;
            this.btnAgregarEspecialidadMedico.Click += new System.EventHandler(this.btnAgregarEspecialidadMedico_Click);
            // 
            // btnVerEmpleadosView
            // 
            this.btnVerEmpleadosView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerEmpleadosView.FlatAppearance.BorderSize = 0;
            this.btnVerEmpleadosView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerEmpleadosView.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnVerEmpleadosView.Location = new System.Drawing.Point(0, 40);
            this.btnVerEmpleadosView.Name = "btnVerEmpleadosView";
            this.btnVerEmpleadosView.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnVerEmpleadosView.Size = new System.Drawing.Size(210, 40);
            this.btnVerEmpleadosView.TabIndex = 1;
            this.btnVerEmpleadosView.Text = "VER EMPLEADOS";
            this.btnVerEmpleadosView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerEmpleadosView.UseVisualStyleBackColor = true;
            this.btnVerEmpleadosView.Click += new System.EventHandler(this.btnVerEmpleadosView_Click);
            // 
            // btnNuevaAgregarEmpleadoView
            // 
            this.btnNuevaAgregarEmpleadoView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevaAgregarEmpleadoView.FlatAppearance.BorderSize = 0;
            this.btnNuevaAgregarEmpleadoView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaAgregarEmpleadoView.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnNuevaAgregarEmpleadoView.Location = new System.Drawing.Point(0, 0);
            this.btnNuevaAgregarEmpleadoView.Name = "btnNuevaAgregarEmpleadoView";
            this.btnNuevaAgregarEmpleadoView.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnNuevaAgregarEmpleadoView.Size = new System.Drawing.Size(210, 40);
            this.btnNuevaAgregarEmpleadoView.TabIndex = 0;
            this.btnNuevaAgregarEmpleadoView.Text = "AGREGAR EMPLEADO";
            this.btnNuevaAgregarEmpleadoView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaAgregarEmpleadoView.UseVisualStyleBackColor = true;
            this.btnNuevaAgregarEmpleadoView.Click += new System.EventHandler(this.btnNuevaAgregarEmpleadoView_Click);
            // 
            // opcGestionDeEmpleados
            // 
            this.opcGestionDeEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.opcGestionDeEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.opcGestionDeEmpleados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(64)))));
            this.opcGestionDeEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opcGestionDeEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcGestionDeEmpleados.ForeColor = System.Drawing.Color.AliceBlue;
            this.opcGestionDeEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("opcGestionDeEmpleados.Image")));
            this.opcGestionDeEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.opcGestionDeEmpleados.Location = new System.Drawing.Point(0, 567);
            this.opcGestionDeEmpleados.Name = "opcGestionDeEmpleados";
            this.opcGestionDeEmpleados.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.opcGestionDeEmpleados.Size = new System.Drawing.Size(210, 45);
            this.opcGestionDeEmpleados.TabIndex = 9;
            this.opcGestionDeEmpleados.Text = "GESTION DE EMPLEADOS";
            this.opcGestionDeEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.opcGestionDeEmpleados.UseVisualStyleBackColor = false;
            this.opcGestionDeEmpleados.Click += new System.EventHandler(this.opcGestionDeEmpleados_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(64)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.Location = new System.Drawing.Point(0, 1224);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(210, 45);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "CERRAR SESSION";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // panelOpcGestionDeUsuarios
            // 
            this.panelOpcGestionDeUsuarios.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panelOpcGestionDeUsuarios.Controls.Add(this.btnAgregarUsuario);
            this.panelOpcGestionDeUsuarios.Controls.Add(this.btnUsuarios);
            this.panelOpcGestionDeUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOpcGestionDeUsuarios.Location = new System.Drawing.Point(0, 491);
            this.panelOpcGestionDeUsuarios.Name = "panelOpcGestionDeUsuarios";
            this.panelOpcGestionDeUsuarios.Size = new System.Drawing.Size(210, 76);
            this.panelOpcGestionDeUsuarios.TabIndex = 7;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarUsuario.FlatAppearance.BorderSize = 0;
            this.btnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUsuario.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(0, 40);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAgregarUsuario.Size = new System.Drawing.Size(210, 40);
            this.btnAgregarUsuario.TabIndex = 1;
            this.btnAgregarUsuario.Text = "AGREGAR USUARIO";
            this.btnAgregarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 0);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(210, 40);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "VER USUARIOS";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // opcGestionDeUsuarios
            // 
            this.opcGestionDeUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.opcGestionDeUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.opcGestionDeUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(64)))));
            this.opcGestionDeUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opcGestionDeUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcGestionDeUsuarios.ForeColor = System.Drawing.Color.AliceBlue;
            this.opcGestionDeUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("opcGestionDeUsuarios.Image")));
            this.opcGestionDeUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.opcGestionDeUsuarios.Location = new System.Drawing.Point(0, 446);
            this.opcGestionDeUsuarios.Name = "opcGestionDeUsuarios";
            this.opcGestionDeUsuarios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.opcGestionDeUsuarios.Size = new System.Drawing.Size(210, 45);
            this.opcGestionDeUsuarios.TabIndex = 6;
            this.opcGestionDeUsuarios.Text = "GESTION DE USUARIOS";
            this.opcGestionDeUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.opcGestionDeUsuarios.UseVisualStyleBackColor = false;
            this.opcGestionDeUsuarios.Click += new System.EventHandler(this.opcGestionDeUsuarios_Click);
            // 
            // panelOpcGestionPacientes
            // 
            this.panelOpcGestionPacientes.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panelOpcGestionPacientes.Controls.Add(this.btnVerPacientes);
            this.panelOpcGestionPacientes.Controls.Add(this.btnAggPaciente);
            this.panelOpcGestionPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOpcGestionPacientes.Location = new System.Drawing.Point(0, 362);
            this.panelOpcGestionPacientes.Name = "panelOpcGestionPacientes";
            this.panelOpcGestionPacientes.Size = new System.Drawing.Size(210, 84);
            this.panelOpcGestionPacientes.TabIndex = 4;
            // 
            // btnVerPacientes
            // 
            this.btnVerPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerPacientes.FlatAppearance.BorderSize = 0;
            this.btnVerPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPacientes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnVerPacientes.Location = new System.Drawing.Point(0, 40);
            this.btnVerPacientes.Name = "btnVerPacientes";
            this.btnVerPacientes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnVerPacientes.Size = new System.Drawing.Size(210, 40);
            this.btnVerPacientes.TabIndex = 2;
            this.btnVerPacientes.Text = "VER PACIENTES";
            this.btnVerPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerPacientes.UseVisualStyleBackColor = true;
            this.btnVerPacientes.Click += new System.EventHandler(this.btnVerPacientes_Click);
            // 
            // btnAggPaciente
            // 
            this.btnAggPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAggPaciente.FlatAppearance.BorderSize = 0;
            this.btnAggPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggPaciente.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAggPaciente.Location = new System.Drawing.Point(0, 0);
            this.btnAggPaciente.Name = "btnAggPaciente";
            this.btnAggPaciente.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAggPaciente.Size = new System.Drawing.Size(210, 40);
            this.btnAggPaciente.TabIndex = 1;
            this.btnAggPaciente.Text = "AGREGAR PACIENTE";
            this.btnAggPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAggPaciente.UseVisualStyleBackColor = true;
            this.btnAggPaciente.Click += new System.EventHandler(this.btnAggPaciente_Click);
            // 
            // opcGestionPaciente
            // 
            this.opcGestionPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.opcGestionPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.opcGestionPaciente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(64)))));
            this.opcGestionPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opcGestionPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcGestionPaciente.ForeColor = System.Drawing.Color.AliceBlue;
            this.opcGestionPaciente.Image = ((System.Drawing.Image)(resources.GetObject("opcGestionPaciente.Image")));
            this.opcGestionPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.opcGestionPaciente.Location = new System.Drawing.Point(0, 317);
            this.opcGestionPaciente.Name = "opcGestionPaciente";
            this.opcGestionPaciente.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.opcGestionPaciente.Size = new System.Drawing.Size(210, 45);
            this.opcGestionPaciente.TabIndex = 3;
            this.opcGestionPaciente.Text = "GESTION DE PACIENTES";
            this.opcGestionPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.opcGestionPaciente.UseVisualStyleBackColor = false;
            this.opcGestionPaciente.Click += new System.EventHandler(this.opcGestionPaciente_Click);
            this.opcGestionPaciente.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.opcGestionPaciente.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.panel1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(210, 189);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "CLIGAR";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(42, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 109);
            this.panel1.TabIndex = 0;
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.Transparent;
            this.contenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contenedor.BackgroundImage")));
            this.contenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contenedor.Controls.Add(this.panel2);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(227, 0);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(977, 563);
            this.contenedor.TabIndex = 1;
            this.contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.contenedor_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.lblTipoUsuario);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblUsuarioOnline);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 543);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 20);
            this.panel2.TabIndex = 0;
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuario.ForeColor = System.Drawing.Color.White;
            this.lblTipoUsuario.Location = new System.Drawing.Point(631, 2);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(107, 17);
            this.lblTipoUsuario.TabIndex = 3;
            this.lblTipoUsuario.Text = "Tipo de usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SpringGreen;
            this.label3.Location = new System.Drawing.Point(484, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "TIPO DE USUARIO : ";
            // 
            // lblUsuarioOnline
            // 
            this.lblUsuarioOnline.AutoSize = true;
            this.lblUsuarioOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioOnline.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioOnline.Location = new System.Drawing.Point(152, 3);
            this.lblUsuarioOnline.Name = "lblUsuarioOnline";
            this.lblUsuarioOnline.Size = new System.Drawing.Size(129, 17);
            this.lblUsuarioOnline.TabIndex = 1;
            this.lblUsuarioOnline.Text = "Nombre de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SpringGreen;
            this.label2.Location = new System.Drawing.Point(20, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "USUARIO ONLINE : ";
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Location = new System.Drawing.Point(0, 160);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(210, 40);
            this.button4.TabIndex = 4;
            this.button4.Text = "VER  ESPECIALIDADES";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 563);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.panelDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelOpcConsultaMedica.ResumeLayout(false);
            this.panelDashboard.ResumeLayout(false);
            this.panelReportes.ResumeLayout(false);
            this.panelGestionCitas.ResumeLayout(false);
            this.panelOpcGestionDeEmpleados.ResumeLayout(false);
            this.panelOpcGestionDeUsuarios.ResumeLayout(false);
            this.panelOpcGestionPacientes.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.contenedor.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button opcConsultaMedica;
        private System.Windows.Forms.Panel panelOpcConsultaMedica;
        private System.Windows.Forms.Button btnHistorialConsultas;
        private System.Windows.Forms.Button btnRegistrarConsulta;
        private System.Windows.Forms.Panel panelOpcGestionPacientes;
        private System.Windows.Forms.Button btnVerPacientes;
        private System.Windows.Forms.Button btnAggPaciente;
        private System.Windows.Forms.Button opcGestionPaciente;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUsuarioOnline;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Panel panelOpcGestionDeEmpleados;
        private System.Windows.Forms.Button AgregarEspecialidad;
        private System.Windows.Forms.Button btnVerEmpleadosView;
        private System.Windows.Forms.Button btnNuevaAgregarEmpleadoView;
        private System.Windows.Forms.Panel panelOpcGestionDeUsuarios;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button opcGestionDeUsuarios;
        private System.Windows.Forms.Panel panelGestionCitas;
        private System.Windows.Forms.Button opcCitas;
        private System.Windows.Forms.Button btnAgregarEspecialidadMedico;
        private System.Windows.Forms.Button opcGestionDeEmpleados;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button ImprimirCita;
        private System.Windows.Forms.Button btnVerCita;
        private System.Windows.Forms.Button btnRegistrarCitaView;
        private System.Windows.Forms.Button btnDocEsp;
        private System.Windows.Forms.Button opcReportes;
        private System.Windows.Forms.Panel panelReport;
        private System.Windows.Forms.Panel panelReportes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnReporteConsultasDoctor;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}