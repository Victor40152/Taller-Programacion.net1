namespace tallerprogramacion1
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
            this.btnmasa = new System.Windows.Forms.Button();
            this.btnprom = new System.Windows.Forms.Button();
            this.btnraiz = new System.Windows.Forms.Button();
            this.btnvolumen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnmasa
            // 
            this.btnmasa.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmasa.Location = new System.Drawing.Point(12, 30);
            this.btnmasa.Name = "btnmasa";
            this.btnmasa.Size = new System.Drawing.Size(235, 33);
            this.btnmasa.TabIndex = 0;
            this.btnmasa.Text = "Calculo Masa Corporal";
            this.btnmasa.UseVisualStyleBackColor = true;
            this.btnmasa.Click += new System.EventHandler(this.btnmasa_Click);
            // 
            // btnprom
            // 
            this.btnprom.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprom.Location = new System.Drawing.Point(268, 30);
            this.btnprom.Name = "btnprom";
            this.btnprom.Size = new System.Drawing.Size(203, 33);
            this.btnprom.TabIndex = 1;
            this.btnprom.Text = "Promedio de Notas";
            this.btnprom.UseVisualStyleBackColor = true;
            this.btnprom.Click += new System.EventHandler(this.btnprom_Click);
            // 
            // btnraiz
            // 
            this.btnraiz.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnraiz.Location = new System.Drawing.Point(487, 30);
            this.btnraiz.Name = "btnraiz";
            this.btnraiz.Size = new System.Drawing.Size(203, 33);
            this.btnraiz.TabIndex = 2;
            this.btnraiz.Text = "Raiz Cuadrada";
            this.btnraiz.UseVisualStyleBackColor = true;
            this.btnraiz.Click += new System.EventHandler(this.btnraiz_Click);
            // 
            // btnvolumen
            // 
            this.btnvolumen.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolumen.Location = new System.Drawing.Point(706, 30);
            this.btnvolumen.Name = "btnvolumen";
            this.btnvolumen.Size = new System.Drawing.Size(203, 33);
            this.btnvolumen.TabIndex = 3;
            this.btnvolumen.Text = "Calculo Volumen";
            this.btnvolumen.UseVisualStyleBackColor = true;
            this.btnvolumen.Click += new System.EventHandler(this.btnvolumen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 364);
            this.Controls.Add(this.btnvolumen);
            this.Controls.Add(this.btnraiz);
            this.Controls.Add(this.btnprom);
            this.Controls.Add(this.btnmasa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnmasa;
        private System.Windows.Forms.Button btnprom;
        private System.Windows.Forms.Button btnraiz;
        private System.Windows.Forms.Button btnvolumen;
    }
}

