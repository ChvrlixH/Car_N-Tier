using Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Entities.Concrete
{
    public class CarImage : BaseEntity
    {
        public string MainImage { get; set; }
        public string Images { get; set; }
        public int ImageId { get; set; }
        public Image Image { get; set; }
    }
}
