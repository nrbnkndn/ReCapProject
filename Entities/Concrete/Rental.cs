using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Rental:IEntity
    {
        public int rentalID { get; set; }
        public DateTime rentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int carId { get; set; }
        public int customerId { get; set; }
    }
}
