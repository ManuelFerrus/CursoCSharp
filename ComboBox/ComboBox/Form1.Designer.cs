namespace ComboBox
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
            this.cboPersona = new System.Windows.Forms.ComboBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnValue = new System.Windows.Forms.Button();
            this.btnMostrarValores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboPersona
            // 
            this.cboPersona.FormattingEnabled = true;
            this.cboPersona.Location = new System.Drawing.Point(51, 24);
            this.cboPersona.Name = "cboPersona";
            this.cboPersona.Size = new System.Drawing.Size(121, 21);
            this.cboPersona.TabIndex = 0;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(102, 119);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnValue
            // 
            this.btnValue.Location = new System.Drawing.Point(81, 169);
            this.btnValue.Name = "btnValue";
            this.btnValue.Size = new System.Drawing.Size(116, 23);
            this.btnValue.TabIndex = 2;
            this.btnValue.Text = "Mostrar Value";
            this.btnValue.UseVisualStyleBackColor = true;
            this.btnValue.Click += new System.EventHandler(this.btnValue_Click);
            // 
            // btnMostrarValores
            // 
            this.btnMostrarValores.Location = new System.Drawing.Point(81, 218);
            this.btnMostrarValores.Name = "btnMostrarValores";
            this.btnMostrarValores.Size = new System.Drawing.Size(116, 23);
            this.btnMostrarValores.TabIndex = 3;
            this.btnMostrarValores.Text = "Mostrar Valores";
            this.btnMostrarValores.UseVisualStyleBackColor = true;
            this.btnMostrarValores.Click += new System.EventHandler(this.btnMostrarValores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnMostrarValores);
            this.Controls.Add(this.btnValue);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.cboPersona);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPersona;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnValue;
        private System.Windows.Forms.Button btnMostrarValores;
    }
}

