
namespace primeiro
{
    partial class METODOCalcularMedia
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
            this.btnGerarMedia = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGerarMedia
            // 
            this.btnGerarMedia.Location = new System.Drawing.Point(335, 266);
            this.btnGerarMedia.Margin = new System.Windows.Forms.Padding(4);
            this.btnGerarMedia.Name = "btnGerarMedia";
            this.btnGerarMedia.Size = new System.Drawing.Size(132, 38);
            this.btnGerarMedia.TabIndex = 13;
            this.btnGerarMedia.Text = "Calcular";
            this.btnGerarMedia.UseVisualStyleBackColor = true;
            this.btnGerarMedia.Click += new System.EventHandler(this.btnGerarMedia_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(587, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Terceira nota";
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(591, 178);
            this.txtNota3.Margin = new System.Windows.Forms.Padding(4);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(85, 22);
            this.txtNota3.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Segunda nota";
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(359, 178);
            this.txtNota2.Margin = new System.Windows.Forms.Padding(4);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(85, 22);
            this.txtNota2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Primeira nota";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(125, 178);
            this.txtNota1.Margin = new System.Windows.Forms.Padding(4);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(85, 22);
            this.txtNota1.TabIndex = 7;
            // 
            // METODOCalcularMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGerarMedia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNota1);
            this.Name = "METODOCalcularMedia";
            this.Text = "METODOCalcularMedia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerarMedia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNota1;
    }
}