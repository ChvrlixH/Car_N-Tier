using Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Entities.Concrete
{
    public class Color : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Car> Colors { get; set;}
    }
}
