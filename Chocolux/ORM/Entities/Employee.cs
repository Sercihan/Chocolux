using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Chocolux.ORM.Entities
{
    public class Employee
    {

        public int Id { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        [StringLength(30)]
        public string Surname { get; set; }
        public string Image { get; set; }
        [StringLength(500)]
        public string Description { get; set; }

    }
}
