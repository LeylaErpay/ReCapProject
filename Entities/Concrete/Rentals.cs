using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Rentals:IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentDate { get; set; }
        //Datetime'ın boş olabilme durumuna karşı sonuna ? ekliyoruz.
        public DateTime? ReturnDate { get; set; }
    }
}
