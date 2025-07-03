namespace exercicio13_porcentagem_condicao
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPctReprovadosC = new System.Windows.Forms.TextBox();
            this.txtPctReprovadosD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumReprovadosC = new System.Windows.Forms.TextBox();
            this.txtNumReprovadosD = new System.Windows.Forms.TextBox();
            this.txtTotalReprovados = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Porcentagem de reprovados (Turma C):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Porcentagem de reprovados (Turma D):";
            // 
            // txtPctReprovadosC
            // 
            this.txtPctReprovadosC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPctReprovadosC.Location = new System.Drawing.Point(403, 34);
            this.txtPctReprovadosC.Name = "txtPctReprovadosC";
            this.txtPctReprovadosC.Size = new System.Drawing.Size(100, 29);
            this.txtPctReprovadosC.TabIndex = 2;
            // 
            // txtPctReprovadosD
            // 
            this.txtPctReprovadosD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPctReprovadosD.Location = new System.Drawing.Point(403, 74);
            this.txtPctReprovadosD.Name = "txtPctReprovadosD";
            this.txtPctReprovadosD.Size = new System.Drawing.Size(100, 29);
            this.txtPctReprovadosD.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nº de alunos de reprovados (Turma C):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(341, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nº de alunos de reprovados (Turma D):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Porcentagem Total de Reprovação:";
            // 
            // txtNumReprovadosC
            // 
            this.txtNumReprovadosC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumReprovadosC.Location = new System.Drawing.Point(403, 170);
            this.txtNumReprovadosC.Name = "txtNumReprovadosC";
            this.txtNumReprovadosC.Size = new System.Drawing.Size(100, 29);
            this.txtNumReprovadosC.TabIndex = 7;
            // 
            // txtNumReprovadosD
            // 
            this.txtNumReprovadosD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumReprovadosD.Location = new System.Drawing.Point(403, 208);
            this.txtNumReprovadosD.Name = "txtNumReprovadosD";
            this.txtNumReprovadosD.Size = new System.Drawing.Size(100, 29);
            this.txtNumReprovadosD.TabIndex = 8;
            // 
            // txtTotalReprovados
            // 
            this.txtTotalReprovados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalReprovados.Location = new System.Drawing.Point(403, 278);
            this.txtTotalReprovados.Name = "txtTotalReprovados";
            this.txtTotalReprovados.Size = new System.Drawing.Size(100, 29);
            this.txtTotalReprovados.TabIndex = 9;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(538, 47);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(104, 41);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "EXIBIR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 468);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTotalReprovados);
            this.Controls.Add(this.txtNumReprovadosD);
            this.Controls.Add(this.txtNumReprovadosC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPctReprovadosD);
            this.Controls.Add(this.txtPctReprovadosC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPctReprovadosC;
        private System.Windows.Forms.TextBox txtPctReprovadosD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumReprovadosC;
        private System.Windows.Forms.TextBox txtNumReprovadosD;
        private System.Windows.Forms.TextBox txtTotalReprovados;
        private System.Windows.Forms.Button btnCalcular;
    }
}

