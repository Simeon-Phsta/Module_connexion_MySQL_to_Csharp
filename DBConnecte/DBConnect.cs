using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DBConnecte
{
    // La class persone reçoit les valeurs la base de données
  
    public class Personne
    {
        
        private string nom;
        private DateTime date_naissance;

        //ascesseurs 
        public string Nom { get => nom; set => nom = value; }
        public DateTime Date_naissance { get => date_naissance; set => date_naissance = value; }

        //contructeurs
        // L'un sans paramètres et l'autre, correspondant à celles de la bdd qui récupère les valeurs contenu dans les zones de texte du formulaire
        public Personne()
        {

        }

        public Personne(string nom, DateTime date_n)
        {
            this.nom = nom;
            date_naissance = date_n;
        }

        // Méthode de conversion SQL <-> C# (les formats sont différents)
        public String Convert2MySql(DateTime dt)
        {
            return dt.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private DateTime Convert2C(String sqlDate)
        {
            return DateTime.Parse(sqlDate);
        }

        // affiche les valeurs de personne
        public string affiche()
        {
            return "personne = " + nom + " " + date_naissance.ToString();
        }
    }

    public class DBConnect
    {
        /*
         * On va maintenant créer la class DBConnect dans la bibliothèque, qui va accueillir nos différentes requêtes SQL.
         */

        //Il faut initialisé les différents composants nécessaires pour se connecter: l' ip, la database, le user et le password.
        private MySqlConnection connection;
        private string server;
        private string database;
        private string User;
        private string password;

        //Constructor
        //Le constructeur aura les composants de connexion en paramètres
        public DBConnect(string ip, string bdd, string user, string pwd)
        {
            // récupération des futures zones de textes dans notre formulaire pour la connexion puis on utilise Initialize()
            server = ip;
            database = bdd;
            User = user;
            password = pwd;
            Initialize();
        }

        //Initialize values
        // déclare une classe MySqlConnection en utilisant les paramètres de DBConnect()
        private void Initialize()
        {
            string connectionString;

            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "user=" + User + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);

        }

        //open connection to database
        // On va se servir de la class MySqlConnection du nom de connection pour maintenant essayer de se connecter
        // si cela ne fonctionne pas on renvoie l'erreur
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }

        //Close connection
        //On ferme la connexion et on renvoi si il y a une erreur
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        // Insert prends en paramètre une classe Personne qui va récupéré a deux paramètres Nom et Date_naissance
        // Insert envoi la requête avec les dites valeurs qui sont celles récupérés dans le formulaire avec la zone de texte et la date time
        //puis envoie tout simplement le tout dans la bdd avec là encore OpenConnection
        public void Insert(Personne nouveau)
        {
            string query = "INSERT INTO matable(nom, ddn) VALUES ('" + nouveau.Nom + "', '" + nouveau.Convert2MySql(nouveau.Date_naissance) + "')";

            //ouvre connection
            if (this.OpenConnection() == true)
            {
                //créer une requête et attribuer la requête et la connexion depuis le constructeur
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute la requête
                cmd.ExecuteNonQuery();

                //ferme connection
                this.CloseConnection();
            }
        }

        //Update statement
        //Même principe que pour au dessus sauf qu'il faut une autre personne pour contenir avoir les anciennes valeurs à remplacer
        // Nouvelle contient les nouvelles valeurs et editer pour le where
        public void Update(Personne nouvelle, Personne editer)
        {
            string query = "UPDATE matable SET nom='" + nouvelle.Nom + "', ddn='" + nouvelle.Convert2MySql(nouvelle.Date_naissance) + "' WHERE name='" + editer.Nom + "'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //créer la requête sql
                MySqlCommand cmd = new MySqlCommand();
                //Assigne the query
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //ferme connection
                this.CloseConnection();
            }
        }

        //Delete statement
        // comme Insert sauf que la requête DELETE la ligne
        public void Delete( string nomsup )
        {
            string query = "DELETE FROM matable WHERE name='" + nomsup + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Select statement
        // La requête récupère tout le contenu de matable
        public List<Personne> Select()
        {
            string query = "SELECT * FROM matable";

            //Create une liste pour y ranger le résultat de la requête
            List<Personne> list = new List<Personne>();

            //Ouvre connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //initialisation d'un objet personne
                Personne unepersonne;

                //Lit les données de la list au travers d'une boucle avec la class MySqlDataReader
                while (dataReader.Read())
                {
                    unepersonne = new Personne(dataReader["nom"].ToString(), DateTime.Parse(dataReader["ddn"].ToString()));
                    list.Add(unepersonne);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }
    }
}

