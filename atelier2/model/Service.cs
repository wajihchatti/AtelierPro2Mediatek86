using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier2.model
{
    /// <summary>
    /// Classe métier liée à la table Service
    /// </summary>
    public class Service
    {
        public int Idservice { get; }
        public string Nom { get; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public Service(int idservice, string nom)
        {
            this.Idservice = idservice;
            this.Nom = nom;

        }

        /// <summary>
        /// Définit l'information à afficher (juste le nom)
        /// </summary>
        /// <returns>Nom du service</returns>
        public override string ToString()
        {
            return this.Nom;
        }
    }
}
