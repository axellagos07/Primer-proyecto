namespace IProyecto
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
            this.Ejecutarbutton = new System.Windows.Forms.Button();
            this.NumerotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ParoImparlabel = new System.Windows.Forms.Label();
            this.Signolabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ejecutarbutton
            // 
            this.Ejecutarbutton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ejecutarbutton.Location = new System.Drawing.Point(317, 156);
            this.Ejecutarbutton.Name = "Ejecutarbutton";
            this.Ejecutarbutton.Size = new System.Drawing.Size(87, 33);
            this.Ejecutarbutton.TabIndex = 0;
            this.Ejecutarbutton.Text = "Ejecutar";
            this.Ejecutarbutton.UseVisualStyleBackColor = true;
            this.Ejecutarbutton.Click += new System.EventHandler(this.Ejecutarbutton_Click);
            // 
            // NumerotextBox
            // 
            this.NumerotextBox.Location = new System.Drawing.Point(317, 91);
            this.NumerotextBox.Name = "NumerotextBox";
            this.NumerotextBox.Size = new System.Drawing.Size(100, 20);
            this.NumerotextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese un número entero:";
            // 
            // ParoImparlabel
            // 
            this.ParoImparlabel.AutoSize = true;
            this.ParoImparlabel.Location = new System.Drawing.Point(467, 156);
            this.ParoImparlabel.Name = "ParoImparlabel";
            this.ParoImparlabel.Size = new System.Drawing.Size(129, 13);
            this.ParoImparlabel.TabIndex = 3;
            this.ParoImparlabel.Text = "El numero es par o impar?";
            // 
            // Signolabel
            // 
            this.Signolabel.AutoSize = true;
            this.Signolabel.Location = new System.Drawing.Point(467, 195);
            this.Signolabel.Name = "Signolabel";
            this.Signolabel.Size = new System.Drawing.Size(168, 13);
            this.Signolabel.TabIndex = 4;
            this.Signolabel.Text = "El número es positivo o Negativo?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(375, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Número par o impar y si es negativo o positivo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 325);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Signolabel);
            this.Controls.Add(this.ParoImparlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumerotextBox);
            this.Controls.Add(this.Ejecutarbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ejecutarbutton;
        private System.Windows.Forms.TextBox NumerotextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ParoImparlabel;
        private System.Windows.Forms.Label Signolabel;
        private System.Windows.Forms.Label label4;
    }
}

