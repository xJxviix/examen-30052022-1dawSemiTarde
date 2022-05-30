
namespace JavierSuarezHuacon24
{
    partial class Jugar
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
            this.labelPregunta = new System.Windows.Forms.Label();
            this.comboBoxRespuestas = new System.Windows.Forms.ComboBox();
            this.btnNiIdea = new System.Windows.Forms.Button();
            this.btnEstoySeguro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione la opción correcta de la pregunta";
            // 
            // labelPregunta
            // 
            this.labelPregunta.AutoSize = true;
            this.labelPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPregunta.Location = new System.Drawing.Point(82, 144);
            this.labelPregunta.Name = "labelPregunta";
            this.labelPregunta.Size = new System.Drawing.Size(118, 29);
            this.labelPregunta.TabIndex = 1;
            this.labelPregunta.Text = "Pregunta";
            // 
            // comboBoxRespuestas
            // 
            this.comboBoxRespuestas.FormattingEnabled = true;
            this.comboBoxRespuestas.Location = new System.Drawing.Point(87, 226);
            this.comboBoxRespuestas.Name = "comboBoxRespuestas";
            this.comboBoxRespuestas.Size = new System.Drawing.Size(284, 28);
            this.comboBoxRespuestas.TabIndex = 2;
            // 
            // btnNiIdea
            // 
            this.btnNiIdea.Location = new System.Drawing.Point(87, 371);
            this.btnNiIdea.Name = "btnNiIdea";
            this.btnNiIdea.Size = new System.Drawing.Size(171, 61);
            this.btnNiIdea.TabIndex = 3;
            this.btnNiIdea.Text = "Ni idea";
            this.btnNiIdea.UseVisualStyleBackColor = true;
            // 
            // btnEstoySeguro
            // 
            this.btnEstoySeguro.Location = new System.Drawing.Point(391, 371);
            this.btnEstoySeguro.Name = "btnEstoySeguro";
            this.btnEstoySeguro.Size = new System.Drawing.Size(171, 61);
            this.btnEstoySeguro.TabIndex = 4;
            this.btnEstoySeguro.Text = "Estoy Seguro";
            this.btnEstoySeguro.UseVisualStyleBackColor = true;
            // 
            // Jugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 532);
            this.Controls.Add(this.btnEstoySeguro);
            this.Controls.Add(this.btnNiIdea);
            this.Controls.Add(this.comboBoxRespuestas);
            this.Controls.Add(this.labelPregunta);
            this.Controls.Add(this.label1);
            this.Name = "Jugar";
            this.Text = "Hola Soy Mister Question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPregunta;
        private System.Windows.Forms.ComboBox comboBoxRespuestas;
        private System.Windows.Forms.Button btnNiIdea;
        private System.Windows.Forms.Button btnEstoySeguro;
    }
}