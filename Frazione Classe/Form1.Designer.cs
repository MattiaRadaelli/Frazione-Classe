namespace ClasseFrazione
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Num = new System.Windows.Forms.TextBox();
            this.Den = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Prodotto = new System.Windows.Forms.Button();
            this.Divisione = new System.Windows.Forms.Button();
            this.Somma = new System.Windows.Forms.Button();
            this.Differenza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Num
            // 
            this.Num.Location = new System.Drawing.Point(82, 60);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(47, 20);
            this.Num.TabIndex = 0;
            // 
            // Den
            // 
            this.Den.Location = new System.Drawing.Point(82, 101);
            this.Den.Name = "Den";
            this.Den.Size = new System.Drawing.Size(47, 20);
            this.Den.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "--------------";
            // 
            // Prodotto
            // 
            this.Prodotto.Location = new System.Drawing.Point(247, 58);
            this.Prodotto.Name = "Prodotto";
            this.Prodotto.Size = new System.Drawing.Size(36, 23);
            this.Prodotto.TabIndex = 4;
            this.Prodotto.Text = "x";
            this.Prodotto.UseVisualStyleBackColor = true;
            // 
            // Divisione
            // 
            this.Divisione.Location = new System.Drawing.Point(304, 58);
            this.Divisione.Name = "Divisione";
            this.Divisione.Size = new System.Drawing.Size(36, 23);
            this.Divisione.TabIndex = 5;
            this.Divisione.Text = "/";
            this.Divisione.UseVisualStyleBackColor = true;
            // 
            // Somma
            // 
            this.Somma.Location = new System.Drawing.Point(247, 98);
            this.Somma.Name = "Somma";
            this.Somma.Size = new System.Drawing.Size(36, 23);
            this.Somma.TabIndex = 6;
            this.Somma.Text = "+";
            this.Somma.UseVisualStyleBackColor = true;
            // 
            // Differenza
            // 
            this.Differenza.Location = new System.Drawing.Point(304, 99);
            this.Differenza.Name = "Differenza";
            this.Differenza.Size = new System.Drawing.Size(36, 23);
            this.Differenza.TabIndex = 7;
            this.Differenza.Text = "-";
            this.Differenza.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Differenza);
            this.Controls.Add(this.Somma);
            this.Controls.Add(this.Divisione);
            this.Controls.Add(this.Prodotto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Den);
            this.Controls.Add(this.Num);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox Num;
        private System.Windows.Forms.TextBox Den;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Prodotto;
        private System.Windows.Forms.Button Divisione;
        private System.Windows.Forms.Button Somma;
        private System.Windows.Forms.Button Differenza;
    }
}

