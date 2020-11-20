namespace RH.UI.Windows
{
    partial class InclusaoFuncionarioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InclusaoFuncionarioForm));
            this.senhaTextBox = new System.Windows.Forms.MaskedTextBox();
            this.senhaLabel = new System.Windows.Forms.Label();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.sairButton = new System.Windows.Forms.Button();
            this.retornarButton = new System.Windows.Forms.Button();
            this.limparButton = new System.Windows.Forms.Button();
            this.cadastrarButton = new System.Windows.Forms.Button();
            this.diasSemanaLabel = new System.Windows.Forms.Label();
            this.horarioTrabalhoSaidaLabel = new System.Windows.Forms.Label();
            this.horarioTrabalhoSaidaTextBox = new System.Windows.Forms.MaskedTextBox();
            this.horarioTrabalhoEntradaLabel = new System.Windows.Forms.Label();
            this.reTextBox = new System.Windows.Forms.MaskedTextBox();
            this.reLabel = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.horarioTrabalhoEntradaTextBox = new System.Windows.Forms.MaskedTextBox();
            this.diasSemanaComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.senhaTextBox.Location = new System.Drawing.Point(117, 161);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(100, 25);
            this.senhaTextBox.TabIndex = 3;
            this.senhaTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.senhaTextBox_MaskInputRejected);
            // 
            // senhaLabel
            // 
            this.senhaLabel.AutoSize = true;
            this.senhaLabel.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.senhaLabel.Location = new System.Drawing.Point(46, 164);
            this.senhaLabel.Name = "senhaLabel";
            this.senhaLabel.Size = new System.Drawing.Size(46, 18);
            this.senhaLabel.TabIndex = 115;
            this.senhaLabel.Text = "Senha";
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold);
            this.tituloLabel.Location = new System.Drawing.Point(220, 15);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(362, 25);
            this.tituloLabel.TabIndex = 114;
            this.tituloLabel.Text = "Calcula Salário Líquido";
            // 
            // sairButton
            // 
            this.sairButton.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.sairButton.Location = new System.Drawing.Point(613, 396);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(141, 39);
            this.sairButton.TabIndex = 10;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // retornarButton
            // 
            this.retornarButton.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.retornarButton.Location = new System.Drawing.Point(429, 396);
            this.retornarButton.Name = "retornarButton";
            this.retornarButton.Size = new System.Drawing.Size(153, 39);
            this.retornarButton.TabIndex = 9;
            this.retornarButton.Text = "Retornar";
            this.retornarButton.UseVisualStyleBackColor = true;
            this.retornarButton.Click += new System.EventHandler(this.retornarButton_Click);
            // 
            // limparButton
            // 
            this.limparButton.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.limparButton.Location = new System.Drawing.Point(260, 396);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(149, 39);
            this.limparButton.TabIndex = 8;
            this.limparButton.Text = "Limpar";
            this.limparButton.UseVisualStyleBackColor = true;
            this.limparButton.Click += new System.EventHandler(this.limparButton_Click);
            // 
            // cadastrarButton
            // 
            this.cadastrarButton.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.cadastrarButton.Location = new System.Drawing.Point(74, 396);
            this.cadastrarButton.Name = "cadastrarButton";
            this.cadastrarButton.Size = new System.Drawing.Size(162, 39);
            this.cadastrarButton.TabIndex = 7;
            this.cadastrarButton.Text = "Cadastrar";
            this.cadastrarButton.UseVisualStyleBackColor = true;
            this.cadastrarButton.Click += new System.EventHandler(this.cadastrarButton_Click);
            // 
            // diasSemanaLabel
            // 
            this.diasSemanaLabel.AutoSize = true;
            this.diasSemanaLabel.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.diasSemanaLabel.Location = new System.Drawing.Point(46, 316);
            this.diasSemanaLabel.Name = "diasSemanaLabel";
            this.diasSemanaLabel.Size = new System.Drawing.Size(108, 18);
            this.diasSemanaLabel.TabIndex = 108;
            this.diasSemanaLabel.Text = "Dias da Semana";
            // 
            // horarioTrabalhoSaidaLabel
            // 
            this.horarioTrabalhoSaidaLabel.AutoSize = true;
            this.horarioTrabalhoSaidaLabel.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.horarioTrabalhoSaidaLabel.Location = new System.Drawing.Point(46, 265);
            this.horarioTrabalhoSaidaLabel.Name = "horarioTrabalhoSaidaLabel";
            this.horarioTrabalhoSaidaLabel.Size = new System.Drawing.Size(162, 18);
            this.horarioTrabalhoSaidaLabel.TabIndex = 101;
            this.horarioTrabalhoSaidaLabel.Text = "Horário Trabalho Saída:";
            // 
            // horarioTrabalhoSaidaTextBox
            // 
            this.horarioTrabalhoSaidaTextBox.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.horarioTrabalhoSaidaTextBox.Location = new System.Drawing.Point(258, 265);
            this.horarioTrabalhoSaidaTextBox.Mask = "99:99";
            this.horarioTrabalhoSaidaTextBox.Name = "horarioTrabalhoSaidaTextBox";
            this.horarioTrabalhoSaidaTextBox.Size = new System.Drawing.Size(57, 25);
            this.horarioTrabalhoSaidaTextBox.TabIndex = 5;
            this.horarioTrabalhoSaidaTextBox.ValidatingType = typeof(System.DateTime);
            this.horarioTrabalhoSaidaTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.horarioTrabalhoSaidaTextBox_MaskInputRejected);
            // 
            // horarioTrabalhoEntradaLabel
            // 
            this.horarioTrabalhoEntradaLabel.AutoSize = true;
            this.horarioTrabalhoEntradaLabel.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.horarioTrabalhoEntradaLabel.Location = new System.Drawing.Point(46, 222);
            this.horarioTrabalhoEntradaLabel.Name = "horarioTrabalhoEntradaLabel";
            this.horarioTrabalhoEntradaLabel.Size = new System.Drawing.Size(178, 18);
            this.horarioTrabalhoEntradaLabel.TabIndex = 96;
            this.horarioTrabalhoEntradaLabel.Text = "Horário Trabalho Entrada:";
            // 
            // reTextBox
            // 
            this.reTextBox.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.reTextBox.Location = new System.Drawing.Point(117, 105);
            this.reTextBox.Mask = "999";
            this.reTextBox.Name = "reTextBox";
            this.reTextBox.Size = new System.Drawing.Size(41, 25);
            this.reTextBox.TabIndex = 2;
            this.reTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.reTextBox_MaskInputRejected);
            // 
            // reLabel
            // 
            this.reLabel.AutoSize = true;
            this.reLabel.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.reLabel.Location = new System.Drawing.Point(46, 108);
            this.reLabel.Name = "reLabel";
            this.reLabel.Size = new System.Drawing.Size(31, 18);
            this.reLabel.TabIndex = 94;
            this.reLabel.Text = "RE:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.nomeTextBox.Location = new System.Drawing.Point(117, 61);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(554, 25);
            this.nomeTextBox.TabIndex = 1;
            this.nomeTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.nomeTextBox_MaskInputRejected);
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.nomeLabel.Location = new System.Drawing.Point(46, 65);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(53, 18);
            this.nomeLabel.TabIndex = 92;
            this.nomeLabel.Text = "Nome: ";
            // 
            // horarioTrabalhoEntradaTextBox
            // 
            this.horarioTrabalhoEntradaTextBox.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.horarioTrabalhoEntradaTextBox.Location = new System.Drawing.Point(258, 218);
            this.horarioTrabalhoEntradaTextBox.Mask = "99:99";
            this.horarioTrabalhoEntradaTextBox.Name = "horarioTrabalhoEntradaTextBox";
            this.horarioTrabalhoEntradaTextBox.Size = new System.Drawing.Size(57, 25);
            this.horarioTrabalhoEntradaTextBox.TabIndex = 4;
            this.horarioTrabalhoEntradaTextBox.ValidatingType = typeof(System.DateTime);
            this.horarioTrabalhoEntradaTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.horarioTrabalhoEntradaTextBox_MaskInputRejected);
            // 
            // diasSemanaComboBox
            // 
            this.diasSemanaComboBox.FormattingEnabled = true;
            this.diasSemanaComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.diasSemanaComboBox.Location = new System.Drawing.Point(162, 316);
            this.diasSemanaComboBox.Name = "diasSemanaComboBox";
            this.diasSemanaComboBox.Size = new System.Drawing.Size(62, 21);
            this.diasSemanaComboBox.TabIndex = 6;
            this.diasSemanaComboBox.SelectedIndexChanged += new System.EventHandler(this.diasSemanaComboBox_SelectedIndexChanged);
            // 
            // InclusaoFuncionarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.diasSemanaComboBox);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.senhaLabel);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.retornarButton);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.cadastrarButton);
            this.Controls.Add(this.diasSemanaLabel);
            this.Controls.Add(this.horarioTrabalhoSaidaLabel);
            this.Controls.Add(this.horarioTrabalhoSaidaTextBox);
            this.Controls.Add(this.horarioTrabalhoEntradaTextBox);
            this.Controls.Add(this.horarioTrabalhoEntradaLabel);
            this.Controls.Add(this.reTextBox);
            this.Controls.Add(this.reLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.nomeLabel);
            this.Name = "InclusaoFuncionarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Funcionario";
            this.Load += new System.EventHandler(this.InclusaoFuncionarioForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox senhaTextBox;
        private System.Windows.Forms.Label senhaLabel;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.Button retornarButton;
        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.Button cadastrarButton;
        private System.Windows.Forms.Label diasSemanaLabel;
        private System.Windows.Forms.Label horarioTrabalhoSaidaLabel;
        private System.Windows.Forms.MaskedTextBox horarioTrabalhoSaidaTextBox;
        private System.Windows.Forms.Label horarioTrabalhoEntradaLabel;
        private System.Windows.Forms.MaskedTextBox reTextBox;
        private System.Windows.Forms.Label reLabel;
        private System.Windows.Forms.MaskedTextBox nomeTextBox;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.MaskedTextBox horarioTrabalhoEntradaTextBox;
        private System.Windows.Forms.ComboBox diasSemanaComboBox;
    }
}