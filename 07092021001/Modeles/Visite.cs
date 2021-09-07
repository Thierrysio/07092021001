using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07092021001.Modeles
{
    public class Visite
    {
        #region Attributs
        public static List<Visite> CollClasse = new List<Visite>();
        private string _etat;
        private int _dureeTotale;
        private Station _laStation;
        private List<Borne> _lesBornes;
        #endregion
        #region Constructeur
        public Visite(Station uneStation, List<Borne> lesBornes)
        {
            this.Etat = "P";
            this.DureeTotale = 0;
            this.LaStation = uneStation;
            this._lesBornes = lesBornes;
            CollClasse.Add(this);
        }
        #endregion
        #region Getters-Setters
        public string Etat { get => _etat; set => _etat = value; }
        public int DureeTotale { get => _dureeTotale; set => _dureeTotale = value; }
        public Station LaStation { get => _laStation; set => _laStation = value; }
        public List<Borne> LesBornes { get => _lesBornes; set => _lesBornes = value; }
        #endregion
        #region Méthodes

        public int getDureeTotal()
        {
            this.DureeTotale = 0;
            foreach (Borne laBorne in this._lesBornes)
            {
                this.DureeTotale += laBorne.getDureeRevision();
            }
            return this.DureeTotale;
        }
        public string getEtat()
        {
            return this._etat;
        }
        public void changerEtat()
        {
            this._etat = (this._etat == "P") ? "A" : "R";
        }
        #endregion
    }
}
