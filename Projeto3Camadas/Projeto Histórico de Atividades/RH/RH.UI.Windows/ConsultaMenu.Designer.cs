namespace RH.UI.Windows
{
    partial class ConsultaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaMenu));
            this.tituloLabel = new System.Windows.Forms.Label();
            this.retornarButton = new System.Windows.Forms.Button();
            this.consultarPeriodoButton = new System.Windows.Forms.Button();
            this.consultarDiaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold);
            this.tituloLabel.Location = new System.Drawing.Point(216, 30);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(362, 25);
            this.tituloLabel.TabIndex = 74;
            this.tituloLabel.Text = "Calcula Salário Líquido";
            // 
            // retornarButton
            // 
            this.retornarButton.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.retornarButton.Location = new System.Drawing.Point(252, 307);
            this.retornarButton.Name = "retornarButton";
            this.retornarButton.Size = new System.Drawing.Size(281, 39);
            this.retornarButton.TabIndex = 3;
            this.retornarButton.Text = "Retornar";
            this.retornarButton.UseVisualStyleBackColor = true;
            this.retornarButton.Click += new System.EventHandler(this.retornarButton_Click);
            // 
            // consultarPeriodoButton
            // 
            this.consultarPeriodoButton.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.consultarPeriodoButton.Location = new System.Drawing.Point(252, 231);
            this.consultarPeriodoButton.Name = "consultarPeriodoButton";
            this.consultarPeriodoButton.Size = new System.Drawing.Size(281, 39);
            this.consultarPeriodoButton.TabIndex = 2;
            this.consultarPeriodoButton.Text = "Consultar Período";
            this.consultarPeriodoButton.UseVisualStyleBackColor = true;
            this.consultarPeriodoButton.Click += new System.EventHandler(this.consultarPeriodoButton_Click);
            // 
            // consultarDiaButton
            // 
            this.consultarDiaButton.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.consultarDiaButton.Location = new System.Drawing.Point(252, 157);
            this.consultarDiaButton.Name = "consultarDiaButton";
            this.consultarDiaButton.Size = new System.Drawing.Size(281, 39);
            this.consultarDiaButton.TabIndex = 1;
            this.consultarDiaButton.Text = "Consultar Dia";
            this.consultarDiaButton.UseVisualStyleBackColor = true;
            this.consultarDiaButton.Click += new System.EventHandler(this.consultarDiaButton_Click);
            // 
            // ConsultaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.retornarButton);
            this.Controls.Add(this.consultarPeriodoButton);
            this.Controls.Add(this.consultarDiaButton);
            this.Name = "ConsultaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Menu";
            this.Load += new System.EventHandler(this.ConsultaMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Button retornarButton;
        private System.Windows.Forms.Button consultarPeriodoButton;
        private System.Windows.Forms.Button consultarDiaButton;
    }
}