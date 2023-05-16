namespace atelier2.model
{
    /// <summary>
    /// Classe métier liée à la table Motif
    /// </summary>
    public class Motif
    {
        public int Idmotif { get; }
        public string Libelle { get; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        public Motif(int idmotif, string libelle)
        {
            this.Idmotif = idmotif;
            this.Libelle = libelle;
        }

        /// <summary>
        /// Définit l'information à afficher (juste le nom)
        /// </summary>
        /// <returns>Libelle du motif</returns>
        public override string ToString()
        {
            return this.Libelle;
        }
    }
}
