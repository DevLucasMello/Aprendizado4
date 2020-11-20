namespace RH.UI.Windows
{
    partial class ConsultaDia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaDia));
            this.atividadeTextBox = new System.Windows.Forms.TextBox();
            this.alterarButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.atividadeLabel = new System.Windows.Forms.Label();
            this.horaSaidaTextBox = new System.Windows.Forms.MaskedTextBox();
            this.horaSaidaLabel = new System.Windows.Forms.Label();
            this.horaEntradaTextBox = new System.Windows.Forms.MaskedTextBox();
            this.horaEntradaLabel = new System.Windows.Forms.Label();
            this.sairButton = new System.Windows.Forms.Button();
            this.retornarButton = new System.Windows.Forms.Button();
            this.consultarButton = new System.Windows.Forms.Button();
            this.diaTextBox = new System.Windows.Forms.MaskedTextBox();
            this.diaLabel = new System.Windows.Forms.Label();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.codAtivlabel = new System.Windows.Forms.Label();
            this.codAtivcomboBox = new System.Windows.Forms.ComboBox();
            this.semanaComboBox = new System.Windows.Forms.ComboBox();
            this.semanaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // atividadeTextBox
            // 
            this.atividadeTextBox.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.atividadeTextBox.Location = new System.Drawing.Point(199, 265);
            this.atividadeTextBox.Multiline = true;
            this.atividadeTextBox.Name = "atividadeTextBox";
            this.atividadeTextBox.Size = new System.Drawing.Size(577, 143);
            this.atividadeTextBox.TabIndex = 6;
            this.atividadeTextBox.TextChanged += new System.EventHandler(this.atividadeTextBox_TextChanged);
            // 
            // alterarButton
            // 
            this.alterarButton.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.alterarButton.Location = new System.Drawing.Point(238, 466);
            this.alterarButton.Name = "alterarButton";
            this.alterarButton.Size = new System.Drawing.Size(130, 39);
            this.alterarButton.TabIndex = 8;
            this.alterarButton.Text = "Alterar";
            this.alterarButton.UseVisualStyleBackColor = true;
            this.alterarButton.Click += new System.EventHandler(this.alterarButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.excluirButton.Location = new System.Drawing.Point(374, 467);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(130, 39);
            this.excluirButton.TabIndex = 9;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // atividadeLabel
            // 
            this.atividadeLabel.AutoSize = true;
            this.atividadeLabel.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.atividadeLabel.Location = new System.Drawing.Point(88, 309);
            this.atividadeLabel.Name = "atividadeLabel";
            this.atividadeLabel.Size = new System.Drawing.Size(71, 18);
            this.atividadeLabel.TabIndex = 96;
            this.atividadeLabel.Text = "Atividade";
            // 
            // horaSaidaTextBox
            // 
            this.horaSaidaTextBox.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.horaSaidaTextBox.Location = new System.Drawing.Point(523, 200);
            this.horaSaidaTextBox.Mask = "99:99";
            this.horaSaidaTextBox.Name = "horaSaidaTextBox";
            this.horaSaidaTextBox.Size = new System.Drawing.Size(60, 25);
            this.horaSaidaTextBox.TabIndex = 5;
            this.horaSaidaTextBox.ValidatingType = typeof(System.DateTime);
            this.horaSaidaTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.horaSaidaTextBox_MaskInputRejected);
            // 
            // horaSaidaLabel
            // 
            this.horaSaidaLabel.AutoSize = true;
            this.horaSaidaLabel.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.horaSaidaLabel.Location = new System.Drawing.Point(423, 203);
            this.horaSaidaLabel.Name = "horaSaidaLabel";
            this.horaSaidaLabel.Size = new System.Drawing.Size(79, 18);
            this.horaSaidaLabel.TabIndex = 94;
            this.horaSaidaLabel.Text = "Hora Saída";
            // 
            // horaEntradaTextBox
            // 
            this.horaEntradaTextBox.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.horaEntradaTextBox.Location = new System.Drawing.Point(325, 196);
            this.horaEntradaTextBox.Mask = "99:99";
            this.horaEntradaTextBox.Name = "horaEntradaTextBox";
            this.horaEntradaTextBox.Size = new System.Drawing.Size(55, 25);
            this.horaEntradaTextBox.TabIndex = 4;
            this.horaEntradaTextBox.ValidatingType = typeof(System.DateTime);
            this.horaEntradaTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.horaEntradaTextBox_MaskInputRejected);
            // 
            // horaEntradaLabel
            // 
            this.horaEntradaLabel.AutoSize = true;
            this.horaEntradaLabel.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.horaEntradaLabel.Location = new System.Drawing.Point(208, 199);
            this.horaEntradaLabel.Name = "horaEntradaLabel";
            this.horaEntradaLabel.Size = new System.Drawing.Size(99, 18);
            this.horaEntradaLabel.TabIndex = 92;
            this.horaEntradaLabel.Text = "Hora Entrada:";
            // 
            // sairButton
            // 
            this.sairButton.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.sairButton.Location = new System.Drawing.Point(658, 467);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(130, 39);
            this.sairButton.TabIndex = 11;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // retornarButton
            // 
            this.retornarButton.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.retornarButton.Location = new System.Drawing.Point(512, 468);
            this.retornarButton.Name = "retornarButton";
            this.retornarButton.Size = new System.Drawing.Size(140, 39);
            this.retornarButton.TabIndex = 10;
            this.retornarButton.Text = "Retornar";
            this.retornarButton.UseVisualStyleBackColor = true;
            this.retornarButton.Click += new System.EventHandler(this.retornarButton_Click);
            // 
            // consultarButton
            // 
            this.consultarButton.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.consultarButton.Location = new System.Drawing.Point(85, 466);
            this.consultarButton.Name = "consultarButton";
            this.consultarButton.Size = new System.Drawing.Size(147, 39);
            this.consultarButton.TabIndex = 7;
            this.consultarButton.Text = "Consultar";
            this.consultarButton.UseVisualStyleBackColor = true;
            this.consultarButton.Click += new System.EventHandler(this.consultarButton_Click);
            // 
            // diaTextBox
            // 
            this.diaTextBox.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.diaTextBox.Location = new System.Drawing.Point(261, 79);
            this.diaTextBox.Mask = "99/99/9999";
            this.diaTextBox.Name = "diaTextBox";
            this.diaTextBox.Size = new System.Drawing.Size(87, 25);
            this.diaTextBox.TabIndex = 1;
            this.diaTextBox.ValidatingType = typeof(System.DateTime);
            this.diaTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.diaTextBox_MaskInputRejected);
            // 
            // diaLabel
            // 
            this.diaLabel.AutoSize = true;
            this.diaLabel.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.diaLabel.Location = new System.Drawing.Point(208, 82);
            this.diaLabel.Name = "diaLabel";
            this.diaLabel.Size = new System.Drawing.Size(35, 18);
            this.diaLabel.TabIndex = 74;
            this.diaLabel.Text = "Dia:";
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold);
            this.tituloLabel.Location = new System.Drawing.Point(249, 9);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(362, 25);
            this.tituloLabel.TabIndex = 73;
            this.tituloLabel.Text = "Calcula Salário Líquido";
            // 
            // codAtivlabel
            // 
            this.codAtivlabel.AutoSize = true;
            this.codAtivlabel.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.codAtivlabel.Location = new System.Drawing.Point(441, 79);
            this.codAtivlabel.Name = "codAtivlabel";
            this.codAtivlabel.Size = new System.Drawing.Size(144, 18);
            this.codAtivlabel.TabIndex = 100;
            this.codAtivlabel.Text = "Código da Atividade:";
            // 
            // codAtivcomboBox
            // 
            this.codAtivcomboBox.FormattingEnabled = true;
            this.codAtivcomboBox.Location = new System.Drawing.Point(600, 76);
            this.codAtivcomboBox.Name = "codAtivcomboBox";
            this.codAtivcomboBox.Size = new System.Drawing.Size(121, 21);
            this.codAtivcomboBox.TabIndex = 2;
            // 
            // semanaComboBox
            // 
            this.semanaComboBox.FormattingEnabled = true;
            this.semanaComboBox.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.semanaComboBox.Location = new System.Drawing.Point(319, 131);
            this.semanaComboBox.Name = "semanaComboBox";
            this.semanaComboBox.Size = new System.Drawing.Size(51, 21);
            this.semanaComboBox.TabIndex = 3;
            // 
            // semanaLabel
            // 
            this.semanaLabel.AutoSize = true;
            this.semanaLabel.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.semanaLabel.Location = new System.Drawing.Point(208, 134);
            this.semanaLabel.Name = "semanaLabel";
            this.semanaLabel.Size = new System.Drawing.Size(105, 18);
            this.semanaLabel.TabIndex = 102;
            this.semanaLabel.Text = "Fim de Semana:";
            // 
            // ConsultaDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(887, 535);
            this.Controls.Add(this.semanaComboBox);
            this.Controls.Add(this.semanaLabel);
            this.Controls.Add(this.codAtivcomboBox);
            this.Controls.Add(this.codAtivlabel);
            this.Controls.Add(this.atividadeTextBox);
            this.Controls.Add(this.alterarButton);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.atividadeLabel);
            this.Controls.Add(this.horaSaidaTextBox);
            this.Controls.Add(this.horaSaidaLabel);
            this.Controls.Add(this.horaEntradaTextBox);
            this.Controls.Add(this.horaEntradaLabel);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.retornarButton);
            this.Controls.Add(this.consultarButton);
            this.Controls.Add(this.diaTextBox);
            this.Controls.Add(this.diaLabel);
            this.Controls.Add(this.tituloLabel);
            this.Name = "ConsultaDia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Dia";
            this.Load += new System.EventHandler(this.ConsultaDia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox atividadeTextBox;
        private System.Windows.Forms.Button alterarButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Label atividadeLabel;
        private System.Windows.Forms.MaskedTextBox horaSaidaTextBox;
        private System.Windows.Forms.Label horaSaidaLabel;
        private System.Windows.Forms.MaskedTextBox horaEntradaTextBox;
        private System.Windows.Forms.Label horaEntradaLabel;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.Button retornarButton;
        private System.Windows.Forms.Button consultarButton;
        private System.Windows.Forms.MaskedTextBox diaTextBox;
        private System.Windows.Forms.Label diaLabel;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label codAtivlabel;
        private System.Windows.Forms.ComboBox codAtivcomboBox;
        private System.Windows.Forms.ComboBox semanaComboBox;
        private System.Windows.Forms.Label semanaLabel;
    }
}