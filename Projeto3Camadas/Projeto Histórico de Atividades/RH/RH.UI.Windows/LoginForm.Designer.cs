namespace RH.UI.Windows
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.senhaTextBox = new System.Windows.Forms.MaskedTextBox();
            this.reTextBox = new System.Windows.Forms.MaskedTextBox();
            this.sairButton = new System.Windows.Forms.Button();
            this.retornarButton = new System.Windows.Forms.Button();
            this.entrarButton = new System.Windows.Forms.Button();
            this.senhaLabel = new System.Windows.Forms.Label();
            this.reLabel = new System.Windows.Forms.Label();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.senhaTextBox.Location = new System.Drawing.Point(394, 235);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(100, 25);
            this.senhaTextBox.TabIndex = 2;
            this.senhaTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.senhaTextBox_MaskInputRejected);
            // 
            // reTextBox
            // 
            this.reTextBox.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.reTextBox.Location = new System.Drawing.Point(394, 144);
            this.reTextBox.Mask = "999";
            this.reTextBox.Name = "reTextBox";
            this.reTextBox.Size = new System.Drawing.Size(38, 25);
            this.reTextBox.TabIndex = 1;
            this.reTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.reTextBox_MaskInputRejected);
            // 
            // sairButton
            // 
            this.sairButton.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.sairButton.Location = new System.Drawing.Point(541, 366);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(155, 39);
            this.sairButton.TabIndex = 5;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // retornarButton
            // 
            this.retornarButton.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.retornarButton.Location = new System.Drawing.Point(320, 366);
            this.retornarButton.Name = "retornarButton";
            this.retornarButton.Size = new System.Drawing.Size(158, 39);
            this.retornarButton.TabIndex = 4;
            this.retornarButton.Text = "Retornar";
            this.retornarButton.UseVisualStyleBackColor = true;
            this.retornarButton.Click += new System.EventHandler(this.retornarButton_Click);
            // 
            // entrarButton
            // 
            this.entrarButton.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.entrarButton.Location = new System.Drawing.Point(105, 366);
            this.entrarButton.Name = "entrarButton";
            this.entrarButton.Size = new System.Drawing.Size(154, 39);
            this.entrarButton.TabIndex = 3;
            this.entrarButton.Text = "Entrar";
            this.entrarButton.UseVisualStyleBackColor = true;
            this.entrarButton.Click += new System.EventHandler(this.entrarButton_Click);
            // 
            // senhaLabel
            // 
            this.senhaLabel.AutoSize = true;
            this.senhaLabel.Font = new System.Drawing.Font("Kristen ITC", 9.75F);
            this.senhaLabel.Location = new System.Drawing.Point(308, 238);
            this.senhaLabel.Name = "senhaLabel";
            this.senhaLabel.Size = new System.Drawing.Size(46, 18);
            this.senhaLabel.TabIndex = 101;
            this.senhaLabel.Text = "Senha";
            // 
            // reLabel
            // 
            this.reLabel.AutoSize = true;
            this.reLabel.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reLabel.Location = new System.Drawing.Point(308, 147);
            this.reLabel.Name = "reLabel";
            this.reLabel.Size = new System.Drawing.Size(27, 18);
            this.reLabel.TabIndex = 100;
            this.reLabel.Text = "RE";
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold);
            this.tituloLabel.Location = new System.Drawing.Point(224, 45);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(362, 25);
            this.tituloLabel.TabIndex = 99;
            this.tituloLabel.Text = "Calcula Salário Líquido";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.reTextBox);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.retornarButton);
            this.Controls.Add(this.entrarButton);
            this.Controls.Add(this.senhaLabel);
            this.Controls.Add(this.reLabel);
            this.Controls.Add(this.tituloLabel);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox senhaTextBox;
        private System.Windows.Forms.MaskedTextBox reTextBox;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.Button retornarButton;
        private System.Windows.Forms.Button entrarButton;
        private System.Windows.Forms.Label senhaLabel;
        private System.Windows.Forms.Label reLabel;
        private System.Windows.Forms.Label tituloLabel;
    }
}