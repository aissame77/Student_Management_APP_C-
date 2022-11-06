using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENSAT_STUDENT_MANAGEMENT_SYSTEM
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(MainPanel, Color.Black, 20, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop);
            LoadForm(new Home_screen());            
        }

   public void LoadForm(object form)
        {
            if (this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();

        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            LoadForm(new Gestion_Notes());
        }

        private void Gestion_etudiant_button_Click(object sender, EventArgs e)
        {
            LoadForm(new Gestion_Etudiant());
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            LoadForm(new Consultation_notes());
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            LoadForm(new Bilan());
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            LoadForm(new Home_screen());
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            LoadForm(new Home_screen());
        }
     
        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
