
namespace primeiro
{
    partial class METODOHotel
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
            this.btnCalcularValorFinal = new System.Windows.Forms.Button();
            this.txtNumeroDePessoas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroDeDias = new System.Windows.Forms.TextBox();
            this.rbStandart = new System.Windows.Forms.RadioButton();
            this.rbLuxo = new System.Windows.Forms.RadioButton();
            this.rbSuperLuxo = new System.Windows.Forms.RadioButton();
            this.lblPeçoFinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcularValorFinal
            // 
            this.btnCalcularValorFinal.Location = new System.Drawing.Point(215, 282);
            this.btnCalcularValorFinal.Name = "btnCalcularValorFinal";
            this.btnCalcularValorFinal.Size = new System.Drawing.Size(75, 30);
            this.btnCalcularValorFinal.TabIndex = 0;
            this.btnCalcularValorFinal.Text = "Calcular";
            this.btnCalcularValorFinal.UseVisualStyleBackColor = true;
            this.btnCalcularValorFinal.Click += new System.EventHandler(this.btnCalcularValorFinal_Click);
            // 
            // txtNumeroDePessoas
            // 
            this.txtNumeroDePessoas.Location = new System.Drawing.Point(215, 79);
            this.txtNumeroDePessoas.Name = "txtNumeroDePessoas";
            this.txtNumeroDePessoas.Size = new System.Drawing.Size(136, 22);
            this.txtNumeroDePessoas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número de Pessoas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero de dias";
            // 
            // txtNumeroDeDias
            // 
            this.txtNumeroDeDias.Location = new System.Drawing.Point(215, 140);
            this.txtNumeroDeDias.Name = "txtNumeroDeDias";
            this.txtNumeroDeDias.Size = new System.Drawing.Size(136, 22);
            this.txtNumeroDeDias.TabIndex = 3;
            // 
            // rbStandart
            // 
            this.rbStandart.AutoSize = true;
            this.rbStandart.Checked = true;
            this.rbStandart.Location = new System.Drawing.Point(215, 180);
            this.rbStandart.Name = "rbStandart";
            this.rbStandart.Size = new System.Drawing.Size(83, 21);
            this.rbStandart.TabIndex = 5;
            this.rbStandart.TabStop = true;
            this.rbStandart.Text = "Standart";
            this.rbStandart.UseVisualStyleBackColor = true;
            // 
            // rbLuxo
            // 
            this.rbLuxo.AutoSize = true;
            this.rbLuxo.Location = new System.Drawing.Point(215, 208);
            this.rbLuxo.Name = "rbLuxo";
            this.rbLuxo.Size = new System.Drawing.Size(59, 21);
            this.rbLuxo.TabIndex = 6;
            this.rbLuxo.Text = "Luxo";
            this.rbLuxo.UseVisualStyleBackColor = true;
            // 
            // rbSuperLuxo
            // 
            this.rbSuperLuxo.AutoSize = true;
            this.rbSuperLuxo.Location = new System.Drawing.Point(215, 236);
            this.rbSuperLuxo.Name = "rbSuperLuxo";
            this.rbSuperLuxo.Size = new System.Drawing.Size(97, 21);
            this.rbSuperLuxo.TabIndex = 7;
            this.rbSuperLuxo.Text = "SuperLuxo";
            this.rbSuperLuxo.UseVisualStyleBackColor = true;
            // 
            // lblPeçoFinal
            // 
            this.lblPeçoFinal.AutoSize = true;
            this.lblPeçoFinal.Location = new System.Drawing.Point(215, 319);
            this.lblPeçoFinal.Name = "lblPeçoFinal";
            this.lblPeçoFinal.Size = new System.Drawing.Size(20, 17);
            this.lblPeçoFinal.TabIndex = 8;
            this.lblPeçoFinal.Text = "...";
            this.lblPeçoFinal.Visible = false;
            // 
            // FormHotelMetodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPeçoFinal);
            this.Controls.Add(this.rbSuperLuxo);
            this.Controls.Add(this.rbLuxo);
            this.Controls.Add(this.rbStandart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeroDeDias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumeroDePessoas);
            this.Controls.Add(this.btnCalcularValorFinal);
            this.Name = "FormHotelMetodo";
            this.Text = "FormHotelMetodo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularValorFinal;
        private System.Windows.Forms.TextBox txtNumeroDePessoas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroDeDias;
        private System.Windows.Forms.RadioButton rbStandart;
        private System.Windows.Forms.RadioButton rbLuxo;
        private System.Windows.Forms.RadioButton rbSuperLuxo;
        private System.Windows.Forms.Label lblPeçoFinal;
    }
}