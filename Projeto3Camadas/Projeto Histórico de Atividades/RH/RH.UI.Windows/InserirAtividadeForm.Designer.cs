namespace RH.UI.Windows
{
    partial class InserirAtividadeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InserirAtividadeForm));
            this.limparButton = new System.Windows.Forms.Button();
            this.atividadeTextBox = new System.Windows.Forms.TextBox();
            this.atividadeLabel = new System.Windows.Forms.Label();
            this.sairButton = new System.Windows.Forms.Button();
            this.consultarButton = new System.Windows.Forms.Button();
            this.inserirButton = new System.Windows.Forms.Button();
            this.dataInicioTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dataInicioLabel = new System.Windows.Forms.Label();
            this.reTextBox = new System.Windows.Forms.MaskedTextBox();
            this.reLabel = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.codigoTextBox = new System.Windows.Forms.MaskedTextBox();
            this.horaIniciolabel = new System.Windows.Forms.Label();
            this.horaInicioTextBox = new System.Windows.Forms.MaskedTextBox();
            this.horaFimlabel = new System.Windows.Forms.Label();
            this.horaFimTextBox = new System.Windows.Forms.MaskedTextBox();
            this.semanaLabel = new System.Windows.Forms.Label();
            this.semanaComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // limparButton
            // 
            this.limparButton.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.limparButton.Location = new System.Drawing.Point(270, 462);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(130, 39);
            this.limparButton.TabIndex = 10;
            this.limparButton.Text = "Limpar";
            this.limparButton.UseVisualStyleBackColor = true;
            this.limparButton.Click += new System.EventHandler(this.limparButton_Click);
            // 
            // atividadeTextBox
            // 
            this.atividadeTextBox.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.atividadeTextBox.Location = new System.Drawing.Point(174, 283);
            this.atividadeTextBox.Multiline = true;
            this.atividadeTextBox.Name = "atividadeTextBox";
            this.atividadeTextBox.Size = new System.Drawing.Size(577, 143);
            this.atividadeTextBox.TabIndex = 8;
            this.atividadeTextBox.TextChanged += new System.EventHandler(this.atividadeTextBox_TextChanged);
            // 
            // atividadeLabel
            // 
            this.atividadeLabel.AutoSize = true;
            this.atividadeLabel.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.atividadeLabel.Location = new System.Drawing.Point(72, 335);
            this.atividadeLabel.Name = "atividadeLabel";
            this.atividadeLabel.Size = new System.Drawing.Size(71, 18);
            this.atividadeLabel.TabIndex = 83;
            this.atividadeLabel.Text = "Atividade";
            // 
            // sairButton
            // 
            this.sairButton.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.sairButton.Location = new System.Drawing.Point(601, 462);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(130, 39);
            this.sairButton.TabIndex = 12;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // consultarButton
            // 
            this.consultarButton.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.consultarButton.Location = new System.Drawing.Point(433, 462);
            this.consultarButton.Name = "consultarButton";
            this.consultarButton.Size = new System.Drawing.Size(138, 39);
            this.consultarButton.TabIndex = 11;
            this.consultarButton.Text = "Consultar";
            this.consultarButton.UseVisualStyleBackColor = true;
            this.consultarButton.Click += new System.EventHandler(this.consultarButton_Click);
            // 
            // inserirButton
            // 
            this.inserirButton.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.inserirButton.Location = new System.Drawing.Point(113, 462);
            this.inserirButton.Name = "inserirButton";
            this.inserirButton.Size = new System.Drawing.Size(130, 39);
            this.inserirButton.TabIndex = 9;
            this.inserirButton.Text = "Inserir";
            this.inserirButton.UseVisualStyleBackColor = true;
            this.inserirButton.Click += new System.EventHandler(this.inserirButton_Click);
            // 
            // dataInicioTextBox
            // 
            this.dataInicioTextBox.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.dataInicioTextBox.Location = new System.Drawing.Point(200, 210);
            this.dataInicioTextBox.Mask = "99/99/9999";
            this.dataInicioTextBox.Name = "dataInicioTextBox";
            this.dataInicioTextBox.Size = new System.Drawing.Size(92, 25);
            this.dataInicioTextBox.TabIndex = 4;
            this.dataInicioTextBox.ValidatingType = typeof(System.DateTime);
            this.dataInicioTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.dataInicioTextBox_MaskInputRejected);
            // 
            // dataInicioLabel
            // 
            this.dataInicioLabel.AutoSize = true;
            this.dataInicioLabel.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.dataInicioLabel.Location = new System.Drawing.Point(72, 213);
            this.dataInicioLabel.Name = "dataInicioLabel";
            this.dataInicioLabel.Size = new System.Drawing.Size(111, 18);
            this.dataInicioLabel.TabIndex = 76;
            this.dataInicioLabel.Text = "Data Atividade:";
            // 
            // reTextBox
            // 
            this.reTextBox.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.reTextBox.Location = new System.Drawing.Point(182, 158);
            this.reTextBox.Mask = "999";
            this.reTextBox.Name = "reTextBox";
            this.reTextBox.Size = new System.Drawing.Size(40, 25);
            this.reTextBox.TabIndex = 3;
            this.reTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.reTextBox_MaskInputRejected);
            // 
            // reLabel
            // 
            this.reLabel.AutoSize = true;
            this.reLabel.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.reLabel.Location = new System.Drawing.Point(72, 161);
            this.reLabel.Name = "reLabel";
            this.reLabel.Size = new System.Drawing.Size(31, 18);
            this.reLabel.TabIndex = 74;
            this.reLabel.Text = "RE:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.nomeTextBox.Location = new System.Drawing.Point(182, 108);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(568, 25);
            this.nomeTextBox.TabIndex = 2;
            this.nomeTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.nomeTextBox_MaskInputRejected);
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.nomeLabel.Location = new System.Drawing.Point(72, 111);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(53, 18);
            this.nomeLabel.TabIndex = 72;
            this.nomeLabel.Text = "Nome: ";
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold);
            this.tituloLabel.Location = new System.Drawing.Point(230, 9);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(362, 25);
            this.tituloLabel.TabIndex = 71;
            this.tituloLabel.Text = "Calcula Salário Líquido";
            // 
            // codigoLabel
            // 
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.codigoLabel.Location = new System.Drawing.Point(72, 62);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(58, 18);
            this.codigoLabel.TabIndex = 87;
            this.codigoLabel.Text = "Código:";
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.codigoTextBox.Location = new System.Drawing.Point(155, 59);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(108, 25);
            this.codigoTextBox.TabIndex = 1;
            this.codigoTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.codigoTextBox_MaskInputRejected);
            // 
            // horaIniciolabel
            // 
            this.horaIniciolabel.AutoSize = true;
            this.horaIniciolabel.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.horaIniciolabel.Location = new System.Drawing.Point(347, 177);
            this.horaIniciolabel.Name = "horaIniciolabel";
            this.horaIniciolabel.Size = new System.Drawing.Size(50, 18);
            this.horaIniciolabel.TabIndex = 89;
            this.horaIniciolabel.Text = "Início:";
            // 
            // horaInicioTextBox
            // 
            this.horaInicioTextBox.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.horaInicioTextBox.Location = new System.Drawing.Point(415, 174);
            this.horaInicioTextBox.Mask = "99:99";
            this.horaInicioTextBox.Name = "horaInicioTextBox";
            this.horaInicioTextBox.Size = new System.Drawing.Size(64, 25);
            this.horaInicioTextBox.TabIndex = 5;
            this.horaInicioTextBox.ValidatingType = typeof(System.DateTime);
            this.horaInicioTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.horaInicioTextBox_MaskInputRejected);
            // 
            // horaFimlabel
            // 
            this.horaFimlabel.AutoSize = true;
            this.horaFimlabel.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.horaFimlabel.Location = new System.Drawing.Point(347, 225);
            this.horaFimlabel.Name = "horaFimlabel";
            this.horaFimlabel.Size = new System.Drawing.Size(34, 18);
            this.horaFimlabel.TabIndex = 91;
            this.horaFimlabel.Text = "Fim:";
            // 
            // horaFimTextBox
            // 
            this.horaFimTextBox.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.horaFimTextBox.Location = new System.Drawing.Point(415, 222);
            this.horaFimTextBox.Mask = "99:99";
            this.horaFimTextBox.Name = "horaFimTextBox";
            this.horaFimTextBox.Size = new System.Drawing.Size(64, 25);
            this.horaFimTextBox.TabIndex = 6;
            this.horaFimTextBox.ValidatingType = typeof(System.DateTime);
            this.horaFimTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.horaFimTextBox_MaskInputRejected);
            // 
            // semanaLabel
            // 
            this.semanaLabel.AutoSize = true;
            this.semanaLabel.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.semanaLabel.Location = new System.Drawing.Point(502, 198);
            this.semanaLabel.Name = "semanaLabel";
            this.semanaLabel.Size = new System.Drawing.Size(105, 18);
            this.semanaLabel.TabIndex = 93;
            this.semanaLabel.Text = "Fim de Semana:";
            // 
            // semanaComboBox
            // 
            this.semanaComboBox.FormattingEnabled = true;
            this.semanaComboBox.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.semanaComboBox.Location = new System.Drawing.Point(613, 195);
            this.semanaComboBox.Name = "semanaComboBox";
            this.semanaComboBox.Size = new System.Drawing.Size(51, 21);
            this.semanaComboBox.TabIndex = 7;
            this.semanaComboBox.SelectedIndexChanged += new System.EventHandler(this.semanaComboBox_SelectedIndexChanged);
            // 
            // InserirAtividadeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(849, 513);
            this.Controls.Add(this.semanaComboBox);
            this.Controls.Add(this.semanaLabel);
            this.Controls.Add(this.horaFimTextBox);
            this.Controls.Add(this.horaFimlabel);
            this.Controls.Add(this.horaInicioTextBox);
            this.Controls.Add(this.horaIniciolabel);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(this.codigoLabel);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.atividadeTextBox);
            this.Controls.Add(this.atividadeLabel);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.consultarButton);
            this.Controls.Add(this.inserirButton);
            this.Controls.Add(this.dataInicioTextBox);
            this.Controls.Add(this.dataInicioLabel);
            this.Controls.Add(this.reTextBox);
            this.Controls.Add(this.reLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.tituloLabel);
            this.Name = "InserirAtividadeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Atividade";
            this.Load += new System.EventHandler(this.InserirAtividadeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.TextBox atividadeTextBox;
        private System.Windows.Forms.Label atividadeLabel;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.Button consultarButton;
        private System.Windows.Forms.Button inserirButton;
        private System.Windows.Forms.MaskedTextBox dataInicioTextBox;
        private System.Windows.Forms.Label dataInicioLabel;
        private System.Windows.Forms.MaskedTextBox reTextBox;
        private System.Windows.Forms.Label reLabel;
        private System.Windows.Forms.MaskedTextBox nomeTextBox;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.MaskedTextBox codigoTextBox;
        private System.Windows.Forms.Label horaIniciolabel;
        private System.Windows.Forms.MaskedTextBox horaInicioTextBox;
        private System.Windows.Forms.Label horaFimlabel;
        private System.Windows.Forms.MaskedTextBox horaFimTextBox;
        private System.Windows.Forms.Label semanaLabel;
        private System.Windows.Forms.ComboBox semanaComboBox;
    }
}