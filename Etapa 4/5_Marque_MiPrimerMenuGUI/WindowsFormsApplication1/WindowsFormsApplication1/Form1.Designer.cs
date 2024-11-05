namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.multiplicacion = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.Button();
            this.salir1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(269, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO/A";
            // 
            // multiplicacion
            // 
            this.multiplicacion.Font = new System.Drawing.Font("Perpetua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicacion.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.multiplicacion.Location = new System.Drawing.Point(349, 256);
            this.multiplicacion.Name = "multiplicacion";
            this.multiplicacion.Size = new System.Drawing.Size(168, 76);
            this.multiplicacion.TabIndex = 1;
            this.multiplicacion.Text = "Multiplicación";
            this.multiplicacion.UseVisualStyleBackColor = true;
            this.multiplicacion.Click += new System.EventHandler(this.multiplicacion_Click);
            // 
            // resta
            // 
            this.resta.Font = new System.Drawing.Font("Perpetua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resta.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.resta.Location = new System.Drawing.Point(623, 256);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(145, 76);
            this.resta.TabIndex = 2;
            this.resta.Text = "Resta";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // suma
            // 
            this.suma.Font = new System.Drawing.Font("Perpetua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suma.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.suma.Location = new System.Drawing.Point(101, 256);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(145, 76);
            this.suma.TabIndex = 3;
            this.suma.Text = "Suma";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // salir1
            // 
            this.salir1.Font = new System.Drawing.Font("Perpetua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.salir1.Location = new System.Drawing.Point(740, 454);
            this.salir1.Name = "salir1";
            this.salir1.Size = new System.Drawing.Size(107, 51);
            this.salir1.TabIndex = 4;
            this.salir1.Text = "Salir";
            this.salir1.UseVisualStyleBackColor = true;
            this.salir1.Click += new System.EventHandler(this.salir1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(355, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 49);
            this.label2.TabIndex = 5;
            this.label2.Text = "elegí una opción";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(872, 517);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salir1);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.multiplicacion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button multiplicacion;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button salir1;
        private System.Windows.Forms.Label label2;
    }
}

