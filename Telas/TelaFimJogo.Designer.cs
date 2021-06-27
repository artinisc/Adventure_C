
namespace Adventure.Telas
{
    partial class TelaFimJogo
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
            this.imagemFim = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imagemFim
            // 
            this.imagemFim.BackColor = System.Drawing.Color.Transparent;
            this.imagemFim.Location = new System.Drawing.Point(154, 142);
            this.imagemFim.Name = "imagemFim";
            this.imagemFim.Size = new System.Drawing.Size(700, 120);
            this.imagemFim.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(411, 551);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "INICIO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaFimJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imagemFim);
            this.Name = "TelaFimJogo";
            this.Text = "TelaFimJogo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label imagemFim;
        private System.Windows.Forms.Button button1;
    }
}