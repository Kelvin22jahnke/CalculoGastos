
namespace CalculoGasto
{
    partial class frmCalculoGastos
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
            this.txtQuilometragemInicial = new System.Windows.Forms.TextBox();
            this.txtQuilometragemFinal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecoCombustivel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtQuilometroPorLitro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quilometragem Inicial (KM):";
            // 
            // txtQuilometragemInicial
            // 
            this.txtQuilometragemInicial.Location = new System.Drawing.Point(153, 18);
            this.txtQuilometragemInicial.Name = "txtQuilometragemInicial";
            this.txtQuilometragemInicial.Size = new System.Drawing.Size(100, 20);
            this.txtQuilometragemInicial.TabIndex = 1;
            // 
            // txtQuilometragemFinal
            // 
            this.txtQuilometragemFinal.Location = new System.Drawing.Point(395, 18);
            this.txtQuilometragemFinal.Name = "txtQuilometragemFinal";
            this.txtQuilometragemFinal.Size = new System.Drawing.Size(100, 20);
            this.txtQuilometragemFinal.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quilometragem Final (KM):";
            // 
            // txtPrecoCombustivel
            // 
            this.txtPrecoCombustivel.Location = new System.Drawing.Point(153, 54);
            this.txtPrecoCombustivel.Name = "txtPrecoCombustivel";
            this.txtPrecoCombustivel.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoCombustivel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preço do Combustivel:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(392, 93);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(107, 30);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtQuilometroPorLitro
            // 
            this.txtQuilometroPorLitro.Location = new System.Drawing.Point(395, 57);
            this.txtQuilometroPorLitro.Name = "txtQuilometroPorLitro";
            this.txtQuilometroPorLitro.Size = new System.Drawing.Size(100, 20);
            this.txtQuilometroPorLitro.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "KM por Litro:";
            // 
            // frmCalculoGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 148);
            this.Controls.Add(this.txtQuilometroPorLitro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtPrecoCombustivel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQuilometragemFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuilometragemInicial);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmCalculoGastos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo de Gastos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuilometragemInicial;
        private System.Windows.Forms.TextBox txtQuilometragemFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecoCombustivel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtQuilometroPorLitro;
        private System.Windows.Forms.Label label4;
    }
}

