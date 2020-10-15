using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBConnecte;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DBConnect test;
        Personne editer;

        // fonction
        private void remplirListe()
        {
            dataGridView1.Rows.Clear();

            List<Personne> lespersonne = test.Select();
            foreach (Personne quelquun in lespersonne)
            {
                dataGridView1.Rows.Add(quelquun.Nom, quelquun.Date_naissance);
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Bouton Se connecter
        private void button1_Click(object sender, EventArgs e)
        {
            //récupération du contenu dans les zones texte à gauche du bouton
            string ip = Textip.Text;
            string bdd = Textbdd.Text;
            string id = Textid.Text;
            string pwd = Textpwd.Text;
            //instentiation de l'objet DBConnect
            test = new DBConnect(ip, bdd, id, pwd);
            
            //Renvoie un messagebox si c'est bon ou non pour tester la connexion
            if (test.OpenConnection() == true) 
            {
                MessageBox.Show("Vous êtes connectez !");
            }
            else
            {
                MessageBox.Show("Erreur de connexion");
            }
            test.CloseConnection();
        }

        //Bouton Voir la liste
        private void butListe_Click(object sender, EventArgs e)
        {
            //Tout est dans le nom
            remplirListe();
        }

        //Bouton Editer la personne
        private void butEditer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Selected)
            {
                //editer, class personne qui se "construit" avec les valeurs dans la datagrid selectionner par l'utilisateur
                editer = new Personne(dataGridView1.CurrentRow.Cells[0].Value.ToString(), DateTime.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString()));

                //les valeurs se placent dans les zones en bas à droite
                textBox1.Text = editer.Nom;
                dateTimePicker1.Value = editer.Date_naissance;
            }
        }

        //Bouton Supprimer
        private void butSupprimer_Click(object sender, EventArgs e)
        {
            //convertion d'une ligne du tableau en string
            string suppr = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            if (MessageBox.Show("êtes vous sur de vouloir supprimer " + suppr + " ?", "advertissement ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // suppression de la ligne correspondant à suppr
                test.Delete(suppr);

                //re remplit la liste du tableau pour la mettre à jour 
                remplirListe();

            }
        }

        //Bouton Mettre à jour
        private void butMaj_Click(object sender, EventArgs e)
        {
            //Init d'un objet Peronne()
            Personne nouvelle = new Personne();

            // récupération des informations dans les zones en bas à droite pour envoyer la requête de mise à jour dans la bdd
            // puis maj de la liste visuel pour l'utilisateur
            if (textBox1.Text != "")
            {
                nouvelle.Nom = textBox1.Text;
                nouvelle.Date_naissance = dateTimePicker1.Value;
                test.Update(nouvelle, editer);
                remplirListe();
            }
            else
            {
                MessageBox.Show("rentrer un nom ! ");
                textBox1.Focus();
            }
        }

        //Bouton Ajouter 
        // Même procédure que vu pour le Bouton Mise à jour sauf qu'ici on n'a pas de récupération des anciennes valeurs 
        private void butAjouter_Click(object sender, EventArgs e)
        {
            Personne nouveau = new Personne();

            if (textBox1.Text != "")
            {
                nouveau.Nom = textBox1.Text;
                nouveau.Date_naissance = dateTimePicker1.Value;
                test.Insert(nouveau);
                remplirListe();
            }
            else
            {
                MessageBox.Show("rentrer un nom ! ");
                textBox1.Focus();
            }
        }
    }
}
