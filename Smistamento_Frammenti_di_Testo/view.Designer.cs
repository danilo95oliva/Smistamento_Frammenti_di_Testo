namespace Smistamento_Frammenti_di_Testo
{
    partial class view
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
            this.input = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.esegui = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.AutoSize = true;
            this.input.Location = new System.Drawing.Point(49, 57);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(219, 13);
            this.input.TabIndex = 0;
            this.input.Text = "Inserisci il percorso della directory di partenza";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inserisci il percorso della directory di destinazione";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(696, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(52, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(696, 20);
            this.textBox2.TabIndex = 3;
            // 
            // esegui
            // 
            this.esegui.Location = new System.Drawing.Point(52, 226);
            this.esegui.Name = "esegui";
            this.esegui.Size = new System.Drawing.Size(71, 28);
            this.esegui.TabIndex = 4;
            this.esegui.Text = "Smista";
            this.esegui.UseVisualStyleBackColor = true;
            this.esegui.Click += new System.EventHandler(this.esegui_Click);
            // 
            // view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 322);
            this.Controls.Add(this.esegui);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input);
            this.Name = "view";
            this.Text = "Smistamento frammenti di testo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button esegui;
    }
}

