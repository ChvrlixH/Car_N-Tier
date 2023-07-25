using Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Entities.Concrete
{
    public class Brand :BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Car> Cars { get; set; }

    }
}
