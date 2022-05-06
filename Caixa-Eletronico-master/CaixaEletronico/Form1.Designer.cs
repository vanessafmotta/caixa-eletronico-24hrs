namespace CaixaEletronico
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblQtd100 = new System.Windows.Forms.Label();
            this.lblQtd50 = new System.Windows.Forms.Label();
            this.lblQtd20 = new System.Windows.Forms.Label();
            this.lblQtd10 = new System.Windows.Forms.Label();
            this.lblQtd5 = new System.Windows.Forms.Label();
            this.lblQtd2 = new System.Windows.Forms.Label();
            this.boxNt100 = new System.Windows.Forms.TextBox();
            this.boxNt50 = new System.Windows.Forms.TextBox();
            this.boxNt20 = new System.Windows.Forms.TextBox();
            this.boxNt10 = new System.Windows.Forms.TextBox();
            this.boxNt2 = new System.Windows.Forms.TextBox();
            this.boxNt5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblValorSol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o valor desejado:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(34, 65);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 1;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(152, 61);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Ok";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "RESULTADO: ";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(37, 128);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(89, 13);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor Solicitado =";
            // 
            // lblQtd100
            // 
            this.lblQtd100.AutoSize = true;
            this.lblQtd100.Location = new System.Drawing.Point(37, 167);
            this.lblQtd100.Name = "lblQtd100";
            this.lblQtd100.Size = new System.Drawing.Size(104, 13);
            this.lblQtd100.TabIndex = 5;
            this.lblQtd100.Text = "Qtd notas de 100,00";
            // 
            // lblQtd50
            // 
            this.lblQtd50.AutoSize = true;
            this.lblQtd50.Location = new System.Drawing.Point(37, 218);
            this.lblQtd50.Name = "lblQtd50";
            this.lblQtd50.Size = new System.Drawing.Size(98, 13);
            this.lblQtd50.TabIndex = 6;
            this.lblQtd50.Text = "Qtd notas de 50,00";
            // 
            // lblQtd20
            // 
            this.lblQtd20.AutoSize = true;
            this.lblQtd20.Location = new System.Drawing.Point(201, 167);
            this.lblQtd20.Name = "lblQtd20";
            this.lblQtd20.Size = new System.Drawing.Size(98, 13);
            this.lblQtd20.TabIndex = 7;
            this.lblQtd20.Text = "Qtd notas de 20,00";
            // 
            // lblQtd10
            // 
            this.lblQtd10.AutoSize = true;
            this.lblQtd10.Location = new System.Drawing.Point(201, 218);
            this.lblQtd10.Name = "lblQtd10";
            this.lblQtd10.Size = new System.Drawing.Size(98, 13);
            this.lblQtd10.TabIndex = 8;
            this.lblQtd10.Text = "Qtd notas de 10,00";
            // 
            // lblQtd5
            // 
            this.lblQtd5.AutoSize = true;
            this.lblQtd5.Location = new System.Drawing.Point(354, 167);
            this.lblQtd5.Name = "lblQtd5";
            this.lblQtd5.Size = new System.Drawing.Size(92, 13);
            this.lblQtd5.TabIndex = 9;
            this.lblQtd5.Text = "Qtd notas de 5,00";
            // 
            // lblQtd2
            // 
            this.lblQtd2.AutoSize = true;
            this.lblQtd2.Location = new System.Drawing.Point(354, 218);
            this.lblQtd2.Name = "lblQtd2";
            this.lblQtd2.Size = new System.Drawing.Size(92, 13);
            this.lblQtd2.TabIndex = 10;
            this.lblQtd2.Text = "Qtd notas de 2,00";
            // 
            // boxNt100
            // 
            this.boxNt100.Enabled = false;
            this.boxNt100.Location = new System.Drawing.Point(40, 183);
            this.boxNt100.Name = "boxNt100";
            this.boxNt100.Size = new System.Drawing.Size(100, 20);
            this.boxNt100.TabIndex = 11;
            // 
            // boxNt50
            // 
            this.boxNt50.Enabled = false;
            this.boxNt50.Location = new System.Drawing.Point(41, 234);
            this.boxNt50.Name = "boxNt50";
            this.boxNt50.Size = new System.Drawing.Size(100, 20);
            this.boxNt50.TabIndex = 12;
            // 
            // boxNt20
            // 
            this.boxNt20.Enabled = false;
            this.boxNt20.Location = new System.Drawing.Point(204, 183);
            this.boxNt20.Name = "boxNt20";
            this.boxNt20.Size = new System.Drawing.Size(100, 20);
            this.boxNt20.TabIndex = 13;
            // 
            // boxNt10
            // 
            this.boxNt10.Enabled = false;
            this.boxNt10.Location = new System.Drawing.Point(204, 234);
            this.boxNt10.Name = "boxNt10";
            this.boxNt10.Size = new System.Drawing.Size(100, 20);
            this.boxNt10.TabIndex = 14;
            // 
            // boxNt2
            // 
            this.boxNt2.Enabled = false;
            this.boxNt2.Location = new System.Drawing.Point(357, 234);
            this.boxNt2.Name = "boxNt2";
            this.boxNt2.Size = new System.Drawing.Size(100, 20);
            this.boxNt2.TabIndex = 15;
            // 
            // boxNt5
            // 
            this.boxNt5.Enabled = false;
            this.boxNt5.Location = new System.Drawing.Point(357, 182);
            this.boxNt5.Name = "boxNt5";
            this.boxNt5.Size = new System.Drawing.Size(100, 20);
            this.boxNt5.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "CAIXA ELETRÔNICO";
            // 
            // lblValorSol
            // 
            this.lblValorSol.AutoSize = true;
            this.lblValorSol.Location = new System.Drawing.Point(132, 128);
            this.lblValorSol.Name = "lblValorSol";
            this.lblValorSol.Size = new System.Drawing.Size(0, 13);
            this.lblValorSol.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 282);
            this.Controls.Add(this.lblValorSol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxNt5);
            this.Controls.Add(this.boxNt2);
            this.Controls.Add(this.boxNt10);
            this.Controls.Add(this.boxNt20);
            this.Controls.Add(this.boxNt50);
            this.Controls.Add(this.boxNt100);
            this.Controls.Add(this.lblQtd2);
            this.Controls.Add(this.lblQtd5);
            this.Controls.Add(this.lblQtd10);
            this.Controls.Add(this.lblQtd20);
            this.Controls.Add(this.lblQtd50);
            this.Controls.Add(this.lblQtd100);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblQtd100;
        private System.Windows.Forms.Label lblQtd50;
        private System.Windows.Forms.Label lblQtd20;
        private System.Windows.Forms.Label lblQtd10;
        private System.Windows.Forms.Label lblQtd5;
        private System.Windows.Forms.Label lblQtd2;
        private System.Windows.Forms.TextBox boxNt100;
        private System.Windows.Forms.TextBox boxNt50;
        private System.Windows.Forms.TextBox boxNt20;
        private System.Windows.Forms.TextBox boxNt10;
        private System.Windows.Forms.TextBox boxNt2;
        private System.Windows.Forms.TextBox boxNt5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblValorSol;
        public System.Windows.Forms.TextBox txtValor;
    }
}

