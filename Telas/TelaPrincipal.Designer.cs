
using System.Drawing;
using System.Windows.Forms;

namespace Adventure
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.Logo = new System.Windows.Forms.Label();
            this.BtNovoJogo = new System.Windows.Forms.Button();
            this.BtContinuar = new System.Windows.Forms.Button();
            this.BtSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(246, 57);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(508, 100);
            this.Logo.TabIndex = 0;
            this.Logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtNovoJogo
            // 
            this.BtNovoJogo.BackColor = System.Drawing.Color.Black;
            this.BtNovoJogo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtNovoJogo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtNovoJogo.Location = new System.Drawing.Point(395, 261);
            this.BtNovoJogo.Name = "BtNovoJogo";
            this.BtNovoJogo.Size = new System.Drawing.Size(230, 60);
            this.BtNovoJogo.TabIndex = 1;
            this.BtNovoJogo.Text = "Novo Jogo";
            this.BtNovoJogo.UseVisualStyleBackColor = false;
            this.BtNovoJogo.Click += new System.EventHandler(this.BtNovoJogo_Click);
            // 
            // BtContinuar
            // 
            this.BtContinuar.BackColor = System.Drawing.Color.Black;
            this.BtContinuar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtContinuar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtContinuar.Location = new System.Drawing.Point(395, 410);
            this.BtContinuar.Name = "BtContinuar";
            this.BtContinuar.Size = new System.Drawing.Size(230, 60);
            this.BtContinuar.TabIndex = 1;
            this.BtContinuar.Text = "Continuar";
            this.BtContinuar.UseVisualStyleBackColor = false;
            this.BtContinuar.Click += new System.EventHandler(this.BtContinuar_Click);
            // 
            // BtSair
            // 
            this.BtSair.BackColor = System.Drawing.Color.Black;
            this.BtSair.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtSair.Location = new System.Drawing.Point(395, 562);
            this.BtSair.Name = "BtSair";
            this.BtSair.Size = new System.Drawing.Size(230, 60);
            this.BtSair.TabIndex = 1;
            this.BtSair.Text = "Sair";
            this.BtSair.UseVisualStyleBackColor = false;
            this.BtSair.Click += new System.EventHandler(this.BtSair_Click);
            // 
            // TelaPrincipal
            // 
            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Imagens\Tela_Principal\Menu_Principal.jpg"); 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.BtSair);
            this.Controls.Add(this.BtContinuar);
            this.Controls.Add(this.BtNovoJogo);
            this.Controls.Add(this.Logo);
            this.Name = "TelaPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.Button BtNovoJogo;
        private System.Windows.Forms.Button BtContinuar;
        private System.Windows.Forms.Button BtSair;
    }
}

