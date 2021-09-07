using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07092021001.Modeles
{
    public class Station
    {
        #region Attributs
        public static List<Station> CollClasse = new List<Station>();
        private int _idStation;
        private string _libelleEmplacement;
        private List<Borne> _lesBornes;
        #endregion
        #region Constructeur
        public Station(int idStation, string libelleEmplacement)
        {
            this.IdStation = idStation;
            this.LibelleEmplacement = libelleEmplacement;
            this.LesBornes = new List<Borne>();
            CollClasse.Add(this);
        }
        #endregion
        #region Getters-Setters
        public int IdStation { get => _idStation; set => _idStation = value; }
        public string LibelleEmplacement { get => _libelleEmplacement; set => _libelleEmplacement = value; }
        public List<Borne> LesBornes { get => _lesBornes; set => _lesBornes = value; }
        #endregion
        #region Méthodes
        /// <summary>
        /// 01 - recuperer l'Id de la station courante
        /// </summary>
        /// <returns>l'Id de la station</returns>
        public int getId()
        {
            return this._idStation;
        }
        /// <summary>
        /// 01 - Recuperer le libelle de l'objet courant
        /// </summary>
        /// <returns>le libelle de l'emplacement de l'objet courant</returns>
        public string getLibelleEmplacement()
        {
            return this._libelleEmplacement;
        }
        public Visite GetVisiteAFaire()
        {
            Visite v = null;
            List<Borne> mesBornes = new List<Borne>();
            foreach (Borne laBorne in this._lesBornes)
            {
                if (laBorne.estAReviser()) mesBornes.Add(laBorne);
            }

            if (mesBornes.Count > 0)
            {
                v = new Visite(this, mesBornes);

            }

            return v;

        }
        #endregion
    }
}
