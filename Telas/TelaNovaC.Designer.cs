
namespace Adventure.Telas
{
    partial class TelaNovaC
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
            this.imgGuerreiro = new System.Windows.Forms.Label();
            this.imgMago = new System.Windows.Forms.Label();
            this.imgArqueiro = new System.Windows.Forms.Label();
            this.nomeGuerreiro = new System.Windows.Forms.Label();
            this.nomeMago = new System.Windows.Forms.Label();
            this.nomeArqueiro = new System.Windows.Forms.Label();
            this.Descricao = new System.Windows.Forms.Label();
            this.btGuerreiro = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imgGuerreiro
            // 
            this.imgGuerreiro.BackColor = System.Drawing.Color.Transparent;
            this.imgGuerreiro.Location = new System.Drawing.Point(65, 231);
            this.imgGuerreiro.Name = "imgGuerreiro";
            this.imgGuerreiro.Size = new System.Drawing.Size(232, 341);
            this.imgGuerreiro.TabIndex = 0;
            // 
            // imgMago
            // 
            this.imgMago.BackColor = System.Drawing.Color.Transparent;
            this.imgMago.Location = new System.Drawing.Point(384, 231);
            this.imgMago.Name = "imgMago";
            this.imgMago.Size = new System.Drawing.Size(232, 341);
            this.imgMago.TabIndex = 0;
            // 
            // imgArqueiro
            // 
            this.imgArqueiro.BackColor = System.Drawing.Color.Transparent;
            this.imgArqueiro.Location = new System.Drawing.Point(704, 231);
            this.imgArqueiro.Name = "imgArqueiro";
            this.imgArqueiro.Size = new System.Drawing.Size(232, 341);
            this.imgArqueiro.TabIndex = 0;
            // 
            // nomeGuerreiro
            // 
            this.nomeGuerreiro.BackColor = System.Drawing.Color.Transparent;
            this.nomeGuerreiro.Location = new System.Drawing.Point(65, 160);
            this.nomeGuerreiro.Name = "nomeGuerreiro";
            this.nomeGuerreiro.Size = new System.Drawing.Size(232, 50);
            this.nomeGuerreiro.TabIndex = 1;
            // 
            // nomeMago
            // 
            this.nomeMago.BackColor = System.Drawing.Color.Transparent;
            this.nomeMago.Location = new System.Drawing.Point(384, 160);
            this.nomeMago.Name = "nomeMago";
            this.nomeMago.Size = new System.Drawing.Size(232, 50);
            this.nomeMago.TabIndex = 1;
            // 
            // nomeArqueiro
            // 
            this.nomeArqueiro.BackColor = System.Drawing.Color.Transparent;
            this.nomeArqueiro.Location = new System.Drawing.Point(704, 160);
            this.nomeArqueiro.Name = "nomeArqueiro";
            this.nomeArqueiro.Size = new System.Drawing.Size(232, 50);
            this.nomeArqueiro.TabIndex = 1;
            // 
            // Descricao
            // 
            this.Descricao.BackColor = System.Drawing.Color.Transparent;
            this.Descricao.Location = new System.Drawing.Point(299, 35);
            this.Descricao.Name = "Descricao";
            this.Descricao.Size = new System.Drawing.Size(380, 67);
            this.Descricao.TabIndex = 1;
            // 
            // btGuerreiro
            // 
            this.btGuerreiro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btGuerreiro.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btGuerreiro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btGuerreiro.Location = new System.Drawing.Point(65, 606);
            this.btGuerreiro.Name = "btGuerreiro";
            this.btGuerreiro.Size = new System.Drawing.Size(232, 65);
            this.btGuerreiro.TabIndex = 2;
            this.btGuerreiro.Text = "Selecionar";
            this.btGuerreiro.UseVisualStyleBackColor = false;
            this.btGuerreiro.Click += new System.EventHandler(this.btGuerreiro_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(384, 606);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "Selecionar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(704, 606);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 65);
            this.button2.TabIndex = 2;
            this.button2.Text = "Selecionar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TelaNovaC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btGuerreiro);
            this.Controls.Add(this.Descricao);
            this.Controls.Add(this.nomeArqueiro);
            this.Controls.Add(this.nomeMago);
            this.Controls.Add(this.nomeGuerreiro);
            this.Controls.Add(this.imgArqueiro);
            this.Controls.Add(this.imgMago);
            this.Controls.Add(this.imgGuerreiro);
            this.Name = "TelaNovaC";
            this.Text = "TelaNovaC";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label imgGuerreiro;
        private System.Windows.Forms.Label imgMago;
        private System.Windows.Forms.Label imgArqueiro;
        private System.Windows.Forms.Label nomeGuerreiro;
        private System.Windows.Forms.Label nomeMago;
        private System.Windows.Forms.Label nomeArqueiro;
        private System.Windows.Forms.Label Descricao;
        private System.Windows.Forms.Button btGuerreiro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}