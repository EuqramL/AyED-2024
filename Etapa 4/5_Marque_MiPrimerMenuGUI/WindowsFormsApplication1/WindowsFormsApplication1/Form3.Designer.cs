﻿namespace WindowsFormsApplication1
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numero2 = new System.Windows.Forms.TextBox();
            this.numero1 = new System.Windows.Forms.TextBox();
            this.respuesta = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.num2Res = new System.Windows.Forms.Label();
            this.num1Res = new System.Windows.Forms.Label();
            this.volver = new System.Windows.Forms.Button();
            this.salir1 = new System.Windows.Forms.Button();
            this.multiplicacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(283, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 83);
            this.label1.TabIndex = 2;
            this.label1.Text = "Multiplicación";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(206, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(456, 49);
            this.label2.TabIndex = 7;
            this.label2.Text = "colocá los dos numeros para multiplicarlos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(559, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 49);
            this.label4.TabIndex = 12;
            this.label4.Text = "Numero 2:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(150, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 49);
            this.label3.TabIndex = 11;
            this.label3.Text = "Numero 1:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // numero2
            // 
            this.numero2.Location = new System.Drawing.Point(568, 271);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(164, 20);
            this.numero2.TabIndex = 10;
            this.numero2.TextChanged += new System.EventHandler(this.numero2_TextChanged);
            // 
            // numero1
            // 
            this.numero1.Location = new System.Drawing.Point(159, 271);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(164, 20);
            this.numero1.TabIndex = 9;
            this.numero1.TextChanged += new System.EventHandler(this.numero1_TextChanged);
            // 
            // respuesta
            // 
            this.respuesta.AutoSize = true;
            this.respuesta.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respuesta.ForeColor = System.Drawing.Color.DarkGreen;
            this.respuesta.Location = new System.Drawing.Point(510, 323);
            this.respuesta.Name = "respuesta";
            this.respuesta.Size = new System.Drawing.Size(125, 49);
            this.respuesta.TabIndex = 18;
            this.respuesta.Text = "Respuesta";
            this.respuesta.Click += new System.EventHandler(this.respuesta_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(481, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 49);
            this.label6.TabIndex = 17;
            this.label6.Text = "=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(343, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 49);
            this.label5.TabIndex = 16;
            this.label5.Text = "*";
            // 
            // num2Res
            // 
            this.num2Res.AutoSize = true;
            this.num2Res.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2Res.ForeColor = System.Drawing.Color.DarkGreen;
            this.num2Res.Location = new System.Drawing.Point(368, 323);
            this.num2Res.Name = "num2Res";
            this.num2Res.Size = new System.Drawing.Size(129, 49);
            this.num2Res.TabIndex = 15;
            this.num2Res.Text = "Numero 2";
            this.num2Res.Click += new System.EventHandler(this.num2Res_Click);
            // 
            // num1Res
            // 
            this.num1Res.AutoSize = true;
            this.num1Res.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1Res.ForeColor = System.Drawing.Color.DarkGreen;
            this.num1Res.Location = new System.Drawing.Point(230, 323);
            this.num1Res.Name = "num1Res";
            this.num1Res.Size = new System.Drawing.Size(126, 49);
            this.num1Res.TabIndex = 14;
            this.num1Res.Text = "Numero 1";
            this.num1Res.Click += new System.EventHandler(this.num1Res_Click);
            // 
            // volver
            // 
            this.volver.Font = new System.Drawing.Font("Perpetua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volver.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.volver.Location = new System.Drawing.Point(28, 448);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(107, 51);
            this.volver.TabIndex = 21;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // salir1
            // 
            this.salir1.Font = new System.Drawing.Font("Perpetua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.salir1.Location = new System.Drawing.Point(743, 448);
            this.salir1.Name = "salir1";
            this.salir1.Size = new System.Drawing.Size(107, 51);
            this.salir1.TabIndex = 20;
            this.salir1.Text = "Salir";
            this.salir1.UseVisualStyleBackColor = true;
            this.salir1.Click += new System.EventHandler(this.salir1_Click);
            // 
            // multiplicacion
            // 
            this.multiplicacion.Font = new System.Drawing.Font("Perpetua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicacion.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.multiplicacion.Location = new System.Drawing.Point(352, 398);
            this.multiplicacion.Name = "multiplicacion";
            this.multiplicacion.Size = new System.Drawing.Size(145, 76);
            this.multiplicacion.TabIndex = 19;
            this.multiplicacion.Text = "Calcular";
            this.multiplicacion.UseVisualStyleBackColor = true;
            this.multiplicacion.Click += new System.EventHandler(this.suma_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(883, 509);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.salir1);
            this.Controls.Add(this.multiplicacion);
            this.Controls.Add(this.respuesta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.num2Res);
            this.Controls.Add(this.num1Res);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.numero1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numero2;
        private System.Windows.Forms.TextBox numero1;
        private System.Windows.Forms.Label respuesta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label num2Res;
        private System.Windows.Forms.Label num1Res;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.Button salir1;
        private System.Windows.Forms.Button multiplicacion;
    }
}