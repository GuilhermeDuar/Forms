namespace primeiro
{
    partial class CalcularValorMulta
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
            this.txtVelocidade = new System.Windows.Forms.TextBox();
            this.btnGerarMulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Velocidade";
            // 
            // txtVelocidade
            // 
            this.txtVelocidade.Location = new System.Drawing.Point(36, 49);
            this.txtVelocidade.Name = "txtVelocidade";
            this.txtVelocidade.Size = new System.Drawing.Size(100, 20);
            this.txtVelocidade.TabIndex = 1;
            // 
            // btnGerarMulta
            // 
            this.btnGerarMulta.Location = new System.Drawing.Point(49, 113);
            this.btnGerarMulta.Name = "btnGerarMulta";
            this.btnGerarMulta.Size = new System.Drawing.Size(75, 23);
            this.btnGerarMulta.TabIndex = 2;
            this.btnGerarMulta.Text = "Gerar Multa";
            this.btnGerarMulta.UseVisualStyleBackColor = true;
            this.btnGerarMulta.Click += new System.EventHandler(this.btnGerarMulta_Click);
            // 
            // FormRadar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 174);
            this.Controls.Add(this.btnGerarMulta);
            this.Controls.Add(this.txtVelocidade);
            this.Controls.Add(this.label1);
            this.Name = "FormRadar";
            this.Text = "FormRadar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVelocidade;
        private System.Windows.Forms.Button btnGerarMulta;
    }
}