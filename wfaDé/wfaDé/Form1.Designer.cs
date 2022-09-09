namespace wfaDé
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblTypeDé = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblValeurDé = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalPoint = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnMelange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type de dé :";
            // 
            // lblTypeDé
            // 
            this.lblTypeDé.AutoSize = true;
            this.lblTypeDé.Location = new System.Drawing.Point(431, 90);
            this.lblTypeDé.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeDé.Name = "lblTypeDé";
            this.lblTypeDé.Size = new System.Drawing.Size(57, 16);
            this.lblTypeDé.TabIndex = 2;
            this.lblTypeDé.Text = "TypeDé";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valeur de dé :";
            // 
            // lblValeurDé
            // 
            this.lblValeurDé.AutoSize = true;
            this.lblValeurDé.Location = new System.Drawing.Point(431, 132);
            this.lblValeurDé.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValeurDé.Name = "lblValeurDé";
            this.lblValeurDé.Size = new System.Drawing.Size(64, 16);
            this.lblValeurDé.TabIndex = 4;
            this.lblValeurDé.Text = "ValeurDé";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 5;
            // 
            // lblTotalPoint
            // 
            this.lblTotalPoint.AutoSize = true;
            this.lblTotalPoint.Location = new System.Drawing.Point(425, 175);
            this.lblTotalPoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPoint.Name = "lblTotalPoint";
            this.lblTotalPoint.Size = new System.Drawing.Size(68, 16);
            this.lblTotalPoint.TabIndex = 6;
            this.lblTotalPoint.Text = "TotalPoint";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total points :";
            // 
            // BtnMelange
            // 
            this.BtnMelange.Location = new System.Drawing.Point(357, 37);
            this.BtnMelange.Name = "BtnMelange";
            this.BtnMelange.Size = new System.Drawing.Size(113, 31);
            this.BtnMelange.TabIndex = 8;
            this.BtnMelange.Text = "Melange";
            this.BtnMelange.UseVisualStyleBackColor = true;
            this.BtnMelange.Click += new System.EventHandler(this.BtnMelange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 274);
            this.Controls.Add(this.BtnMelange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalPoint);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblValeurDé);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTypeDé);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTypeDé;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblValeurDé;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnMelange;
    }
}

