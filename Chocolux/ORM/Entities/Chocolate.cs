using System.ComponentModel.DataAnnotations;

namespace Chocolux.ORM.Entities
{
    public class Chocolate
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }

    }
}
