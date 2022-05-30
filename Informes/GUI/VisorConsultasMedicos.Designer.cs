namespace Informes.GUI
{
    partial class VisorConsultasMedicos
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
            this.crvConsultas = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvConsultas
            // 
            this.crvConsultas.ActiveViewIndex = -1;
            this.crvConsultas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvConsultas.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvConsultas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvConsultas.Location = new System.Drawing.Point(0, 0);
            this.crvConsultas.Name = "crvConsultas";
            this.crvConsultas.Size = new System.Drawing.Size(901, 473);
            this.crvConsultas.TabIndex = 0;
            this.crvConsultas.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // VisorConsultasMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 473);
            this.Controls.Add(this.crvConsultas);
            this.Name = "VisorConsultasMedicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisorConsultasMedicos";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvConsultas;
    }
}