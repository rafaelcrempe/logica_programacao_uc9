namespace AlturaMedia
{
    partial class AlturaMedia
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAltura1 = new System.Windows.Forms.TextBox();
            this.txtAltura2 = new System.Windows.Forms.TextBox();
            this.txtAltura3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblAlturaMedia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAltura1
            // 
            this.txtAltura1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura1.Location = new System.Drawing.Point(47, 76);
            this.txtAltura1.Name = "txtAltura1";
            this.txtAltura1.Size = new System.Drawing.Size(215, 29);
            this.txtAltura1.TabIndex = 0;
            // 
            // txtAltura2
            // 
            this.txtAltura2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura2.Location = new System.Drawing.Point(47, 154);
            this.txtAltura2.Name = "txtAltura2";
            this.txtAltura2.Size = new System.Drawing.Size(212, 29);
            this.txtAltura2.TabIndex = 1;
            // 
            // txtAltura3
            // 
            this.txtAltura3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura3.Location = new System.Drawing.Point(47, 234);
            this.txtAltura3.Name = "txtAltura3";
            this.txtAltura3.Size = new System.Drawing.Size(212, 29);
            this.txtAltura3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite a primeira altura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Digite a segunda altura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Digite a terceira altura:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCalcular.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCalcular.Location = new System.Drawing.Point(76, 284);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(146, 40);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblAlturaMedia
            // 
            this.lblAlturaMedia.AutoSize = true;
            this.lblAlturaMedia.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlturaMedia.Location = new System.Drawing.Point(113, 360);
            this.lblAlturaMedia.Name = "lblAlturaMedia";
            this.lblAlturaMedia.Size = new System.Drawing.Size(0, 23);
            this.lblAlturaMedia.TabIndex = 7;
            // 
            // AlturaMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(304, 450);
            this.Controls.Add(this.lblAlturaMedia);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAltura3);
            this.Controls.Add(this.txtAltura2);
            this.Controls.Add(this.txtAltura1);
            this.Name = "AlturaMedia";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAltura1;
        private System.Windows.Forms.TextBox txtAltura2;
        private System.Windows.Forms.TextBox txtAltura3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblAlturaMedia;
    }
}

