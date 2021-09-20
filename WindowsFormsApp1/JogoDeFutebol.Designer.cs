namespace primeiro
{
    partial class JogoDeFutebol
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
            this.btnConferir1 = new System.Windows.Forms.Button();
            this.pctTime1 = new System.Windows.Forms.PictureBox();
            this.btnProcurar1 = new System.Windows.Forms.Button();
            this.btnProcurar2 = new System.Windows.Forms.Button();
            this.pctTime2 = new System.Windows.Forms.PictureBox();
            this.btnConferir2 = new System.Windows.Forms.Button();
            this.lblGolsTime1 = new System.Windows.Forms.Label();
            this.lblGolsTime2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTime1 = new System.Windows.Forms.TextBox();
            this.txtTime2 = new System.Windows.Forms.TextBox();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.btnAnular1 = new System.Windows.Forms.Button();
            this.btnAnular2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctTime1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTime2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConferir1
            // 
            this.btnConferir1.Location = new System.Drawing.Point(48, 361);
            this.btnConferir1.Name = "btnConferir1";
            this.btnConferir1.Size = new System.Drawing.Size(95, 25);
            this.btnConferir1.TabIndex = 8;
            this.btnConferir1.Text = "Gol!";
            this.btnConferir1.UseVisualStyleBackColor = true;
            this.btnConferir1.Click += new System.EventHandler(this.btnConferir1_Click);
            // 
            // pctTime1
            // 
            this.pctTime1.BackColor = System.Drawing.SystemColors.Control;
            this.pctTime1.Location = new System.Drawing.Point(29, 24);
            this.pctTime1.Name = "pctTime1";
            this.pctTime1.Size = new System.Drawing.Size(136, 155);
            this.pctTime1.TabIndex = 9;
            this.pctTime1.TabStop = false;
            // 
            // btnProcurar1
            // 
            this.btnProcurar1.Location = new System.Drawing.Point(75, 185);
            this.btnProcurar1.Name = "btnProcurar1";
            this.btnProcurar1.Size = new System.Drawing.Size(32, 19);
            this.btnProcurar1.TabIndex = 10;
            this.btnProcurar1.Text = "...";
            this.btnProcurar1.UseVisualStyleBackColor = true;
            this.btnProcurar1.Click += new System.EventHandler(this.btnProcurar1_Click);
            // 
            // btnProcurar2
            // 
            this.btnProcurar2.Location = new System.Drawing.Point(361, 185);
            this.btnProcurar2.Name = "btnProcurar2";
            this.btnProcurar2.Size = new System.Drawing.Size(32, 19);
            this.btnProcurar2.TabIndex = 12;
            this.btnProcurar2.Text = "...";
            this.btnProcurar2.UseVisualStyleBackColor = true;
            this.btnProcurar2.Click += new System.EventHandler(this.btnProcurar2_Click);
            // 
            // pctTime2
            // 
            this.pctTime2.BackColor = System.Drawing.SystemColors.Control;
            this.pctTime2.Location = new System.Drawing.Point(312, 24);
            this.pctTime2.Name = "pctTime2";
            this.pctTime2.Size = new System.Drawing.Size(136, 155);
            this.pctTime2.TabIndex = 11;
            this.pctTime2.TabStop = false;
            // 
            // btnConferir2
            // 
            this.btnConferir2.Location = new System.Drawing.Point(331, 361);
            this.btnConferir2.Name = "btnConferir2";
            this.btnConferir2.Size = new System.Drawing.Size(95, 25);
            this.btnConferir2.TabIndex = 13;
            this.btnConferir2.Text = "Gol!";
            this.btnConferir2.UseVisualStyleBackColor = true;
            this.btnConferir2.Click += new System.EventHandler(this.btnConferir2_Click);
            // 
            // lblGolsTime1
            // 
            this.lblGolsTime1.AutoSize = true;
            this.lblGolsTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGolsTime1.Location = new System.Drawing.Point(79, 314);
            this.lblGolsTime1.Name = "lblGolsTime1";
            this.lblGolsTime1.Size = new System.Drawing.Size(32, 33);
            this.lblGolsTime1.TabIndex = 14;
            this.lblGolsTime1.Text = "0";
            // 
            // lblGolsTime2
            // 
            this.lblGolsTime2.AutoSize = true;
            this.lblGolsTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGolsTime2.Location = new System.Drawing.Point(365, 314);
            this.lblGolsTime2.Name = "lblGolsTime2";
            this.lblGolsTime2.Size = new System.Drawing.Size(32, 33);
            this.lblGolsTime2.TabIndex = 15;
            this.lblGolsTime2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Time 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Time 2";
            // 
            // txtTime1
            // 
            this.txtTime1.Location = new System.Drawing.Point(43, 232);
            this.txtTime1.Name = "txtTime1";
            this.txtTime1.Size = new System.Drawing.Size(100, 20);
            this.txtTime1.TabIndex = 18;
            // 
            // txtTime2
            // 
            this.txtTime2.Location = new System.Drawing.Point(326, 232);
            this.txtTime2.Name = "txtTime2";
            this.txtTime2.Size = new System.Drawing.Size(100, 20);
            this.txtTime2.TabIndex = 19;
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Location = new System.Drawing.Point(205, 388);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(75, 23);
            this.btnEncerrar.TabIndex = 20;
            this.btnEncerrar.Text = "Encerrar";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // btnAnular1
            // 
            this.btnAnular1.Location = new System.Drawing.Point(150, 362);
            this.btnAnular1.Name = "btnAnular1";
            this.btnAnular1.Size = new System.Drawing.Size(15, 23);
            this.btnAnular1.TabIndex = 21;
            this.btnAnular1.Text = "-";
            this.btnAnular1.UseVisualStyleBackColor = true;
            this.btnAnular1.Click += new System.EventHandler(this.btnAnular1_Click);
            // 
            // btnAnular2
            // 
            this.btnAnular2.Location = new System.Drawing.Point(312, 363);
            this.btnAnular2.Name = "btnAnular2";
            this.btnAnular2.Size = new System.Drawing.Size(15, 23);
            this.btnAnular2.TabIndex = 22;
            this.btnAnular2.Text = "-";
            this.btnAnular2.UseVisualStyleBackColor = true;
            this.btnAnular2.Click += new System.EventHandler(this.btnAnular2_Click);
            // 
            // alphanumericTextBox1
            // 
            // 
            // Times
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 423);
            this.Controls.Add(this.btnAnular2);
            this.Controls.Add(this.btnAnular1);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.txtTime2);
            this.Controls.Add(this.txtTime1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGolsTime2);
            this.Controls.Add(this.lblGolsTime1);
            this.Controls.Add(this.btnConferir2);
            this.Controls.Add(this.btnProcurar2);
            this.Controls.Add(this.pctTime2);
            this.Controls.Add(this.btnProcurar1);
            this.Controls.Add(this.pctTime1);
            this.Controls.Add(this.btnConferir1);
            this.Name = "Times";
            this.Text = "FormTimes";
            ((System.ComponentModel.ISupportInitialize)(this.pctTime1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTime2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConferir1;
        private System.Windows.Forms.PictureBox pctTime1;
        private System.Windows.Forms.Button btnProcurar1;
        private System.Windows.Forms.Button btnProcurar2;
        private System.Windows.Forms.PictureBox pctTime2;
        private System.Windows.Forms.Button btnConferir2;
        private System.Windows.Forms.Label lblGolsTime1;
        private System.Windows.Forms.Label lblGolsTime2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTime1;
        private System.Windows.Forms.TextBox txtTime2;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Button btnAnular1;
        private System.Windows.Forms.Button btnAnular2;
    }
}