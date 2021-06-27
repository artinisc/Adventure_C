
namespace Adventure.Telas
{
    partial class TelaRecompensa
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
            this.btR1 = new System.Windows.Forms.Button();
            this.btR2 = new System.Windows.Forms.Button();
            this.btR3 = new System.Windows.Forms.Button();
            this.descR = new System.Windows.Forms.Label();
            this.descR1 = new System.Windows.Forms.Label();
            this.descR2 = new System.Windows.Forms.Label();
            this.descR3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btR1
            // 
            this.btR1.BackColor = System.Drawing.Color.Transparent;
            this.btR1.Location = new System.Drawing.Point(48, 205);
            this.btR1.Name = "btR1";
            this.btR1.Size = new System.Drawing.Size(260, 101);
            this.btR1.TabIndex = 0;
            this.btR1.UseVisualStyleBackColor = false;
            this.btR1.Click += new System.EventHandler(this.btR1_Click);
            // 
            // btR2
            // 
            this.btR2.BackColor = System.Drawing.Color.Transparent;
            this.btR2.Location = new System.Drawing.Point(373, 205);
            this.btR2.Name = "btR2";
            this.btR2.Size = new System.Drawing.Size(260, 101);
            this.btR2.TabIndex = 0;
            this.btR2.UseVisualStyleBackColor = false;
            this.btR2.Click += new System.EventHandler(this.btR2_Click);
            // 
            // btR3
            // 
            this.btR3.BackColor = System.Drawing.Color.Transparent;
            this.btR3.Location = new System.Drawing.Point(691, 205);
            this.btR3.Name = "btR3";
            this.btR3.Size = new System.Drawing.Size(260, 101);
            this.btR3.TabIndex = 0;
            this.btR3.UseVisualStyleBackColor = false;
            this.btR3.Click += new System.EventHandler(this.btR3_Click);
            // 
            // descR
            // 
            this.descR.BackColor = System.Drawing.Color.Transparent;
            this.descR.Location = new System.Drawing.Point(285, 64);
            this.descR.Name = "descR";
            this.descR.Size = new System.Drawing.Size(419, 59);
            this.descR.TabIndex = 1;
            // 
            // descR1
            // 
            this.descR1.BackColor = System.Drawing.Color.Transparent;
            this.descR1.Location = new System.Drawing.Point(56, 370);
            this.descR1.Name = "descR1";
            this.descR1.Size = new System.Drawing.Size(251, 286);
            this.descR1.TabIndex = 2;
            // 
            // descR2
            // 
            this.descR2.BackColor = System.Drawing.Color.Transparent;
            this.descR2.Location = new System.Drawing.Point(382, 370);
            this.descR2.Name = "descR2";
            this.descR2.Size = new System.Drawing.Size(251, 286);
            this.descR2.TabIndex = 2;
            // 
            // descR3
            // 
            this.descR3.BackColor = System.Drawing.Color.Transparent;
            this.descR3.Location = new System.Drawing.Point(700, 370);
            this.descR3.Name = "descR3";
            this.descR3.Size = new System.Drawing.Size(251, 286);
            this.descR3.TabIndex = 2;
            // 
            // TelaRecompensa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.descR3);
            this.Controls.Add(this.descR2);
            this.Controls.Add(this.descR1);
            this.Controls.Add(this.descR);
            this.Controls.Add(this.btR3);
            this.Controls.Add(this.btR2);
            this.Controls.Add(this.btR1);
            this.Name = "TelaRecompensa";
            this.Text = "TelaRecompensa";
            this.Load += new System.EventHandler(this.TelaRecompensa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btR1;
        private System.Windows.Forms.Button btR2;
        private System.Windows.Forms.Button btR3;
        private System.Windows.Forms.Label descR;
        private System.Windows.Forms.Label descR1;
        private System.Windows.Forms.Label descR2;
        private System.Windows.Forms.Label descR3;
    }
}