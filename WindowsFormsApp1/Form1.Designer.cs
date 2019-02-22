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
            this.textBox_um_real = new System.Windows.Forms.TextBox();
            this.textBox_cinquenta_centavos = new System.Windows.Forms.TextBox();
            this.textBox_25_centavos = new System.Windows.Forms.TextBox();
            this.textBox_10_centavos = new System.Windows.Forms.TextBox();
            this.textBox_5_centavos = new System.Windows.Forms.TextBox();
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
            this.textBox_5_centavos_pago = new System.Windows.Forms.TextBox();
            this.textBox_10_centavos_pago = new System.Windows.Forms.TextBox();
            this.textBox_25_centavos_pago = new System.Windows.Forms.TextBox();
            this.textBox_50_centavos_pago = new System.Windows.Forms.TextBox();
            this.textBox_um_real_pago = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_valor_trocado = new System.Windows.Forms.TextBox();
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
            // textBox_um_real
            // 
            this.textBox_um_real.Location = new System.Drawing.Point(113, 33);
            this.textBox_um_real.Name = "textBox_um_real";
            this.textBox_um_real.Size = new System.Drawing.Size(100, 20);
            this.textBox_um_real.TabIndex = 1;
            this.textBox_um_real.TextChanged += new System.EventHandler(this.textBox_um_real_TextChanged);
            // 
            // textBox_cinquenta_centavos
            // 
            this.textBox_cinquenta_centavos.Location = new System.Drawing.Point(113, 85);
            this.textBox_cinquenta_centavos.Name = "textBox_cinquenta_centavos";
            this.textBox_cinquenta_centavos.Size = new System.Drawing.Size(100, 20);
            this.textBox_cinquenta_centavos.TabIndex = 2;
            this.textBox_cinquenta_centavos.TextChanged += new System.EventHandler(this.textBox_cinquenta_centavos_TextChanged);
            // 
            // textBox_25_centavos
            // 
            this.textBox_25_centavos.Location = new System.Drawing.Point(113, 138);
            this.textBox_25_centavos.Name = "textBox_25_centavos";
            this.textBox_25_centavos.Size = new System.Drawing.Size(100, 20);
            this.textBox_25_centavos.TabIndex = 3;
            this.textBox_25_centavos.TextChanged += new System.EventHandler(this.textBox_25_centavos_TextChanged);
            // 
            // textBox_10_centavos
            // 
            this.textBox_10_centavos.Location = new System.Drawing.Point(113, 195);
            this.textBox_10_centavos.Name = "textBox_10_centavos";
            this.textBox_10_centavos.Size = new System.Drawing.Size(100, 20);
            this.textBox_10_centavos.TabIndex = 4;
            this.textBox_10_centavos.TextChanged += new System.EventHandler(this.textBox_10_centavos_TextChanged);
            // 
            // textBox_5_centavos
            // 
            this.textBox_5_centavos.Location = new System.Drawing.Point(113, 264);
            this.textBox_5_centavos.Name = "textBox_5_centavos";
            this.textBox_5_centavos.Size = new System.Drawing.Size(100, 20);
            this.textBox_5_centavos.TabIndex = 5;
            this.textBox_5_centavos.TextChanged += new System.EventHandler(this.textBox_5_centavos_TextChanged);
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
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(411, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Pago R$ 0,10";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(411, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Pago R$ 0,25";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(411, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Pago R$ 0,50";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(411, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Pago R$ 1,00";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textBox_5_centavos_pago
            // 
            this.textBox_5_centavos_pago.Location = new System.Drawing.Point(512, 264);
            this.textBox_5_centavos_pago.Name = "textBox_5_centavos_pago";
            this.textBox_5_centavos_pago.Size = new System.Drawing.Size(100, 20);
            this.textBox_5_centavos_pago.TabIndex = 15;
            this.textBox_5_centavos_pago.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox_10_centavos_pago
            // 
            this.textBox_10_centavos_pago.Location = new System.Drawing.Point(512, 195);
            this.textBox_10_centavos_pago.Name = "textBox_10_centavos_pago";
            this.textBox_10_centavos_pago.Size = new System.Drawing.Size(100, 20);
            this.textBox_10_centavos_pago.TabIndex = 14;
            this.textBox_10_centavos_pago.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox_25_centavos_pago
            // 
            this.textBox_25_centavos_pago.Location = new System.Drawing.Point(512, 138);
            this.textBox_25_centavos_pago.Name = "textBox_25_centavos_pago";
            this.textBox_25_centavos_pago.Size = new System.Drawing.Size(100, 20);
            this.textBox_25_centavos_pago.TabIndex = 13;
            this.textBox_25_centavos_pago.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBox_50_centavos_pago
            // 
            this.textBox_50_centavos_pago.Location = new System.Drawing.Point(512, 85);
            this.textBox_50_centavos_pago.Name = "textBox_50_centavos_pago";
            this.textBox_50_centavos_pago.Size = new System.Drawing.Size(100, 20);
            this.textBox_50_centavos_pago.TabIndex = 12;
            this.textBox_50_centavos_pago.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // textBox_um_real_pago
            // 
            this.textBox_um_real_pago.Location = new System.Drawing.Point(512, 33);
            this.textBox_um_real_pago.Name = "textBox_um_real_pago";
            this.textBox_um_real_pago.Size = new System.Drawing.Size(100, 20);
            this.textBox_um_real_pago.TabIndex = 11;
            this.textBox_um_real_pago.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
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
            // textBox_valor_trocado
            // 
            this.textBox_valor_trocado.Location = new System.Drawing.Point(273, 69);
            this.textBox_valor_trocado.Name = "textBox_valor_trocado";
            this.textBox_valor_trocado.Size = new System.Drawing.Size(100, 20);
            this.textBox_valor_trocado.TabIndex = 22;
            this.textBox_valor_trocado.TextChanged += new System.EventHandler(this.textBox_valor_trocado_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 391);
            this.Controls.Add(this.textBox_valor_trocado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_5_centavos_pago);
            this.Controls.Add(this.textBox_10_centavos_pago);
            this.Controls.Add(this.textBox_25_centavos_pago);
            this.Controls.Add(this.textBox_50_centavos_pago);
            this.Controls.Add(this.textBox_um_real_pago);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_5_centavos);
            this.Controls.Add(this.textBox_10_centavos);
            this.Controls.Add(this.textBox_25_centavos);
            this.Controls.Add(this.textBox_cinquenta_centavos);
            this.Controls.Add(this.textBox_um_real);
            this.Controls.Add(this.button_resolver);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_resolver;
        private System.Windows.Forms.TextBox textBox_um_real;
        private System.Windows.Forms.TextBox textBox_cinquenta_centavos;
        private System.Windows.Forms.TextBox textBox_25_centavos;
        private System.Windows.Forms.TextBox textBox_10_centavos;
        private System.Windows.Forms.TextBox textBox_5_centavos;
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
        private System.Windows.Forms.TextBox textBox_5_centavos_pago;
        private System.Windows.Forms.TextBox textBox_10_centavos_pago;
        private System.Windows.Forms.TextBox textBox_25_centavos_pago;
        private System.Windows.Forms.TextBox textBox_50_centavos_pago;
        private System.Windows.Forms.TextBox textBox_um_real_pago;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_valor_trocado;
    }
}

