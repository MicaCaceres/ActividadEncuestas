namespace EncuestasForm
{
    partial class btnRegistroDeEncuesta_Click
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
            this.btnRegistroEncuesta_Click = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistroEncuesta_Click
            // 
            this.btnRegistroEncuesta_Click.Location = new System.Drawing.Point(192, 73);
            this.btnRegistroEncuesta_Click.Name = "btnRegistroEncuesta_Click";
            this.btnRegistroEncuesta_Click.Size = new System.Drawing.Size(136, 51);
            this.btnRegistroEncuesta_Click.TabIndex = 0;
            this.btnRegistroEncuesta_Click.Text = "Registrar Encuesta";
            this.btnRegistroEncuesta_Click.UseVisualStyleBackColor = true;
           
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(229, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Resultados";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(229, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnRegistroDeEncuesta_Click
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRegistroEncuesta_Click);
            this.Name = "btnRegistroDeEncuesta_Click";
            this.Text = "Registrar Encuesta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistroEncuesta_Click;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

