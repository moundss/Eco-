namespace Ecoplus.domain.core.Aggregats
{
    internal class Depot
    {
        //public void Supprimer(int id, Depot monDepot)
        //{
        //    if (id!=monDepot.Id)return;

        //}
        public Depot(int id, string libelle, float qte)
        {
            Id = id;
            Libelle = libelle;
            Qte = qte;
        }

        public int Id { get; }
        public string Libelle { get; private set; }
        public float Qte { get; private set; }

        public Depot Ajout(int id, string libelle, float qte)
        {
            return new Depot(id, libelle, qte);
        }

        public void Modifier(int id, Depot monDepot)
        {
            if (id != monDepot.Id) return;

            Libelle = monDepot.Libelle;
            Qte = monDepot.Qte;
        }
    }
}