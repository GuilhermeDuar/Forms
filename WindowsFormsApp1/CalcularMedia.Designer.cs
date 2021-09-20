namespace primeiro
{
    partial class CalcularMedia
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
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.btnGerarMedia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(31, 83);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(65, 20);
            this.txtNota1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Primeira nota";
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(206, 83);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(65, 20);
            this.txtNota2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Segunda nota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Terceira nota";
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(380, 83);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(65, 20);
            this.txtNota3.TabIndex = 4;
            // 
            // btnGerarMedia
            // 
            this.btnGerarMedia.Location = new System.Drawing.Point(188, 154);
            this.btnGerarMedia.Name = "btnGerarMedia";
            this.btnGerarMedia.Size = new System.Drawing.Size(99, 31);
            this.btnGerarMedia.TabIndex = 6;
            this.btnGerarMedia.Text = "Calcular";
            this.btnGerarMedia.UseVisualStyleBackColor = true;
            this.btnGerarMedia.Click += new System.EventHandler(this.btnGerarMedia_Click);
            // 
            // FormMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 243);
            this.Controls.Add(this.btnGerarMedia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNota1);
            this.Name = "FormMedia";
            this.Text = "FormMedia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Button btnGerarMedia;
    }
}