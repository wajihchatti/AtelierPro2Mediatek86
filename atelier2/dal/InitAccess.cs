using System;
using atelier2.model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace atelier2.dal
{
    /// <summary>
    /// Classe permettant d'initialiser les combobox de l'affichage
    /// </summary>
    public class InitAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public InitAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Récupère et retourne les profils
        /// </summary>
        /// <returns>Liste des profils</returns>
        public List<Service> GetLesServices()
        {
            List<Service> lesServices = new List<Service>();
            if (access.Manager != null)
            {
                string req = "select * from service order by idservice;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Service service = new Service((int)record[0], (string)record[1]);
                            lesServices.Add(service);
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message + "!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
            }
            return lesServices;
        }

        /// <summary>
        /// Récupère et retourne les motifs
        /// </summary>
        /// <returns>Liste des motifs</returns>
        public List<Motif> GetLesMotifs()
        {
            List<Motif> lesMotifs = new List<Motif>();
            if (access.Manager != null)
            {
                string req = "select * from motif order by idmotif;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Motif motif = new Motif((int)record[0], (string)record[1]);
                            lesMotifs.Add(motif);
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message + "!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
            }
            return lesMotifs;
        }

    }
}
