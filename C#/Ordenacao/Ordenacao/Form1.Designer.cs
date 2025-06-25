namespace Ordenacao
{
    partial class Form1
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.lblPosicao1 = new System.Windows.Forms.Label();
            this.lblPosicao2 = new System.Windows.Forms.Label();
            this.lblPosicao3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPosicao6 = new System.Windows.Forms.Label();
            this.lblPosicao5 = new System.Windows.Forms.Label();
            this.lblPosicao4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.Location = new System.Drawing.Point(66, 74);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 29);
            this.txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.Location = new System.Drawing.Point(215, 74);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 29);
            this.txtNum2.TabIndex = 1;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.Location = new System.Drawing.Point(200, 143);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(122, 47);
            this.btnOrdenar.TabIndex = 2;
            this.btnOrdenar.Text = "ORDENAR";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // txtNum3
            // 
            this.txtNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum3.Location = new System.Drawing.Point(374, 74);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(100, 29);
            this.txtNum3.TabIndex = 3;
            // 
            // lblPosicao1
            // 
            this.lblPosicao1.AutoSize = true;
            this.lblPosicao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicao1.Location = new System.Drawing.Point(85, 307);
            this.lblPosicao1.Name = "lblPosicao1";
            this.lblPosicao1.Size = new System.Drawing.Size(0, 24);
            this.lblPosicao1.TabIndex = 4;
            // 
            // lblPosicao2
            // 
            this.lblPosicao2.AutoSize = true;
            this.lblPosicao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicao2.Location = new System.Drawing.Point(231, 307);
            this.lblPosicao2.Name = "lblPosicao2";
            this.lblPosicao2.Size = new System.Drawing.Size(0, 24);
            this.lblPosicao2.TabIndex = 5;
            // 
            // lblPosicao3
            // 
            this.lblPosicao3.AutoSize = true;
            this.lblPosicao3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicao3.Location = new System.Drawing.Point(388, 307);
            this.lblPosicao3.Name = "lblPosicao3";
            this.lblPosicao3.Size = new System.Drawing.Size(0, 24);
            this.lblPosicao3.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(62, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ordem Crescente:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ordem Decrescente:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblPosicao6
            // 
            this.lblPosicao6.AutoSize = true;
            this.lblPosicao6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicao6.Location = new System.Drawing.Point(388, 419);
            this.lblPosicao6.Name = "lblPosicao6";
            this.lblPosicao6.Size = new System.Drawing.Size(0, 24);
            this.lblPosicao6.TabIndex = 14;
            // 
            // lblPosicao5
            // 
            this.lblPosicao5.AutoSize = true;
            this.lblPosicao5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicao5.Location = new System.Drawing.Point(231, 419);
            this.lblPosicao5.Name = "lblPosicao5";
            this.lblPosicao5.Size = new System.Drawing.Size(0, 24);
            this.lblPosicao5.TabIndex = 13;
            // 
            // lblPosicao4
            // 
            this.lblPosicao4.AutoSize = true;
            this.lblPosicao4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicao4.Location = new System.Drawing.Point(85, 419);
            this.lblPosicao4.Name = "lblPosicao4";
            this.lblPosicao4.Size = new System.Drawing.Size(0, 24);
            this.lblPosicao4.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 549);
            this.Controls.Add(this.lblPosicao6);
            this.Controls.Add(this.lblPosicao5);
            this.Controls.Add(this.lblPosicao4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPosicao3);
            this.Controls.Add(this.lblPosicao2);
            this.Controls.Add(this.lblPosicao1);
            this.Controls.Add(this.txtNum3);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.Label lblPosicao1;
        private System.Windows.Forms.Label lblPosicao2;
        private System.Windows.Forms.Label lblPosicao3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPosicao6;
        private System.Windows.Forms.Label lblPosicao5;
        private System.Windows.Forms.Label lblPosicao4;
    }
}

