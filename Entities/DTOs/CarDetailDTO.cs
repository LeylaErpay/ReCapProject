using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDTO : IDto
    {
        public int CarID { get; set; }
        public string CarName { get; set; }
        public int BrandID { get; set; }
        public string BrandName { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
