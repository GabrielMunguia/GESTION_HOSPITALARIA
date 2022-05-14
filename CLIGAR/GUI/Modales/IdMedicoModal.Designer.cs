
namespace CLIGAR.GUI.Modales
{
    partial class IdMedicoModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdMedicoModal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.titulo = new System.Windows.Forms.Label();
            this.txtNit = new System.Windows.Forms.Label();
            this.lblNIT = new System.Windows.Forms.Label();
            this.txtDui = new System.Windows.Forms.Label();
            this.lblDUI = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnBuscarMedico = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJVM = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.titulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 42);
            this.panel1.TabIndex = 9;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.White;
            this.titulo.Location = new System.Drawing.Point(209, 9);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(227, 20);
            this.titulo.TabIndex = 1;
            this.titulo.Text = "SELECCIONE UN MEDICO";
            // 
            // txtNit
            // 
            this.txtNit.AutoSize = true;
            this.txtNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNit.Location = new System.Drawing.Point(133, 293);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(205, 24);
            this.txtNit.TabIndex = 31;
            this.txtNit.Text = "NOMBRE DE PRUEBA";
            this.txtNit.Visible = false;
            // 
            // lblNIT
            // 
            this.lblNIT.AutoSize = true;
            this.lblNIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIT.Location = new System.Drawing.Point(72, 293);
            this.lblNIT.Name = "lblNIT";
            this.lblNIT.Size = new System.Drawing.Size(55, 24);
            this.lblNIT.TabIndex = 30;
            this.lblNIT.Text = "NIT : ";
            this.lblNIT.Visible = false;
            // 
            // txtDui
            // 
            this.txtDui.AutoSize = true;
            this.txtDui.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDui.Location = new System.Drawing.Point(133, 252);
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(205, 24);
            this.txtDui.TabIndex = 29;
            this.txtDui.Text = "NOMBRE DE PRUEBA";
            this.txtDui.Visible = false;
            // 
            // lblDUI
            // 
            this.lblDUI.AutoSize = true;
            this.lblDUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDUI.Location = new System.Drawing.Point(72, 252);
            this.lblDUI.Name = "lblDUI";
            this.lblDUI.Size = new System.Drawing.Size(55, 24);
            this.lblDUI.TabIndex = 28;
            this.lblDUI.Text = "DUI : ";
            this.lblDUI.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(186, 215);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(205, 24);
            this.txtNombre.TabIndex = 27;
            this.txtNombre.Text = "NOMBRE DE PRUEBA";
            this.txtNombre.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(72, 215);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(108, 24);
            this.lblNombre.TabIndex = 26;
            this.lblNombre.Text = "NOMBRE : ";
            this.lblNombre.Visible = false;
            // 
            // btnBuscarMedico
            // 
            this.btnBuscarMedico.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscarMedico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarMedico.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBuscarMedico.Location = new System.Drawing.Point(272, 128);
            this.btnBuscarMedico.Name = "btnBuscarMedico";
            this.btnBuscarMedico.Size = new System.Drawing.Size(110, 39);
            this.btnBuscarMedico.TabIndex = 25;
            this.btnBuscarMedico.Text = "BUSCAR";
            this.btnBuscarMedico.UseVisualStyleBackColor = false;
            this.btnBuscarMedico.Click += new System.EventHandler(this.btnBuscarMedico_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(170, 170);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(332, 17);
            this.lblError.TabIndex = 24;
            this.lblError.Text = "ERROR : No se encontro ningun medico con ese id";
            this.lblError.Visible = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnConfirmar.Location = new System.Drawing.Point(463, 334);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(122, 44);
            this.btnConfirmar.TabIndex = 23;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(180, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "INGRESE EL JVM DEL MEDICO";
            // 
            // txtJVM
            // 
            this.txtJVM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJVM.Location = new System.Drawing.Point(196, 93);
            this.txtJVM.Name = "txtJVM";
            this.txtJVM.Size = new System.Drawing.Size(256, 29);
            this.txtJVM.TabIndex = 21;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrar.Location = new System.Drawing.Point(0, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(44, 42);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.Paint += new System.Windows.Forms.PaintEventHandler(this.btnCerrar_Paint);
            // 
            // IdMedicoModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 390);
            this.Controls.Add(this.txtNit);
            this.Controls.Add(this.lblNIT);
            this.Controls.Add(this.txtDui);
            this.Controls.Add(this.lblDUI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnBuscarMedico);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtJVM);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IdMedicoModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IdMedicoModal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label txtNit;
        private System.Windows.Forms.Label lblNIT;
        private System.Windows.Forms.Label txtDui;
        private System.Windows.Forms.Label lblDUI;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.Button btnBuscarMedico;
        private System.Windows.Forms.Label lblError;
        public System.Windows.Forms.Button btnConfirmar;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJVM;
        private System.Windows.Forms.Panel btnCerrar;
    }
}