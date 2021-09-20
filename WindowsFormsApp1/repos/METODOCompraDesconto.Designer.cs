
namespace primeiro
{
    partial class METODOCompraDesconto
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtValorAPagar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbAvista = new System.Windows.Forms.RadioButton();
            this.rbParcelado = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(302, 305);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtValorAPagar
            // 
            this.txtValorAPagar.Location = new System.Drawing.Point(302, 187);
            this.txtValorAPagar.Name = "txtValorAPagar";
            this.txtValorAPagar.Size = new System.Drawing.Size(100, 22);
            this.txtValorAPagar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Preço final";
            // 
            // rbAvista
            // 
            this.rbAvista.AutoSize = true;
            this.rbAvista.Checked = true;
            this.rbAvista.Location = new System.Drawing.Point(302, 216);
            this.rbAvista.Name = "rbAvista";
            this.rbAvista.Size = new System.Drawing.Size(73, 21);
            this.rbAvista.TabIndex = 3;
            this.rbAvista.TabStop = true;
            this.rbAvista.Text = "À Vista";
            this.rbAvista.UseVisualStyleBackColor = true;
            // 
            // rbParcelado
            // 
            this.rbParcelado.AutoSize = true;
            this.rbParcelado.Location = new System.Drawing.Point(302, 244);
            this.rbParcelado.Name = "rbParcelado";
            this.rbParcelado.Size = new System.Drawing.Size(93, 21);
            this.rbParcelado.TabIndex = 4;
            this.rbParcelado.Text = "Parcelado";
            this.rbParcelado.UseVisualStyleBackColor = true;
            // 
            // MetodoCompraDesconto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbParcelado);
            this.Controls.Add(this.rbAvista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorAPagar);
            this.Controls.Add(this.btnCalcular);
            this.Name = "MetodoCompraDesconto";
            this.Text = "MetodoCompraDesconto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtValorAPagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbAvista;
        private System.Windows.Forms.RadioButton rbParcelado;
    }
}