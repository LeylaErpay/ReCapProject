using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Cars :IEntity
    {
        [Key]
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("Car")]
        public int CarID { get; set; }
        public int BrandID { get; set; }     
        public int ColorID { get; set; }
        public string ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Descriptions { get; set; }
        
    }
}
