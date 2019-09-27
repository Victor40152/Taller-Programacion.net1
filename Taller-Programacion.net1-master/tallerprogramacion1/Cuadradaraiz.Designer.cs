namespace tallerprogramacion1
{
    partial class Cuadradaraiz
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
            this.txtraiz = new System.Windows.Forms.TextBox();
            this.lblraiz = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculo de Raiz Cuadrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite el Número:";
            // 
            // txtraiz
            // 
            this.txtraiz.Location = new System.Drawing.Point(268, 136);
            this.txtraiz.Name = "txtraiz";
            this.txtraiz.Size = new System.Drawing.Size(100, 20);
            this.txtraiz.TabIndex = 2;
            // 
            // lblraiz
            // 
            this.lblraiz.AutoSize = true;
            this.lblraiz.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblraiz.Location = new System.Drawing.Point(73, 254);
            this.lblraiz.Name = "lblraiz";
            this.lblraiz.Size = new System.Drawing.Size(184, 22);
            this.lblraiz.TabIndex = 3;
            this.lblraiz.Text = "La raiz cuadrada es :";
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(466, 161);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(120, 32);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // Cuadradaraiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lblraiz);
            this.Controls.Add(this.txtraiz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cuadradaraiz";
            this.Text = "Cuadradaraiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtraiz;
        private System.Windows.Forms.Label lblraiz;
        private System.Windows.Forms.Button btncalcular;
    }
}