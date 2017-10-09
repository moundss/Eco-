using System;

namespace Ecoplus.domain.core.Aggregats
{
    public class Depot
    {
        //public void Supprimer(int id, Depot monDepot)
        //{
        //    if (id!=monDepot.Id)return;

        //}
        public Depot(Guid id, string libelle, float qte, float qteLimit, string localisation)
        {
            Id = id;
            Libelle = libelle;
            Qte = qte;
            Qtelimit = qteLimit;
            Localisation = localisation;
        }

        public Guid Id { get; private set; }
        public string Libelle { get; private set; }
        public float Qte { get; private set; }
        public float Qtelimit { get;private set; }
        public string Localisation { get; private set; }
        public Depot Ajout(Guid id, string libelle, float qte, float qteLimit, string localisation)
        {
            return new Depot (id,libelle, qte, Qtelimit, Localisation);
        }

        public void Modifier(Guid id, Depot monDepot)
        {
            if (id != monDepot.Id) return;

            Libelle = monDepot.Libelle;
            Qte = monDepot.Qte;
            Qtelimit = monDepot.Qtelimit;
            Localisation = monDepot.Localisation;
        }
    }
}