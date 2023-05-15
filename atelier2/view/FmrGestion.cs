using atelier2.controller;
using atelier2.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace atelier2.view
{
    /// <summary>
    /// Fenêtre d'affichage du personnel et des absences
    /// </summary>
    public partial class FmrGestion : Form
    {
        private Boolean enCoursDeModifPersonnel = false;
        
        private BindingSource bdgPersonnel = new BindingSource();

        private FmrGestionController controller;

        /// <summary>
        /// construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FmrGestion()
        {
            InitializeComponent();
            this.FormClosing += MainForm_FormClosing;
            Init();
            Console.WriteLine("on est a la form GEstion taDa!");
        }

        private void Init()
        {
            controller = new FmrGestionController();
            //List<string> LesServices = new List<string>() { "administatif", "médiation culturelle", "prêt" };
            //cbxService.Items.AddRange(LesServices.ToArray());
            RemplirListePersonnel();
            EnCourseDeModifPersonnel(false);
        }

        private void RemplirListePersonnel()
        {
            List<Personnel> lesPersonnels = controller.GetLesPersonnels();
            bdgPersonnel.DataSource = lesPersonnels;
            dgvPerso.DataSource = bdgPersonnel;
            dgvPerso.Columns["idpersonnel"].Visible = false;
            dgvPerso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void EnCourseDeModifPersonnel(Boolean modif)
        {
            enCoursDeModifPersonnel = modif;
            gbxPros.Enabled = !modif;
            if (modif)
            {
                gbxProSelect.Text = "modifier un personnel";
            }
            else
            {
                gbxProSelect.Text = "ajouter un personnel";
                txtProNom.Text = "";
                txtProPrenom.Text = "";
                txtProMail.Text = "";
                txtProTel.Text = "";
            }
        }
        /// <summary>
        /// Arrête le programme
        /// quand on ferme la fenêtre 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnProModifier_Click_1(object sender, EventArgs e)
        {
            if (dgvPerso.SelectedRows.Count > 0)
            {
                EnCourseDeModifPersonnel(true);
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                txtProNom.Text = personnel.Nom;
                txtProPrenom.Text = personnel.Prenom;
                txtProTel.Text = personnel.Tel;
                txtProMail.Text = personnel.Mail;
                Console.WriteLine("modifier");
                cbxService.SelectedIndex = personnel.Service.Idservice - 1;
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée. ", "Information");
            }
        }

        private void BtnProSuprimer_Click(object sender, EventArgs e)
        {
            if (dgvPerso.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelPersonnel(personnel);
                    Console.WriteLine("suprimer");
                    RemplirListePersonnel();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }


        }
        private void BtnProEnregistrer_Click(object sender, EventArgs e)
        {
            Console.WriteLine("doubitchout kloug! ");
            if (!txtProNom.Text.Equals("") && !txtProPrenom.Text.Equals("") 
                && !txtProMail.Text.Equals("") && !txtProTel.Text.Equals("") && !cbxService.SelectedItem.Equals(""))
            {
                Service service = new Service(cbxService.SelectedIndex + 1, cbxService.SelectedItem.ToString());
                if (enCoursDeModifPersonnel)
                {
                    Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                    personnel.Nom = txtProNom.Text;
                    personnel.Prenom = txtProPrenom.Text;
                    personnel.Tel = txtProTel.Text;
                    personnel.Mail = txtProMail.Text;
                    personnel.Service = service;
                    controller.UpdatePersonnel(personnel);
                }
                else
                {
                    Personnel personnel = new Personnel(0, txtProNom.Text, txtProPrenom.Text, txtProTel.Text, txtProMail.Text, service);
                    controller.AddPersonnel(personnel);
                    Console.WriteLine("ajout ? ");
                }
                RemplirListePersonnel();
                EnCourseDeModifPersonnel(false);
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        private void BtnProAnnuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCourseDeModifPersonnel(false);
            }

        }
    }
}
