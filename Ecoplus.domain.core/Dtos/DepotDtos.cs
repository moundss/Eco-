namespace Ecoplus.domain.core.Dtos
{
    public class DepotDtos
    {
        public DepotDtos(int id, string libelle, float qte)
        {
            Id = id;
            Libelle = libelle;
            Qte = qte;
        }

        public int Id { get; }
        public string Libelle { get; }
        public float Qte { get;  }
    }
}