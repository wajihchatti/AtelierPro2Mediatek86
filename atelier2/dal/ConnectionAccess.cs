using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace atelier2.dal
{
    /// <summary>
    /// Classe permettant de  gérer les demandes de verification de login et mot de passe
    /// pour acceder au logiciel de gestion
    /// </summary>
    public class ConnectionAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public ConnectionAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// retourne vrai si la combinaison mdp pwd existe dans la base de données
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        /// <returns>vrai ou faux</returns>
        public bool GetLaConnection(string login, string pwd)
        {
            string req = "SELECT * from responsable WHERE login = @login AND pwd = SHA2(@pwd, 256);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@login",(Object)login);
            parameters.Add("@pwd", (Object)pwd);
            try
            {
                List<Object[]> records = access.Manager.ReqSelect(req, parameters);
                if (records.Count == 1)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
            return false;
        }
    }
}
