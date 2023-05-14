using atelier2.dal;
using atelier2.view;
using System;
using System.Collections.Generic;

namespace atelier2.controller
{
    /// <summary>
    /// Contôleur de FmrGestion
    /// </summary>
    public class FmrGestionController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Personnel
        /// </summary>
        private readonly PersonnelAccess personnelAccess;
        /// <summary>
        /// objet d'accès aux opérations possibles sur Absence
        /// </summary>
        private readonly AbsenceAccess absenceAccess;

        /// <summary>
        /// 
        /// </summary>
        public FmrGestionController()
        {
            personnelAccess = new PersonnelAccess();
            absenceAccess = new AbsenceAccess(); 
        }
    }
}
