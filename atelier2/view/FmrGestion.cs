using atelier2.controller;
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
        private FmrGestionController controller;
        /// <summary>
        /// construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FmrGestion()
        {
            InitializeComponent();
            Init();
            Console.WriteLine("on est a la form GEstion taDa!");
        }

        private void Init()
        {
            controller = new FmrGestionController();
        }

        private void btnProEnregistrer_Click(object sender, EventArgs e)
        {

        }

        private void btnProModifier_Click(object sender, EventArgs e)
        {

        }
    }
}
