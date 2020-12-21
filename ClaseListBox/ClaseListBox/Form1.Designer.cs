namespace ClaseListBox
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent( )
        {
            this.lbCursos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbCursos
            // 
            this.lbCursos.FormattingEnabled = true;
            this.lbCursos.Items.AddRange(new object[] {
            "Matematicas",
            "Comunicacion",
            "Religion",
            "Educacion Fisica"});
            this.lbCursos.Location = new System.Drawing.Point(13, 13);
            this.lbCursos.Name = "lbCursos";
            this.lbCursos.Size = new System.Drawing.Size(259, 160);
            this.lbCursos.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbCursos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbCursos;
    }
}

