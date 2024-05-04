namespace HotelPets
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnnumAnimais = new Label();
            btnConsumoRacao = new Label();
            btnDiasHospedagem = new Label();
            bntQuantidade = new Label();
            panel1 = new Panel();
            btnCalcular = new Button();
            lblresultado = new Label();
            numAnimais = new NumericUpDown();
            numRacao = new NumericUpDown();
            numHospedagem = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAnimais).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRacao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHospedagem).BeginInit();
            SuspendLayout();
            // 
            // btnnumAnimais
            // 
            btnnumAnimais.AutoSize = true;
            btnnumAnimais.Location = new Point(70, 120);
            btnnumAnimais.Name = "btnnumAnimais";
            btnnumAnimais.Size = new Size(139, 20);
            btnnumAnimais.TabIndex = 3;
            btnnumAnimais.Text = "Número de animais";
            // 
            // btnConsumoRacao
            // 
            btnConsumoRacao.AutoSize = true;
            btnConsumoRacao.Location = new Point(70, 221);
            btnConsumoRacao.Name = "btnConsumoRacao";
            btnConsumoRacao.Size = new Size(223, 20);
            btnConsumoRacao.TabIndex = 4;
            btnConsumoRacao.Text = "Consumo médio de ração diário";
            // 
            // btnDiasHospedagem
            // 
            btnDiasHospedagem.AutoSize = true;
            btnDiasHospedagem.Location = new Point(70, 304);
            btnDiasHospedagem.Name = "btnDiasHospedagem";
            btnDiasHospedagem.Size = new Size(153, 20);
            btnDiasHospedagem.TabIndex = 5;
            btnDiasHospedagem.Text = "Dias de Hospedagem";
            // 
            // bntQuantidade
            // 
            bntQuantidade.AutoSize = true;
            bntQuantidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bntQuantidade.Location = new Point(46, 51);
            bntQuantidade.Name = "bntQuantidade";
            bntQuantidade.Size = new Size(195, 28);
            bntQuantidade.TabIndex = 6;
            bntQuantidade.Text = "Quantidade de ração";
            // 
            // panel1
            // 
            panel1.Controls.Add(numHospedagem);
            panel1.Controls.Add(numRacao);
            panel1.Controls.Add(numAnimais);
            panel1.Controls.Add(btnCalcular);
            panel1.Controls.Add(bntQuantidade);
            panel1.Controls.Add(btnDiasHospedagem);
            panel1.Controls.Add(btnConsumoRacao);
            panel1.Controls.Add(btnnumAnimais);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 457);
            panel1.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(176, 395);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(88, 26);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Font = new Font("Source Serif Pro", 59.9999962F, FontStyle.Bold, GraphicsUnit.Point);
            lblresultado.Location = new Point(533, 165);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(112, 138);
            lblresultado.TabIndex = 2;
            lblresultado.Text = "0";
            // 
            // numAnimais
            // 
            numAnimais.Location = new Point(70, 166);
            numAnimais.Name = "numAnimais";
            numAnimais.Size = new Size(181, 27);
            numAnimais.TabIndex = 3;
            // 
            // numRacao
            // 
            numRacao.Location = new Point(70, 262);
            numRacao.Name = "numRacao";
            numRacao.Size = new Size(181, 27);
            numRacao.TabIndex = 8;
            // 
            // numHospedagem
            // 
            numHospedagem.Location = new Point(70, 338);
            numHospedagem.Name = "numHospedagem";
            numHospedagem.Size = new Size(181, 27);
            numHospedagem.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblresultado);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAnimais).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRacao).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHospedagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label btnnumAnimais;
        private Label btnConsumoRacao;
        private Label btnDiasHospedagem;
        private Label bntQuantidade;
        private Panel panel1;
        private Button btnCalcular;
        private Label lblresultado;
        private NumericUpDown numAnimais;
        private NumericUpDown numHospedagem;
        private NumericUpDown numRacao;
    }
}