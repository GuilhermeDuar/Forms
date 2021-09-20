namespace primeiro
{
    partial class DesafioVotacao
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
            this.rdCandidatoB = new System.Windows.Forms.RadioButton();
            this.rdCandidatoA = new System.Windows.Forms.RadioButton();
            this.rdCandidatoC = new System.Windows.Forms.RadioButton();
            this.btnVoto = new System.Windows.Forms.Button();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdCandidatoB
            // 
            this.rdCandidatoB.AutoSize = true;
            this.rdCandidatoB.Location = new System.Drawing.Point(25, 79);
            this.rdCandidatoB.Name = "rdCandidatoB";
            this.rdCandidatoB.Size = new System.Drawing.Size(83, 17);
            this.rdCandidatoB.TabIndex = 0;
            this.rdCandidatoB.Text = "Candidato B";
            this.rdCandidatoB.UseVisualStyleBackColor = true;
            // 
            // rdCandidatoA
            // 
            this.rdCandidatoA.AutoSize = true;
            this.rdCandidatoA.Checked = true;
            this.rdCandidatoA.Location = new System.Drawing.Point(25, 42);
            this.rdCandidatoA.Name = "rdCandidatoA";
            this.rdCandidatoA.Size = new System.Drawing.Size(83, 17);
            this.rdCandidatoA.TabIndex = 0;
            this.rdCandidatoA.TabStop = true;
            this.rdCandidatoA.Text = "Candidato A";
            this.rdCandidatoA.UseVisualStyleBackColor = true;
            // 
            // rdCandidatoC
            // 
            this.rdCandidatoC.AutoSize = true;
            this.rdCandidatoC.Location = new System.Drawing.Point(25, 115);
            this.rdCandidatoC.Name = "rdCandidatoC";
            this.rdCandidatoC.Size = new System.Drawing.Size(83, 17);
            this.rdCandidatoC.TabIndex = 1;
            this.rdCandidatoC.Text = "Candidato C";
            this.rdCandidatoC.UseVisualStyleBackColor = true;
            // 
            // btnVoto
            // 
            this.btnVoto.Location = new System.Drawing.Point(332, 237);
            this.btnVoto.Name = "btnVoto";
            this.btnVoto.Size = new System.Drawing.Size(75, 23);
            this.btnVoto.TabIndex = 2;
            this.btnVoto.Text = "Votar";
            this.btnVoto.UseVisualStyleBackColor = true;
            this.btnVoto.Click += new System.EventHandler(this.btnVoto_Click);
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Enabled = false;
            this.btnEncerrar.Location = new System.Drawing.Point(12, 237);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(75, 23);
            this.btnEncerrar.TabIndex = 3;
            this.btnEncerrar.Text = "Encerrar";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // Votacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 272);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.btnVoto);
            this.Controls.Add(this.rdCandidatoC);
            this.Controls.Add(this.rdCandidatoA);
            this.Controls.Add(this.rdCandidatoB);
            this.Name = "Votacao";
            this.Text = "FormVotacao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdCandidatoB;
        private System.Windows.Forms.RadioButton rdCandidatoA;
        private System.Windows.Forms.RadioButton rdCandidatoC;
        private System.Windows.Forms.Button btnVoto;
        private System.Windows.Forms.Button btnEncerrar;
    }
}