using System.ComponentModel.DataAnnotations;

namespace GeneriqueCRUD.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        // Ajoutez d'autres propriétés nécessaires
    }
}
