using Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Entities.Concrete
{
    public class Car : BaseAuditableEntity
    {  
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int CarImageId { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public Brand Brand { get; set; }
        public Color Color { get; set; }
        public CarImage CarImage { get; set; }
    }
}
