using ENSAT_STUDENT_MANAGEMENT_SYSTEM.Models;
using miniProjet_dll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using miniProjet_dll;
namespace ENSAT_STUDENT_MANAGEMENT_SYSTEM
{
    public partial class Gestion_Etudiant : Form
    {
        public Gestion_Etudiant()
        {
            InitializeComponent();
        }
        private void Clean()
        {
            this.in_code.Text = "";
            this.inputNom.Text = "";
            this.inputPrenom.Text = "";
            this.inputFiliere.Text = "";
            this.inputNiveau.Text = "";
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            this.Clean();

        }

        private void Btn_Ajouter_Click(object sender, EventArgs e)
        {
            string code, nom, prenom, fil, niv;
            code = this.in_code.Text;
            nom = this.inputNom.Text;
            prenom = this.inputPrenom.Text;
            fil = this.inputFiliere.Text;
            niv = this.inputNiveau.Text;

            Connexion.Connect("Sql");
            Eleves E1 = new Eleves();
            try
            {
                E1.Code = code;
                E1.prenom = prenom;
                E1.nom = nom;

                E1.niveau = niv;
                E1.code_fil = fil;
                
                int succes = E1.save();
                if (succes != 0)
                {
                    MessageBox.Show("Ajoute avec succe");
                    Clean();
                }
                else
                {
                    MessageBox.Show("L'Ajoute a echoue");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("un champ ou plusieurs manque pour cette operation");
            }
        }

        private void Btn_Rechercher_Click(object sender, EventArgs e)
        {
           
            string code = this.in_code.Text;
            string nom = inputNom.Text;
            string prenom = inputPrenom.Text;
            string fil = inputFiliere.Text;
            string niv = inputNiveau.Text;
            this.GridEleveData.Rows.Clear();

            Connexion.Connect("Sql");
            Eleves ev = new Eleves();
            if (code.Equals(""))
            {
                //List<dynamic> list = ev.All();
                //foreach (dynamic d in list)
                //{
                //    List<object> ls = new List<object>();
                //    ls = (List<object>)d;

                //    this.GridEleveData.Rows.Add(ls[0].ToString() , ls[1], ls[2], ls[3], ls[4]);
                //}
                this.GridEleveData.Rows.Clear();
                List<dynamic> lis = ev.select();
                for (int i = 0; i < lis.Count; i++)
                {
                    Dictionary<string, object> dict = new Dictionary<string, object>();
                    dict = ev.ToDictionary<object>(lis[i]);
                    this.GridEleveData.Rows.Add(dict["code"].ToString(), dict["nom"].ToString(), dict["prenom"].ToString(), dict["niveau"].ToString(), dict["code_fil"].ToString());
                }
            }
            else
            {
                this.GridEleveData.Rows.Clear();
                try
                {
                    string sql = "select id from Eleves where code=" + "'" + code + "' ;";
                    SqlDataReader dr = (SqlDataReader)Connexion.Select(sql);
                    dr.Read();
                    int id = Int32.Parse(dr[0].ToString());
                    dr.Close();

                    ev.id = id;

                    dynamic dic = ev.find();

                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    dictionary = ev.ToDictionary<object>(dic);

                    this.in_code.Text = dictionary["code"].ToString();
                    this.inputFiliere.Text = dictionary["code_fil"].ToString();
                    this.inputNiveau.Text = dictionary["niveau"].ToString();
                    this.inputNom.Text = dictionary["nom"].ToString();
                    this.inputPrenom.Text = dictionary["prenom"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("n'existe pas");

                }
            }

        }

        private void inputFiliere_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.inputNiveau.Items.Clear();

            string fil = this.inputFiliere.Text;
            if (fil.Equals("AP"))
            {
                this.inputNiveau.Items.Add(fil + "1");
                this.inputNiveau.Items.Add(fil + "2");
            }
            else
            {
                this.inputNiveau.Items.Add(fil + "1");
                this.inputNiveau.Items.Add(fil + "2");
                this.inputNiveau.Items.Add(fil + "3");
            }
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            string code, nom, prenom, fil, niv;
            code = this.in_code.Text;
            nom = this.inputNom.Text;
            prenom = this.inputPrenom.Text;
            fil = this.inputFiliere.Text;
            niv = this.inputNiveau.Text;
            string sql = "select id from Eleves where code=" + "'" + code + "' ;";
            SqlDataReader dr = (SqlDataReader)Connexion.Select(sql);
            dr.Read();
            Eleves E1 = new Eleves();
            E1.id = (int)dr["id"];
            dr.Close();
            Connexion.Connect("Sql");

            E1.code_fil = fil;
            E1.prenom = prenom;
            E1.nom = nom;
            E1.Code = code;
            E1.niveau = niv;

            // int succes = E1.save("UpdateEleves");
            int succes = E1.save();
            if (succes != 0)
            {
                MessageBox.Show("Modifier avec succe");
                Clean();
            }
            else
            {
                MessageBox.Show("La modification a echoue");

            }
        }

        private void Btn_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                Connexion.Connect("Sql");

                string code = this.in_code.Text;
                string sql = "select id from Eleves where code=" + "'" + code + "' ;";
                SqlDataReader dr = (SqlDataReader)Connexion.Select(sql);
                dr.Read();
                Eleves ev = new Eleves();
                ev.id = (int)dr["id"];
                dr.Close();
                int succes = ev.delete();
                if (succes != 0)
                {
                    MessageBox.Show("Supprime avec succe");
                    Clean();
                }
                else
                {
                    MessageBox.Show("La suppression a echoue");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur produit peut etre que l'enregistrement est dans une autre table ");
            }

        }
    }
}
