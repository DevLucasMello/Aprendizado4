namespace RH.UI.Windows
{
    partial class ConsultaPeriodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaPeriodo));
            this.imprimirButton = new System.Windows.Forms.Button();
            this.sairButton = new System.Windows.Forms.Button();
            this.retornarButton = new System.Windows.Forms.Button();
            this.consultarButton = new System.Windows.Forms.Button();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.anoComboBox = new System.Windows.Forms.ComboBox();
            this.anoLabel = new System.Windows.Forms.Label();
            this.mesComboBox = new System.Windows.Forms.ComboBox();
            this.mesLabel = new System.Windows.Forms.Label();
            this.pontoPanel = new System.Windows.Forms.Panel();
            this.pontoDataGridView = new System.Windows.Forms.DataGridView();
            this.periodoLabel = new System.Windows.Forms.Label();
            this.periodoComboBox = new System.Windows.Forms.ComboBox();
            this.pontoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pontoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // imprimirButton
            // 
            this.imprimirButton.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.imprimirButton.Location = new System.Drawing.Point(204, 518);
            this.imprimirButton.Name = "imprimirButton";
            this.imprimirButton.Size = new System.Drawing.Size(130, 39);
            this.imprimirButton.TabIndex = 8;
            this.imprimirButton.Text = "Imprimir";
            this.imprimirButton.UseVisualStyleBackColor = true;
            this.imprimirButton.Click += new System.EventHandler(this.imprimirButton_Click);
            // 
            // sairButton
            // 
            this.sairButton.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.sairButton.Location = new System.Drawing.Point(499, 518);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(130, 39);
            this.sairButton.TabIndex = 10;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // retornarButton
            // 
            this.retornarButton.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.retornarButton.Location = new System.Drawing.Point(349, 518);
            this.retornarButton.Name = "retornarButton";
            this.retornarButton.Size = new System.Drawing.Size(130, 39);
            this.retornarButton.TabIndex = 9;
            this.retornarButton.Text = "Retornar";
            this.retornarButton.UseVisualStyleBackColor = true;
            this.retornarButton.Click += new System.EventHandler(this.retornarButton_Click);
            // 
            // consultarButton
            // 
            this.consultarButton.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.consultarButton.Location = new System.Drawing.Point(47, 518);
            this.consultarButton.Name = "consultarButton";
            this.consultarButton.Size = new System.Drawing.Size(142, 39);
            this.consultarButton.TabIndex = 7;
            this.consultarButton.Text = "Consultar";
            this.consultarButton.UseVisualStyleBackColor = true;
            this.consultarButton.Click += new System.EventHandler(this.consultarButton_Click);
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold);
            this.tituloLabel.Location = new System.Drawing.Point(181, 9);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(362, 25);
            this.tituloLabel.TabIndex = 214;
            this.tituloLabel.Text = "Calcula Salário Líquido";
            // 
            // anoComboBox
            // 
            this.anoComboBox.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.anoComboBox.FormattingEnabled = true;
            this.anoComboBox.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.anoComboBox.Location = new System.Drawing.Point(430, 55);
            this.anoComboBox.Name = "anoComboBox";
            this.anoComboBox.Size = new System.Drawing.Size(121, 26);
            this.anoComboBox.TabIndex = 2;
            this.anoComboBox.SelectedIndexChanged += new System.EventHandler(this.anoComboBox_SelectedIndexChanged);
            // 
            // anoLabel
            // 
            this.anoLabel.AutoSize = true;
            this.anoLabel.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.anoLabel.Location = new System.Drawing.Point(375, 59);
            this.anoLabel.Name = "anoLabel";
            this.anoLabel.Size = new System.Drawing.Size(40, 18);
            this.anoLabel.TabIndex = 363;
            this.anoLabel.Text = "Ano:";
            // 
            // mesComboBox
            // 
            this.mesComboBox.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.mesComboBox.FormattingEnabled = true;
            this.mesComboBox.Items.AddRange(new object[] {
            "01 - Janeiro",
            "02 - Fevereiro",
            "03 - Março",
            "04 - Abril",
            "05 - Maio",
            "06 - Junho",
            "07 - Julho",
            "08 - Agosto",
            "09 - Setembro",
            "10 - Outubro",
            "11 - Novembro",
            "12 - Dezembro"});
            this.mesComboBox.Location = new System.Drawing.Point(226, 55);
            this.mesComboBox.Name = "mesComboBox";
            this.mesComboBox.Size = new System.Drawing.Size(121, 26);
            this.mesComboBox.TabIndex = 1;
            this.mesComboBox.SelectedIndexChanged += new System.EventHandler(this.mesComboBox_SelectedIndexChanged);
            // 
            // mesLabel
            // 
            this.mesLabel.AutoSize = true;
            this.mesLabel.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.mesLabel.Location = new System.Drawing.Point(165, 58);
            this.mesLabel.Name = "mesLabel";
            this.mesLabel.Size = new System.Drawing.Size(39, 18);
            this.mesLabel.TabIndex = 361;
            this.mesLabel.Text = "Mês:";
            // 
            // pontoPanel
            // 
            this.pontoPanel.Controls.Add(this.pontoDataGridView);
            this.pontoPanel.Location = new System.Drawing.Point(79, 161);
            this.pontoPanel.Name = "pontoPanel";
            this.pontoPanel.Size = new System.Drawing.Size(541, 302);
            this.pontoPanel.TabIndex = 6;
            // 
            // pontoDataGridView
            // 
            this.pontoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pontoDataGridView.Location = new System.Drawing.Point(47, 40);
            this.pontoDataGridView.Name = "pontoDataGridView";
            this.pontoDataGridView.Size = new System.Drawing.Size(452, 230);
            this.pontoDataGridView.TabIndex = 4;
            // 
            // periodoLabel
            // 
            this.periodoLabel.AutoSize = true;
            this.periodoLabel.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.periodoLabel.Location = new System.Drawing.Point(252, 115);
            this.periodoLabel.Name = "periodoLabel";
            this.periodoLabel.Size = new System.Drawing.Size(63, 18);
            this.periodoLabel.TabIndex = 366;
            this.periodoLabel.Text = "Período:";
            // 
            // periodoComboBox
            // 
            this.periodoComboBox.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.periodoComboBox.FormattingEnabled = true;
            this.periodoComboBox.Items.AddRange(new object[] {
            "01 - Entrada",
            "02 - Saida"});
            this.periodoComboBox.Location = new System.Drawing.Point(321, 112);
            this.periodoComboBox.Name = "periodoComboBox";
            this.periodoComboBox.Size = new System.Drawing.Size(121, 26);
            this.periodoComboBox.TabIndex = 3;
            // 
            // ConsultaPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(675, 584);
            this.Controls.Add(this.periodoComboBox);
            this.Controls.Add(this.periodoLabel);
            this.Controls.Add(this.pontoPanel);
            this.Controls.Add(this.anoComboBox);
            this.Controls.Add(this.anoLabel);
            this.Controls.Add(this.mesComboBox);
            this.Controls.Add(this.mesLabel);
            this.Controls.Add(this.imprimirButton);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.retornarButton);
            this.Controls.Add(this.consultarButton);
            this.Controls.Add(this.tituloLabel);
            this.Name = "ConsultaPeriodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaPeriodo";
            this.Load += new System.EventHandler(this.ConsultaPeriodo_Load);
            this.pontoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pontoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button imprimirButton;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.Button retornarButton;
        private System.Windows.Forms.Button consultarButton;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.ComboBox anoComboBox;
        private System.Windows.Forms.Label anoLabel;
        private System.Windows.Forms.ComboBox mesComboBox;
        private System.Windows.Forms.Label mesLabel;
        private System.Windows.Forms.Panel pontoPanel;
        private System.Windows.Forms.DataGridView pontoDataGridView;
        private System.Windows.Forms.Label periodoLabel;
        private System.Windows.Forms.ComboBox periodoComboBox;
    }
}