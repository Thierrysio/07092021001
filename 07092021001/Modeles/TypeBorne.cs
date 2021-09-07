using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07092021001.Modeles
{
    public class TypeBorne
    {
        #region Attributs
        public static List<TypeBorne> CollClasse = new List<TypeBorne>();
        private int _codeTypeBorne;
        private int _dureeRevision;
        private int _nbJoursEntreRevisions;
        private int _nbUnitesEntreRevisions;
        #endregion
        #region Constructeur
        public TypeBorne(int codeTypeBorne, int dureeRevision, int nbJoursEntreRevisions, int nbUnitesEntreRevisions)
        {
            this.CodeTypeBorne = codeTypeBorne;
            this.DureeRevision = dureeRevision;
            this.NbJoursEntreRevisions = nbJoursEntreRevisions;
            this.NbUnitesEntreRevisions = nbUnitesEntreRevisions;
            TypeBorne.CollClasse.Add(this);
        }
        #endregion
        #region Getters-Setters
        public int CodeTypeBorne { get => _codeTypeBorne; set => _codeTypeBorne = value; }
        public int DureeRevision { get => _dureeRevision; set => _dureeRevision = value; }
        public int NbJoursEntreRevisions { get => _nbJoursEntreRevisions; set => _nbJoursEntreRevisions = value; }
        public int NbUnitesEntreRevisions { get => _nbUnitesEntreRevisions; set => _nbUnitesEntreRevisions = value; }
        #endregion
        #region Méthodes
        public int getDureeRevision()
        {
            return this._dureeRevision;
        }
        public int getNbJoursEntreRevisions()
        {
            return this._nbJoursEntreRevisions;
        }
        public int getNbUnitesRevisions()
        {
            return this._nbUnitesEntreRevisions;
        }
        #endregion
    }
}
