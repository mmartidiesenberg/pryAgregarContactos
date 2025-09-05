namespace pryAgregarContactos
{
    partial class frmDatosContacto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumero = new System.Windows.Forms.MaskedTextBox();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.lstListadoDatos = new System.Windows.Forms.ListBox();
            this.lblDatos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(329, 208);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.Mask = "(999)000-0000";
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(143, 29);
            this.txtNumero.TabIndex = 0;
            // 
            // txtContacto
            // 
            this.txtContacto.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContacto.Location = new System.Drawing.Point(329, 144);
            this.txtContacto.Margin = new System.Windows.Forms.Padding(4);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(143, 29);
            this.txtContacto.TabIndex = 1;
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacto.ForeColor = System.Drawing.Color.Indigo;
            this.lblContacto.Location = new System.Drawing.Point(46, 144);
            this.lblContacto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(92, 26);
            this.lblContacto.TabIndex = 2;
            this.lblContacto.Text = "Contacto";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.Indigo;
            this.lblTelefono.Location = new System.Drawing.Point(46, 212);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(171, 26);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Número Teléfono";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(353, 279);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(120, 45);
            this.btnGrabar.TabIndex = 5;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // lstListadoDatos
            // 
            this.lstListadoDatos.FormattingEnabled = true;
            this.lstListadoDatos.ItemHeight = 16;
            this.lstListadoDatos.Location = new System.Drawing.Point(52, 407);
            this.lstListadoDatos.Margin = new System.Windows.Forms.Padding(4);
            this.lstListadoDatos.Name = "lstListadoDatos";
            this.lstListadoDatos.Size = new System.Drawing.Size(207, 132);
            this.lstListadoDatos.TabIndex = 6;
            this.lstListadoDatos.SelectedIndexChanged += new System.EventHandler(this.lstListadoDatos_SelectedIndexChanged);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.ForeColor = System.Drawing.Color.Indigo;
            this.lblDatos.Location = new System.Drawing.Point(182, 54);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(249, 26);
            this.lblDatos.TabIndex = 7;
            this.lblDatos.Text = "Ingrese los Datos a Grabar";
            // 
            // frmDatosContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(613, 576);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.lstListadoDatos);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblContacto);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.txtNumero);
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDatosContacto";
            this.Text = "Contacto y Número de Teléfono";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtNumero;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.ListBox lstListadoDatos;
        private System.Windows.Forms.Label lblDatos;
    }
}

