﻿namespace tallerprogramacion1
{
    partial class Indicemasa
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtdato1 = new System.Windows.Forms.TextBox();
            this.txtdato2 = new System.Windows.Forms.TextBox();
            this.lblmasa = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculo de Masa Corporal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese su peso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese su Altura:";
            // 
            // txtdato1
            // 
            this.txtdato1.Location = new System.Drawing.Point(271, 111);
            this.txtdato1.Name = "txtdato1";
            this.txtdato1.Size = new System.Drawing.Size(100, 20);
            this.txtdato1.TabIndex = 3;
            // 
            // txtdato2
            // 
            this.txtdato2.Location = new System.Drawing.Point(271, 158);
            this.txtdato2.Name = "txtdato2";
            this.txtdato2.Size = new System.Drawing.Size(100, 20);
            this.txtdato2.TabIndex = 4;
            // 
            // lblmasa
            // 
            this.lblmasa.AutoSize = true;
            this.lblmasa.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmasa.Location = new System.Drawing.Point(40, 253);
            this.lblmasa.Name = "lblmasa";
            this.lblmasa.Size = new System.Drawing.Size(320, 24);
            this.lblmasa.TabIndex = 5;
            this.lblmasa.Text = "El indice de su masa corporal es:";
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(476, 155);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(112, 37);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // Indicemasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 414);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lblmasa);
            this.Controls.Add(this.txtdato2);
            this.Controls.Add(this.txtdato1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Indicemasa";
            this.Text = "Indicemasa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdato1;
        private System.Windows.Forms.TextBox txtdato2;
        private System.Windows.Forms.Label lblmasa;
        private System.Windows.Forms.Button btncalcular;
    }
}