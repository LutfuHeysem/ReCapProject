using ReCapProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Entities.Concrete
{
    class Car : IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
