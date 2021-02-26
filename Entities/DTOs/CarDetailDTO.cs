using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dto
{
    public class CarDetailDto:IDto
    {
        //Data Transformation Object
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public long ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public string Decriptions { get; set; }
    }
}
