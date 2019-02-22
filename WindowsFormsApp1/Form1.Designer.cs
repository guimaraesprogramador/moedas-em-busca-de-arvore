namespace WindowsFormsApp1
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
            this.button_resolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cinquenta_receber = new System.Windows.Forms.MaskedTextBox();
            this.vinte_e_cinco_receber = new System.Windows.Forms.MaskedTextBox();
            this.dez_receber = new System.Windows.Forms.MaskedTextBox();
            this.cinco_receber = new System.Windows.Forms.MaskedTextBox();
            this.um_real_receber = new System.Windows.Forms.MaskedTextBox();
            this.troco = new System.Windows.Forms.MaskedTextBox();
            this.um_real_pagos = new System.Windows.Forms.MaskedTextBox();
            this.cinquenta_pagos = new System.Windows.Forms.MaskedTextBox();
            this.vinte_e_cinco_pagos = new System.Windows.Forms.MaskedTextBox();
            this.dez_pagos = new System.Windows.Forms.MaskedTextBox();
            this.cinco_pago = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // button_resolver
            // 
            this.button_resolver.Location = new System.Drawing.Point(288, 311);
            this.button_resolver.Name = "button_resolver";
            this.button_resolver.Size = new System.Drawing.Size(85, 41);
            this.button_resolver.TabIndex = 0;
            this.button_resolver.Text = "Resolver";
            this.button_resolver.UseVisualStyleBackColor = true;
            this.button_resolver.Click += new System.EventHandler(this.button_resolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Moedas de R$ 1,00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Moedas de R$ 0,50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Moedas de R$ 0,25";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Moedas de R$ 0,10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Moedas de R$ 0,05";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Pago R$ 0,05";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(411, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Pago R$ 0,10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(411, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Pago R$ 0,25";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(411, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Pago R$ 0,50";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(411, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Pago R$ 1,00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(277, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Valor a ser trocado";
            // 
            // cinquenta_receber
            // 
            this.cinquenta_receber.Location = new System.Drawing.Point(113, 89);
            this.cinquenta_receber.Mask = "00000";
            this.cinquenta_receber.Name = "cinquenta_receber";
            this.cinquenta_receber.Size = new System.Drawing.Size(100, 20);
            this.cinquenta_receber.TabIndex = 23;
            this.cinquenta_receber.ValidatingType = typeof(int);
            // 
            // vinte_e_cinco_receber
            // 
            this.vinte_e_cinco_receber.Location = new System.Drawing.Point(113, 142);
            this.vinte_e_cinco_receber.Mask = "00000";
            this.vinte_e_cinco_receber.Name = "vinte_e_cinco_receber";
            this.vinte_e_cinco_receber.Size = new System.Drawing.Size(100, 20);
            this.vinte_e_cinco_receber.TabIndex = 24;
            this.vinte_e_cinco_receber.ValidatingType = typeof(int);
            // 
            // dez_receber
            // 
            this.dez_receber.Location = new System.Drawing.Point(113, 195);
            this.dez_receber.Mask = "00000";
            this.dez_receber.Name = "dez_receber";
            this.dez_receber.Size = new System.Drawing.Size(100, 20);
            this.dez_receber.TabIndex = 25;
            this.dez_receber.ValidatingType = typeof(int);
            // 
            // cinco_receber
            // 
            this.cinco_receber.Location = new System.Drawing.Point(113, 268);
            this.cinco_receber.Mask = "00000";
            this.cinco_receber.Name = "cinco_receber";
            this.cinco_receber.Size = new System.Drawing.Size(100, 20);
            this.cinco_receber.TabIndex = 26;
            this.cinco_receber.ValidatingType = typeof(int);
            // 
            // um_real_receber
            // 
            this.um_real_receber.Location = new System.Drawing.Point(113, 33);
            this.um_real_receber.Mask = "00000";
            this.um_real_receber.Name = "um_real_receber";
            this.um_real_receber.Size = new System.Drawing.Size(100, 20);
            this.um_real_receber.TabIndex = 27;
            this.um_real_receber.ValidatingType = typeof(int);
            // 
            // troco
            // 
            this.troco.Location = new System.Drawing.Point(280, 69);
            this.troco.Mask = "0.0000";
            this.troco.Name = "troco";
            this.troco.Size = new System.Drawing.Size(100, 20);
            this.troco.TabIndex = 28;
            this.troco.ValidatingType = typeof(int);
            // 
            // um_real_pagos
            // 
            this.um_real_pagos.Location = new System.Drawing.Point(490, 37);
            this.um_real_pagos.Mask = "00000";
            this.um_real_pagos.Name = "um_real_pagos";
            this.um_real_pagos.Size = new System.Drawing.Size(100, 20);
            this.um_real_pagos.TabIndex = 29;
            this.um_real_pagos.ValidatingType = typeof(int);
            // 
            // cinquenta_pagos
            // 
            this.cinquenta_pagos.Location = new System.Drawing.Point(490, 89);
            this.cinquenta_pagos.Mask = "00000";
            this.cinquenta_pagos.Name = "cinquenta_pagos";
            this.cinquenta_pagos.Size = new System.Drawing.Size(100, 20);
            this.cinquenta_pagos.TabIndex = 30;
            this.cinquenta_pagos.ValidatingType = typeof(int);
            // 
            // vinte_e_cinco_pagos
            // 
            this.vinte_e_cinco_pagos.Location = new System.Drawing.Point(490, 142);
            this.vinte_e_cinco_pagos.Mask = "00000";
            this.vinte_e_cinco_pagos.Name = "vinte_e_cinco_pagos";
            this.vinte_e_cinco_pagos.Size = new System.Drawing.Size(100, 20);
            this.vinte_e_cinco_pagos.TabIndex = 31;
            this.vinte_e_cinco_pagos.ValidatingType = typeof(int);
            // 
            // dez_pagos
            // 
            this.dez_pagos.Location = new System.Drawing.Point(490, 199);
            this.dez_pagos.Mask = "00000";
            this.dez_pagos.Name = "dez_pagos";
            this.dez_pagos.Size = new System.Drawing.Size(100, 20);
            this.dez_pagos.TabIndex = 32;
            this.dez_pagos.ValidatingType = typeof(int);
            // 
            // cinco_pago
            // 
            this.cinco_pago.Location = new System.Drawing.Point(490, 264);
            this.cinco_pago.Mask = "00000";
            this.cinco_pago.Name = "cinco_pago";
            this.cinco_pago.Size = new System.Drawing.Size(100, 20);
            this.cinco_pago.TabIndex = 33;
            this.cinco_pago.ValidatingType = typeof(int);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 391);
            this.Controls.Add(this.cinco_pago);
            this.Controls.Add(this.dez_pagos);
            this.Controls.Add(this.vinte_e_cinco_pagos);
            this.Controls.Add(this.cinquenta_pagos);
            this.Controls.Add(this.um_real_pagos);
            this.Controls.Add(this.troco);
            this.Controls.Add(this.um_real_receber);
            this.Controls.Add(this.cinco_receber);
            this.Controls.Add(this.dez_receber);
            this.Controls.Add(this.vinte_e_cinco_receber);
            this.Controls.Add(this.cinquenta_receber);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_resolver);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_resolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox cinquenta_receber;
        private System.Windows.Forms.MaskedTextBox vinte_e_cinco_receber;
        private System.Windows.Forms.MaskedTextBox dez_receber;
        private System.Windows.Forms.MaskedTextBox cinco_receber;
        private System.Windows.Forms.MaskedTextBox um_real_receber;
        private System.Windows.Forms.MaskedTextBox troco;
        private System.Windows.Forms.MaskedTextBox um_real_pagos;
        private System.Windows.Forms.MaskedTextBox cinquenta_pagos;
        private System.Windows.Forms.MaskedTextBox vinte_e_cinco_pagos;
        private System.Windows.Forms.MaskedTextBox dez_pagos;
        private System.Windows.Forms.MaskedTextBox cinco_pago;
    }
}

