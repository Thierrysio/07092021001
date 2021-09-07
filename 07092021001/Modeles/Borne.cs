using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07092021001.Modeles
{
    public class Borne
    {
        #region Attributs
        public static List<Borne> CollClasse = new List<Borne>();
        private int _idBorne;
        private DateTime _dateDerniereRevision;
        private int _indiceCompteurUnites;
        private TypeBorne _leType;
        #endregion
        #region Constructeur
        public Borne(int idBorne, DateTime dateDerniereRevision, int indiceCompteurUnites, TypeBorne unType)
        {
            this._idBorne = idBorne;
            this._dateDerniereRevision = dateDerniereRevision;
            this._indiceCompteurUnites = indiceCompteurUnites;
            this._leType = unType;
            Borne.CollClasse.Add(this);
        }
        #endregion
        #region Getters-Setters
        public int IdBorne { get => _idBorne; set => _idBorne = value; }
        public DateTime DateDerniereRevision { get => _dateDerniereRevision; set => _dateDerniereRevision = value; }
        public int IndiceCompteurUnites { get => _indiceCompteurUnites; set => _indiceCompteurUnites = value; }
        public TypeBorne LeType { get => _leType; set => _leType = value; }
        #endregion
        #region Méthodes

        public int Get500()
        {
            foreach(Borne uneBorne in Borne.CollClasse)
            {
                if(uneBorne.IdBorne == 500)
                {
                    return uneBorne.IdBorne;
                }
            }
            return 0;
        }
        public int getDureeRevision()
        {
            return this.LeType.getDureeRevision();
        }
        public bool estAReviser()
        {
            if ((this._indiceCompteurUnites > LeType.getNbUnitesRevisions() ) || ((int)(DateTime.Now - this.DateDerniereRevision).TotalDays > this.LeType.getNbJoursEntreRevisions()))
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
