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
            this.butListe = new System.Windows.Forms.Button();
            this.butMaj = new System.Windows.Forms.Button();
            this.butAjouter = new System.Windows.Forms.Button();
            this.butEditer = new System.Windows.Forms.Button();
            this.butSupprimer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Serveur";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom de la base de données";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Identifiant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mot de passe";
            // 
            // Textip
            // 
            this.Textip.Location = new System.Drawing.Point(12, 36);
            this.Textip.Name = "Textip";
            this.Textip.Size = new System.Drawing.Size(100, 20);
            this.Textip.TabIndex = 4;
            this.Textip.Text = "localhost";
            this.Textip.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Textbdd
            // 
            this.Textbdd.Location = new System.Drawing.Point(138, 36);
            this.Textbdd.Name = "Textbdd";
            this.Textbdd.Size = new System.Drawing.Size(100, 20);
            this.Textbdd.TabIndex = 5;
            this.Textbdd.Text = "csharp";
            this.Textbdd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Textid
            // 
            this.Textid.Location = new System.Drawing.Point(272, 36);
            this.Textid.Name = "Textid";
            this.Textid.Size = new System.Drawing.Size(100, 20);
            this.Textid.TabIndex = 6;
            this.Textid.Text = "root";
            this.Textid.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Textpwd
            // 
            this.Textpwd.Location = new System.Drawing.Point(393, 36);
            this.Textpwd.Name = "Textpwd";
            this.Textpwd.Size = new System.Drawing.Size(100, 20);
            this.Textpwd.TabIndex = 7;
            this.Textpwd.Text = "root";
            this.Textpwd.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(540, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Se Connecter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butListe
            // 
            this.butListe.Location = new System.Drawing.Point(540, 71);
            this.butListe.Name = "butListe";
            this.butListe.Size = new System.Drawing.Size(112, 23);
            this.butListe.TabIndex = 9;
            this.butListe.Text = "Voir la liste";
            this.butListe.UseVisualStyleBackColor = true;
            this.butListe.Click += new System.EventHandler(this.butListe_Click);
            // 
            // butMaj
            // 
            this.butMaj.Location = new System.Drawing.Point(459, 314);
            this.butMaj.Name = "butMaj";
            this.butMaj.Size = new System.Drawing.Size(75, 23);
            this.butMaj.TabIndex = 10;
            this.butMaj.Text = "Mettre à jour";
            this.butMaj.UseVisualStyleBackColor = true;
            this.butMaj.Click += new System.EventHandler(this.butMaj_Click);
            // 
            // butAjouter
            // 
            this.butAjouter.Location = new System.Drawing.Point(563, 314);
            this.butAjouter.Name = "butAjouter";
            this.butAjouter.Size = new System.Drawing.Size(75, 23);
            this.butAjouter.TabIndex = 11;
            this.butAjouter.Text = "Ajouter";
            this.butAjouter.UseVisualStyleBackColor = true;
            this.butAjouter.Click += new System.EventHandler(this.butAjouter_Click);
            // 
            // butEditer
            // 
            this.butEditer.Location = new System.Drawing.Point(261, 123);
            this.butEditer.Name = "butEditer";
            this.butEditer.Size = new System.Drawing.Size(112, 23);
            this.butEditer.TabIndex = 12;
            this.butEditer.Text = "Editer la personne";
            this.butEditer.UseVisualStyleBackColor = true;
            this.butEditer.Click += new System.EventHandler(this.butEditer_Click);
            // 
            // butSupprimer
            // 
            this.butSupprimer.Location = new System.Drawing.Point(261, 152);
            this.butSupprimer.Name = "butSupprimer";
            this.butSupprimer.Size = new System.Drawing.Size(111, 23);
            this.butSupprimer.TabIndex = 13;
            this.butSupprimer.Text = "Supprimer";
            this.butSupprimer.UseVisualStyleBackColor = true;
            this.butSupprimer.Click += new System.EventHandler(this.butSupprimer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(15, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 242);
            this.dataGridView1.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(499, 227);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(499, 262);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nom :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Date de naissance :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Liste des personnes";
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date de naissance";
            this.Column2.Name = "Column2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 406);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butSupprimer);
            this.Controls.Add(this.butEditer);
            this.Controls.Add(this.butAjouter);
            this.Controls.Add(this.butMaj);
            this.Controls.Add(this.butListe);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button butListe;
        private System.Windows.Forms.Button butMaj;
        private System.Windows.Forms.Button butAjouter;
        private System.Windows.Forms.Button butEditer;
        private System.Windows.Forms.Button butSupprimer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

