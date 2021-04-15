
namespace MiPrimeraAplicacionDeConsola02
{
    partial class frmTipoUsuario
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
            this.dgvTipoUsuario = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreTipoUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTipoUsuario
            // 
            this.dgvTipoUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoUsuario.Location = new System.Drawing.Point(12, 56);
            this.dgvTipoUsuario.Name = "dgvTipoUsuario";
            this.dgvTipoUsuario.Size = new System.Drawing.Size(776, 382);
            this.dgvTipoUsuario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el nombre de tipo usuario";
            // 
            // txtNombreTipoUsuario
            // 
            this.txtNombreTipoUsuario.Location = new System.Drawing.Point(207, 11);
            this.txtNombreTipoUsuario.Name = "txtNombreTipoUsuario";
            this.txtNombreTipoUsuario.Size = new System.Drawing.Size(249, 20);
            this.txtNombreTipoUsuario.TabIndex = 2;
            this.txtNombreTipoUsuario.TextChanged += new System.EventHandler(this.filtrarTipoUsuario);
            // 
            // frmTipoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNombreTipoUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTipoUsuario);
            this.Name = "frmTipoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo Usuario";
            this.Load += new System.EventHandler(this.frmTipoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTipoUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreTipoUsuario;
    }
}