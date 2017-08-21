namespace Generar_Factura
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtRutaArchivos = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnElegirCarpetaArchivos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnElegirCarpeta = new System.Windows.Forms.Button();
            this.txtRutaSelec = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRutaArchivos
            // 
            this.txtRutaArchivos.Location = new System.Drawing.Point(6, 44);
            this.txtRutaArchivos.Name = "txtRutaArchivos";
            this.txtRutaArchivos.ReadOnly = true;
            this.txtRutaArchivos.Size = new System.Drawing.Size(508, 20);
            this.txtRutaArchivos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnElegirCarpetaArchivos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRutaArchivos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 111);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de los Archivos";
            // 
            // btnElegirCarpetaArchivos
            // 
            this.btnElegirCarpetaArchivos.Location = new System.Drawing.Point(363, 70);
            this.btnElegirCarpetaArchivos.Name = "btnElegirCarpetaArchivos";
            this.btnElegirCarpetaArchivos.Size = new System.Drawing.Size(151, 23);
            this.btnElegirCarpetaArchivos.TabIndex = 0;
            this.btnElegirCarpetaArchivos.Text = "Elegir carpeta de Archivos";
            this.btnElegirCarpetaArchivos.Click += new System.EventHandler(this.btnElegirCarpetaArchivos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ruta de los Archivos:";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(18, 243);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(112, 23);
            this.btnEjecutar.TabIndex = 2;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnElegirCarpeta);
            this.groupBox2.Controls.Add(this.txtRutaSelec);
            this.groupBox2.Location = new System.Drawing.Point(12, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 92);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Donde Guardar el Archivo";
            // 
            // btnElegirCarpeta
            // 
            this.btnElegirCarpeta.Location = new System.Drawing.Point(402, 56);
            this.btnElegirCarpeta.Name = "btnElegirCarpeta";
            this.btnElegirCarpeta.Size = new System.Drawing.Size(112, 23);
            this.btnElegirCarpeta.TabIndex = 1;
            this.btnElegirCarpeta.Text = "Guardar Archivo en";
            this.btnElegirCarpeta.UseVisualStyleBackColor = true;
            this.btnElegirCarpeta.Click += new System.EventHandler(this.btnElegirCarpeta_Click);
            // 
            // txtRutaSelec
            // 
            this.txtRutaSelec.Location = new System.Drawing.Point(6, 30);
            this.txtRutaSelec.Name = "txtRutaSelec";
            this.txtRutaSelec.ReadOnly = true;
            this.txtRutaSelec.Size = new System.Drawing.Size(508, 20);
            this.txtRutaSelec.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 278);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Generar Facturacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtRutaArchivos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnElegirCarpeta;
        private System.Windows.Forms.TextBox txtRutaSelec;
        private System.Windows.Forms.Button btnElegirCarpetaArchivos;
    }
}

