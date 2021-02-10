using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace Entities.Concrete
{
    public class Brands :IEntity
    {
        [Key]
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("Brand")]
        public int BrandID { get; set; }
        public string BrandName { get; set; }
    }
}
