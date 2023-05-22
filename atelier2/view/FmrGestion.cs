using atelier2.controller;
using atelier2.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace atelier2.view
{
    /// <summary>
    /// Fenêtre d'affichage du personnel et des absences
    /// </summary>
    public partial class FmrGestion : Form
    {
        /// <summary>
        /// Booléen pour savoir si une modification personnel est demandée
        /// </summary>
        private Boolean enCoursDeModifPersonnel = false;
        /// <summary>
        /// Booléen pour savoir si une modification d'absence est demandée
        /// </summary>
        private Boolean enCoursDeModifAbsence = false;
        /// <summary>
        /// Personnel dont les absences sont affiché
        /// </summary>
        private Personnel personnelSelect;
        /// <summary>
        /// Objet pour gérer la liste du personnel
        /// </summary>
        private BindingSource bdgPersonnel = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des absences du personnel selectionné
        /// </summary>
        private BindingSource bdgAbsence = new BindingSource();
        /// <summary>
        ///  Objet pour gérer la liste des services
        /// </summary>
        private BindingSource bdgServices = new BindingSource();
        /// <summary>
        ///  Objet pour gérer la liste des motifs
        /// </summary>
        private BindingSource bdgMotifs = new BindingSource();
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FmrGestionController controller;

        /// <summary>
        /// construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FmrGestion()
        {
            InitializeComponent();
            this.FormClosing += MainForm_FormClosing;
            Init();
        }
        /// <summary>
        /// Initialisation:
        /// Creation du controleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controller = new FmrGestionController();
            RemplirListePersonnel();
            gbxAbs.Enabled = false;
            EnCourseDeModifPersonnel(false);
            EnCourseDeModifAbsence(false);
            RemplirListeService();
            RemplirListeMotif();
        }

        /// <summary>
        /// Affiche le personnel
        /// </summary>
        private void RemplirListePersonnel()
        {
            List<Personnel> lesPersonnels = controller.GetLesPersonnels();
            bdgPersonnel.DataSource = lesPersonnels;
            dgvPerso.DataSource = bdgPersonnel;
            dgvPerso.Columns["idpersonnel"].Visible = false;
            dgvPerso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPerso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// Affiche les absences du personnel selectionné
        /// </summary>
        /// <param name="personnel"></param>
        private void RemplirListeAbsence(Personnel personnel)
        {
            List<Absence> LesAbsences = controller.GetLesAbsences(personnel);
            bdgAbsence.DataSource = LesAbsences;
            dgvAbs.DataSource = bdgAbsence;
            dgvAbs.Columns["idpersonnel"].Visible = false;
            dgvAbs.Columns["datedebut"].DefaultCellStyle.Format = "d/M/yyyy";
            dgvAbs.Columns["datefin"].DefaultCellStyle.Format = "d/M/yyyy";
            dgvAbs.Columns["datedebut"].HeaderText = "Date de debut";
            dgvAbs.Columns["datefin"].HeaderText = "Date de fin";
            dgvAbs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAbs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gbxAbsences.Text = "absence de " + personnel.Nom + " " + personnel.Prenom;
            gbxAbs.Enabled = true;
        }

        /// <summary>
        /// Affiche les services
        /// </summary>
        private void RemplirListeService()
        {
            List<Service> lesServices = controller.GetLesServices();
            bdgServices.DataSource = lesServices;
            cbxService.DataSource = bdgServices;
        }

        /// <summary>
        /// Affiche les motifs
        /// </summary>
        private void RemplirListeMotif()
        {
            List<Motif> lesMotifs = controller.GetLesMotifs();
            bdgMotifs.DataSource = lesMotifs;
            cbxMotif.DataSource = bdgMotifs;
        }

        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="modif"></param>
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
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="modif"></param>
        private void EnCourseDeModifAbsence(Boolean modif)
        {
            enCoursDeModifAbsence = modif;
            gbxAbsences.Enabled = !modif;
            dateTimePicker1.Enabled = !modif;
            if (modif)
            {
                gbxAbs.Text = "modifier une absence";
            }
            else
            {
                gbxAbs.Text = "ajouter une absence";
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker2.Value = DateTime.Now.AddDays(1);
            }
        }

        /// <summary>
        /// Demande de modification d'un personnel 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                cbxService.SelectedIndex = personnel.Service.Idservice - 1;
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée. ", "Information");
            }
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAbsModifier_Click(object sender, EventArgs e)
        {
            if (dgvAbs.SelectedRows.Count > 0 )
            {
                EnCourseDeModifAbsence(true);
                Absence absence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                dateTimePicker1.Value = absence.Datedebut;
                dateTimePicker2.Value = absence.Datefin;
                cbxMotif.SelectedIndex = absence.Motif.Idmotif - 1;
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée. ", "Information");
            }
        }

        /// <summary>
        /// Demande de supression d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnProSuprimer_Click(object sender, EventArgs e)
        {
            if (dgvPerso.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelLesAbsences(personnel);
                    controller.DelPersonnel(personnel);
                    RemplirListePersonnel();
                    if (dgvAbs.RowCount > 0)
                    {
                        Personnel personnelSelect = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                        this.personnelSelect = personnelSelect;
                        RemplirListeAbsence(personnelSelect);
                    }
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Demande de supression d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAbsSuprimer_Click(object sender, EventArgs e)
        {
            if (dgvAbs.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer l'" + gbxAbsences.Text + " du "  + absence.Datedebut.ToString("d/M/yyyy") 
                    + " au " + absence.Datefin.ToString("d/M/yyyy") + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelAbsence(absence);
                    Console.WriteLine("suprimer");
                    RemplirListeAbsence(personnelSelect);
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }


        /// <summary>
        /// Demande d'enregistrement de l'ajout ou de la modification d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnProEnregistrer_Click(object sender, EventArgs e)
        {
            if (!txtProNom.Text.Equals("") && !txtProPrenom.Text.Equals("") 
                && !txtProMail.Text.Equals("") && !txtProTel.Text.Equals("") && cbxService.SelectedIndex > - 1 && cbxService.SelectedIndex < cbxService.Items.Count)
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
                }
                RemplirListePersonnel();
                EnCourseDeModifPersonnel(false);
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }
        /// <summary>
        /// Demande d'enregistrement de l'ajout ou de la modification d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAbsEnregistrer_Click(object sender, EventArgs e)
        {
            if ( dateTimePicker1.Value <= dateTimePicker2.Value && cbxMotif.SelectedIndex > -1 && cbxMotif.SelectedIndex < cbxMotif.Items.Count)
            {
                Motif motif = new Motif(cbxMotif.SelectedIndex + 1, cbxMotif.SelectedItem.ToString());
                if(enCoursDeModifAbsence)
                {
                    Absence absence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                    absence.Datedebut = dateTimePicker1.Value;
                    absence.Datefin = dateTimePicker2.Value;
                    absence.Motif = motif;
                    if (VerifAbs(absence))
                        controller.UpdateAbsence(absence);   
                }
                else
                {
                    Absence absence = new Absence(personnelSelect.Idpersonnel, dateTimePicker1.Value, dateTimePicker2.Value, motif);
                    if (VerifAbs(absence))
                        controller.AddAbsence(absence);
                }
                RemplirListeAbsence(personnelSelect);
                EnCourseDeModifAbsence(false);
            }
            else
            {
                MessageBox.Show("Les champs doivent être correctement remplis.", "Information");
            }

        }

        /// <summary>
        /// Annule la demande d'ajout ou de modification d'un personnel
        /// Vide les zones de saisie du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnProAnnuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCourseDeModifPersonnel(false);
            }

        }

        /// <summary>
        /// Annule la demande d'ajout ou de modification d'une absence
        /// Réinitialise les zones de saisie  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAbsAnnuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCourseDeModifAbsence(false);
            }
        }

        /// <summary>
        /// Deamande l'affichage des absences du personnel selectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bntafficher_Click(object sender, EventArgs e)
        {
            if (dgvPerso.SelectedRows.Count > 0)
            {
                Personnel personnelSelect = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                this.personnelSelect = personnelSelect;
                RemplirListeAbsence(personnelSelect);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée. ", "Information");
            }
        }

        /// <summary>
        /// Verifie qu'une absence n'a pas deja été assigné le même jour
        /// </summary>
        /// <param name="absence"></param>
        /// <returns></returns>
        private bool VerifAbs(Absence absence)
        {
            int compt = 0;
            if (enCoursDeModifAbsence)
                compt--;
            foreach (Absence absenceAVerifier in bdgAbsence.List)
            {
                if (absence.Datedebut.ToString("yyyy-MM-dd") == absenceAVerifier.Datedebut.ToString("yyyy-MM-dd"))
                {
                    compt++;
                    if (compt == 1) 
                    {
                        MessageBox.Show("Cette date est deja renseigné", "Information");
                        return false;
                    }
                }
            }
            return true;
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
    }
}
