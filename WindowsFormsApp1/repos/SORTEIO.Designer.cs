
namespace primeiro
{
    partial class SORTEIO
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
            this.btnSortear = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtCadastro = new System.Windows.Forms.TextBox();
            this.txtNomes = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSortear
            // 
            this.btnSortear.Location = new System.Drawing.Point(128, 358);
            this.btnSortear.Name = "btnSortear";
            this.btnSortear.Size = new System.Drawing.Size(85, 45);
            this.btnSortear.TabIndex = 3;
            this.btnSortear.Text = "Sortear";
            this.btnSortear.UseVisualStyleBackColor = true;
            this.btnSortear.Click += new System.EventHandler(this.btnSortear_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(128, 89);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(84, 44);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtCadastro
            // 
            this.txtCadastro.Location = new System.Drawing.Point(90, 61);
            this.txtCadastro.Name = "txtCadastro";
            this.txtCadastro.Size = new System.Drawing.Size(170, 22);
            this.txtCadastro.TabIndex = 0;
            // 
            // txtNomes
            // 
            this.txtNomes.Location = new System.Drawing.Point(90, 139);
            this.txtNomes.Name = "txtNomes";
            this.txtNomes.Size = new System.Drawing.Size(170, 213);
            this.txtNomes.TabIndex = 1;
            this.txtNomes.Text = "";
            // 
            // SORTEIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNomes);
            this.Controls.Add(this.txtCadastro);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnSortear);
            this.Name = "SORTEIO";
            this.Text = "SORTEIO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSortear;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtCadastro;
        private System.Windows.Forms.RichTextBox txtNomes;
    }
}