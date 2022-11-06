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
using crud22;
using ENSAT_STUDENT_MANAGEMENT_SYSTEM.Models;

namespace ENSAT_STUDENT_MANAGEMENT_SYSTEM
{
    public partial class Gestion_Notes : Form
    {
        public Gestion_Notes()
        {
            InitializeComponent();
        }
        private void Clean()
        {
            this.inputNote.Text = "";

            inputCodeEleve.Text = "";
            inputMatiere.Text = "";
        }

        private void Btn_Ajouter_Click(object sender, EventArgs e)
        {

        }

        private void inputCodeEleve_TextChanged(object sender, EventArgs e)
        {
            this.inputMatiere.Items.Clear();
            string code = this.inputCodeEleve.Text;
            if (code.Length >= 3)
            {

                try
                {
                    Connexion.Connect("Sql");
                    string sql = "select id from Eleves where code=" + "'" + code + "'";
                    SqlDataReader dr = (SqlDataReader)Connexion.Select(sql);
                    dr.Read();
                    int id = Int32.Parse(dr[0].ToString());

                    dr.Close();
                    Model ev = new Eleves();
                    ev.id = id;

                    dynamic dic = ev.find();

                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    dictionary = ev.ToDictionary<object>(dic);
                    string fil = dictionary["code_fil"].ToString();
                    string niv = dictionary["niveau"].ToString();

                    string req = "select Mat.code from Matieres Mat,Modules M where Mat.code_module=M.cod e and M.code_fil=" + "'" + fil + "'" + " and  M.niveau=" + "'" + niv + "' ;";
                    SqlDataReader mydr = (SqlDataReader)Connexion.Select(req);

                    if (mydr.HasRows)
                    {
                        while (mydr.Read())
                        {
                            inputMatiere.Items.Add(mydr[0].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("le code peut etre n'existe pas ou vous avez tapez un erreur essayer un autre");
                }



            }
        }

        private void Btn_Nouveu_Click(object sender, EventArgs e)
        {
            this.Clean();
        }
    }
}
