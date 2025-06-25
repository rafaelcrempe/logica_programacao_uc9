namespace exercicio4_metros_centimetros
{
    partial class frmPrincipal
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConverter = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(151, 116);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(213, 29);
            this.txtValor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o valor em metros:";
            // 
            // btnConverter
            // 
            this.btnConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverter.Location = new System.Drawing.Point(192, 173);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(129, 44);
            this.btnConverter.TabIndex = 2;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(184, 296);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(151, 23);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Resize += new System.EventHandler(this.frmPrincipal_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label lblResultado;
    }
}

