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
    public partial class Consultation_notes : Form
    {
        public Consultation_notes()
        {
            InitializeComponent();
        }
        private void Clean()
        {
            this.inputMatiere.Text = "";
            inputNiveau.Text = "";
            InputFiliere.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {


            this.dataGridView1.Rows.Clear();
            Connexion.Connect("Sql");
            string mat = inputMatiere.Text;
            string Fil = InputFiliere.Text;
            string niv = inputNiveau.Text;
            double som = 0.0;
            int count = 0;
            double moy;
            if (Fil.Equals("") || mat.Equals("") || niv.Equals(""))
            {
                MessageBox.Show("tou les champs sont obligatoire");
            }
            else
            {
                try
                {
                    string sql = "select E.code,E.nom,E.prenom,N.note from Eleves E, Matieres Mat,Modules Mo, Notes N where E.code = N.code_eleve and N.code_mat = Mat.code and N.code_mat =" + "'" + mat + "'" + " and Mat.code_module = Mo.code and Mo.niveau =" + "'" + niv + "'" + " and Mo.code_fil =" + "'" + Fil + "'";

                    SqlDataReader dr = (SqlDataReader)Connexion.Select(sql);
                    if (dr.HasRows)
                    {

                        while (dr.Read())
                        {
                            this.dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
                            som += double.Parse(dr[3].ToString());
                            count++;
                        }
                        moy = som / count;
                        dr.Close();
                        inputMoyenne.Text = moy.ToString();

                    }
                    else
                    {
                        MessageBox.Show("les notes ne sont pas pret pour cette matiere ou \n la base de donnes 'est pas encore complete pour cette demande");
                        this.Clean();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("erreur est produit");
                }
            }

        }

        private void InputFiliere_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.inputNiveau.Items.Clear();
            inputNiveau.Text = "";
            string fil = this.InputFiliere.Text;
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

        private void inputNiveau_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connexion.Connect("Sql");
            this.inputMatiere.Items.Clear();
            string fil = this.InputFiliere.Text;
            string niv = inputNiveau.Text;
            string sql = "select M.code from Matieres M,Modules Mo where M.code_module=Mo.code and Mo.niveau=" + "'" + niv + "'" + " and Mo.code_fil=" + "'" + fil + "'";
            SqlDataReader dr = (SqlDataReader)Connexion.Select(sql);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    inputMatiere.Items.Add(dr[0].ToString());
                }
            }
            else
            {
                MessageBox.Show("la filiere ou le niveau choisi pas encore pret ");
                Clean();
            }
        }
    }
}
