using atelier2.dal;
using atelier2.view;
using atelier2.model;
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

        public List<Personnel> GetLesPersonnels()
        {
            return personnelAccess.GetLesPersonnels();
        }

        public List<Absence> GetLesAbsences(Personnel personnel)
        {
            return absenceAccess.GetLesAbsences(personnel);
        }

        public void AddPersonnel(Personnel personnel)
        {
            personnelAccess.AddPersonnel(personnel);
        }

        public void AddAbsence(Absence absence)
        {
            absenceAccess.AddAbsence(absence);
        }

        public void UpdatePersonnel(Personnel personnel)
        {
            personnelAccess.UpdatePersonnel(personnel);
        }

        public void UpdateAbsence(Absence absence)
        {
            absenceAccess.UpdateAbsence(absence);
        }

        public void DelPersonnel(Personnel personnel)
        {
            personnelAccess.DelPersonnel(personnel);
        }

        public void DelAbsence(Absence absence)
        {
            absenceAccess.DelAbsence(absence);
        }


    }
}
