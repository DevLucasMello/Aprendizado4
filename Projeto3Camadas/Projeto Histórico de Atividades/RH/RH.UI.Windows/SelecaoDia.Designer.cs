namespace RH.UI.Windows
{
    partial class SelecaoDia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelecaoDia));
            this.diaTextBox = new System.Windows.Forms.MaskedTextBox();
            this.diaLabel = new System.Windows.Forms.Label();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.consultarButton = new System.Windows.Forms.Button();
            this.limparButton = new System.Windows.Forms.Button();
            this.retornarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // diaTextBox
            // 
            this.diaTextBox.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.diaTextBox.Location = new System.Drawing.Point(365, 104);
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
            this.diaLabel.Location = new System.Drawing.Point(312, 107);
            this.diaLabel.Name = "diaLabel";
            this.diaLabel.Size = new System.Drawing.Size(35, 18);
            this.diaLabel.TabIndex = 77;
            this.diaLabel.Text = "Dia:";
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold);
            this.tituloLabel.Location = new System.Drawing.Point(217, 27);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(362, 25);
            this.tituloLabel.TabIndex = 76;
            this.tituloLabel.Text = "Calcula Salário Líquido";
            // 
            // consultarButton
            // 
            this.consultarButton.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.consultarButton.Location = new System.Drawing.Point(330, 193);
            this.consultarButton.Name = "consultarButton";
            this.consultarButton.Size = new System.Drawing.Size(147, 39);
            this.consultarButton.TabIndex = 2;
            this.consultarButton.Text = "Consultar";
            this.consultarButton.UseVisualStyleBackColor = true;
            this.consultarButton.Click += new System.EventHandler(this.consultarButton_Click);
            // 
            // limparButton
            // 
            this.limparButton.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.limparButton.Location = new System.Drawing.Point(330, 268);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(147, 39);
            this.limparButton.TabIndex = 3;
            this.limparButton.Text = "Limpar";
            this.limparButton.UseVisualStyleBackColor = true;
            this.limparButton.Click += new System.EventHandler(this.limparButton_Click);
            // 
            // retornarButton
            // 
            this.retornarButton.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.retornarButton.Location = new System.Drawing.Point(330, 353);
            this.retornarButton.Name = "retornarButton";
            this.retornarButton.Size = new System.Drawing.Size(140, 39);
            this.retornarButton.TabIndex = 4;
            this.retornarButton.Text = "Retornar";
            this.retornarButton.UseVisualStyleBackColor = true;
            this.retornarButton.Click += new System.EventHandler(this.retornarButton_Click);
            // 
            // SelecaoDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.retornarButton);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.consultarButton);
            this.Controls.Add(this.diaTextBox);
            this.Controls.Add(this.diaLabel);
            this.Controls.Add(this.tituloLabel);
            this.Name = "SelecaoDia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleção do Dia";
            this.Load += new System.EventHandler(this.SelecaoDia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox diaTextBox;
        private System.Windows.Forms.Label diaLabel;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Button consultarButton;
        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.Button retornarButton;
    }
}