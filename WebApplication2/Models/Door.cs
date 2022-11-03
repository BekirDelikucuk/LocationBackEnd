using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    [Table("door")]
    public class Door
    {
        [Key, Required]
        public int Id { get; set; }
        public string LocationName { get; set; }
        public double CoordinateX { get; set; }
        public double CoordinateY { get; set; }
    }
}
