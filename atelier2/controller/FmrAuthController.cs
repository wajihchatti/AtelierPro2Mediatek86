using atelier2.dal;
using atelier2.view;

namespace atelier2.controller
{
    /// <summary>
    /// Contrôleur de FmrAuth
    /// </summary>
    public class FmrAuthController
    {
        /// <summary>
        /// objet d'accès a la verification login mot de passe
        /// </summary>
        private readonly ConnectionAccess connectionAccess;

        /// <summary>
        /// vu du systeme de gestion du personnel et de leurs absences 
        /// </summary>
        private FmrGestion gestion;

        /// <summary>
        /// Récupère les acces aux données
        /// </summary>
        public FmrAuthController()
        {
            connectionAccess = new ConnectionAccess();
        }

        /// <summary>
        /// Valide ou non l'authentification login pwd du responsable
        /// Si valide lance la fenêtre de gestion et renvoi vrai
        /// Sinon valide renvoi false
        /// </summary>
        /// <param name="login"></param>
        /// <param name="psw"></param>
        /// <returns></returns>
        public bool GetLaConnection(string login, string psw)
        {
            if (connectionAccess.GetLaConnection(login, psw)) 
            {
                initGestion();
                return true;
            }
            return false;
        }

        private void initGestion()
        {
            gestion = new FmrGestion();
            gestion.Show();
        }
    }
}
