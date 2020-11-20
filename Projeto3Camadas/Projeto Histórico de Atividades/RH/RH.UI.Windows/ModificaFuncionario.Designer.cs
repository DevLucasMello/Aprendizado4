namespace RH.UI.Windows
{
    partial class ModificaFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificaFuncionario));
            this.senhaTextBox = new System.Windows.Forms.MaskedTextBox();
            this.senhaLabel = new System.Windows.Forms.Label();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.sairButton = new System.Windows.Forms.Button();
            this.atividadesButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.alterarButton = new System.Windows.Forms.Button();
            this.diaSemanaLabel = new System.Windows.Forms.Label();
            this.horarioTrabalhoSaidaLabel = new System.Windows.Forms.Label();
            this.horarioTrabalhoSaidaTextBox = new System.Windows.Forms.MaskedTextBox();
            this.horarioTrabalhoEntradaTextBox = new System.Windows.Forms.MaskedTextBox();
            this.horarioTrabalhoEntradaLabel = new System.Windows.Forms.Label();
            this.reTextBox = new System.Windows.Forms.MaskedTextBox();
            this.reLabel = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.diasSemanaComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.senhaTextBox.Location = new System.Drawing.Point(150, 187);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(100, 25);
            this.senhaTextBox.TabIndex = 3;
            this.senhaTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.senhaTextBox_MaskInputRejected);
            // 
            // senhaLabel
            // 
            this.senhaLabel.AutoSize = true;
            this.senhaLabel.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.senhaLabel.Location = new System.Drawing.Point(79, 190);
            this.senhaLabel.Name = "senhaLabel";
            this.senhaLabel.Size = new System.Drawing.Size(46, 18);
            this.senhaLabel.TabIndex = 140;
            this.senhaLabel.Text = "Senha";
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold);
            this.tituloLabel.Location = new System.Drawing.Point(253, 41);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(362, 25);
            this.tituloLabel.TabIndex = 139;
            this.tituloLabel.Text = "Calcula Salário Líquido";
            // 
            // sairButton
            // 
            this.sairButton.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.sairButton.Location = new System.Drawing.Point(625, 425);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(141, 39);
            this.sairButton.TabIndex = 10;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // atividadesButton
            // 
            this.atividadesButton.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.atividadesButton.Location = new System.Drawing.Point(441, 425);
            this.atividadesButton.Name = "atividadesButton";
            this.atividadesButton.Size = new System.Drawing.Size(153, 39);
            this.atividadesButton.TabIndex = 9;
            this.atividadesButton.Text = "Atividades";
            this.atividadesButton.UseVisualStyleBackColor = true;
            this.atividadesButton.Click += new System.EventHandler(this.atividadesButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.excluirButton.Location = new System.Drawing.Point(272, 425);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(149, 39);
            this.excluirButton.TabIndex = 8;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // alterarButton
            // 
            this.alterarButton.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.alterarButton.Location = new System.Drawing.Point(86, 425);
            this.alterarButton.Name = "alterarButton";
            this.alterarButton.Size = new System.Drawing.Size(162, 39);
            this.alterarButton.TabIndex = 7;
            this.alterarButton.Text = "Alterar";
            this.alterarButton.UseVisualStyleBackColor = true;
            this.alterarButton.Click += new System.EventHandler(this.alterarButton_Click);
            // 
            // diaSemanaLabel
            // 
            this.diaSemanaLabel.AutoSize = true;
            this.diaSemanaLabel.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.diaSemanaLabel.Location = new System.Drawing.Point(72, 341);
            this.diaSemanaLabel.Name = "diaSemanaLabel";
            this.diaSemanaLabel.Size = new System.Drawing.Size(108, 18);
            this.diaSemanaLabel.TabIndex = 133;
            this.diaSemanaLabel.Text = "Dias da Semana";
            // 
            // horarioTrabalhoSaidaLabel
            // 
            this.horarioTrabalhoSaidaLabel.AutoSize = true;
            this.horarioTrabalhoSaidaLabel.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.horarioTrabalhoSaidaLabel.Location = new System.Drawing.Point(72, 290);
            this.horarioTrabalhoSaidaLabel.Name = "horarioTrabalhoSaidaLabel";
            this.horarioTrabalhoSaidaLabel.Size = new System.Drawing.Size(162, 18);
            this.horarioTrabalhoSaidaLabel.TabIndex = 126;
            this.horarioTrabalhoSaidaLabel.Text = "Horário Trabalho Saída:";
            // 
            // horarioTrabalhoSaidaTextBox
            // 
            this.horarioTrabalhoSaidaTextBox.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.horarioTrabalhoSaidaTextBox.Location = new System.Drawing.Point(284, 290);
            this.horarioTrabalhoSaidaTextBox.Mask = "99:99";
            this.horarioTrabalhoSaidaTextBox.Name = "horarioTrabalhoSaidaTextBox";
            this.horarioTrabalhoSaidaTextBox.Size = new System.Drawing.Size(57, 25);
            this.horarioTrabalhoSaidaTextBox.TabIndex = 5;
            this.horarioTrabalhoSaidaTextBox.ValidatingType = typeof(System.DateTime);
            this.horarioTrabalhoSaidaTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.horarioTrabalhoSaidaTextBox_MaskInputRejected);
            // 
            // horarioTrabalhoEntradaTextBox
            // 
            this.horarioTrabalhoEntradaTextBox.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.horarioTrabalhoEntradaTextBox.Location = new System.Drawing.Point(284, 243);
            this.horarioTrabalhoEntradaTextBox.Mask = "99:99";
            this.horarioTrabalhoEntradaTextBox.Name = "horarioTrabalhoEntradaTextBox";
            this.horarioTrabalhoEntradaTextBox.Size = new System.Drawing.Size(57, 25);
            this.horarioTrabalhoEntradaTextBox.TabIndex = 4;
            this.horarioTrabalhoEntradaTextBox.ValidatingType = typeof(System.DateTime);
            this.horarioTrabalhoEntradaTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.horarioTrabalhoEntradaTextBox_MaskInputRejected);
            // 
            // horarioTrabalhoEntradaLabel
            // 
            this.horarioTrabalhoEntradaLabel.AutoSize = true;
            this.horarioTrabalhoEntradaLabel.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.horarioTrabalhoEntradaLabel.Location = new System.Drawing.Point(72, 247);
            this.horarioTrabalhoEntradaLabel.Name = "horarioTrabalhoEntradaLabel";
            this.horarioTrabalhoEntradaLabel.Size = new System.Drawing.Size(178, 18);
            this.horarioTrabalhoEntradaLabel.TabIndex = 121;
            this.horarioTrabalhoEntradaLabel.Text = "Horário Trabalho Entrada:";
            // 
            // reTextBox
            // 
            this.reTextBox.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.reTextBox.Location = new System.Drawing.Point(150, 131);
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
            this.reLabel.Location = new System.Drawing.Point(79, 134);
            this.reLabel.Name = "reLabel";
            this.reLabel.Size = new System.Drawing.Size(31, 18);
            this.reLabel.TabIndex = 119;
            this.reLabel.Text = "RE:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.nomeTextBox.Location = new System.Drawing.Point(150, 87);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(554, 25);
            this.nomeTextBox.TabIndex = 1;
            this.nomeTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.nomeTextBox_MaskInputRejected);
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.nomeLabel.Location = new System.Drawing.Point(79, 90);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(53, 18);
            this.nomeLabel.TabIndex = 117;
            this.nomeLabel.Text = "Nome: ";
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
            this.diasSemanaComboBox.Location = new System.Drawing.Point(199, 338);
            this.diasSemanaComboBox.Name = "diasSemanaComboBox";
            this.diasSemanaComboBox.Size = new System.Drawing.Size(62, 21);
            this.diasSemanaComboBox.TabIndex = 6;
            this.diasSemanaComboBox.SelectedIndexChanged += new System.EventHandler(this.diasSemanaComboBox_SelectedIndexChanged);
            // 
            // ModificaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(837, 490);
            this.Controls.Add(this.diasSemanaComboBox);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.senhaLabel);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.atividadesButton);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.alterarButton);
            this.Controls.Add(this.diaSemanaLabel);
            this.Controls.Add(this.horarioTrabalhoSaidaLabel);
            this.Controls.Add(this.horarioTrabalhoSaidaTextBox);
            this.Controls.Add(this.horarioTrabalhoEntradaTextBox);
            this.Controls.Add(this.horarioTrabalhoEntradaLabel);
            this.Controls.Add(this.reTextBox);
            this.Controls.Add(this.reLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.nomeLabel);
            this.Name = "ModificaFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifica Cliente";
            this.Load += new System.EventHandler(this.ModificaFuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox senhaTextBox;
        private System.Windows.Forms.Label senhaLabel;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.Button atividadesButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button alterarButton;
        private System.Windows.Forms.Label diaSemanaLabel;
        private System.Windows.Forms.Label horarioTrabalhoSaidaLabel;
        private System.Windows.Forms.MaskedTextBox horarioTrabalhoSaidaTextBox;
        private System.Windows.Forms.MaskedTextBox horarioTrabalhoEntradaTextBox;
        private System.Windows.Forms.Label horarioTrabalhoEntradaLabel;
        private System.Windows.Forms.MaskedTextBox reTextBox;
        private System.Windows.Forms.Label reLabel;
        private System.Windows.Forms.MaskedTextBox nomeTextBox;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.ComboBox diasSemanaComboBox;
    }
}