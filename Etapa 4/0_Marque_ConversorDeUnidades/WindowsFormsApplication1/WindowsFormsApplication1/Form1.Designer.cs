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
            this.chad = new System.Windows.Forms.Label();
            this.celcius = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fahrenheit = new System.Windows.Forms.Label();
            this.Kelvin = new System.Windows.Forms.Label();
            this.fahrenheitNum = new System.Windows.Forms.Label();
            this.kelvinNum = new System.Windows.Forms.Label();
            this.Fnum = new System.Windows.Forms.Label();
            this.Knum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chad
            // 
            this.chad.AutoSize = true;
            this.chad.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chad.Location = new System.Drawing.Point(89, 29);
            this.chad.Name = "chad";
            this.chad.Size = new System.Drawing.Size(368, 37);
            this.chad.TabIndex = 0;
            this.chad.Text = "Ingrese los grados celcius";
            // 
            // celcius
            // 
            this.celcius.Location = new System.Drawing.Point(96, 80);
            this.celcius.Name = "celcius";
            this.celcius.Size = new System.Drawing.Size(337, 20);
            this.celcius.TabIndex = 1;
            this.celcius.TextChanged += new System.EventHandler(this.celcius_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 79);
            this.button1.TabIndex = 2;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fahrenheit
            // 
            this.fahrenheit.AutoSize = true;
            this.fahrenheit.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fahrenheit.Location = new System.Drawing.Point(91, 311);
            this.fahrenheit.Name = "fahrenheit";
            this.fahrenheit.Size = new System.Drawing.Size(128, 25);
            this.fahrenheit.TabIndex = 3;
            this.fahrenheit.Text = "Fahrenheit:";
            // 
            // Kelvin
            // 
            this.Kelvin.AutoSize = true;
            this.Kelvin.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kelvin.Location = new System.Drawing.Point(395, 309);
            this.Kelvin.Name = "Kelvin";
            this.Kelvin.Size = new System.Drawing.Size(91, 27);
            this.Kelvin.TabIndex = 4;
            this.Kelvin.Text = "Kelvin:";
            // 
            // fahrenheitNum
            // 
            this.fahrenheitNum.AutoSize = true;
            this.fahrenheitNum.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fahrenheitNum.Location = new System.Drawing.Point(214, 311);
            this.fahrenheitNum.Name = "fahrenheitNum";
            this.fahrenheitNum.Size = new System.Drawing.Size(0, 25);
            this.fahrenheitNum.TabIndex = 5;
            // 
            // kelvinNum
            // 
            this.kelvinNum.AutoSize = true;
            this.kelvinNum.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kelvinNum.Location = new System.Drawing.Point(482, 311);
            this.kelvinNum.Name = "kelvinNum";
            this.kelvinNum.Size = new System.Drawing.Size(0, 25);
            this.kelvinNum.TabIndex = 6;
            // 
            // Fnum
            // 
            this.Fnum.AutoSize = true;
            this.Fnum.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fnum.Location = new System.Drawing.Point(214, 311);
            this.Fnum.Name = "Fnum";
            this.Fnum.Size = new System.Drawing.Size(95, 25);
            this.Fnum.TabIndex = 7;
            this.Fnum.Text = "Numero";
            this.Fnum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Knum
            // 
            this.Knum.AutoSize = true;
            this.Knum.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Knum.Location = new System.Drawing.Point(488, 311);
            this.Knum.Name = "Knum";
            this.Knum.Size = new System.Drawing.Size(95, 25);
            this.Knum.TabIndex = 8;
            this.Knum.Text = "Numero";
            this.Knum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(810, 513);
            this.Controls.Add(this.Knum);
            this.Controls.Add(this.Fnum);
            this.Controls.Add(this.kelvinNum);
            this.Controls.Add(this.fahrenheitNum);
            this.Controls.Add(this.Kelvin);
            this.Controls.Add(this.fahrenheit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.celcius);
            this.Controls.Add(this.chad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chad;
        private System.Windows.Forms.TextBox celcius;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label fahrenheit;
        private System.Windows.Forms.Label Kelvin;
        private System.Windows.Forms.Label fahrenheitNum;
        private System.Windows.Forms.Label kelvinNum;
        private System.Windows.Forms.Label Fnum;
        private System.Windows.Forms.Label Knum;
    }
}

