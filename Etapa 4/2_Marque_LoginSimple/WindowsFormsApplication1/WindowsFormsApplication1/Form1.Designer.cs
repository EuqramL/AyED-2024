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
            this.boton = new System.Windows.Forms.Button();
            this.usurio = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boton
            // 
            this.boton.Location = new System.Drawing.Point(395, 280);
            this.boton.Name = "boton";
            this.boton.Size = new System.Drawing.Size(102, 66);
            this.boton.TabIndex = 0;
            this.boton.Text = "Login";
            this.boton.UseVisualStyleBackColor = true;
            this.boton.Click += new System.EventHandler(this.boton_Click);
            // 
            // usurio
            // 
            this.usurio.Location = new System.Drawing.Point(359, 106);
            this.usurio.Name = "usurio";
            this.usurio.Size = new System.Drawing.Size(175, 20);
            this.usurio.TabIndex = 1;
            this.usurio.TextChanged += new System.EventHandler(this.usurio_TextChanged);
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(359, 201);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(175, 20);
            this.contraseña.TabIndex = 2;
            this.contraseña.TextChanged += new System.EventHandler(this.contraseña_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contaseña:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(860, 517);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.usurio);
            this.Controls.Add(this.boton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton;
        private System.Windows.Forms.TextBox usurio;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

