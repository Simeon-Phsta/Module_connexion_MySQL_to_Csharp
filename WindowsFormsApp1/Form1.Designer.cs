namespace WindowsFormsApp1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Textip = new System.Windows.Forms.TextBox();
            this.Textbdd = new System.Windows.Forms.TextBox();
            this.Textid = new System.Windows.Forms.TextBox();
            this.Textpwd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Serveur";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom de la base de données";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Identifiant";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mot de passe";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Textip
            // 
            this.Textip.Location = new System.Drawing.Point(19, 80);
            this.Textip.Name = "Textip";
            this.Textip.Size = new System.Drawing.Size(100, 20);
            this.Textip.TabIndex = 4;
            this.Textip.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Textbdd
            // 
            this.Textbdd.Location = new System.Drawing.Point(154, 80);
            this.Textbdd.Name = "Textbdd";
            this.Textbdd.Size = new System.Drawing.Size(100, 20);
            this.Textbdd.TabIndex = 5;
            this.Textbdd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Textid
            // 
            this.Textid.Location = new System.Drawing.Point(331, 80);
            this.Textid.Name = "Textid";
            this.Textid.Size = new System.Drawing.Size(100, 20);
            this.Textid.TabIndex = 6;
            this.Textid.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Textpwd
            // 
            this.Textpwd.Location = new System.Drawing.Point(471, 80);
            this.Textpwd.Name = "Textpwd";
            this.Textpwd.Size = new System.Drawing.Size(100, 20);
            this.Textpwd.TabIndex = 7;
            this.Textpwd.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Se Connecter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 197);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Textpwd);
            this.Controls.Add(this.Textid);
            this.Controls.Add(this.Textbdd);
            this.Controls.Add(this.Textip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Textip;
        private System.Windows.Forms.TextBox Textbdd;
        private System.Windows.Forms.TextBox Textid;
        private System.Windows.Forms.TextBox Textpwd;
        private System.Windows.Forms.Button button1;
    }
}

