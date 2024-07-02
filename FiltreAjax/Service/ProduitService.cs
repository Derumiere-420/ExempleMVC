using Filtre.Models;

namespace Filtre.Service
{
    public class ProduitService
    {

        private readonly MyDbContext _context;

        public ProduitService(MyDbContext context)
        {
            _context = context;
        }
        public List<Produit> GetProduits(string nom, decimal? cout, string categorie)
        {
            return _context.Produit.AsQueryable()
           .Where(p => string.IsNullOrEmpty(nom) || p.Nom.Contains(nom))
           .Where(p => !cout.HasValue || p.Cout == cout.Value)
           .Where(p => string.IsNullOrEmpty(categorie) || p.Categorie.Contains(categorie))
           .ToList();
        }
    }
}
