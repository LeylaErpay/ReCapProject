using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Colors :IEntity
    {
        [Key]
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("Color")]
        public int ColorID { get; set; }
        public string ColorName { get; set; }
    }
}
