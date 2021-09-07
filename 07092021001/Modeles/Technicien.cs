using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07092021001.Modeles
{
    public class Technicien
    {
        #region Attributs
        public static List<Technicien> CollClasse = new List<Technicien>();
        private int _matricule;
        private string _nom;
        private string _prenom;
        private List<Visite> _lesVisites;
        #endregion
        #region Constructeur
        public Technicien(int matricule, string nom, string prenom)
        {
            this.Matricule = matricule;
            this.Nom = nom;
            this.Prenom = prenom;
            this.LesVisites = new List<Visite>();
            CollClasse.Add(this);
        }
        #endregion
        #region Getters-Setters
        public int Matricule { get => _matricule; set => _matricule = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public List<Visite> LesVisites { get => _lesVisites; set => _lesVisites = value; }
        #endregion
        #region Méthodes
        public int getTempsOccupe()
        {
            int res = 0;
            foreach (Visite laVisite in this._lesVisites)
            {
                res += laVisite.getDureeTotal();
            }
            return res;
        }
        public void affecterVisite(Visite uneVisite)
        {
            uneVisite.changerEtat();
            //uneVisite.getDureeTotal();
            this._lesVisites.Add(uneVisite);
        }
        public List<Visite> getLesVisites()
        {
            return this._lesVisites;
        }
        #endregion
    }
}
