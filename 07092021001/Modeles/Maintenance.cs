using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07092021001.Modeles
{
    public class Maintenance
    {
        #region Attributs
        private List<Station> _lesStations;
        private List<Technicien> _lesTechniciens;
        private List<Visite> _lesVisites;
        public static List<Maintenance> collClasse = new List<Maintenance>();


        #endregion
        #region Constructeur
        public Maintenance(List<Technicien> lesTechniciens,List<Station> lesStations)
        {
            _lesTechniciens = lesTechniciens;
            _lesStations = LesStations;
            _lesVisites = new List<Visite>();
            Maintenance.collClasse.Add(this);
        }
        #endregion
        #region Getters-Setters
        public List<Station> LesStations { get => _lesStations; set => _lesStations = value; }
        public List<Technicien> LesTechniciens { get => _lesTechniciens; set => _lesTechniciens = value; }
        public List<Visite> LesVisites { get => _lesVisites; set => _lesVisites = value; }
        #endregion
        #region Méthodes
        public void Reviser()
        {
            foreach (Station uneStation in this.LesStations)
            {
                if (uneStation.GetVisiteAFaire() != null)
                {
                    this.LesVisites.Add(uneStation.GetVisiteAFaire());

                }
            }
            this.AffecterVisites();
        }
        public void AffecterVisites()
        {
            Technicien technicienRetenu = null;
            
            int tempsVisiteMoinsOccupe = int.MaxValue;

            foreach( Visite uneVisite in this.LesVisites)
            {
                foreach(Technicien unTechnicien in Technicien.CollClasse)
                {
                    if(unTechnicien.getTempsOccupe()< tempsVisiteMoinsOccupe)
                    {
                        technicienRetenu = unTechnicien;
                        tempsVisiteMoinsOccupe = unTechnicien.getTempsOccupe();
                    }
                }
                technicienRetenu.affecterVisite(uneVisite);
            }
            
        }
        #endregion
    }
}
