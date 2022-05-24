namespace CLIGAR.GUI.Recepcion
{
    partial class AgregarCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarCita));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.btnSeleccionarDoctor = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHorarioLunes = new System.Windows.Forms.Label();
            this.lblHorarioMartes = new System.Windows.Forms.Label();
            this.lblHorarioMiercoles = new System.Windows.Forms.Label();
            this.lblHorarioJueves = new System.Windows.Forms.Label();
            this.lblHorarioViernes = new System.Windows.Forms.Label();
            this.lblHorarioSabado = new System.Windows.Forms.Label();
            this.lblHorarioDomingo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.btnSeleccionarPaciente = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.txtResonsable = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.cbxUrgencia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Urgencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1091, 35);
            this.panel1.TabIndex = 2;
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
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1091, 50);
            this.panel2.TabIndex = 3;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1091, 50);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.btnSeleccionarDoctor.Location = new System.Drawing.Point(797, 3);
            this.btnSeleccionarDoctor.MaximumSize = new System.Drawing.Size(291, 44);
            this.btnSeleccionarDoctor.MinimumSize = new System.Drawing.Size(291, 44);
            this.btnSeleccionarDoctor.Name = "btnSeleccionarDoctor";
            this.btnSeleccionarDoctor.Size = new System.Drawing.Size(291, 44);
            this.btnSeleccionarDoctor.TabIndex = 13;
            this.btnSeleccionarDoctor.Text = "SELECCIONAR DOCTOR";
            this.btnSeleccionarDoctor.UseVisualStyleBackColor = false;
            this.btnSeleccionarDoctor.Click += new System.EventHandler(this.btnSeleccionarDoctor_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 85);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1091, 452);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lblHorarioLunes, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblHorarioMartes, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblHorarioMiercoles, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblHorarioJueves, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblHorarioViernes, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.lblHorarioSabado, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.lblHorarioDomingo, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(214, 446);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lblHorarioLunes
            // 
            this.lblHorarioLunes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHorarioLunes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarioLunes.Location = new System.Drawing.Point(3, 55);
            this.lblHorarioLunes.Name = "lblHorarioLunes";
            this.lblHorarioLunes.Size = new System.Drawing.Size(208, 55);
            this.lblHorarioLunes.TabIndex = 28;
            this.lblHorarioLunes.Text = "LUNES :";
            this.lblHorarioLunes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHorarioMartes
            // 
            this.lblHorarioMartes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHorarioMartes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarioMartes.Location = new System.Drawing.Point(3, 110);
            this.lblHorarioMartes.Name = "lblHorarioMartes";
            this.lblHorarioMartes.Size = new System.Drawing.Size(208, 55);
            this.lblHorarioMartes.TabIndex = 27;
            this.lblHorarioMartes.Text = "MARTES :";
            this.lblHorarioMartes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHorarioMiercoles
            // 
            this.lblHorarioMiercoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHorarioMiercoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarioMiercoles.Location = new System.Drawing.Point(3, 165);
            this.lblHorarioMiercoles.Name = "lblHorarioMiercoles";
            this.lblHorarioMiercoles.Size = new System.Drawing.Size(208, 55);
            this.lblHorarioMiercoles.TabIndex = 26;
            this.lblHorarioMiercoles.Text = "MIERCOLES : ";
            this.lblHorarioMiercoles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHorarioJueves
            // 
            this.lblHorarioJueves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHorarioJueves.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarioJueves.Location = new System.Drawing.Point(3, 220);
            this.lblHorarioJueves.Name = "lblHorarioJueves";
            this.lblHorarioJueves.Size = new System.Drawing.Size(208, 55);
            this.lblHorarioJueves.TabIndex = 25;
            this.lblHorarioJueves.Text = "JUEVES :";
            this.lblHorarioJueves.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHorarioViernes
            // 
            this.lblHorarioViernes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHorarioViernes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarioViernes.Location = new System.Drawing.Point(3, 275);
            this.lblHorarioViernes.Name = "lblHorarioViernes";
            this.lblHorarioViernes.Size = new System.Drawing.Size(208, 55);
            this.lblHorarioViernes.TabIndex = 24;
            this.lblHorarioViernes.Text = "VIERNES :";
            this.lblHorarioViernes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHorarioSabado
            // 
            this.lblHorarioSabado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHorarioSabado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarioSabado.Location = new System.Drawing.Point(3, 330);
            this.lblHorarioSabado.Name = "lblHorarioSabado";
            this.lblHorarioSabado.Size = new System.Drawing.Size(208, 55);
            this.lblHorarioSabado.TabIndex = 23;
            this.lblHorarioSabado.Text = "SABADO :";
            this.lblHorarioSabado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHorarioDomingo
            // 
            this.lblHorarioDomingo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHorarioDomingo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarioDomingo.Location = new System.Drawing.Point(3, 385);
            this.lblHorarioDomingo.Name = "lblHorarioDomingo";
            this.lblHorarioDomingo.Size = new System.Drawing.Size(208, 61);
            this.lblHorarioDomingo.TabIndex = 17;
            this.lblHorarioDomingo.Text = "DOMINGO :";
            this.lblHorarioDomingo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 55);
            this.label1.TabIndex = 16;
            this.label1.Text = "HORARIOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(223, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.43498F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.56503F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(865, 446);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.00699F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.99302F));
            this.tableLayoutPanel5.Controls.Add(this.lblPaciente, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnSeleccionarPaciente, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(859, 45);
            this.tableLayoutPanel5.TabIndex = 1;
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
            this.btnSeleccionarPaciente.Location = new System.Drawing.Point(569, 3);
            this.btnSeleccionarPaciente.MaximumSize = new System.Drawing.Size(291, 44);
            this.btnSeleccionarPaciente.MinimumSize = new System.Drawing.Size(291, 44);
            this.btnSeleccionarPaciente.Name = "btnSeleccionarPaciente";
            this.btnSeleccionarPaciente.Size = new System.Drawing.Size(291, 44);
            this.btnSeleccionarPaciente.TabIndex = 13;
            this.btnSeleccionarPaciente.Text = "SELECCIONAR PACIENTE";
            this.btnSeleccionarPaciente.UseVisualStyleBackColor = false;
            this.btnSeleccionarPaciente.Click += new System.EventHandler(this.btnSeleccionarPaciente_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.33876F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.66124F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel8, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel9, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.dgvCitas, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 54);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.46154F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.53846F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(859, 389);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.dtpFechaCita, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.txtResonsable, 1, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(434, 104);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "RESPONSABLE : ";
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
            this.dtpFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaCita.Location = new System.Drawing.Point(164, 3);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(267, 27);
            this.dtpFechaCita.TabIndex = 17;
            this.dtpFechaCita.ValueChanged += new System.EventHandler(this.dtpFechaCita_ValueChanged);
            // 
            // txtResonsable
            // 
            this.txtResonsable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResonsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResonsable.Location = new System.Drawing.Point(164, 55);
            this.txtResonsable.Name = "txtResonsable";
            this.txtResonsable.Size = new System.Drawing.Size(267, 27);
            this.txtResonsable.TabIndex = 19;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.txtContacto, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.cbxUrgencia, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(443, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(413, 104);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "CONTACTO";
            // 
            // txtContacto
            // 
            this.txtContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContacto.Location = new System.Drawing.Point(133, 55);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(277, 27);
            this.txtContacto.TabIndex = 21;
            // 
            // cbxUrgencia
            // 
            this.cbxUrgencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxUrgencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUrgencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUrgencia.FormattingEnabled = true;
            this.cbxUrgencia.Items.AddRange(new object[] {
            "Leve",
            "Grave",
            "Muy grave"});
            this.cbxUrgencia.Location = new System.Drawing.Point(133, 3);
            this.cbxUrgencia.Name = "cbxUrgencia";
            this.cbxUrgencia.Size = new System.Drawing.Size(277, 28);
            this.cbxUrgencia.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "URGENCIA  : ";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.80145F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.19855F));
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel14, 1, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(443, 113);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(413, 273);
            this.tableLayoutPanel9.TabIndex = 2;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 2;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.82051F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.17949F));
            this.tableLayoutPanel14.Controls.Add(this.tableLayoutPanel15, 1, 0);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(59, 212);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 1;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(351, 58);
            this.tableLayoutPanel14.TabIndex = 12;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 2;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.10174F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.89826F));
            this.tableLayoutPanel15.Controls.Add(this.btnGuardar, 1, 0);
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(47, 3);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 1;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(301, 52);
            this.tableLayoutPanel15.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(162, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(136, 46);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.Urgencia,
            this.Hora,
            this.Detalle});
            this.dgvCitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCitas.Location = new System.Drawing.Point(3, 113);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCitas.Size = new System.Drawing.Size(434, 273);
            this.dgvCitas.TabIndex = 3;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
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
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Image = ((System.Drawing.Image)(resources.GetObject("Detalle.Image")));
            this.Detalle.Name = "Detalle";
            // 
            // AgregarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1091, 537);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarCita";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel btnCerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDoctor;
        public System.Windows.Forms.Button btnSeleccionarDoctor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblHorarioLunes;
        private System.Windows.Forms.Label lblHorarioMartes;
        private System.Windows.Forms.Label lblHorarioMiercoles;
        private System.Windows.Forms.Label lblHorarioDomingo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHorarioJueves;
        private System.Windows.Forms.Label lblHorarioViernes;
        private System.Windows.Forms.Label lblHorarioSabado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lblPaciente;
        public System.Windows.Forms.Button btnSeleccionarPaciente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.ComboBox cbxUrgencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResonsable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urgencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewImageColumn Detalle;
    }
}