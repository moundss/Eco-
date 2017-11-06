using System;

namespace Ecoplus.domain.core.Aggregats
{
    public class Depot
    {
        
        public Depot( string libelle, float qte, float qteLimit, string localisation, string semence)
        {
            Libelle = !string.IsNullOrWhiteSpace(libelle) ? libelle : "inconnu";
            Qte = qte >= 0 ? qte : 0;
            Qtelimit = qteLimit>=0? qteLimit:0;
            Localisation =!string.IsNullOrWhiteSpace(localisation)? localisation:"inconnue";
            Semence =!string.IsNullOrWhiteSpace(semence)? semence:"inconnue";
        }

        public int Id { get; private set; }
        public string Libelle { get; private set; }
        public float Qte { get; private set; }
        public float Qtelimit { get;private set; }
        public string Localisation { get; private set; }
        public string Semence { get; private set; }
        public Depot Ajout( string libelle, float qte, float qteLimit, string localisation, string semence)
        {
            return new Depot (libelle, qte, Qtelimit, Localisation,semence);
        }

        public void Modifier(int id, Depot monDepot)
        {
            if (id != monDepot.Id) return;

            Libelle = monDepot.Libelle;
            Qte = monDepot.Qte;
            Qtelimit = monDepot.Qtelimit;
            Localisation = monDepot.Localisation;
            Semence = monDepot.Semence;
        }
    }
}