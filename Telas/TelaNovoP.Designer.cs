
using System.Drawing;
using System.Windows.Forms;

namespace Adventure.Telas
{
    partial class TelaNovoP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaNovoP));
            this.textoBemVindo = new System.Windows.Forms.Label();
            this.imputNome = new System.Windows.Forms.TextBox();
            this.btAvancar = new System.Windows.Forms.Button();
            this.textoNome = new System.Windows.Forms.Label();
            this.btVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoBemVindo
            // 
            this.textoBemVindo.BackColor = System.Drawing.Color.Transparent;
            this.textoBemVindo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textoBemVindo.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textoBemVindo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textoBemVindo.Image = ((System.Drawing.Image)(resources.GetObject("textoBemVindo.Image")));
            this.textoBemVindo.Location = new System.Drawing.Point(12, 19);
            this.textoBemVindo.Name = "textoBemVindo";
            this.textoBemVindo.Size = new System.Drawing.Size(860, 120);
            this.textoBemVindo.TabIndex = 0;
            this.textoBemVindo.Click += new System.EventHandler(this.label1_Click);
            // 
            // imputNome
            // 
            this.imputNome.BackColor = System.Drawing.Color.AntiqueWhite;
            this.imputNome.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.imputNome.Location = new System.Drawing.Point(39, 649);
            this.imputNome.Name = "imputNome";
            this.imputNome.Size = new System.Drawing.Size(460, 39);
            this.imputNome.TabIndex = 1;
            this.imputNome.TextChanged += new System.EventHandler(this.imputNome_TextChanged);
            // 
            // btAvancar
            // 
            this.btAvancar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btAvancar.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btAvancar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAvancar.Location = new System.Drawing.Point(812, 640);
            this.btAvancar.Name = "btAvancar";
            this.btAvancar.Size = new System.Drawing.Size(140, 53);
            this.btAvancar.TabIndex = 2;
            this.btAvancar.Text = "Avançar";
            this.btAvancar.UseVisualStyleBackColor = false;
            this.btAvancar.Click += new System.EventHandler(this.btAvancar_Click);
            // 
            // textoNome
            // 
            this.textoNome.BackColor = System.Drawing.Color.Transparent;
            this.textoNome.Image = ((System.Drawing.Image)(resources.GetObject("textoNome.Image")));
            this.textoNome.Location = new System.Drawing.Point(39, 596);
            this.textoNome.Name = "textoNome";
            this.textoNome.Size = new System.Drawing.Size(120, 40);
            this.textoNome.TabIndex = 3;
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btVoltar.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btVoltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btVoltar.Location = new System.Drawing.Point(645, 640);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(140, 53);
            this.btVoltar.TabIndex = 4;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // TelaNovoP
            // 
            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Imagens\Genericas\Dialogo.jpg");
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.textoNome);
            this.Controls.Add(this.btAvancar);
            this.Controls.Add(this.imputNome);
            this.Controls.Add(this.textoBemVindo);
            this.Name = "TelaNovoP";
            this.Text = "TelaNovoP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textoBemVindo;
        private System.Windows.Forms.TextBox imputNome;
        private System.Windows.Forms.Button btAvancar;
        private System.Windows.Forms.Label textoNome;
        private System.Windows.Forms.Button btVoltar;
    }
}